using System;

class Program
{
    //Return Inverso Número
    static void Main(string[] args)
    {
        int num, inverso;

        Console.Write("Digite um número: ");
        num = Convert.ToInt32(Console.ReadLine());

        inverso = (-1 * num);

        Console.WriteLine("O inverso de " + num + " é: " + inverso);
    }
}
