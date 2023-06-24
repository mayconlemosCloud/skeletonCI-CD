

using MiniAPI.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    Calculadora resultado = new Calculadora();
    int soma = resultado.Soma(2, 4);
    return soma.ToString();
});

app.Run();
