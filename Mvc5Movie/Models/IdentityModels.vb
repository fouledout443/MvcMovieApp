Imports Microsoft.AspNet.Identity.EntityFramework
Imports System.Data.Entity
Imports Mvc5Movie.Models
Imports Microsoft.AspNet.Identity


' You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
Public Class ApplicationUser
    Inherits IdentityUser
End Class

Public Class ApplicationDbContext
    Inherits IdentityDbContext(Of ApplicationUser)
    Public Sub New()
        MyBase.New("DefaultConnection")
    End Sub

End Class
