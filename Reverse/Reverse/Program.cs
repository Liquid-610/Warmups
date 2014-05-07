using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    class Program
    {
        public static String reverse(string input)
        {
            input = input.ToLower();
            char[] a = input.ToCharArray();
            Array.Reverse(a);

            for (int i = 1; i <= a.Length; i += 2)
            {
                a[i] = (char)(a[i] - 32);  //.ToString().ToUpper()[0];
 
            }        

            return new string(a);
          
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            String output = reverse(input);






            Console.Write(output);

            
        }
    }
}
