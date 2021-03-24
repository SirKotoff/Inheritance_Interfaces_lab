using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ProgramHelper: ProgramConverter,ICodeChecker,IConvertible
    {
        public bool CheckCodeSyntax(string check, string language)
        {
            return true;

            
        }

        public string ConvertToCSharp(string s)
        {
            return "Код конвертирован в язык C#";
        }


        public string ConvertToVB(string ss)
        {
            return "Код конвертирован в язык VB";
        }

        




    }
}
