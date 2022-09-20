// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

double ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double a = ReadNumber("Введите число a:");
double b = ReadNumber("Введите число b:");
double c = ReadNumber("Введите число c:");

if (a < (b + 1) && b < (a + c) && c < (b + a))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}