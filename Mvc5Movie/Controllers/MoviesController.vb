'Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Mvc5Movie.Models

Namespace Mvc5Movie
    Public Class MoviesController
        Inherits System.Web.Mvc.Controller

        Private db As New MovieDBContext

        ' GET: /Movies/
        Function Index(ByVal movieGenre As String, ByVal searchString As String) As ActionResult
            'Dim searchString As String = id
            Dim genreList As New List(Of String)
            Dim genreQuery = From m In db.Movies
                             Order By m.Genre
                             Select m.Genre
            'add distinct genres to list
            genreList.AddRange(genreQuery.Distinct)

            ViewBag.movieGenre = New SelectList(genreList)

            Dim movies = From m In db.Movies Select m

            If Not String.IsNullOrEmpty(searchString) Then
                movies = movies.Where(Function(movie) movie.Title.Contains(searchString))
            End If

            If Not String.IsNullOrEmpty(movieGenre) Then
                movies = movies.Where(Function(movie) movie.Genre.Equals(movieGenre))
            End If

            Return View(movies)

        End Function

        ' GET: /Movies/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim movie As Movie = db.Movies.Find(id)
            If IsNothing(movie) Then
                Return HttpNotFound()
            End If
            Return View(movie)
        End Function

        ' GET: /Movies/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Movies/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Title,ReleaseDate,Genre,Price,Rating")> ByVal movie As Movie) As ActionResult
            If ModelState.IsValid Then
                db.Movies.Add(movie)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(movie)
        End Function

        ' GET: /Movies/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim movie As Movie = db.Movies.Find(id)
            If IsNothing(movie) Then
                Return HttpNotFound()
            End If
            Return View(movie)
        End Function

        ' POST: /Movies/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Title,ReleaseDate,Genre,Price,Rating")> ByVal movie As Movie) As ActionResult
            If ModelState.IsValid Then
                db.Entry(movie).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(movie)
        End Function

        ' GET: /Movies/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim movie As Movie = db.Movies.Find(id)
            If IsNothing(movie) Then
                Return HttpNotFound()
            End If
            Return View(movie)
        End Function

        ' POST: /Movies/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim movie As Movie = db.Movies.Find(id)
            db.Movies.Remove(movie)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
