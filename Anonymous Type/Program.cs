using System.Collections.Generic;
using System.Dynamic;
using System.Net;

public class Program
{

    private static void Main(string[] args)
    {
        //Anonymous Type
        //var student = new { Id = 1, FirstName = "Yash", LastName = "Bedekar" };
        //Console.WriteLine("This Is my Anonymous Type Program ");
        //Console.WriteLine(student.Id);
        //Console.WriteLine(student.FirstName);
        //Console.WriteLine(student.LastName);


        //var Teacher = new []  { Id = 2, TeacherName = "Kavita", Subject = "English" };
        //Console.WriteLine(Teacher.Id);
        //Console.WriteLine(Teacher.TeacherName);
        //Console.WriteLine(Teacher.Subject);
        //Console.ReadKey();

        //LINQ Query returns an Anonymous Type
        //        IList<Employee> employeeList = new List<Employee>()
        //        {
        //            new Employee() { EmpID = 1, EmpName = "John", EmpSalary = 1800, EmpAddress = "Kolhapur" },
        //            new Employee() { EmpID = 2, EmpName = "Steve", EmpSalary = 2100, EmpAddress = "Kolhapur" },
        //            new Employee() { EmpID = 3, EmpName = "Bill", EmpSalary = 18000, EmpAddress = "Kolhapur" },
        //            new Employee() { EmpID = 4, EmpName = "Ram", EmpSalary = 200000, EmpAddress = "Kolhapur" },
        //            new Employee() { EmpID = 5, EmpName = "Ron", EmpSalary = 210000, EmpAddress = "Kolhapur" }



        //        };
        //        var Employee = from E in employeeList
        //                       select new { EmpID = E.EmpID, EmpName = E.EmpName, EmpSalary = E.EmpSalary, EmpAddress = E.EmpAddress};
        //        foreach (var emp in Employee)
        //        Console.WriteLine(emp.EmpID + "-" + emp.EmpName);
        //        Console.ReadKey();
        //    }

        //    public partial class Employee
        //    {

        //        public int EmpID { get; set; }
        //        public string? EmpName;
        //        public int EmpSalary { get; set; }
        //        public string? EmpAddress { get; set; }

        //Run-time Exception Error
        dynamic emp = new ITemployee();

        emp.DisplayITemployeeInfo(1, "Yash");
        emp.DisplayITemployeeInfo("1");
        emp.FakeMethod();
        Console.WriteLine(emp.ID);
        Console.ReadKey();
   }
}


//Dynamic Types
public partial class ITemployee
{ 
    public void DisplayITemployeeInfo(int ID)
    {
        Console.WriteLine("Demo Student Info:");
    }
}



