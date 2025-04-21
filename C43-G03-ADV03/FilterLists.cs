using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_ADV03
{
    public delegate bool filterdelegate<T>(T a);

    internal class FilterLists
    {

        public static List<T> findelements<T>(List<T> numbers,filterdelegate<T> filter)
        { 
         List <T> result = new List<T>();
            if (numbers?.Count >0&&filter!=null) {
                for (int i = 0; i < numbers.Count; i++) {
                   // if (numbers[i] % 2 == 1) 
                   if(filter(numbers[i]))
                    { 

                       result.Add(numbers[i]);
                    }
                
                
                }

            }
            return result;
        }

    }
}
