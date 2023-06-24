using MiniAPI.Services;

namespace Testes
{
    public class CalculadoraTeste
    {
        [Fact]
        public void DeveSomarCorretamente()
        {
            var calculadora = new Calculadora();
            int soma = calculadora.Soma(10, 10);
            Assert.Equal(20, soma);

        }
    }
}