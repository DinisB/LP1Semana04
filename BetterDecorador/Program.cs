using System;
using System.Globalization;

namespace BetterDecorador
{
    public class Program
    {
        private static string Decor(string s, char dec, int num)
        {
            string res = new String(dec, num);
            return $"{res} {s} {res}";
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], Convert.ToChar(args[1]), Convert.ToInt32(args[2])));
        }
    }
}
