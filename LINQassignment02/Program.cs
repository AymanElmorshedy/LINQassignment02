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
            var result = ProductsList.Where(p=>p.UnitPrice>1000).FirstOrDefault();
            Console.WriteLine(result);
            #endregion

            #endregion
        }
    }
}
