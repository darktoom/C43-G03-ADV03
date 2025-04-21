using System.Runtime.InteropServices;

namespace C43_G03_ADV03
{
    public delegate int stringfuncdelegate(string str);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex 1
            //// step 1
            //stringfuncdelegate? stringfunc;
            //// step 2 

            //stringfunc = Stringfunc.getcountupper;
            //stringfunc+= Stringfunc.getcountlower;
            //stringfunc-= Stringfunc.getcountlower;
            ////step3
            //int result = stringfunc.Invoke("ROute");
            //result = stringfunc("hAtEM");
            //Console.WriteLine(result);
            #endregion
            #region ex2
            //int[] num = { 7, 2, 4, 6, 5, 8 };

            //SortingAlgorithms<int>.bubblesort(num, SortingTypes.SortAsc); 
            //sortingtypesdelegate<int,int,bool> sorting1 = SortingTypes.SortAsc;
            //foreach (int i in num)
            //{

            //    Console.WriteLine($"{i}");
            //}
            #endregion
            #region ex2 genric
            // string[] names = { "omar", "hatem", "mohmmed","ali" };


            // SortingAlgorithms<string>.bubblesort(names,SortingTypes.SortAsc);
            //sortingtypesdelegate<string,string,bool> sort2 = SortingTypes.SortDesc;
            // foreach (string name in names) {

            //     Console.WriteLine($"{name}");
            // }
            #endregion
            #region ex3

            //   List<int>number = Enumerable.Range(1, 100).ToList();

            //   List<int> oddnumber=FilterLists.findelements(number,FiltersOfList .checkodd);
            //   filterdelegate <int>filtering= FiltersOfList .checkeven;
            //   List<int> evennumbers=FilterLists.findelements(number,filtering);
            //   filterdelegate<int> filter7 = FiltersOfList .divideableby7;
            //   List<int> div7=FilterLists.findelements(number,filter7);

            //   //foreach (int item in div7)
            //   //{

            //   //    Console.WriteLine(item);
            //   //}

            //   List<string> names = ["Ahmed", "hatem","mohmmed","shehab","ali"];


            //List<string>more4=   FilterLists.findelements<string>(names,FiltersOfList .checklengthmore4);
            //   List<string> less4 = FilterLists.findelements<string>(names, FiltersOfList.checklengthless4);

            //   foreach (string item in more4)
            //   {
            //       Console.WriteLine($" { item } ");
            //   }


            #endregion
            #region testbuiltin delegate
            //  Predicate<int> predicate = TestBuiltinDelegate.checkpostive;
            //  bool result = predicate.Invoke(7);
            //  Console.WriteLine($"{result}");

            //  Func<int, string> func = TestBuiltinDelegate.casting;
            //  string cast = func.Invoke(10);
            //  Console.WriteLine(cast);

            //  Action action = TestBuiltinDelegate.print;
            //  action.Invoke();


            //  Action <string> action1=TestBuiltinDelegate.print;
            //action1.Invoke("ahmed");





            #endregion
            #region  anonymous method
            //    Predicate<int> predicate = delegate (int number) { return number >= 0; };
            //bool result = predicate.Invoke(7);
            //    Console.WriteLine($"{result}");

            //    Func<int, string> func = delegate (int number) { return number.ToString(); };
            //string cast = func.Invoke(10);
            //    Console.WriteLine(cast);

            //    Action action = delegate { Console.WriteLine("hello world"); }; 
            //action.Invoke();


            //    Action<string> action1 = delegate (string name) { Console.WriteLine($"hello,{name}"); };
            //action1.Invoke("ahmed");
            #endregion
            #region lambda exprssion
           //    Action action = ()=> Console.WriteLine("hello world"); 
           // action.Invoke();
           //    Action<string> action1 =  name =>  Console.WriteLine($"hello,{name}"); 
           // action1.Invoke("ahmed");

           //     Func<int, string> func =  number=>  number.ToString(); 
           // string cast = func.Invoke(10);
           //    Console.WriteLine(cast);

           //Predicate<int> predicate =  number=>  number >= 0; 
           // bool result = predicate.Invoke(7);
           // Console.WriteLine($"{result}");

            #endregion


        }
    }
}
