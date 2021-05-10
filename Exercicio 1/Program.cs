using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu?");
           int dataNascimento = int.Parse(Console.ReadLine());

           int anoAtual = DateTime.Now.Year;

           int idadeCliente = anoAtual - dataNascimento;
           
           if (idadeCliente >= 18){
               Console.WriteLine("Você pode votar esse ano!");
           
            }else{
               Console.WriteLine("Você não pode votar esse ano!");
           }
        }
    }
}
