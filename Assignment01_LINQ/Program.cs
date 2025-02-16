using static Assignment01_LINQ.ListGenerator;

namespace Assignment01_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.LINQ - Restriction Operators
            ////1.Find all products that are out of stock.
            //var result = ProducstList.Where(p => p.UnitsInStock == 0);

            ////2.Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProducstList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            ////3.Returns digits whose name is shorter than their value.
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = arr.Select((name, index) => new { Name = name, Value = index })
            //                .Where(x => x.Name.Length < x.Value).Select(x => x.Value).ToList(); 

            #endregion

            #region LINQ - Element Operators
            ////1. Get first Product out of Stock 
            //var result = ProducstList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Console.WriteLine(result);

            ////2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProducstList.FirstOrDefault(p => p.UnitPrice > 1000m);
            //Console.WriteLine(result?.UnitPrice ?? 0);

            ////3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(p => p > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result); 

            #endregion

            ////1. Uses Count to get the number of odd numbers in the array
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = arr.Count(a => a % 2 ==1 );
            //Console.WriteLine(result);

            ////2. Return a list of customers and how many orders each has.
            //var result = CustomersList.Count();


        }
    }
}
