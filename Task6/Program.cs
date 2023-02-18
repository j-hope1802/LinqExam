
List<Employee> employees = new List<Employee>
{
 new Employee { Name = "Alice", Department = "Sales", Salary = 50000
},
 new Employee { Name = "Bob", Department = "IT", Salary = 60000 },
 new Employee { Name = "Charlie", Department = "Sales", Salary = 
55000 },
 new Employee { Name = "Dave", Department = "IT", Salary = 65000 },
 new Employee { Name = "Eve", Department = "HR", Salary = 45000 }
};

var Employees = employees.GroupBy(d => d.Department).Select(de => new 

{

 Department = de.Key, 
Avg = de.Average(e => e.Salary) } );


 foreach (var item in Employees)
 {
 System.Console.WriteLine(item);
 }