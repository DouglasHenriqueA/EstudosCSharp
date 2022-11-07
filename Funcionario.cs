using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosFixação
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public override string ToString()
        {
            return "Funcionario: " + Nome + ", $" + SalarioLiquido();
        }
        public double SalarioLiquido()
        {
            double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }
        public void AumentarSalario(double percent)
        {
            SalarioBruto += (SalarioBruto * (percent/100));
        }
    }
}
