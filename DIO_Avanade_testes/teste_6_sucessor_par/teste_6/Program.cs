// See https://aka.ms/new-console-template for more information
using System;

class DIO
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());

        if (x % 2 == 0)
        {
            x += 2;
        }
        else
        {
            x ++;
        }
        Console.WriteLine(x);
        //escreva aqui o seu código

    }

}