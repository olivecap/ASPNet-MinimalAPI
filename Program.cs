// Cretae web application
using MinimalAPI;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;

var builber = WebApplication.CreateBuilder();

// Build web app
var App = builber.Build();


//------------------------------------------------
// Param 1 => URL
// Param 2 =< Delegate de la route
//------------------------------------------------
// REST API
App.MapGet("/get", () => "GET: Hello World");
App.MapPost("/post", () => "POST: Hello World");
App.MapPut("/put", () => "PUT: Hello World");
App.MapDelete("/delete", () => "DELETE: Hello World");

//------------
//- ARTICLES -
//------------
var list = new List<Article>
{
    new Article(1, "Marteau"),
    new Article(2, "Scie")
};

// REST API For Article
App.MapGet("/article", () => new Article(1, "Marteau"));

//------------------------------------------------------------------------
// {id} permet de dfinir en root un param
// La param de la root est recupere et transformer dans le param (int id)
//------------------------------------------------------------------------
App.MapGet("/articles/{id}", (int id) => 
{ 
    // Search article
    var article = list.Find(a => a.Id == id);

    // Check if article is found
    if (article == null)
        return Results.NotFound();

    // Return article
    return Results.Ok(article);
});

// Run Aplliction
App.Run();




