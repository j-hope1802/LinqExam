List<Person> people = new List<Person>
{
 new Person { Name = "Alice", Age = 20 },
 new Person { Name = "Bob", Age = 30 },
 new Person { Name = "Charlie", Age = 20 },
 new Person { Name = "Dave", Age = 30 },
 new Person { Name = "Eve", Age = 20 }
};

var human = people.OrderBy(p => p.Age);
 
foreach (var p in human)
    Console.WriteLine($"{p.Name} - {p.Age}");
 
