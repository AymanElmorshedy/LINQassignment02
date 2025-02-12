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


            int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = Numbers.Count(n=>n%2==1);
            Console.WriteLine(result);

            #endregion
            #endregion
        }
    }
}
