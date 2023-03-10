using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduzca un numero entero: ");
        int alturaT = int.Parse(Console.ReadLine());

        for (int i = 1; i <= alturaT; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}




