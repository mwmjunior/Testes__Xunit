using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {

        // Padrao AAA - Act , Arrange , Assert
        [Fact]
        public void TestMethodSum()
        {
            //Arange
            var x1 = 4.1;

            var x2 = 5.9;

            var resultExpected = 10;

            //Act
            var sum = Calculo.Somar(x1, x2);

            //Assert 
            Assert.Equal(resultExpected, sum);

        }

        [Fact]
        public void TestMethodSub()
        {
            var x1 = 9.9;

            var x2 = 3.2;

            var resultExpected = 6.7;


            var sub = Calculo.Subtrair(x1, x2);

            Assert.Equal(resultExpected, sub);

        }

        [Fact]
        public void TestMethodMulti()
        {
            var x1 = 15;

            var x2 = 9.65;

            var resultExpected = 144.75;


            var multi = Calculo.Multiplicacao(x1, x2);

            Assert.Equal(resultExpected, multi);
        }

        [Fact]
        public void TestMethodDiv()
        {
            var x1 = 18;

            var x2 = 25.2;

            var resultExpected = 0.7142857142857143;


            var div = Calculo.Divisao(x1, x2);

            Assert.Equal(resultExpected, div);
        }

        [Fact]
        public void TestMethodBaskara()
        {
            var a = 1;

            var b = 3;
            
            var c = 2;

            var resultExpected = new double[] { -1, -2 };



            var bask = Calculo.Baskara(a,b,c);

            Assert.Equal(resultExpected, bask);
        }
    }
}
