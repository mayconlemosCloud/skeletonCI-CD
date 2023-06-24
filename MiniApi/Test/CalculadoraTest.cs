using FluentAssertions;
using WebAPI.Service;

namespace Test
{
    public class CalculadoraTest
    {
        [Fact]
        public void DeveSomarCorretamente()
        {
            var calculadora = new Calculadora().Soma(20, 30);
            calculadora.Should().Be(50);
        }
    }
}