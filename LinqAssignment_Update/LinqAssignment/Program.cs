using System.Linq;
using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;

namespace LinqAssignment
{
    class Program
    {
        private static int Option;
        private static readonly List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 1, FirstName = "John", LastName = "Abharam", Salary = 1000000, JoiningDate = "2013-01-01", Department = "Banking"
                },

                new Employee()
                {
                    EmployeeId = 2, FirstName = "Michael", LastName = "Clarke", Salary = 800000, JoiningDate = "2013-01-01", Department = "Insurance"
                },

                new Employee()
                {
                    EmployeeId = 3, FirstName = "Roy", LastName = "Thomas", Salary = 700000, JoiningDate = "2013-02-01", Department = "Banking"
                },

                new Employee()
                {
                    EmployeeId = 4, FirstName = "Tom", LastName = "Jose", Salary = 600000, JoiningDate = "2013-02-01",  Department = "Insurance"
                },

                 new Employee()
                {
                    EmployeeId = 5, FirstName = "Jerry", LastName = "Pinto", Salary = 650000, JoiningDate = "2013-02-01", Department = "Insurance"
                 },
                 new Employee()
                {
                    EmployeeId = 6, FirstName = "Phillip", LastName = "Mathew ", Salary = 750000, JoiningDate = "2013-01-01", Department = "Services"
                 }
        };

        static void Main(string[] args)
        {

            bool value = true;
            while (value)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------------Welcome-------------------------------------------");
                Console.WriteLine("1-Get All Employee Details from the Employee Table");
                Console.WriteLine("2-Get First_Name and Last_Name from Employee Table");
                Console.WriteLine("3-Get First_Name from Employee Table in Upper Case");
                Console.WriteLine("4-Get First_Name from Employee Table in Lower Case");
                Console.WriteLine("5-Get Unique DEPARTMENT from Employee Table");
                Console.WriteLine("6-Get Length of FIRST_NAME from Employee Table");
                Console.WriteLine("7-Get FIRST_NAME,Joining year,Joining Month and Joining Date from Employee Table");
                Console.WriteLine("8-Get All Employee details from the Employee Table order by First_Name Ascending");
                Console.WriteLine("9-Get All Employee details from the Employee Table order by First_Name descending");
                Console.WriteLine("10-Get All Employee details from the Employee Table order by First_Name Ascending and Salary descending");
                Console.WriteLine("11-Get Employee details from Employee Table whose employee name is “John”");
                Console.WriteLine("12-Get Employee details from Employee Table whose employee name are “John” and “Roy”");
                Console.WriteLine("13-Get Employee details from Employee Table whose employee name are not “John” and “Roy”");
                Console.WriteLine("14-Get Employee details from Employee Table whose first name starts with 'J'");
                Console.WriteLine("15-Get Employee details from Employee Table whose first name contains 'o'");
                Console.WriteLine("16-Get Employee details from Employee Table whose first name ends with 'n'");
                Console.WriteLine("17-Get Employee details from Employee Table whose first name ends with 'n' and name contains 4 letters");
                Console.WriteLine("18-Get Employee details from Employee Table whose first name starts with 'J' and name contains 4 letters");
                Console.WriteLine("19-Select first 3 characters of FIRST_NAME from EMPLOYEE");
                Console.WriteLine("20-Get position of 'o' in name 'John' from employee table");
                Console.WriteLine("21-Get FIRST_NAME from employee table after removing white spaces from right side");
                Console.WriteLine("22-Get FIRST_NAME from employee table after removing white spaces from left side");
                Console.WriteLine("23-Get First_Name from employee table after replacing 'o' with '$' ");
                Console.WriteLine("24-Get First_Name and Last_Name as single column from employee table separated by a '_'");
                Console.WriteLine("25-Get employee details from employee table whose Salary greater than 600000");
                Console.WriteLine("26-Get employee details from employee table whose Salary less than 800000");
                Console.WriteLine("27-Get employee details from employee table whose Salary between 500000 and 800000");
                Console.WriteLine("28-Get employee details from employee table whose name is 'John' and 'Michael'");
                Console.WriteLine("29-Get employee details from employee table whose joining year is “2013”");
                Console.WriteLine("30-Get employee details from employee table whose joining month is “January”");
                Console.WriteLine("31-EXIT");
                Console.WriteLine("---------------------------------------Result-----------------------------------------");

                Console.WriteLine("Enter your Option :");

                Option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (Option)
                {
                    case 1:
                        showAllEmployeeDetails();
                        break;
                    case 2:
                        getFullName();
                        break;
                    case 3:
                        getFirstNameUpperCase();
                        break;
                    case 4:
                        getFirstNameLowerCase();
                        break;
                    case 5:
                        getDifferentDepartment();
                        break;
                    case 6:
                        getFirstNameLength();
                        break;
                    case 7:
                        getFirstNameAndDateOfJoining();
                        break;
                    case 8:
                        getFirstNameAsc();
                        break;
                    case 9:
                        getFirstNameDesc();
                        break;
                    case 10:
                        getFirstNameAscAndSalaryDes();
                        break;
                    case 11:
                        getEmployeeByName();
                        break;
                    case 12:
                        getEmployeeByBothName();
                        break;
                    case 13:
                        getEmployeeNotInclude();
                        break;
                    case 14:
                        getEmployeeStartWithJ();
                        break;
                    case 15:
                        getEmployeeContainsO();
                        break;
                    case 16:
                        getEmployeeEndsWithN();
                        break;
                    case 17:
                        getEmployeeEndsNContain4();
                        break;
                    case 18:
                        getEmployeeStartJContains4();
                        break;
                    case 19:
                        getFirst3Char();
                        break;
                    case 20:
                        getPositionOfO();
                        break;
                    case 21:
                        getRemovingWhiteSpaceFromRightSide();
                        break;
                    case 22:
                        getRemovingWhiteSpaceFromLeftSide();
                        break;
                    case 23:
                        getReplaceOTo();
                        break;
                    case 24:
                        NameSeparatedBy_();
                        break;
                    case 25:
                        getSalaryGreaterThanSixLakh();
                        break;
                    case 26:
                        getSalaryLessThanEightLakh();
                        break;
                    case 27:
                        getSalaryBetweenFiveLakhToEightLakh();
                        break;
                    case 28:
                        getNameJohnAndMichael();
                        break;
                    case 29:
                        getJoinBefore();
                        break;
                    case 30:
                        getJoinAfter();
                        break;

                }
            }
        }

        private static void showAllEmployeeDetails()
        {
            Console.WriteLine("\n");
            foreach (var emp in employees)
            {
                Console.WriteLine("FullName : " + emp.FirstName + " " + emp.LastName);
                Console.WriteLine("Salary : " + emp.Salary);
                Console.WriteLine("Joining Date : " + emp.JoiningDate);
                Console.WriteLine("Department : " + emp.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getFullName()
        {
            var fullName = from emp in employees select new { emp.FirstName, emp.LastName };
            foreach (var name in fullName)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
        }

        private static void getFirstNameUpperCase()
        {
            var employeeRecord = from emp in employees select new { emp.FirstName };
            foreach (var name in employeeRecord)
            {
                Console.WriteLine("First_Name : " + name.FirstName.ToUpper());
            }
        }
        private static void getFirstNameLowerCase()
        {
            var employeeRecord = from emp in employees select new { emp.FirstName };
            foreach (var name in employeeRecord)
            {
                Console.WriteLine("First_Name : " + name.FirstName.ToLower());
            }
        }
        private static void getDifferentDepartment()
        {
            var employeeDepartmentRecord = from emp in employees select new { emp.Department };
            var employeeDifferentDept = employeeDepartmentRecord.Distinct();
            foreach (var dept in employeeDifferentDept)
            {
                Console.WriteLine(dept.Department);
            }
        }
        private static void getFirstNameLength()
        {
            var employeeData = from emp in employees select new { emp.FirstName };
            foreach (var name in employeeData)
            {
                Console.WriteLine("First_Name length : " + name.FirstName.Length);
            }
        }

        private static void getFirstNameAndDateOfJoining()
        {
            var employeeRecord = from emp in employees select new { emp.FirstName, emp.JoiningDate };
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("First Name : " + employee.FirstName);
                Console.WriteLine("Joining year : " + employee.JoiningDate);
                Console.WriteLine("\n");
            }
        }

        private static void getFirstNameAsc()
        {
            var employeeRecord = employees.OrderBy(data => data.FirstName);
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("Employee First_Name : " + employee.FirstName);
                Console.WriteLine("\n");
            }
        }
        private static void getFirstNameDesc()
        {
            var employeeRecord = employees.OrderByDescending(data => data.FirstName);
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("Employee First_Name : " + employee.FirstName);
                Console.WriteLine("\n");
            }
        }
        private static void getFirstNameAscAndSalaryDes()
        {
            var employeeRecord = employees.OrderBy(data => data.FirstName).ThenByDescending(data => data.Salary);
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("Employee First_Name : " + employee.FirstName + "  Salary : " + employee.Salary);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeByName()
        {
            var singleEmployee = employees.Where(t => t.FirstName == "John").FirstOrDefault();
            Console.WriteLine("FullName : " + singleEmployee.FirstName + " " + singleEmployee.LastName);
            Console.WriteLine("Salary : " + singleEmployee.Salary);
            Console.WriteLine("Joining Date : " + singleEmployee.JoiningDate);
            Console.WriteLine("Department : " + singleEmployee.Department);
            Console.WriteLine("\n");
        }
        private static void getEmployeeByBothName()
        {
            var employeeRecord = employees.Where(t => t.FirstName == "John" || t.FirstName == "Roy");
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeNotInclude()
        {

            var employeeRecord = employees.Where(t => t.FirstName != "John" || t.FirstName != "Roy");
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeStartWithJ()
        {
            var employeeRecord = employees.Where(t => t.FirstName.StartsWith("J"));
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeContainsO()
        {
            var employeeRecord = employees.Where(t => t.FirstName.Contains("o"));
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeEndsWithN()
        {
            var employeeRecord = employees.Where(t => t.FirstName.EndsWith("n"));
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getEmployeeEndsNContain4()
        {
            var employeeRecord = employees.Where(t => t.FirstName.EndsWith("n") && t.FirstName.Length == 4);
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }
        private static void getEmployeeStartJContains4()
        {
            var employeeRecord = employees.Where(t => t.FirstName.StartsWith("J") && t.FirstName.Length == 4);
            foreach (var employee in employeeRecord)
            {
                Console.WriteLine("FullName : " + employee.FirstName + " " + employee.LastName);
                Console.WriteLine("Salary : " + employee.Salary);
                Console.WriteLine("Joining Date : " + employee.JoiningDate);
                Console.WriteLine("Department : " + employee.Department);
                Console.WriteLine("\n");
            }
        }

        private static void getFirst3Char()
        {
            var employeeRecord = from e in employees
                                 select new { FirstName = e.FirstName.Substring(0, 3) };
            foreach (var emp in employeeRecord)
            {
                Console.WriteLine(emp);
            }
        }

        private static void getPositionOfO()
        {
            var employeeRecord = employees.Where(st => st.FirstName.ToLower().Contains("o"));
            foreach (var std in employeeRecord)
            {
                Console.WriteLine(std.FirstName);
                Console.WriteLine(std.FirstName.ToLower().IndexOf("o"));
            }
        }
        private static void getRemovingWhiteSpaceFromRightSide()
        {
            var employeeRecord = employees.Where(st => st.FirstName.ToLower().Contains("o"));
            foreach (var std in employeeRecord)
            {
                Console.WriteLine(std.FirstName.TrimEnd());
            }
        }
        private static void getRemovingWhiteSpaceFromLeftSide()
        {
            var employeeRecord = employees.Where(st => st.FirstName.ToLower().Contains("o"));
            foreach (var std in employeeRecord)
            {
                Console.WriteLine(std.FirstName.TrimStart());
            }
        }

        private static void getReplaceOTo()
        {
            var employeeRecord = from e in employees
                                 select e;
            foreach (Employee emp in employeeRecord)
            {
                Console.WriteLine(emp.FirstName.ToLower().Replace("o", "$"));
            }
        }
        private static void NameSeparatedBy_()
        {
            var employeeRecord = from e in employees
                                 select e;
            foreach (Employee emp in employeeRecord)
            {
                var e = string.Join("_", emp.FirstName, emp.LastName);
                Console.WriteLine(e);
            }
        }
        private static void getSalaryGreaterThanSixLakh()
        {
            var employeeRecord = from e in employees
                                 where e.Salary > 600000
                                 select e;
            foreach (var emp in employeeRecord)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.Salary);
            }
        }
        private static void getSalaryLessThanEightLakh()
        {
            var employeeRecord = from e in employees
                                 where e.Salary < 800000
                                 select e;
            foreach (var emp in employeeRecord)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.Salary);
            }

        }
        private static void getSalaryBetweenFiveLakhToEightLakh()
        {
            var employeeRecord = from e in employees
                                 where e.Salary > 500000 && e.Salary < 800000
                                 select e;
            foreach (var emp in employeeRecord)
            {
                Console.WriteLine(emp.FirstName);
                Console.WriteLine(emp.Salary);
            }
        }
        private static void getNameJohnAndMichael()
        {
            var employeeRecord = from e in employees
                      where e.FirstName == "John" || e.FirstName == "Michael "
                      select e;
            foreach (var emp in employeeRecord)
            {
                Console.WriteLine(emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }
        }

    private static void getJoinBefore()
        {
            var employeeRecord = from e in employees
                      where e.JoiningDate.Contains("13")
                      select e;
            foreach (var emp in employeeRecord)
            {
                Console.WriteLine(emp.FirstName);
            }
        }

    private static void getJoinAfter()
        {
            var employeeRecord = from e in employees
                      where e.JoiningDate.Contains("01")
                      select e;
            foreach (var emp in employeeRecord)
            {
                Console.WriteLine(emp.FirstName);
            }
        }

        }
    }


    
 