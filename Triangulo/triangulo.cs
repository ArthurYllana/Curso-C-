using System;
using System.Globalization;

namespace Triangulo {
    class Triangulo {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double Area() {
            // Usando a fórmula de Heron para calcular a área do triângulo
            double s = (A + B + C) / 2.0;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
    }
}