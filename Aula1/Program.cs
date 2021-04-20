using System;

namespace Aula1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Double nota1, nota2, media;

            Console.Write("Seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2 ;

            if(media >= 7.0)
            {
                Console.WriteLine("Parabens " + nome + " passou, com media " + media);
            }
            else
            {
                Console.WriteLine( nome + " voce reprovou, sua media foi " + media);
            }

            Console.ReadLine();
        }
    }  
}
