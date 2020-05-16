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

            ///////////////3
            string chislo = "gdfgdf234dg54gf*23oP42";
            Regex reg = new Regex(@"\b");
            string[] textSplit = reg.Split(chislo);

            reg = new Regex(@"[0-9]+");
            var matches = reg.Matches(textSplit[1]);
            string chislo1 = "";
            foreach (Match m in matches)
            {
                chislo1 += m.Value;
            }
            string chislo2 = "";
            var matches1 = reg.Matches(textSplit[3]);
            foreach (Match item in matches1)
            {
                chislo2 += item.Value;
            }
            switch (textSplit[2])
            {
                case "+":
                    Console.WriteLine(Convert.ToInt32(chislo1)+Convert.ToInt32(chislo2));
                    break;
                case "-":
                    Console.WriteLine(Convert.ToInt32(chislo1) - Convert.ToInt32(chislo2));
                    break;
                case "/":
                    Console.WriteLine(Convert.ToInt32(chislo1) / Convert.ToInt32(chislo2));
                    break;
                case "*":
                    Console.WriteLine(Convert.ToInt32(chislo1) * Convert.ToInt32(chislo2));
                    break;
                default:
                    Console.WriteLine("Ошибка операции.");
                    break;
            }
            //////////////4
            string strRegex = @"(?<=[a-z])([A-Z])|(?<=[A-Z])([A-Z][a-z])";
            reg = new Regex(strRegex, RegexOptions.None);
            string strString = @"camelCasingText";
            string strReplace = @" $1$2";
            var myreg = reg.Replace(strString, strReplace);
            Console.WriteLine(myreg);

            Console.ReadKey();
        }
    }
}
