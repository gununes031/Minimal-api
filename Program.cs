using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;
using MinimalApi.Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;



var builder = WebApplication.CreateBuilder(args);

 builder.Services.AddScoped<iAdministradorServico, AdministradorServico>();

 builder.Services.AddEndpointsApiExplorer();
 builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbContexto>(Options => {
    Options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"));
});
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", ([FromBody]loginDTO loginDTO, iAdministradorServico administradorServico)=> {
    if (administradorServico.Login(loginDTO) != null) 
    return Results.Ok("Login com sucesso");
    else
    return Results.Unauthorized();
});

app.UseSwagger();
app.UseSwaggerUI();

app.Run();


