using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW_12_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hello world, aaAaa!";
            var stext = from p in text
                        select p.ToString().ToLower().Replace('a', '1').Replace('e', '2').Replace('i', '3').Replace('o', '4').Replace('u', '5');
            foreach (var item in stext)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            var repText = from p in text
                          select p.ToString().ToLower().Replace('1', 'a').Replace('2', 'e').Replace('3', 'i').Replace('4', 'o').Replace('5', 'u');
            foreach (var item in repText)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            string chislo = "gdfgdf234dg54gf*23oP42";
            Regex reg = new Regex(@"[^*+-\/]+");
            string operationSimvol = reg.Replace(chislo, "");
            Console.WriteLine(operationSimvol);

            Regex regxp = new Regex(@"\b");

            string[] sss = regxp.Split(chislo);
            Console.WriteLine(sss[1]); 
            

            Console.ReadKey();
        }
    }
}
