int[] numbers = { 1, 5, 8, 12, 15, 20 };

var result=numbers.Where(x=>x>10);

 Console.WriteLine(string.Join(' ', result));