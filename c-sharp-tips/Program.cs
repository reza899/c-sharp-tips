using System;
using System.Collections;
using System.Collections.Generic;

namespace c_sharp_tips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 4, 5, 6, 7 };
            ArrayList arlist = new ArrayList() { 1, 5, "Hello", 2.5 };

            IEnumerable<int> enumInt = list;
            var eee = enumInt.GetEnumerator();
            int[] a=new int[5];
            int j=0;
            foreach (var item in enumInt)
            {
                eee.MoveNext();
                a[j++] = eee.Current;
            }

            var gg = new Nullable<int>(12);
            Console.WriteLine($"HasValue: {gg.HasValue} \r\n {gg.ValueOrDefault()}");

            GenericCol<int> genericStruct = new GenericCol<int>();
            string gs = genericStruct.Add(2);

            GenericDict<int, string> genericDict = new GenericDict<int, string>();
            string gd = genericDict.Add(1, "hello");

            var util = new Utilities<int>();
            int max = util.Max(4, 6);


            var indx = new Indexer<int>();
            for (int i = 0; i < 100; i++)
            {
                indx[i] = new Random().Next(100, 1000);
            }
            Console.WriteLine(indx[90]); 
            
        }


    }
}
