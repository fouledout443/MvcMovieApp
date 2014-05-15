@Code
    'Layout = "~/Views/Shared/_Layout.vbhtml
    ViewBag.Title = "Welcome"
End Code

<h2>Welcome</h2>

<ul>
    @For i = 1 To ViewBag.NumTimes
        @<li> @ViewBag.Message </li>
    Next
</ul>