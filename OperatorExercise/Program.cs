Console.WriteLine("Please enter a number: ");
var a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a second number: ");
var b = Convert.ToInt32(Console.ReadLine());
var addition = a += b;
var subtraction = a -= b;
var multiplication = a *= b;
var division = a /= b;
var modulus = a %= b;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"The sum is {addition}");
Console.WriteLine($"The difference is {subtraction}");
Console.WriteLine($"The product is {multiplication}");
Console.WriteLine($"The quotient is {division}");
Console.WriteLine($"The remainder is {modulus}");
