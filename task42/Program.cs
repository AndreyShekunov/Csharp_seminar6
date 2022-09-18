// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// Например:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void PintBinaryView(int number) // метод вывода на экран двоичного числа
{
    if (number <= 0)
    {
        return;
    }
    else
    {
        PintBinaryView(number / 2);
        Console.Write(number % 2);
    }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

PintBinaryView(num);