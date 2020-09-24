using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Quantos funcionários serão registrados? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário #" + (i + 1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                list.Add(new Funcionario(id, nome, salario));
            }



            Console.WriteLine("Digite a id do funcionário que terá aumento de salário: ");
            int idF = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == idF);

            if (func != null)
            {
                Console.Write("Insira a porcentagem: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.Aumento(porc);
            }
            else
            {
                Console.WriteLine("Este id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários: ");

            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
