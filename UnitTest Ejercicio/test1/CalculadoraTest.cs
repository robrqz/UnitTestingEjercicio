using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Ejercicio1.test1
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora = new Calculadora();

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-1, 1, 0)]
        [InlineData(0, 0, 0)]
        public void Sumar_ValoresValidos_RetornaResultadoCorrecto(int a, int b, int esperado)
        {
            var resultado = _calculadora.Sumar(a, b);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        [InlineData(0, 1, 0)]
        public void Dividir_ValoresValidos_RetornaResultadoCorrecto(int a, int b, int esperado)
        {
            var resultado = _calculadora.Dividir(a, b);
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void Dividir_DivisionPorCero_LanzaExcepcion()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(10, 0));
        }
    }
}
