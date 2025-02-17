using Assignment01_LINQ.Data;
using System.Xml.Linq;
using static Assignment01_LINQ.ListGenerator;

namespace Assignment01_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region VAR X Dynamic
            //string name = "Ahmed";

            #region var
            var name = "Ahmed";
            // complilar will detect the variable datatype 
            // based on it's initial value in complilation time
            //var name02;
            //// invalid must be initialized
            //var name3 = null; 
            //// can't be intialized with null nạme = null;
            name = null;
            #endregion
            #region Dynamic

            //dynamic name1 = "Ahmed";
            //name1= 10; 
            //name1 = true;
            //dynamic x;
            //// not must be initialized
            //dynamic Y = null;
            //// can be initialized with null
            //// CLR will detect the variable datatype 
            //// based on it's last assigned value in runtime 
            ///
            #endregion
            #endregion
            
            #region Extinsion method

            //int x = 123;
            //int y;
            //y=x.Reverse();
            //Console.WriteLine(y); 

            #endregion
            
            #region AnnounymousType
            ////Employee employee = new Employee() { Id=10,Name="Mohamed",Salary=2000 };
            //var employee = new { Id=10, Name="Mohamed", Salary=2000 }; //AnnounymousType
            //Console.WriteLine(employee.GetType()); 

            #endregion
            
            #region LINQ

            //List<int> Nums = new List<int>() {1,2,3,4,5,9,7,10,20,30,22,14,15};
            ////List<int> oddNums = Nums.Where(n=>n%2==1).ToList();
            //var oddNums = Nums.Where(n => n%2==1);
            //foreach (int n in oddNums) 
            //{
            //    Console.Write($"{n} ");
            //}

            #endregion

            #region LINQ Syntax
            ////1.Fluent Syntax
            //List<int> nums = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            ////var oddNums = nums.Where(n => n%2==1);
            //////2.Query Syntax
            //var oddNum = from n in nums
            //             where n%2==1
            //             select n;
            #endregion

            #region Immediat Excution

            ////immediate Excution[element, aggregate, casting]
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
            //var oddNum = Enumerable.Where(numbers, N => N % 2 == 1).ToList(); 
            //// where => immediate excute
            //numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            #endregion



        }
    }
}
