using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = (a + b) / 2;
        c = c - 40;
        int[] v = new int[7];

        v[3] = a + b + c;

        for (int cont = 0; cont < 7; cont++)
           
        {
           
            System.Console.WriteLine($"vetor[{cont}] = {v[cont]}");
        }
    }
}