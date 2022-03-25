double Okr(double x, int y) // Метод округления.
{
    return Math.Round(x, y);
}

int Znak()  // Метод для получения числа до которого округлять полученые значения.
{
    Console.WriteLine("Введи количество знаков после запятой у начального числа.");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int Znakk()// Метод для получения числа до которого округлять полученые значения.
{
    Console.WriteLine("Введи количество знаков после запятой у конечного числа.");
    int x = int.Parse(Console.ReadLine());
    return x;
}

Console.WriteLine("Выберете действие: \n 1: Перевод радиан в градусы. \n 2: Перевод градусов в радианы."); // Начало.

int per = int.Parse(Console.ReadLine());

if (per != 1 && per != 2)
{
    Console.WriteLine("Ошибка ввода!!!");
    Environment.Exit(0); // Завершение программы.
}

Console.WriteLine("Введи число.");
double chi = double.Parse(Console.ReadLine());


chi = Okr(chi, Znak()); // Округление введёного числа.

if (per == 1)
{
    chi = (180 / Math.PI) * chi; // Перевод радиан в градусы.
    Console.WriteLine(Okr(chi, Znakk())); // Округление и ввывод итового числа.
}
else
{
    chi = (Math.PI / 180) * chi; //Перевод градусов в радианы.
    Console.WriteLine(Okr(chi, Znakk())); // Округление и ввывод итового числа.
}