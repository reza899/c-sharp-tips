using c_sharp_tips.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace c_sharp_tips
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            // CollectionSample();
            // p.DelegateSample();

            // p.LambdaExprsSample();
            p.NullableSample();
        }

        private void NullableSample()
        {
            //Nullable<DateTime>
            DateTime? dt1 = null;
            DateTime dt = dt1 ?? DateTime.Today;
        }

        private static List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book(){Id=1,Price=2.5M,Title="Book1"},
                new Book(){Id=2,Price=5,Title="Book2"}
            };
        }

        private  void LambdaExprsSample()
        {
            int n = Multiplyer(10); // 100
            Func<int,int,int> func = (y,z) => y * z;
            var k = func(10, 10); // 100

            //using lambda expression, is much faster and easier
            foreach (var item in GetBooks().Where(x => x.Price < 3))
            {
                Console.WriteLine(item.Title + " : " + item.Price);
            }
            //using predicate (get an object and return a boolean)
            foreach (var item in GetBooks().Where(CheaerThanThree))
            {
                Console.WriteLine(item.Title + " : " + item.Price);
            }
        }

        private bool CheaerThanThree(Book book)
        {
            return book.Price < 3;
        }

        private int Multiplyer(int v)
        {
            return v*v;
        }

        private void DelegateSample()
        {
            Action<int> action = new Action<int>(DoSomething);
            action(245);

            Func<int, int, string> func = new Func<int, int, string>(DoSomethingCalc);
            var ss= func(100, 240);
        }

        public string DoSomethingCalc(int i, int j)
        {
            return (i * j).ToString();
        }
        public void DoSomething(int i)
        {
            Console.WriteLine($"Do Something {i} times...");
        }
        private static void CollectionSample()
        {
            int[] list = { 1, 4, 5, 6, 7 };
            ArrayList arlist = new ArrayList() { 1, 5, "Hello", 2.5 };

            IEnumerable<int> enumInt = list;
            var eee = enumInt.GetEnumerator();
            int[] a = new int[5];
            int j = 0;
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
