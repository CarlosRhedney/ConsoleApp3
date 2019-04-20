using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, materia, ra;
            double p1, p2, media;
            Console.Write("\nDigite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("\nDigite a matéria do aluno: ");
            materia = Console.ReadLine();
            Console.Write("\nDigite o ra do aluno:");
            ra = Console.ReadLine();
            Console.Write("\nDigite a nota p1 do aluno: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite a nota p2 do aluno: ");
            p2 = Convert.ToDouble(Console.ReadLine());
            media = (p1 + p2) / 2;
            Console.Write("\n***************************************************************************");
            Console.Write("\nNome: {0} \tMateria: {1} \tR.A: {2}", nome, materia, ra);
            Console.Write("\nNotas: \tP1: {0} \tP2: {1} \tMédia: {2}", p1, p2, media);
            Console.Write("\nDigite qualquer tecla para sair....");
            Console.ReadKey();

        }
    }
}
