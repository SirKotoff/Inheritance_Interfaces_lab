using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string message)
        {
            return "Код конвертирован в язык C#";
        }

        public string ConvertToVB(string message1)
        {
            return "Код конвертирован в язык VB";
        }
    }
}
