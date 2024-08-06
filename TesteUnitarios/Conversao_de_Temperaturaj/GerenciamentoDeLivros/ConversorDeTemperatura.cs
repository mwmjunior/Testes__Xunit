using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GerenciamentoDeTemperatura
{

    public class ConversorDeTemperatura
    {
        // Método que converte uma temperatura de Celsius para Fahrenheit
        public double ConverterCelsiusParaFahrenheit(double celsius)
        {
            // Fórmula de conversão: (Celsius * 9/5) + 32
            return (celsius * 9.0 / 5.0) + 32.0;
        }
    }

}

