using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR
{
    public class Program
    {
        public static int ParseNumber(string input)
        {
            var lines = input.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
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
                if (lines[0] == " _ "&& lines[1] == "  |" && lines [2] =="  |")
                {
                    return 7;
                }

            }
            throw new ArgumentException("Input is not a valid [0-9] range", nameof(input));
        }

        static void Main(string[] args)
        {
        }
    }
}
