using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using static LINQassignment02.ListGenerator;

namespace LINQassignment02
{
    internal class Program
    {
        static void Main()
        {
            #region LINQ - Element Operators
            #region Q01
            //var result = ProductsList.Where(p=>p.UnitsInStock==0).First();
            //Console.WriteLine(result);

            #endregion

            #region Q02
            //var result = ProductsList.Where(p=>p.UnitPrice>1000).FirstOrDefault();
            //Console.WriteLine(result);
            #endregion

            #region Q03
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(n=>n>5).ElementAt(1);
            //Console.WriteLine(result);
            #endregion

            #endregion

            #region LINQ - Aggregate Operators
            #region Q01


            //int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Numbers.Count(n=>n%2==1);
            //Console.WriteLine(result);

            #endregion

            #region Q02
            //var Result = CustomersList.Select(c => new { customerId = c.CustomerID, customerName = c.CustomerName, OrderCount = c.Orders.Count() });
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #region Q03
            //var result = ProductsList.GroupBy(p => p.Category).Select(p => new { categoryName = p.Key, productCount = p.Count() });
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var resuly = Arr.Count();
            //Console.WriteLine(resuly);
            #endregion
            string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            #region Q05

            //var result = dictionaryWords.Count();
            //Console.WriteLine(result);
            #endregion

            #region Q06
            var result = dictionaryWords.Min(x => x.Length);
            Console.WriteLine(result);
            #endregion

            #region Q07
            //var result = dictionaryWords.Max(x => x.Length);
            //Console.WriteLine(result);
            #endregion

            #region Q08
            //var result = dictionaryWords.Average(d=>d.Length);
            //Console.WriteLine(result);
            #endregion
            #endregion
        }
    }
}
