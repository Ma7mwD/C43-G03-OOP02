namespace AssignmentOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                HiringDate hireDate1 = new HiringDate(10, 6, 2018);
                HiringDate hireDate2 = new HiringDate(20, 7, 2019);
                HiringDate hireDate3 = new HiringDate(5, 8, 2020);

                #region Solution Q6
                //6.Create an array of Employees with size three a DBA, Guest and the third one is
                //security officer who have full permissions. (Employee [] EmpArr;)
                Employee[] EmpArr = new Employee[3];

                // Initialize the employees with different security levels
                EmpArr[0] = new Employee(101, "John Doe", SecurityLevel.DBA, 70000m, hireDate1, "M");
                EmpArr[1] = new Employee(102, "Jane Smith", SecurityLevel.Guest, 40000m, hireDate2, "F");
                EmpArr[2] = new Employee(103, "Alice Johnson", SecurityLevel.SecurityOfficer, 80000m, hireDate3, "F");
                #endregion
                foreach (var employee in EmpArr)
                {
                    Console.WriteLine(employee.ToString());
                    Console.WriteLine(); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
