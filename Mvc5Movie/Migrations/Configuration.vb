Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Mvc5Movie.Models

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of Models.ApplicationDbContext)

        Public Sub New()
            AutomaticMigrationsEnabled = True
        End Sub

        Protected Overrides Sub Seed(context As Models.ApplicationDbContext)
            'Add default user to role
            AddUserAndRole(context)

            context.Contacts.AddOrUpdate(Function(c) c.Name,
                                         New Contact() With {.Name = "Monty",
                                                             .Address = "2309 Allen",
                                                             .City = "Ozark",
                                                             .State = "MO",
                                                             .Zip = "65721",
                                                             .Email = "monty@beltz.com"})

        End Sub

        Protected Function AddUserAndRole(context As ApplicationDbContext) As Boolean
            Dim ir As IdentityResult

            Dim rm As New RoleManager(Of IdentityRole)(New RoleStore(Of IdentityRole)(context))

            ir = rm.Create(New IdentityRole("canEdit"))
            Dim um As New UserManager(Of ApplicationUser)(New UserStore(Of ApplicationUser)(context))

            Dim user = New ApplicationUser() With {.UserName = "admin", .Hometown = "testTown", .BirthDate = CType("1/1/1990", Date)}
            ir = um.Create(user, "password")

            If Not ir.Succeeded Then
                Return ir.Succeeded
            End If

            ir = um.AddToRole(user.Id, "canEdit")
            Return ir.Succeeded
        End Function

    End Class
End Namespace

'generated from telerik converter
'Private Function AddUserAndRole(context As ContactManager.Models.ApplicationDbContext) As Boolean
'    Dim ir As IdentityResult
'    Dim rm = New RoleManager(Of IdentityRole)(New RoleStore(Of IdentityRole)(context))
'    ir = rm.Create(New IdentityRole("canEdit"))
'    Dim um = New UserManager(Of ApplicationUser)(New UserStore(Of ApplicationUser)(context))
'	Dim user = New ApplicationUser() With { _
'		Key .UserName = "user1@contoso.com" _
'	}
'    ir = um.Create(user, "P_assw0rd1")
'    If ir.Succeeded = False Then
'        Return ir.Succeeded
'    End If
'    ir = um.AddToRole(user.Id, "canEdit")
'    Return ir.Succeeded
'End Function








