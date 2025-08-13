using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Ejercicio1.test1
{
    public class Calculadora
    {
        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir por cero");
            return a / b;
        }
    }
}