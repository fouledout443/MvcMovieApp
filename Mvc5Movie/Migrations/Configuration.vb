Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports Mvc5Movie.Models

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of Models.MovieDBContext)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub


        Protected Overrides Sub Seed(context As MovieDBContext)
            context.Movies.AddOrUpdate(Function(i) i.Title,
                New Movie() With {
                    .Title = "When Harry Met Sally",
                    .ReleaseDate = DateTime.Parse("1989-1-11"),
                    .Genre = "Romantic Comedy",
                    .Price = 7.99D
                }, New Movie() With {
                    .Title = "Ghostbusters ",
                    .ReleaseDate = DateTime.Parse("1984-3-13"),
                    .Genre = "Comedy",
                    .Price = 8.99D
                }, New Movie() With {
                    .Title = "Ghostbusters 2",
                    .ReleaseDate = DateTime.Parse("1986-2-23"),
                    .Genre = "Comedy",
                    .Price = 9.99D
                }, New Movie() With {
                    .Title = "Rio Bravo",
                    .ReleaseDate = DateTime.Parse("1959-4-15"),
                    .Genre = "Western",
                    .Price = 3.99D
                })
        End Sub


        'Initial seed method
        'Protected Overrides Sub Seed(context As Models.MovieDBContext)
        '    '  This method will be called after migrating to the latest version.

        '    '  You can use the DbSet(Of T).AddOrUpdate() helper extension method 
        '    '  to avoid creating duplicate seed data. E.g.
        '    '
        '    '    context.People.AddOrUpdate(
        '    '       Function(c) c.FullName,
        '    '       New Customer() With {.FullName = "Andrew Peters"},
        '    '       New Customer() With {.FullName = "Brice Lambson"},
        '    '       New Customer() With {.FullName = "Rowan Miller"})
        'End Sub

    End Class

End Namespace
