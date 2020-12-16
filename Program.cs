using System;
using System.Globalization;

namespace URI_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int soma = 0;
            int cont = 0;
            double media;
            idade =int.Parse(Console.ReadLine());
            
            while (idade >0){
                soma = soma + idade;
                cont ++;
                idade =int.Parse(Console.ReadLine());
            }
            media = (double)soma / cont;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
