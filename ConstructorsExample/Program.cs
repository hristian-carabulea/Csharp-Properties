class Program
{
    static void Main()
    {
        //create three objects for Employee

        Employee empl1 = new Employee(103, "Anna", "Clerk"); //constructor 1
        empl1.Tax = 50;

        Employee empl2 = new Employee(102, "Allen"); //constructor 2
        empl2.Job = "Assistant Manager";
        empl2.Tax = 50;

        Employee empl3 = new Employee(); //constructor 3
        empl3.EmplID = 10;
        empl3.EmplName = "Scott";
        empl3.Job = "Manager";
        empl3.Tax = 50;

        Employee empl4 = new Employee() { EmplName = "Ford", Job = "Executive" };
        empl4.Tax = 50;


        //display fields
        System.Console.WriteLine("Company: " + Employee.CompanyName);
        System.Console.WriteLine("First employee:");
        System.Console.WriteLine(empl1.EmplID);
        System.Console.WriteLine(empl1.EmplName);
        System.Console.WriteLine(empl1.Job);
        System.Console.WriteLine(empl1.Salary);
        System.Console.WriteLine(empl1.CalculateNetSalary());

        System.Console.WriteLine();

        System.Console.WriteLine("Company: " + Employee.CompanyName);
        System.Console.WriteLine("Second employee:");
        System.Console.WriteLine(empl2.EmplID);
        System.Console.WriteLine(empl2.EmplName);
        System.Console.WriteLine(empl2.Job);
        System.Console.WriteLine(empl2.Salary);
        System.Console.WriteLine(empl2.CalculateNetSalary());

        System.Console.WriteLine();

        System.Console.WriteLine("Company: " + Employee.CompanyName);
        System.Console.WriteLine("Third employee:");
        System.Console.WriteLine(empl3.EmplID);
        System.Console.WriteLine(empl3.EmplName);
        System.Console.WriteLine(empl3.Job);
        System.Console.WriteLine(empl3.Salary);
        System.Console.WriteLine(empl3.CalculateNetSalary());

        System.Console.WriteLine();

        System.Console.WriteLine("Company: " + Employee.CompanyName);
        System.Console.WriteLine("Fourth employee:");
        System.Console.WriteLine(empl4.EmplID);
        System.Console.WriteLine(empl4.EmplName);
        System.Console.WriteLine(empl4.Job);
        System.Console.WriteLine(empl4.Salary);
        System.Console.WriteLine(empl4.CalculateNetSalary());

        System.Console.WriteLine();

        System.Console.Write("\nEnter any key to end the program: ");

        System.Console.ReadKey();
    }
}