int[] numbers = { 5, 8, 12, 15, 20, 25, 30 };

var result =numbers.OrderByDescending(x=>x).Take(3);

 Console.WriteLine(string.Join(' ', result));
