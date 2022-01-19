// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            while (N-- > 0)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                int newval = (int)Math.Sqrt(val);        //complete com a sua lógica
                int resposta = val - newval;
                Console.WriteLine(resposta);
            }
        }
    }
}