class Program
{
    static void Main()
    {
        Console.Write("Введите двухзначное число: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Введите число A: ");
        int A = int.Parse(Console.ReadLine());

        int sum = (num / 10) + (num % 10);

        string result = (sum % A == 0) ? "кратно" : "не кратно";

        Console.WriteLine($"Сумма цифр числа {num} {result} числу {A}");
    }
}
