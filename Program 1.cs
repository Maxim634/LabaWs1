// Акбаров Максим гр. 22ИТ35, Вариант 1
// формула: ((-1)^n * x^(2*n + 1)) / (2*n + 1)

Console.Write("Введите число x:");
double x = Convert.ToDouble(Console.ReadLine()); // число x
Console.Write("Введите число n:");
double n = Convert.ToDouble(Console.ReadLine()); // число n
double result = 0; // переменная для результата

if (Math.Abs(x) <= 1)
{
    for (double i = 0; i <= n; i++)
    {
        result += ((Math.Pow(-1, n)) * (Math.Pow(x, (2 * n + 1)))) / (2 * n + 1); // формула
    }
    Console.WriteLine(result); // вывод результата в консоль
}
else
{
    Console.WriteLine("Модуль x больше 1");
}