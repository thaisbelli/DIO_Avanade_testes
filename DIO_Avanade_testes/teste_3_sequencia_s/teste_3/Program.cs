﻿// See https://aka.ms/new-console-template for more information
using System;

class DIO
{

    static void Main(string[] args)
    {

        double c, S = 0;
        for (double i = 1; i <= 100; i++)
        {
            c = (1 / i);  //coloque a sua lógica nos espaços em branco
            S += c;
        }
        var x = Math.Round(S, 2);
        Console.WriteLine(x);
    }

}