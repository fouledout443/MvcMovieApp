Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class DataAnnotations
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.Movies", "Title", Function(c) c.String(maxLength := 60))
            AlterColumn("dbo.Movies", "Genre", Function(c) c.String(nullable := False, maxLength := 30))
            AlterColumn("dbo.Movies", "Rating", Function(c) c.String(maxLength := 5))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Movies", "Rating", Function(c) c.String())
            AlterColumn("dbo.Movies", "Genre", Function(c) c.String())
            AlterColumn("dbo.Movies", "Title", Function(c) c.String())
        End Sub
    End Class
End Namespace
