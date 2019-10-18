using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiProyectoPrueba
{
    public class Calculadora
    {
        public static int Sumar(int elementoPrimero, int elementoSegunto)
        {
            return elementoPrimero + elementoSegunto;
        }
        public static int Restar(int elementoPrimero, int elementoSegunto)
        {
            return elementoPrimero - elementoSegunto;
        }
        public static int Multiplicar(int elementoPrimero, int elementoSegunto)
        {
            return elementoPrimero * elementoSegunto;
        }
        public static int Dividir(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }
    }
}
