Option Explicit On

Imports System.Web.Mvc

Public Class HelloWorldController
    Inherits Controller

    ' GET: /HelloWorld
    Function Index() As ActionResult
        Return View()
    End Function

    'Function Welcome(ByVal name As String, Optional numTimes As Integer = 1) As String
    '    Return HttpUtility.HtmlEncode("Name: " & name & " Number of times:" & numTimes)
    '    '"Welcome to my first MVC 5 application! - Monte"
    'End Function

    Function Welcome(name As String, Optional numTimes As Integer = 1) As ViewResult
        ViewBag.Message = "Hello " & name
        ViewBag.NumTimes = numTimes
        Return View()
    End Function
End Class