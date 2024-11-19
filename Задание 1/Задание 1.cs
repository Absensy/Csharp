Console.Write("a = ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("b = ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("c = ");
double num3 = double.Parse(Console.ReadLine());

Console.WriteLine($"({num1:F2} + {num2:F2}) + {num3:F2} = {num1:F2} + ({num2:F2} + {num3:F2})");