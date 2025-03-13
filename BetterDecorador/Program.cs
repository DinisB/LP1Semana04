using System;
using System.Globalization;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
            /// Decorate string
            /// </summary>
            /// <param name="s">String to be used </param>
            /// <param name="dec">Symbol to decorate </param>
            /// <param name="num">Number of times for symbol to appear </param>
            /// <returns> Decorated String </returns>
        private static string Decor(string s, char dec, int num)
        {
            string res = new String(dec, num);
            return $"{res} {s} {res}";
        }
        /// <summary>
            /// Decorate string
            /// </summary>
            /// <param name="args">Console arguments </param>
            /// <returns> Print decorated string to console </returns>
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], Convert.ToChar(args[1]), Convert.ToInt32(args[2])));
        }
    }
}
