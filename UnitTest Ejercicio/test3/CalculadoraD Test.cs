using Xunit;
using UnitTest_Ejercicio1;
using UnitTest_Ejercicio1.test3;

namespace UnitTest_Ejercicio2.test1
{
  
    public class CalculadoraDescuentosTests
    {
        private readonly CalculadoraDescuento _calculadora = new CalculadoraDescuento();

        [Theory]
        [InlineData(100, 10, 90)]
        [InlineData(200, 25, 150)]
        [InlineData(50, 0, 50)]
        public void Calcular_ValoresValidos_RetornaDescuentoCorrecto(decimal precio, int porcentaje, decimal esperado)
        {
            var resultado = _calculadora.Calcular(precio, porcentaje);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(-100, 10)]
        [InlineData(100, -5)]
        [InlineData(100, 150)]
        public void Calcular_ValoresInvalidos_LanzaExcepcion(decimal precio, int porcentaje)
        {
            Assert.Throws<ArgumentException>(() => _calculadora.Calcular(precio, porcentaje));
        }
    }
}