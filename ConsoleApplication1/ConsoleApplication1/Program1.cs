using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool chek;
            string N_POL = "5593899723000169";
            if (N_POL.Length == 16)
            {
                Checker Pol = new Checker();
                Console.WriteLine(Pol.Check_Pol(N_POL));
            }
            else
            {
                Console.WriteLine("Полис не прошёл проверку!!!");
            }
            //Pol.Check_Pol(N_POL);
            //chek = Pol.Check_Pol(N_POL);
            //Console.WriteLine(chek);
            //if (Pol.Check_Pol(N_POL))
            //{
            //    Console.WriteLine(Pol.Check_Pol(N_POL));
            //}
            
            Console.ReadKey();
            
        }


    }

}
