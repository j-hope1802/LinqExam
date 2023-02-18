string[] words = { "apple", "banana", "cherry", "date", "elderberry" };

var select=words.OrderByDescending(x=>x.Length);

    System.Console.WriteLine(string.Join( ' ',select));
