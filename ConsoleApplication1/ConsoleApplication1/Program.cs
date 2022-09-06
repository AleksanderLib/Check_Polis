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
            string N_POL = "5532264332123445";
            Console.WriteLine(N_POL);
            bool chek = true;
            string newpol = N_POL.Remove(N_POL.Length-1);
            char[] reser = newpol.ToCharArray();
            Array.Reverse(reser);//перевернул строку справа на лево 
            string fin1 = " ";//нечет
            string fin2 = " ";//чет
           
            Console.WriteLine(reser);
            for (int i = 1; i < reser.Length+1; i++ )
            {
                //нечетные
                if (i % 2 != 0)
                {
                    fin1 += reser[i-1].ToString();
                    
                }
                //четные
                else
                {
                    if (i % 2 == 0)
                    {
                        fin2 += reser[i-1].ToString();
                        
                    }
                }
                
            }
            Console.WriteLine(fin1);
            Console.WriteLine(fin2);
            int s = Convert.ToInt32(fin1)*2;
            Console.WriteLine(s);
            string str = string.Concat(s.ToString(), fin2.Trim());
            Console.WriteLine(str);
            int  rez = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if(char.IsNumber(str[j]))
                {
                rez += Convert.ToInt32(str[j].ToString());
                }
            }
            Console.WriteLine(rez);
            int gr = ((rez / 10)+1)*10;
            int all = gr - rez;
            Console.WriteLine(gr);
            Console.WriteLine(all);
            if (N_POL.Substring(N_POL.Length - 1) == all.ToString())
            {
                chek = true;
            }
            else
            {
                chek = false;
            }
            Console.WriteLine(chek);
            Console.ReadKey();
        }


    }
}
