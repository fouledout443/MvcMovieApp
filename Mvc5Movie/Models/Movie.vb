﻿Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations

Namespace Models

    Public Class Movie
        Public Property ID As Integer

        <StringLength(60, MinimumLength:=3)>
        Public Property Title As String

        <DataType(DataType.Date), Display(Name:="Release Date")>
        <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
        Public Property ReleaseDate As DateTime

        <RegularExpression("^[A-Z]+[a-zA-Z''-'\s]*$"), Required, StringLength(30)>
        Public Property Genre As String

        <DataType(DataType.Currency), Range(1, 100)>
        Public Property Price As Decimal

        <RegularExpression("^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(5)>
        Public Property Rating As String

    End Class

    'Public Class MovieDBContext
    '    Inherits DbContext
    '    'test...2
    '    'Public Property Movies As DbSet(Of Movie)

    'End Class
End Namespace
