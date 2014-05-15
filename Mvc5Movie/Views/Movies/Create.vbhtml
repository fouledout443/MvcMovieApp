﻿@ModelType Mvc5Movie.Models.Movie
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Movie</h4>
        <hr />
        @Html.ValidationSummary(true)
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
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
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
