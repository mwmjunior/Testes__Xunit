
using GerenciamentoDeTemperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConversorDeTemperatura.Test
{
    public class ConversorDeTemperatura_Test
    {
        // Define um teste que será executado com diferentes conjuntos de dados
        [Theory]
        [InlineData(0, 32)] // 0°C -> 32°F
        [InlineData(100, 212)] // 100°C -> 212°F
        [InlineData(-40, -40)] // -40°C -> -40°F (ponto onde Celsius e Fahrenheit se igualam)
        [InlineData(37, 98.6)] // 37°C -> 98.6°F (temperatura corporal média)
        [InlineData(25, 77)] // 25°C -> 77°F
        public void ConverterCelsiusParaFahrenheit_DeveRetornarResultadoCorreto(double celsius, double fahrenheitEsperado)
        {
            // Act: Chama o método ConverterCelsiusParaFahrenheit com o valor fornecido em Celsius
            double resultado = GerenciadorTemperatura.ConverterCelsiusParaFahrenheit(celsius);

            // Assert: Verifica se o resultado é igual ao valor esperado em Fahrenheit
            Assert.Equal(fahrenheitEsperado, resultado, 1); // 1 representa a precisão do ponto flutuante
        }
    }
}
