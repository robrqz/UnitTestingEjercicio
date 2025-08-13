using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Ejercicio1.test3
{
    public class CalculadoraDescuento
    {
        public decimal Calcular(decimal precio, int porcentaje)
        {
            if (precio < 0) throw new ArgumentException("Precio inválido");
            if (porcentaje < 0 || porcentaje > 100) throw new ArgumentException("Porcentaje inválido");

            return precio - (precio * porcentaje / 100);
        }
    }
}
