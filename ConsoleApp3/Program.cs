using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ConsoleApp3
{

   

     

    class Program
    {
        static void Main(string[] args)
        {
           
 
            ProgramConverter[] pc = new ProgramConverter[3];
            pc[0] = new ProgramHelper();
            pc[1] = new ProgramConverter();
            pc[2] = new ProgramConverter();


            for (int i = 0; i < pc.Length-1; i++)
            {
                if (pc[i] is ICodeChecker)
                { 
                   ICodeChecker qq=  pc[i] as ProgramHelper;
                  Console.WriteLine(qq.CheckCodeSyntax("+","+"));                   
                }
                else
                {             
                    Console.WriteLine(pc[i].ConvertToCSharp("+"));
                    Console.WriteLine(pc[i].ConvertToVB("+"));  
                    
                }
            }


            Console.ReadKey();

        }
    }
}
