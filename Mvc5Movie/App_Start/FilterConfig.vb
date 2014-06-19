Imports System.Web
Imports System.Web.Mvc

Public Module FilterConfig
    Public Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
        filters.Add(New HandleErrorAttribute())
        filters.Add(New AuthorizeAttribute())
        filters.Add(New RequireHttpsAttribute())
    End Sub
End Module