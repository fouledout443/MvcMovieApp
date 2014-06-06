Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations

Namespace Models

    Public Class Movie
        Public Property ID As Integer
        Public Property Title As String
        <Display(Name:="Release Date")>
        <DataType(DataType.Date)>
        <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
        Public Property ReleaseDate As DateTime
        Public Property Genre As String
        Public Property Price As Decimal
    End Class

    Public Class MovieDBContext
        Inherits DbContext
        'test...2
        Public Property Movies As DbSet(Of Movie)

    End Class
End Namespace
