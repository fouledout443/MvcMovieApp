Imports Microsoft.AspNet.Identity.EntityFramework
Imports System.Data.Entity
Imports Mvc5Movie.Models
Imports Microsoft.AspNet.Identity
Imports System.ComponentModel.DataAnnotations

Namespace Models
    ' You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    Public Class ApplicationUser
        Inherits IdentityUser

        'apparently you cant use private properties and such with db migrations....but maybe you can....idk..
        Private _homeTown As String
        Private _birthDate As DateTime

        <Display(Name:="Hometown"), DataType(DataType.Text), MinLength(2), MaxLength(50)>
        Public Property Hometown As String
            Get
                Return _homeTown
            End Get
            Set(ByVal value As String)
                _homeTown = value
            End Set
        End Property

        <Display(Name:="Birthdate"), DataType(DataType.Date)>
        Public Property Birthdate As DateTime
            Get
                Return _birthDate
            End Get
            Set(ByVal value As DateTime)
                _birthDate = value
            End Set
        End Property
        '<Display(Name:="Hometown"), DataType(DataType.Text)>
        'Public Property Hometown As String

        '<Display(Name:="Birthdate"), DataType(DataType.Date), Required>
        'Public Property Birthdate As DateTime
    End Class

    Public Class ApplicationDbContext
        Inherits IdentityDbContext(Of ApplicationUser)

        Public Sub New()
            MyBase.New("DefaultConnection")
        End Sub

        Public Property Contacts As DbSet(Of Contact)
    End Class

End Namespace

'Imports System.Security.Claims
'Imports System.Threading.Tasks
'Imports Microsoft.AspNet.Identity
'Imports Microsoft.AspNet.Identity.EntityFramework
'Imports Microsoft.AspNet.Identity.Owin

'' You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
'Public Class ApplicationUser
'    Inherits IdentityUser
'    Public Async Function GenerateUserIdentityAsync(manager As UserManager(Of ApplicationUser)) As Task(Of ClaimsIdentity)
'        ' Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
'        Dim userIdentity = Await manager.CreateIdentityAsync(Me, DefaultAuthenticationTypes.ApplicationCookie)
'        ' Add custom user claims here
'        Return userIdentity
'    End Function
'End Class

'Public Class ApplicationDbContext
'    Inherits IdentityDbContext(Of ApplicationUser)
'    Public Sub New()
'        MyBase.New("DefaultConnection", throwIfV1Schema:=False)
'    End Sub

'    Public Shared Function Create() As ApplicationDbContext
'        Return New ApplicationDbContext()
'    End Function
'End Class