@ModelType Mvc5Movie.Models.Movie
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Movie</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.ID)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Title, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Title)
                @Html.ValidationMessageFor(Function(model) model.Title)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.ReleaseDate, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ReleaseDate)
                @Html.ValidationMessageFor(Function(model) model.ReleaseDate)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Genre, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Genre)
                @Html.ValidationMessageFor(Function(model) model.Genre)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Price, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Price)
                @Html.ValidationMessageFor(Function(model) model.Price)
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Rating, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Rating)
                @Html.ValidationMessageFor(Function(model) model.Rating)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-success" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
