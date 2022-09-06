using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   

    class Checker
    {
        public bool Check_Pol (string N_POL)
        {
           
           bool chek = false;
          
               string newpol = N_POL.Remove(N_POL.Length - 1);
               char[] reser = newpol.ToCharArray();
               Array.Reverse(reser);
               string fin1 = "";//нечет
               string fin2 = "";//чет

               for (int i = 1; i < reser.Length + 1; i++)
               {
                   //нечетные
                   if (i % 2 != 0)
                   {
                       fin1 += reser[i - 1].ToString();

                   }
                   //четные
                   if (i % 2 == 0)
                   {
                       fin2 += reser[i - 1].ToString();

                   }
               }


               int s = Convert.ToInt32(fin1) * 2;

               string str = string.Concat(s.ToString(), fin2);

               int rez = 0;

               for (int j = 0; j < str.Length; j++)
               {
                   rez += Convert.ToInt32(str[j].ToString());
               }

               int gr = ((rez / 10) + 1) * 10;
               int all = gr - rez;

               int Kt = Convert.ToInt32(N_POL.Substring(N_POL.Length - 1));
               if (Kt == all)
               {
                   chek = true;
               }
               else
               {
                   chek = false;
               }
               if ((gr - rez) % 10 == Kt)
               {
                   chek = true;
               }

               return chek;
          
           }
         }  
    }

