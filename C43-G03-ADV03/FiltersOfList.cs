using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_ADV03
{
    internal class FiltersOfList
    {

        public static bool checkodd(int number)
        {
            return number % 2 != 0;

        }


        public static bool checkeven(int number)
        {
            return number % 2 != 1;

        }

        public static bool divideableby7(int number)
        {
            return number % 7 ==0 ;

        }

        public static bool checklengthmore4(string str)
        {

           return str?.Length >4  ;
        }
        public static bool checklengthless4(string str)
        {

            return str?.Length < 4;
        }


    }
}
