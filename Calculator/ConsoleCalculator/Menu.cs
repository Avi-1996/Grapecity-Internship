using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Menu
    {
        public void Show()
        {
            
            Console.WriteLine();
            Console.WriteLine("\\tWelcome To the Console Calculator");
            Console.WriteLine("\t\tt\t\t\t\t\t\t\t Oprator allowed");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t +     : Addition \t\t  -       : subtraction");
            Console.WriteLine("\t\t\t\t *     : Multiply \t\t /        : Division");
            Console.WriteLine("\t\t\t\t %     : Mod      \t\t ^        : Power");
            Console.WriteLine("\t\t\t\t Sqr   : square   \t\t SqrRoot  : Division");
            Console.WriteLine("\t\t\t\t Sine  : Sine     \t\t Cos      :  Cosine");
            Console.WriteLine("\t\t\t\t       : Tan      \t\t          :  Log");
        }
    }
}
