// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Xml.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.DataAnnotations;
using System.Buffers.Text;
using static Program.User;
using static Program;

public class Program
{

    //    public static void Main()
    //    {
    //        // Student collection
    //        IList<Student> studentList = new List<Student>() {
    //                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
    //                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
    //                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
    //                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
    //                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    //            };

    //    // LINQ Query Syntax to find out teenager students

    //    var teenAgerStudent = from s in studentList
    //                          where s.Age > 12 && s.Age < 20
    //                          select s;
    //    Console.WriteLine("Teen age Students:");
    //        var result = studentList.All(x => x.StudentID == 5);
    //        Console.WriteLine("Id",result);
    //		foreach(Student std in teenAgerStudent)
    //        {			
    //			Console.WriteLine(std.StudentName);
    //		}
    //	}
    //}

    //public class Student
    //{

    //    public int StudentID { get; set; }
    //    public string StudentName { get; set; }
    //    public int Age { get; set; }

    //}



    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ID= 101,Name = "Pooja", Salary = 10000, Department = "IT"},
                new Employee{ID= 102,Name = "Priyanka", Salary = 15000, Department = "Sales"},
                new Employee{ID= 103,Name = "Manoj", Salary = 25000, Department = "Sales"},
                new Employee{ID= 104,Name = "Santosh", Salary = 20000, Department = "IT"},
                new Employee{ID= 105,Name = "Vishal", Salary = 30000, Department = "IT"},
                new Employee{ID= 106,Name = "Sandhya", Salary = 25000, Department = "IT"},
                new Employee{ID= 107,Name = "Mahesh", Salary = 35000, Department = "IT"},
                new Employee{ID= 108,Name = "Manoj", Salary = 11000, Department = "Sales"},
                new Employee{ID= 109,Name = "Pradeep", Salary = 20000, Department = "Sales"},
                new Employee{ID= 110,Name = "Saurav", Salary = 25000, Department = "Sales"},
                new Employee{ID= 111,Name = "Santosh", Salary = 25000, Department = "Sales"}
            };
            return listEmployees;
        }
    public static List<Employee> GetEmployees2()
        {
            List<Employee> employees = new List<Employee>()
            {
                 new Employee{ID= 101,Name = "Raj", Salary = 15000, Department = "IT"},
                new Employee{ID= 102,Name = "Priya", Salary = 15000, Department = "Sales"},
                new Employee{ID= 103,Name = "Sandeep", Salary = 25000, Department = "Sales"},
                new Employee{ID= 104,Name = "Shradha", Salary = 25000, Department = "IT"},
            };
            return employees;
        }
        
    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }


        public static List<User> GetAllUser()
        {
            List<User> employees1 = new List<User>()
                {
                    new User{ID= 101, Name = "Pooja", Salary = 15000, DepartmentId = 10},
                        new User{ID= 102, Name = "Priyanka", Salary = 15000, DepartmentId = 30},
                        new User{ID= 103, Name = "Manoj", Salary = 25000, DepartmentId = 20},
                        new User{ID= 104, Name = "Santosh", Salary = 20000, DepartmentId = 10},
                        new User{ID= 105, Name = "Vishal", Salary = 30000, DepartmentId = 10},
                        new User{ID= 106, Name = "Sandhya", Salary = 25000, DepartmentId = 10},
                        new User{ID= 107, Name = "Mahesh", Salary = 35000, DepartmentId = 30},
                        new User{ID= 108, Name = "Manoj", Salary = 11000, DepartmentId = 10},
                        new User{ID= 109, Name = "Pradeep", Salary = 20000, DepartmentId = 20},
                        new User{ID= 110, Name = "Saurav", Salary = 25000, DepartmentId = 20}
                };
            return employees1;
        }
        public class Department
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public static List<Department> GetAllDepartments()
            {
                    return new List<Department>()
                {
                    new Department { ID = 10, Name = "IT"},
                    new Department { ID = 20, Name = "HR"},
                    new Department { ID = 30, Name = "Sales"},
                };
            }
        }
    }
       

