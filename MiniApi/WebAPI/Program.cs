using WebAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/", () =>
{
    var calculadora = new Calculadora();
    var soma = calculadora.Soma(10,10);
    return soma;
});

app.Run();

