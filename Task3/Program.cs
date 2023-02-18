
string[] names = { "Alice", "Anny", "Amy", "Dave", "Alex","Aiva" }; 

var list = names.Where(x=>x.StartsWith("A") && x.EndsWith("a"));

  System.Console.WriteLine(string.Join( ' ',list));