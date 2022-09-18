// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

int[] GetArray(int size, int leftRange, int rightRange) // метод заполнения массива случайными числами в диапазоне от leftRange до rightRange
{
    int[] arr = new int[size]; // создаем новый массив размером size
    Random rand = new Random(); // создали переменную рандома rand
    for (int i = 0; i < size; i++) // циклом заполняем наш массив arr случайными цифрами в промежутке от leftRang до rightRange
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr; // возвращаем из метода заполненный массив arr
}
int[] arr = GetArray(5, 0, 10);// (размер, левая граница, правая граница)
int[] copyArr = new int[arr.Length]; // создаем новый массив copyArr с длинной исходного массива arr

for (int i = 0; i < arr.Length; i++) // через цикл по элементно копируем массив
{
    copyArr[i] = arr[i];
}

arr[0] = -1000; // в исходном массиве изменяем первый элемент

Console.WriteLine($"Исходный массив = {string.Join(", ", arr)}");
Console.WriteLine($"Скопированный массив = {string.Join(", ", copyArr)}");
