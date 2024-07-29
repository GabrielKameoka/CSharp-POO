using System;

namespace Projeto1_2 {
    class Triangulo {// nome da classe
        public double A;//membros da classe //no caso é atributo
        public double B;//membros da classe //no caso é atributo
        public double C;//membros da classe //no caso é atributo

        public double Area () {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); //membros da classe //no caso é método

        }
    }
}