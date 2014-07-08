Imports System.ComponentModel.DataAnnotations
Imports Mvc5Movie.Models

Public Class ExternalLoginConfirmationViewModel

    <Required>
    <Display(Name:="User name")>
    Public Property UserName As String

    <Display(Name:="Hometown")>
    <DataType(DataType.Text)>
    Public Property Hometown As String

    <Display(Name:="Birthdate")>
    <DataType(DataType.Date)>
    Public Property Birthdate As Nullable(Of DateTime)

End Class

Public Class ManageUserViewModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Current password")>
    Public Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="New password")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirm new password")>
    <Compare("NewPassword", ErrorMessage:="The new password and confirmation password do not match.")>
    Public Property ConfirmPassword As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="User name")>
    Public Property UserName As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Password")>
    Public Property Password As String

    <Display(Name:="Remember me?")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required>
    <Display(Name:="User name")>
    Public Property UserName As String

    <Required>
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Password")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirm password")>
    <Compare("Password", ErrorMessage:="The password and confirmation password do not match.")>
    Public Property ConfirmPassword As String

    <DataType(DataType.Text)>
    <Display(Name:="Home town")>
    Public Property Hometown As String

    <Required>
    <DataType(DataType.Date)>
    <Display(Name:="Birth date")>
    Public Property Birthdate As Nullable(Of DateTime)

End Class
