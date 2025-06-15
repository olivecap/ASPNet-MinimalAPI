// Cretae web application
using System.Runtime.ExceptionServices;

var builber = WebApplication.CreateBuilder();

// Build web app
var App = builber.Build();


//------------------------------------------------
// Param 1 => URL
// Param 2 =< Delegate de la route
//------------------------------------------------
// First API Get
App.MapGet("/Hello", () => "Hello World");

// Run Aplliction
App.Run();




