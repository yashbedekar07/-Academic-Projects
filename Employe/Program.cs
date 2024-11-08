namespace Program
{
    /// <summary>
    /// Main Class
    /// </summary>
    public class ProgramBase
    {
        public string EmpId { get; set; }
        public string Name { get; set; }

        public decimal EmpSalary { get; set; }
        public static void Main(String[] args)
        {
            // Accessing Employee class from both files
            Program employee = new Program(1, "Yash", 25000);
            Console.WriteLine("Employee ID:" +employee.EmpId);
            Console.WriteLine("Employe Name" +employee.Name);
            Console.WriteLine("Employee Salary:" + employee.EmpSalary);
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Partial Sub Class 1
    /// </summary>

    public partial class Program : ProgramBase
    {
        public int EmpId;
        public string Name;
        public decimal EmpSalary;

        public Program(int EmpId, string Name, decimal empSalary)
        {
            this.EmpId = 1;
            this.Name = "Yash";
            this.EmpSalary = 25000;
        }
          
        /// <summary>
        /// Partial Sub Class 2
        /// </summary>
        public class employee : Program
        {
            public employee(int EmpId, string Name,decimal EmpSalary ) : base(EmpId, Name, EmpSalary)
            {
            }
        }
    }
}