using Xunit;
using UnitTest_Ejercicio1.test2;

namespace UnitTest_Ejercicio1.test2
{
    public class EmailValidatorTests
    {
        private readonly EmailValidator _validator = new EmailValidator();

        [Theory]
        [InlineData("usuario@example.com")]
        [InlineData("nombre.apellido@dominio.org")]
        [InlineData("correo@sub.dominio.net")]
        public void EsEmailValido_EmailsCorrectos_RetornaTrue(string email)
        {
            var resultado = _validator.EsEmailValido(email);
            Assert.True(resultado);
        }

        [Theory]
        [InlineData("")]
        [InlineData("     ")]
        [InlineData("sinarroba.com")]
        [InlineData(null)]
        public void EsEmailValido_EmailsIncorrectos_RetornaFalse(string email)
        {
            var resultado = _validator.EsEmailValido(email);
            Assert.False(resultado);
        }
    }
}