public static void Main()
    {

        //1) :- Select(): It is used to format the result of the query as per our requirement.
        //Using Method Syntax
        var SelectMethodSyntax = Employee.GetAllEmployees().ToList();

        //Using Query Syntax
        var SelectQuerySyntax = (from emp in Employee.GetAllEmployees()
                                 select emp).ToList();

        foreach (var emp in SelectMethodSyntax)
        {
            Console.WriteLine($"ID : {emp.ID} Name : {emp.Name} {emp.Salary}");
        }
        Console.WriteLine("using SQL Query syntax");
        foreach (var emp in SelectQuerySyntax)
        {
            Console.WriteLine($"ID : {emp.ID} Name : {emp.Name} {emp.Salary}");
        }


        //2) :-  Where(): It is used to Filter a sequence on a based condition.
        Console.WriteLine("Where Method Example");
        Console.WriteLine("IT Employees");

        var WhereMethodSyntax = Employee.GetAllEmployees().Where(whr => whr.Department == "IT").ToList();

        //Using Query Syntax
        var WhereQuerySyntax = (from emp in Employee.GetAllEmployees() where emp.Department == "Sales" select emp).ToList();

        foreach (var emp in WhereMethodSyntax)
        {
            Console.WriteLine($"ID : {emp.ID} Name : {emp.Name} {emp.Salary}");
        }
        Console.WriteLine("Sales Employees");
        foreach (var emp in WhereQuerySyntax)
        {
            Console.WriteLine($"ID : {emp.ID} Name : {emp.Name} {emp.Salary}");
        }

        //3) :- Distinct(): It is used to remove the duplicate elements from a sequence (list)and
        //returns the distinct elements from a single data source.
        Console.WriteLine();
        Console.WriteLine("Distinct Method Example");
        var DistinctMethodSyntax = Employee.GetAllEmployees().Distinct().Select(x => x.Name.Contains("o")).ToList();

        //Using Query Syntax
        var DistinctQuerySyntax = (from emp in Employee.GetAllEmployees() select emp.Name).Distinct().ToList();

        foreach (var item in DistinctMethodSyntax)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("using SQL Query syntax ");
        foreach (var item in DistinctQuerySyntax)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        //4) :- Empty(): It is used to return an empty collection (i.e. IEnumerable) of a specified type.
        var result = Employee.GetAllEmployees() ?? Enumerable.Empty<Employee>();
        if (result != null)
        {
            foreach(var emp in result)
            {
                Console.WriteLine($"Name :  {emp.Name}");
            }
        }

        var ContainsMethodSyntax = Employee.GetAllEmployees().Where(whr => whr.Name.Contains("S"));
        Console.WriteLine();
        Console.WriteLine("Name contain with alphabet s");
        foreach (var msName in ContainsMethodSyntax)
        {
            Console.WriteLine($"Name: {msName.Name}");
        }
        Console.WriteLine();
        Console.WriteLine("Name contain with alphabet v");

        //Using Query Syntax
        var ContainsQuerySyntax = from name in (Employee.GetAllEmployees().Where(whr => whr.Name.Contains('v')))
                          select name;

        foreach (var qsName in ContainsQuerySyntax)
        {
            Console.WriteLine($"Name : {qsName.Name}");
        }
        Console.WriteLine();

        //Single(): It is used to return the single element from the collection, which satisfies the condition.
        Console.WriteLine("Example Of Single");
        var SingleMethodSyntax = Employee.GetAllEmployees().Single(whr => whr.Name == "Pooja");       
        var SingleOrDefaultMethodSyntax = Employee.GetAllEmployees().SingleOrDefault(whr => whr.Name == "Pooja");       
     
        Console.WriteLine($"Id: {SingleMethodSyntax.ID}  Name:{SingleMethodSyntax.Name} Department:{SingleMethodSyntax.Department} Salary:{SingleMethodSyntax.Salary}");
        Console.WriteLine("Example Of SingleOrDefaultMethodSyntax");
        Console.WriteLine($"Id: {SingleOrDefaultMethodSyntax.ID}  Name:{SingleOrDefaultMethodSyntax.Name} Department:{SingleOrDefaultMethodSyntax.Department} Salary:{SingleOrDefaultMethodSyntax.Salary}");
        Console.WriteLine("Using the Sql Query Syntex");

        //Using Query Syntax
        var SingleQuerySyntax = (from emp in Employee.GetAllEmployees() select emp).Single(emp => emp.Name == "Sandhya");
        Console.WriteLine($"Id: {SingleQuerySyntax.ID}  Name:{SingleQuerySyntax.Name} Department:{SingleQuerySyntax.Department} Salary:{SingleQuerySyntax.Salary}");
        
        Console.WriteLine();



        // First(): It is used to return the first element from a data source or from a collection.
        Console.WriteLine("Example For First Method");
        var FirstMethodSyntax = Employee.GetAllEmployees().First(x => x.Name == "Santosh");
        //Using Query Syntax
        var FirstQuerySyntax = (from emp in Employee.GetAllEmployees() select emp).First();
        Console.WriteLine($"Name: {FirstMethodSyntax.Name} Department: {FirstMethodSyntax.Department} Salary: {FirstMethodSyntax.Salary}");
        Console.WriteLine($"Name: {FirstQuerySyntax.Name} Department: {FirstQuerySyntax.Department} Salary: {FirstQuerySyntax.Salary}");
        Console.WriteLine();

        // All(): It is used to check whether all the elements of a data source satisfy a given condition or not.
        Console.WriteLine("Example of All Method");
        var GetAllrecord = Employee.GetAllEmployees().All(whr => whr.Salary >= 10000);
        if (GetAllrecord)
        {
            Console.WriteLine($"All employees have salary greater than 10000: {GetAllrecord}");
        }
        Console.WriteLine();
        //ToDictionary(): Creates a dictionary from a sequence of key-value pairs.
        Console.WriteLine("Example of ToDictionary Method");
        Dictionary<int, string> employeeDictionarys = Employee.GetAllEmployees().ToDictionary(x => x.ID, x => x.Name);
        foreach (KeyValuePair<int, string> kvp in employeeDictionarys)
        {
            Console.WriteLine($"Key : {kvp.Key} Value : {kvp.Value}");
        }
        Console.WriteLine();

        //Any(): It is used to check whether at least one of the elements of a data source satisfies a given condition or not.
        Console.WriteLine("Example of Any Method");
        var AnyMethodresult = Employee.GetAllEmployees().Any(x => x.Salary > 20000 && x.Department == "IT");
        if (AnyMethodresult)
        {
            Console.WriteLine($"At least one employee in IT Department with salary higher than 20000:{AnyMethodresult}");
        }

        //OrderBy(): It is used to sort the data in Ascending Order.
        Console.WriteLine("Example of OrderBy Method");
        var OrderByMethodSyntax = Employee.GetAllEmployees().OrderBy(ord => ord.Name).ToList();
       
        //Using Query Syntax
        var OrderByQuerySyntax = (from emp in Employee.GetAllEmployees() orderby emp.Name select emp).ToList();
        Console.WriteLine();
        Console.WriteLine("After Sorting Method Syntax: ");
        foreach (var item in OrderByMethodSyntax)
        {
            Console.Write($"Name: {item.Name} \n");
        }
        Console.WriteLine();
        Console.WriteLine("After Sorting Query Syntax: ");
        foreach (var item in OrderByQuerySyntax)
        {
            Console.Write($"Name: {item.Name}  \n");
        }
        Console.WriteLine();

        //OrderByDescending(): It is used to sort the data in Descending order.
        Console.WriteLine("Example of OrderByDesc Method");
        var OrderByDescMethodSyntax = Employee.GetAllEmployees().OrderByDescending(ord => ord.Name).ToList();

        //Using Query Syntax
        var OrderByDescQuerySyntax = (from emp in Employee.GetAllEmployees() orderby emp.Name descending select emp).ToList();
        Console.WriteLine();
        Console.WriteLine("After Sorting Method Syntax: ");
        foreach (var item in OrderByDescMethodSyntax)
        {
            Console.Write($"Name: {item.Name} \n");
        }
        Console.WriteLine();
        Console.WriteLine("After Sorting Query Syntax: ");
        foreach (var item in OrderByDescQuerySyntax)
        {
            Console.Write($"Name: {item.Name}  \n");
        }
        Console.WriteLine();

        //ThenBy(): It is used to sort the data in Ascending order from the second level onwards.
        Console.WriteLine("Example of ThenBy Method");
        var ThenByMethodSyntax = Employee.GetAllEmployees()
            .OrderBy(ord => ord.Name)
            .ThenBy(x => x.Department)
            .ToList();


        //Using Query Syntax
        var ThenByQuerySyntax = (from emp in Employee.GetAllEmployees()
                           orderby emp.Department, emp.Name
                           select emp);

        Console.WriteLine("After Sorting Method Syntax: ");
        foreach (var item in ThenByMethodSyntax)
        {
            Console.Write($"Name: {item.Name}  Department: {item.Department} \n ");
        }

        Console.WriteLine("\n After Sorting Query Syntax: ");
        foreach (var item in ThenByQuerySyntax)
        {
            Console.Write($"Department: {item.Department} Name: {item.Name} \n");
        }
        Console.WriteLine();
        //ThenByDescending() - It is used to sort the data in Descending order also from the second level onwards.
       
        Console.WriteLine("Example of ThenByDesc Method");
        var ThenByDescMethodSyntax = Employee.GetAllEmployees().OrderByDescending(ord => ord.Name).ThenByDescending(x => x.Department).ToList();
        var ThenByDescQuerySyntax = (from emp in Employee.GetAllEmployees() orderby emp.Department descending, emp.Name descending select emp).ToList();

        foreach (var item in ThenByDescMethodSyntax )
        {
            Console.WriteLine($"Name:{item.Name} Deapartment:{item.Department}");
        }
        Console.WriteLine();

        foreach (var emp in ThenByDescQuerySyntax)
        {
            Console.WriteLine($"Name:{emp.Name} Deapartment:{emp.Department}");
        }
        Console.WriteLine();

        //Reverse(): It is used to reverse the data stored in a data source.
        Console.WriteLine("Example of Reverse Method");
        //Using Method Syntax
        var ReverseMethodSyntax = Employee.GetAllEmployees().Select(sel => sel.Name).Reverse();

        //Using Query Syntax
        var ReverseQuerySyntax = (from emp in Employee.GetAllEmployees()
                           select emp.Name).Reverse();

        Console.WriteLine();
        Console.WriteLine("After Reverse Data by Method Syntax: ");
        foreach (var item in ReverseMethodSyntax)
        {
            Console.WriteLine($"{item} ");
        }

        Console.WriteLine();
        Console.WriteLine("After Reverse Data by Method Syntax: ");
        foreach (var item in ReverseQuerySyntax)
        {
            Console.WriteLine($"{item} ");
        }
        Console.WriteLine();

        //Average(): It is used to calculate the average of numeric values from the collection on which it is applied.
        Console.WriteLine("Example of Average Method");
        //Using Method Syntax
        var AverageMethodSyntaxAvgValue = Employee.GetAllEmployees().Average(emp => emp.Salary);

        //Using Query Syntax
        var AverageQuerySyntaxAvgValue = (from emp in Employee.GetAllEmployees()
                                   select emp).Average(e => e.Salary);

        Console.WriteLine($"Method Syntax Average Value = {AverageMethodSyntaxAvgValue}");
        Console.WriteLine();
        Console.WriteLine($"Query Syntax Average Value = {AverageQuerySyntaxAvgValue}");
        Console.WriteLine();

        //Min(),  Max(): It returns the largest and smallest number in the list, respectively.
        Console.WriteLine("Example of Min, Max Method");
        //Using Method Syntax
        var MethodSyntaxMax = Employee.GetAllEmployees().Max(x => x.Salary);
        var MethodSyntaxMin = Employee.GetAllEmployees().Min(x => x.Salary);

        //Using Query Syntax
        var QuerySyntaxMax = (from emp in Employee.GetAllEmployees()
                              select emp).Max(x => x.Salary);

        var QuerySyntaxMin = (from emp in Employee.GetAllEmployees()
                              select emp).Min(x => x.Salary);

        Console.WriteLine($"Highest Salary by Method Syntax:{MethodSyntaxMax}");
        Console.WriteLine($"Lowest Salary by Method Syntax:{MethodSyntaxMin}");
        Console.WriteLine();
        Console.WriteLine("Using Sql Query Syntax");
        Console.WriteLine($"Highest Salary by Query Syntax:{QuerySyntaxMax}");
        Console.WriteLine($"Lowest Salary by Query Syntax:{QuerySyntaxMin}");
        Console.WriteLine();

        //Sum(): It is used to calculate the total or sum of numeric values in the collection.
        Console.WriteLine("Example of Sum Method");
        var SumMethodSyntax = Employee.GetAllEmployees().Where(whr => whr.Department == "IT").Sum(x => x.Salary);
        //var SumMethodSyntax = Employee.GetAllEmployees().Sum(x => x.Salary);

        //Using Query Syntax
        var SumQuerySyntax = (from emp in Employee.GetAllEmployees() where emp.Department == "Sales" select emp).Sum(x => x.Salary);
        //var SumQuerySyntax = (from emp in Employee.GetAllEmployees() select emp).Sum(x => x.Salary);

        Console.WriteLine($"Sum of Salary by Method Syntax: {SumMethodSyntax}");
        Console.WriteLine();
        Console.WriteLine($"Sum of Salary by Query Syntax: {SumQuerySyntax}");
        Console.WriteLine();

        //Skip(): It is used to skip or bypass the first n number of elements from a data source or sequence and
        //    then returns the remaining elements from the data source as output.
        Console.WriteLine("Example of Skip Method");
        var SkipMethodSyntax = Employee.GetAllEmployees().Where(whr => whr.Department == "IT").Skip(2).ToList();

        //Using Query Syntax
        var SkipQuerySyntax = (from emp in Employee.GetAllEmployees() where emp.Department == "Sales" select emp).Skip(2).ToList();

        Console.WriteLine($"Method Syntax");
        foreach (var item in SkipMethodSyntax)
        {
            Console.WriteLine($"ID:{item.ID} Name:{item.Name} Department:{item.Department} Salary:{item.Salary}");
        }
        Console.WriteLine();
        Console.WriteLine($"Query Syntax");
        foreach (var item in SkipQuerySyntax)
        {
            Console.WriteLine($"ID:{item.ID} Name:{item.Name} Department:{item.Department} Salary:{item.Salary}");
        }
        Console.WriteLine();

        // SkipWhile(): It is used to skip all the elements from a data source or a sequence.
        Console.WriteLine("Example of SkipWhile Method");
        //Using Method Syntax
        var SkipWhileMethodSyntax = Employee.GetAllEmployees().Where(whr => whr.Department == "IT").SkipWhile(x => x.Name.Length < 6).ToList();

        Console.WriteLine($"Method Syntax");
        foreach (var item in SkipWhileMethodSyntax)
        {
            Console.WriteLine($"{item.Name} ");
        }
        Console.WriteLine();

        //Take(): It is used to fetch the first "n" number of elements from the data source,
        //    where "n" is an integer that is passed as a parameter to the LINQ Take method.

        //Using Method Syntax
        var TakeMethodSyntax = Employee.GetAllEmployees().Where(whr => whr.Department == "IT").Take(3).ToList();

        //Using Query Syntax
        var TakeQuerySyntax = (from emp in Employee.GetAllEmployees() where emp.Department == "Sales" select emp).Take(3).ToList();


        Console.WriteLine("Method Syntax");
        foreach (var item in TakeMethodSyntax)
        {
            Console.Write($"Department: {item.Department}  Name: {item.Name} ");
        }
        Console.WriteLine();
        Console.WriteLine("Query Syntax");
        foreach (var item in TakeQuerySyntax)
        {
            Console.Write($"Department: {item.Department}  Name: {item.Name} ");
        }
        Console.WriteLine();
        Console.WriteLine();
        //Console.WriteLine();

        //TakeWhile(): It is used to fetch all the elements from a data source or a sequence,
        //or a collection until a specified condition is true.
        Console.WriteLine("Example Of TakeWhile");
        var TakeWhileMethodSyntax = Employee.GetAllEmployees().TakeWhile(x => x.Name.Length >= 5).ToList();

        var TakeWhileQuerySyntax = (from emp in Employee.GetAllEmployees() select emp).TakeWhile(emp => emp.Name.Length >= 5).ToList();
        Console.WriteLine("Method Syntax");
        foreach (var emp in TakeWhileMethodSyntax)
        {
            Console.WriteLine($"Id:{emp.ID} Name: {emp.Name} Department: {emp.Department} Salary: {emp.Name}");
        }
        Console.WriteLine();  
        Console.WriteLine("Query Syntax");  


        foreach (var item in TakeWhileQuerySyntax)
        {
            Console.WriteLine($"Id:{item.ID} Name: {item.Name} Department: {item.Department} Salary: {item.Name}");
        }
        Console.WriteLine();

        //Concat(): It is used to concatenate two sequences into one sequence.
        Console.WriteLine("Example Of Concat");
        var ConcatMethodSyntax = Employee.GetAllEmployees().Concat(Employee.GetEmployees2()).ToList();
        var ConcateQuerySyntax = (from emp in Employee.GetAllEmployees() select emp).Concat(Employee.GetEmployees2()).ToList();
        Console.WriteLine("Method Syntax");
        foreach(var emp in ConcatMethodSyntax)
        {
            Console.WriteLine($"Id:{emp.ID} Name:{emp.Name} Deapartment:{emp.Department} salary:{emp.Salary}");
        }
        Console.WriteLine("Query Syntax");
        foreach(var item in ConcateQuerySyntax)
        {
            Console.WriteLine($"Id: {item.ID} Name:{item.Name} Department: {item.Department} Salary: {item.Salary}");
        }
        Console.WriteLine();

        // Union(): It is used to combine multiple data sources into one data source by removing duplicate elements.
        Console.WriteLine("Example Of Union");
        var UnionMethodSyntax = Employee.GetAllEmployees().Union(Employee.GetEmployees2()).ToList();

        var UnionQuerySyntax = (from emp in Employee.GetAllEmployees() select emp).Union(Employee.GetEmployees2()).ToList();
        Console.WriteLine("Method Syntax");
        foreach(var emp in UnionMethodSyntax)
        {
            Console.WriteLine($"Id:{emp.ID} Name:{emp.Name} Deapartment:{emp.Department} salary:{emp.Salary}");
        }
        Console.WriteLine();
        Console.WriteLine("Query Syntax");
        foreach(var item in UnionQuerySyntax)
        {
            Console.WriteLine($"Id: {item.ID} Name:{item.Name} Department: {item.Department} Salary: {item.Salary}");
        }
        Console.WriteLine();

        //Count(): It is used to return the number of elements present in the collection 
        //    or the number of elements that have satisfied a given condition.
        Console.WriteLine("Example of Count");
        //var CountMehodSyntax = Employee.GetAllEmployees().Count();
        var CountMehodSyntax = Employee.GetAllEmployees().Where(x => x.Department == "IT").Count();

        //var CountQuerySyntax = (from emp in Employee.GetAllEmployees() select emp).Count();
        var CountQuerySyntax = (from emp in Employee.GetAllEmployees().Where(x => x.Salary >= 25000) select emp).Count();
        Console.WriteLine("Method Syntax");
        Console.WriteLine(CountMehodSyntax);
        Console.WriteLine("Query Syntax");
        Console.WriteLine(CountQuerySyntax);
        Console.WriteLine();


        //Range(): It is used to Generate a sequence of integral (integer) numbers within a specified range.
        Console.WriteLine("Example Of Range Method");
        //var RangeMethodSyntax = Enumerable.Range(0, 10).Select(x => x*2);
        var RangeMethodSyntax = Employee.GetAllEmployees().Where(x => x.Department == "IT").Skip(0).Take(6).ToList();
        

        //IEnumerable<int> EvenNumbers = Enumerable.Range(10, 40).Where(x => x % 2 == 0);
        foreach (var item in RangeMethodSyntax)
        {
            Console.WriteLine($"Id: {item.ID} Name:{item.Name} Department: {item.Department} Salary: {item.Salary}");
        }
        Console.WriteLine();
        Console.WriteLine();

        //ToLookup(): It is used for grouping data based on key / value pair.
        Console.WriteLine("Example Of ToLookup Method");
        //Using Method Syntax
        var ToLookupMethodSyntax = Employee.GetAllEmployees().ToLookup(x => x.Department);

        //Using Query Syntax
        var ToLookupQuerySyntax = (from emp in Employee.GetAllEmployees() select emp).ToLookup(x => x.Department);

        Console.WriteLine("Method Syntax");
        foreach (var grp in ToLookupMethodSyntax)
        {
            Console.WriteLine($"{grp.Key} : {grp.Count()}");
            foreach (var item in grp)
            {
                Console.WriteLine($"Name: {item.Name} Salary: {item.Salary} ");
            }
        }

        Console.WriteLine("Query Syntax");
        foreach (var grp in ToLookupQuerySyntax)
        {
            Console.WriteLine($"{grp.Key} : {grp.Count()}");
            foreach (var item in grp)
            {
                Console.Write($"Name: {item.Name} Salary: {item.Salary} ");
            }
        }



        // OfType(): It is used to filter specific type data from a data source based on the data type we passed to this operator.
        Console.WriteLine("Example of OfType");
        var OfTypeMethodSyntax = Employee.GetAllEmployees().Where(x => x.Department == "Sales").OfType<Employee>().ToList();
        var OfTypeQuerySyntax = (from emp in Employee.GetAllEmployees() select emp)
            .Where(x => x.Department == "Sales").OfType<Employee>().ToList(); 
        Console.WriteLine("Using Metod Syntax");
        foreach (var emp in OfTypeMethodSyntax)
        {
            Console.WriteLine($"Id:{emp.ID} Name:{emp.Name} Deapartment:{emp.Department} salary:{emp.Salary}");
        }

        Console.WriteLine("Using Query Syntax");
        foreach(var emp in OfTypeQuerySyntax)
        {
            Console.WriteLine($"Id:{emp.ID} Name:{emp.Name} Deapartment:{emp.Department} salary:{emp.Salary}");
        }



        Console.WriteLine();
        Console.WriteLine("Example of GroupJoin");
        //GroupJoin(): It is used to produce hierarchical data structures.
        //Group Employees by Department using Method Syntax

        var groupJoinMethodSyntax = Department.GetAllDepartments().
            GroupJoin(User.GetAllUser(),
                dept => dept.ID,
                user => user.DepartmentId,
                (dept, user) => new { dept, user }
            );

        var GroupJoinQuerySyntax = (from dept in Department.GetAllDepartments()
                                    join user in User.GetAllUser() on dept.ID equals user.DepartmentId
                                    into UserGroups
                                    select new { dept, UserGroups });

        Console.WriteLine();
        Console.WriteLine("Method Syntax");
        foreach (var grp in groupJoinMethodSyntax)
        {
            Console.WriteLine($"Department: {grp.dept.Name}");
            foreach (var item in grp.user)
            {
                Console.WriteLine($"Name: {item.Name}");
            }
        }
        Console.WriteLine();
        Console.WriteLine("--------------------------- ");
        Console.WriteLine("Query Syntax");
        foreach (var grp in GroupJoinQuerySyntax)
        {
            Console.WriteLine($"Department: {grp.dept.Name}");
            foreach (var item in grp.UserGroups)
            {
                Console.WriteLine($"Name: {item.Name}");
            }
        }

        Console.WriteLine();

        //AsEnumerable() :- 
        Console.WriteLine("Example Of AsEnumerable");
        IEnumerable<Employee> employee = Employee.GetAllEmployees().AsEnumerable().Where(x => x.Salary > 25000);
        foreach (var emp in employee)
        {
            Console.WriteLine($"Id:{emp.ID} Name:{emp.Name} Deapartment:{emp.Department} salary:{emp.Salary}");
        }
        Console.WriteLine();
        Console.WriteLine("My Name is Omprakash");
        var data1 = Employee.GetAllEmployees().ToList();
        //var Range = data.GroupBy(i => i / 3 i => data[i]);
        var Range = Enumerable.Range(0, data1.Count).GroupBy(i => i / 3, i => data1[i]);

        foreach(var item in Range)
        {
            Console.WriteLine($"Group {item.Key}");
            foreach (var s in item)
            {
                Console.WriteLine($"Id:{s.ID} Name:{s.Name} Deapartment:{s.Department} salary:{s.Salary}");
            }
        }



        int[] IntArray = { 10, 20, 30, 40, 50, 60, 55 };
        int[] IntArray2 = { 20, 40, 60, 80, 55, 45,  100 };
        //var IntArray = new List<int>();

        //DefaultIfEmpty Method will return a new sequence with existing sequence values
        Console.WriteLine("Example Of DefaultIfEmpty");
        //Using Method Syntax
        var DefaultOrEmptyMethodSyntax = IntArray.DefaultIfEmpty(4);

        //Using Query Syntax
        var DefaultOrEmptyQuerySyntax = (from num in IntArray select num).DefaultIfEmpty(2);

        foreach (var num in DefaultOrEmptyMethodSyntax)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        foreach (var num in DefaultOrEmptyQuerySyntax)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        Console.WriteLine();
        //ElementAt(): It is used to return the element at a specified index in a sequence.
        //Using Method Syntax
        Console.WriteLine("Example of ElementAt");
        var ElementAtMethodSyntax = IntArray.ElementAt(3);

        //Using Query Syntax
        var ElementAtQuerySyntax = (from num in IntArray2 select num).ElementAt(4);


        Console.WriteLine($"Element at 3 placed: {ElementAtMethodSyntax}");
        Console.WriteLine();
        Console.WriteLine($"Element at 4 placed: {ElementAtQuerySyntax}");


        Console.WriteLine();
       // ElementAtOrDefault(): This method is used to result out a specific element from the respective collection by specifying the specific index.
        Console.WriteLine("Example of ElementAtOrDefault");
        //Using Method Syntax
        var ElementAtOrDefaultMethodSyntax = IntArray.ElementAtOrDefault(-1);

        //Using Query Syntax
        var ElementAtOrDefaultQuerySyntax = (from num in IntArray select num).ElementAtOrDefault(2);


        Console.WriteLine($"The Element at -1 Index: {ElementAtOrDefaultMethodSyntax}");
        Console.WriteLine($"The Element at 2 Index: {ElementAtOrDefaultQuerySyntax}");

        // Single(): It is used to return the single element from the collection, which satisfies the condition.
        Console.WriteLine();
        //Using Method Syntax
        //Fetching the Only Element from the Sequenece using Method Syntax
        //var MethodSyntax = IntArray.Single(); :- show exception sequence contains more than one element 
        var MethodSyntax = IntArray.Single(x => x == 40);

        //Using Query Syntax
        //Fetching the Only Element from the Sequenece using Query Syntax
        //var QuerySyntax = (from num in IntArray select num).Single(); :-show exception sequence contains more than one element
        var QuerySyntax = (from num in IntArray select num).Single(num => num == 40);
        Console.WriteLine(MethodSyntax);
        Console.WriteLine();
        Console.WriteLine(QuerySyntax);


        Console.WriteLine();
        // Intersect(): It is used to return the common elements from both collections.
        Console.WriteLine("Example Of the Intersect");
        var commonMethodArray = IntArray.Intersect(IntArray2).ToList();
        var commonQueryArray = (from num in IntArray select num).Intersect(IntArray2).ToList();
        Console.WriteLine("using Mehod");
        foreach (var num in commonMethodArray)
        {
            Console.WriteLine($"{num} ");
        }
        Console.WriteLine("using Query");
        foreach(var num in commonQueryArray)
        {
            Console.WriteLine($"{num} ");
        }

        //Except(): It is used to return the elements which are present in the first data source but not in the second data source.
        Console.WriteLine("Example Of Except");
        var ExceptMethodSyntax = IntArray2.Except(IntArray).ToList();
        var ExceptQuerySyntax = (from num in IntArray select num).Except(IntArray2).ToList();
        Console.WriteLine("Using Method Syntax");
        foreach(var num in ExceptMethodSyntax)
        {
            Console.WriteLine($"{num} ");
        }
        Console.WriteLine("Using Query Syntax");
        foreach (var num in ExceptQuerySyntax)
        {
            Console.WriteLine($"{num}");
        }

        //    Repeat(): It is used to generate a sequence or a collection with a specified number of elements,
        //        and each element contains the same value.

        Console.WriteLine("Example Of the Repeat");
        var RepeatMethodSyntax = Enumerable.Repeat("Omprakash Abhyankar", 5);
        var RepeatQUerySyntax = (from name in Enumerable.Repeat("Omprakash B. Abhyankar", 5) select name).ToList();
        Console.WriteLine();
        Console.WriteLine("Using Method");
        foreach(var name in RepeatMethodSyntax)
        {
            Console.WriteLine($"{name} ");
        }
        Console.WriteLine();
        Console.WriteLine("Using Query");
        foreach (var name in RepeatQUerySyntax)
        {
            Console.WriteLine($"{name} ");
        }
        Console.WriteLine();





        //OfType Example
        Console.WriteLine("OfType Example");
        var data = new List<object>()
            {
                "Vishal", "Sandhya", 15000, "Mahesh", "Pooja", 10000, 20000, 30000, 40000, "Santosh"
            };

        //Using Method Syntax
        var Method1Syntax = data.OfType<string>().ToList();

        //Using Query Syntax
        var Query1Syntax = (from emp in data.OfType<int>() select emp);
        Console.WriteLine("Using Method");
        foreach (var item in Method1Syntax)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Using Query");
        foreach (var item in Query1Syntax)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Example Of the GroupBy");
        var groupBy = Employee.GetAllEmployees().GroupBy(x => x.Department).ToList();
        foreach (var item in groupBy)
        {
            Console.WriteLine($"Name : {item.Key}");           

                //Console.WriteLine($"Employee whos less than 30000 salary: ");
                foreach (Employee emp in item)
                {
                    Console.WriteLine($"Id:{emp.ID} Name:{emp.Name} Department:{emp.Department} salary:{emp.Salary}");
                }            
        }

        //List<Employee>[] = Employee.GetAllEmployees().ToArray<Employee>(); 
        Console.WriteLine($"Type of the collection: {Employee.GetAllEmployees().GetType().Name}");
        Employee[] employees = Employee.GetAllEmployees().ToArray<Employee>();
        Console.WriteLine($"Type :{employees.GetType().Name}");
        List<Employee> employees1 = employees.ToList();
        Console.WriteLine($"Type of the collection:{employees1.GetType().Name}");
    }
}