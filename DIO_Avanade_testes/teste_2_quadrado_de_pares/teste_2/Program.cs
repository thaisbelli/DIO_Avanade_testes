﻿// See https://aka.ms/new-console-template for more information
using System;

class DIO
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        if (n > 5 && n < 2000)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($" {i} ^2 = {i * i}");
                }        //escreva o seu código nos espaços em branco
            }

        }
    }
}