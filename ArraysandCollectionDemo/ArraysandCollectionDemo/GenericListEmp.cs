using System;
using System.Collections.Generic;


namespace ArraysandCollectionDemo
{
    class GenericListEmp
    {
        static void Main()
        {
            //Employee employee1 = new Employee();
            //employee1.EmpCode = 100;
            //employee1.EmpName = "Scott";
            //employee1.Email = "scott@gmail.com";

            //Employee employee2 = new Employee();
            //employee2.EmpCode = 101;
            //employee2.EmpName = "Tiger";
            //employee2.Email = "tiger@gmail.com";

            //  Object initializer syntax
            Employee employee1 = new Employee { EmpCode = 100, EmpName = "Scott", Email = "scott@gmail.com" };
            Employee employee2 = new Employee { EmpCode = 101, EmpName = "Tiger", Email = "tiger@gmail.com" };

            List<Employee> empList = new List<Employee>();
            empList.Add(employee1);
            empList.Add(employee2);

            foreach (var emp in empList)
            {
                Console.WriteLine($"Code={emp.EmpCode} Name={emp.EmpName} Email={emp.Email}");
            }

            // Collection intializer syntax
            List<Employee> employees = new List<Employee>
            {
                new Employee{EmpCode=100,EmpName= "Scott" ,Email= "scott@gmail.com" },
                new Employee{ EmpCode = 101, EmpName = "Tiger", Email = "tiger@gmail.com" }
            };

            foreach (var emp in employees)
            {
                Console.WriteLine($"Code={emp.EmpCode} Name={emp.EmpName} Email={emp.Email}");
            }


            Console.ReadLine();
        }
    }
}
