using System;
using Encapsulamento.Classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();


        m.NomeTitular = "Thiago Costa";


        m.Numero = "12345678"; // Aqui foi utilizado o SET

        m.Bandeira = "MasterCard";

        Console.WriteLine($"O titular {m.NomeTitular} - Token {m.Token} - CVV {m.Token}"); // Aqui foi utilizado o Get




        }
    }
}
