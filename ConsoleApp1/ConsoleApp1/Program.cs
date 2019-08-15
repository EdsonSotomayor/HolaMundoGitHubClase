using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,resultado;
            Console.WriteLine("Dime 2 digitos");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 + num2;
            Console.WriteLine("Tu resultado es {0}", resultado);

            string nombre;
            Console.WriteLine("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola{0} ", nombre);
        }
    }
}
