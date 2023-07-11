using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Welcome");
            stringBuilder.AppendLine("to C#");
            stringBuilder.AppendLine("I am string builder");
            Console.WriteLine(stringBuilder);
            Console.ReadKey();
        }
      
    }
}
