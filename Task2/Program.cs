int[] numbers = new[] { 1, 5, 8, 12, 15, 20 };
var odds = numbers.Where(x => x % 2 != 0);
var sum=odds.Sum();
 Console.WriteLine(string.Join(' ', sum));