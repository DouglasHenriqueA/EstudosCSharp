using System;

namespace ExerciciosFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            while (sair == false)
            {
                Console.WriteLine("");
                Console.WriteLine(" ---Escolha qual programa testar:---" +
                    "\n ---digite 1 para Retangulo--- " +
                    "\n ---digite 2 para funcionario--- " +
                    "\n ---digite 3 para boletim--- ");
                Console.WriteLine("");
                int decisao = int.Parse(Console.ReadLine());

                if (decisao == 1)
                {
                    retangulo();
                }
                else if (decisao == 2)
                {
                    funcionario();
                }
                else if (decisao == 3)
                {
                    boletim();

                }
                else if (decisao != 1 || decisao != 2 || decisao != 3)
                {
                    Console.WriteLine(" codigo invalido " +
                        "\n-------------------------\n" +
                        " Deseja sair ? " +
                        " Caso sim digite '1' caso não, digite '2'");
                    int saida = int.Parse(Console.ReadLine());

                    if (saida == 1) sair = true;
                    else sair = false;

                }
            }

        }
        public static void retangulo()
        {
            Retangulo r1 = new Retangulo();
            Console.WriteLine("");
            Console.Write("Digite o Lado do retangulo: ");
            r1.Largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do retangulo: ");
            r1.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(r1);
            Console.WriteLine("");
        }
        public static void funcionario()
        {
            Console.WriteLine("");
            Funcionario f1 = new Funcionario();
            Console.Write("Digite o nome do funcionario: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Digite o salario Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Digite imposto sobre o salario: ");
            f1.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine(f1);

            Console.WriteLine("Funcionario irá receber aumento? Se sim digite '1'" +
                "se nao digite '2' ");
            int aumento = int.Parse(Console.ReadLine());
            
            if (aumento == 1)
            {
                Console.WriteLine("Qual a porcentagem de aumento ? ");
                double percent = double.Parse(Console.ReadLine());
                f1.AumentarSalario(percent);
                Console.WriteLine("Dados atualizados: "+f1);
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("");
        }
        public static void boletim()
        {
            Boletim aluno = new Boletim();

            Console.Write(" Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write(" Digite as tres notas do aluno: ");
            aluno.N1 = double.Parse(Console.ReadLine());
            aluno.N2 = double.Parse(Console.ReadLine());
            aluno.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Nota final " + aluno.NotaFinal());
            if (aluno.NotaFinal() > 60) Console.WriteLine(" Aprovado ");
            else if (aluno.NotaFinal() < 60)
            {
                double test = (aluno.NotaFinal() - 60)*-1;
                Console.WriteLine(" Reprovado\n Faltaram "+test+" Pontos");
            }
        }
    }
}
