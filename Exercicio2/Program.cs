using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool pertence = VerificarFibonacci(numero);

        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool VerificarFibonacci(int num)
    {
        int a = 0;
        int b = 1;

        while (b < num)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == num;
    }
}