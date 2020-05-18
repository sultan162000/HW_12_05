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
            ///////////////2

            var repText = from p in text
                          select p.ToString().ToLower().Replace('1', 'a').Replace('2', 'e').Replace('3', 'i').Replace('4', 'o').Replace('5', 'u');
            foreach (var item in repText)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            ///////////////3
            string chislo = "gdfgdf234dg54gf*23oP42";
            var operation = (chislo.Where(i => Char.IsPunctuation(i)).ToArray()[0]);
            var clearText = new string(chislo.Where(i => Char.IsDigit(i) || char.IsPunctuation(i)).ToArray()).Split(operation);

            double one = double.Parse(clearText[0]);
            double two = double.Parse(clearText[1]);

            var resultOp = (operation == '+') ? one + two : (operation == '-') ? one - two : (operation == '/') ? one / two : (operation == '*') ? one * two : -1;
            Console.WriteLine(resultOp);

            //////////////4
            string strRegex = @"(?<=[a-z])([A-Z])|(?<=[A-Z])([A-Z][a-z])";
            Regex reg = new Regex(strRegex, RegexOptions.None);
            string strString = @"camelCasingText";
            string strReplace = @" $1$2";
            var myreg = reg.Replace(strString, strReplace);
            Console.WriteLine(myreg);

            Console.ReadKey();
        }
    }
}
