using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR
{
    public class Program
    {
        public static int ParseDigit(string input)
        {
            var lines = input.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (lines[0] == "   ")
            {
                if (lines[1] == "  |")
                    return 1;
                else
                {
                    return 4;
                }
            }
            else
            {
                if (lines[0] == " _ ")
                {
                    if (lines[1] == "| |")
                        return 0;
                    if (lines[1] == "  |" && lines[2] == "  |")
                        return 7;
                    if (lines[1] == " _|")
                    {
                        if (lines[2] == " _|")
                            return 3;
                        if (lines[2] == "|_ ")
                            return 2;
                    }
                    if (lines[1] == "|_ ")
                    {
                        if (lines[2] == "|_|")
                            return 6;
                        return 5;
                    }
                    if (lines[1] == "|_|")
                    {
                        if (lines[2] == "|_|")
                            return 8;
                        if (lines[2] == " _|")
                            return 9;
                    }
                }

            }
            throw new ArgumentException("Input is not a valid [0-9] range", nameof(input));
        }

        public static int BuildNumber(string input)
        {
            for (var d = 0; d < input.Length / 3;)
            {
                var lines = input.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                var digit = lines[d];
                for (var i = 0; i < d+3; i++)
                {
                    //NO FUNCIONA, PENSAR MEJOR :)
                }
                d = d + 3;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
