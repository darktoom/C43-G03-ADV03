using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_ADV03

{// non-genric
 // public delegate bool sortingtypesdelegate(int a, int b);

    //genric
    public delegate Tout sortingtypesdelegate<in t1,in t2,out Tout>(t1 a, t2 b);
    internal static class SortingAlgorithms<T>
    {
        public static void bubblesort(T[] arr, sortingtypesdelegate<T,T,bool> sorttype)
        {
            if (arr?.Length > 0) {
                for (int i = 0; i < arr.Length; i++) {

                    for (int j = 0; j < arr.Length-i-1; j++) {
                        //if (arr[j] > arr[j+1])
                        if (sorttype?.Invoke(arr[j], arr[j+1])??false)
                            swap(ref arr[j], ref arr[j+1]);
                    
                    }
                
                }
            }

        }
       


        private static void swap<T>(ref T v1, ref T v2)
        {
            T temp=v1;
            v1=v2;
            v2=temp;

        }
    }
}
