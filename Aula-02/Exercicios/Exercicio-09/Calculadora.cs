using System;

namespace Exercicio9_2
{
    class Calculadora
    {
        //calculadora básica
        public double Num1;
        public double Num2;
        public double Num3;
        public double Num4;


        public double soma ()
        {
            return Num1 + Num2 + Num3 + Num4;
        }

        public double subtracao ()
        {
            return Num1 - Num2 - Num3 - Num4;
        }

        public double multiplicacao ()
        {
            return Num1 * Num2 * Num3 * Num4;
        }

        public double divisao ()
        {
            return Num1 / Num2 / Num3 / Num4;
        }

        public double media ()
        {
            return ( Num1 + Num2 + Num3 + Num4 ) / 4;
        }

        //calculadora trigonométrica
        public double Angulo;

        //calculadora raíz
        public double raiz;

        public double calculaRaizQuadrada ()
        {
            return Math.Pow (raiz, 0.5);
        }

        public double calculaRaizCubica ()
        {
            return Math.Pow (raiz, 1.0 / 3.0);
        }

        public double calculaRaizQuarta ()
        {
            return Math.Pow (raiz, 0.25);
        }
    }
}