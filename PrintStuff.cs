using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpData
{
    internal class PrintStuff
    {
        private string language;
        //Constructor
        //Overloading method is below
        public PrintStuff ()
        {
            language = "EN";
        }
        public PrintStuff(string temp)
        {
            language = temp;
        }
        public void PrintName(string firstName)
        {
            if (language == "EN")
            {
            System.Console.WriteLine("Hello, " + firstName + "!");
            }
            if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + firstName + "!");
            }
        }
    }
}
