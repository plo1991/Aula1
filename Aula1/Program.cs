using System;

namespace Aula1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome, resultado;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            sobrenome = Console.ReadLine();

            resultado = nome + " " + sobrenome;

            Console.Write("Resultado: " + resultado);
            Console.ReadLine();
        }
    }  
}
