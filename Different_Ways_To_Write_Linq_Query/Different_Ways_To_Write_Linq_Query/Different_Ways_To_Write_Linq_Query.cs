using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

         //Query Syntax
            
            var querySyntax = from obj in list
                              where obj > 2
                              select obj;

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------");

            //Method Syntax

            var methodSyntax = list.Where(obj => obj > 2);
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("--------------------------------");


            //Mixed Syntax

           var  mixedSyntax = (from obj in list
                           select obj).Max();
            Console.WriteLine("Max Value :{0}",mixedSyntax);


            Console.ReadLine();



        }
    }
}

