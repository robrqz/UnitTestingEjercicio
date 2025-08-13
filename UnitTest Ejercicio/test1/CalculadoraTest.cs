using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Ejercicio1.test1
{
    public class CalculadoraTests
    {
        [Theory]
        [InlineData(2, 3, 1, 6)]
        [InlineData(-1, 1, 0, 0)]
        [InlineData(0, 0, 0, 0)]
        public void Sumar_ValoresValidos_RetornaResultadoCorrecto(int a, int b, int c, int esperado)
        {
            //  Arrange
            var calculadora = new Calculadora();

            //  Act
            var resultado = calculadora.Sumar(a, b, c);

            //  Asserts
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        [InlineData(0, 1, 0)]
        public void Dividir_ValoresValidos_RetornaResultadoCorrecto(int a, int b, int esperado)
        {
            //  Arrange
            var calculadora = new Calculadora();

            //  Act
            var resultado = calculadora.Dividir(a, b);

            //  Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Dividir_DivisionPorCero_LanzaExcepcion()
        {
            //  Arrange
            var calculadora = new Calculadora();

            //  Act
            try
            {
                calculadora.Dividir(10, 0);
            }
            catch (Exception ex)
            {
                //  Assert
                Assert.Equal(ex.GetType(), typeof(DivideByZeroException));
            }

            //Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }
    }
}