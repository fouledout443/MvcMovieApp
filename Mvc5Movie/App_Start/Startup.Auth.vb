Imports Microsoft.AspNet.Identity
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Owin
Imports Microsoft.AspNet.Identity.Owin



Partial Public Class Startup
    ' For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
    Public Sub ConfigureAuth(app As IAppBuilder)
        'Enable the application to use a cookie to store information for the signed in user
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
        .AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
        .LoginPath = New PathString("/Account/Login")})
        ' Use a cookie to temporarily store information about a user logging in with a third party login provider
        app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie)

        'app.UseFacebookAuthentication(
        '   appId:="1439822562952737",
        '   appSecret:="74b6f2e90e5e19dbd7efe3af87d9aeb7")

        app.UseGoogleAuthentication()

    End Sub
End Class

' Uncomment the following lines to enable logging in with third party login providers
'app.UseMicrosoftAccountAuthentication(
'    clientId:="",
'    clientSecret:="")

'app.UseTwitterAuthentication(
'   consumerKey:="",
'   consumerSecret:="")
'clientId:="57516038454-bo08b4jgpp5tjg7ceedp913r5oih52mf.apps.googleusercontent.com",
'clientSecret:="Njnt2eKH-COmmzgqYcGd2q2v")