Console.Write("Введите площадь поверхности куба (S): ");
double S = double.Parse(Console.ReadLine());

double a = Math.Sqrt(S / 6);

Console.WriteLine($"Длина ребра куба: {a:F2}");