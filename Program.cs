using MinimalApi.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (loginDTO loginDTO)=> {
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "1234") 
    return Results.Ok("Login com sucesso");
    else
    return Results.Unauthorized();
});

app.Run();


