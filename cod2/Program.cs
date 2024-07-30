using System;

class Program
{
    static void Main()
    {
        int a = 2;
        int[] v = new int[7];

        while (a < 6)
        {
            v[a] = 10 * a;
            a = a + 1;
        }

        for (int cont = 0; cont < 7; cont++)
        {
            System.Console.WriteLine($"vetor[{cont}] = {v[cont]}");
        }
    }
}