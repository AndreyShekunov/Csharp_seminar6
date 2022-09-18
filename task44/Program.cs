// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void PrintFiboToN(int n) //метод вывода чисел Фибоначи от N
{
    if (n >= 2)
    {
        int[] fibo = new int[n]; // создаем массив размерность n
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < fibo.Length; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
        Console.WriteLine(string.Join(" ", fibo));
    }
    else
    {
        Console.WriteLine("N должно быть не меньше 2");
    }
}

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintFiboToN(number);