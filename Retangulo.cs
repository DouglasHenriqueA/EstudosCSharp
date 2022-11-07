using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerciciosFixação
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public override string ToString()
        {
            return "O retangulo em questão tem area de: " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\n Perimetro de: "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\n Diagonal igual a : " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
        public double Area()
        {
            double AreaR = Largura * Altura;

            return AreaR;
        }
        public double Perimetro()
        {
            double per = 2 * (Altura + Largura);
            return per;
        }
        public double Diagonal()
        {
            double diagonal = Math.Sqrt((Altura * Altura) + (Largura * Largura));
            return diagonal;
        }
    }
}
