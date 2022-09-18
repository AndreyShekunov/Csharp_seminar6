// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void ReverseArray(int[] array) // метод разворота массива
{
    for (int i = 0; i < array.Length / 2; i++) // обрабатываем половину массива (array.Length / 2)
    {
        int temp = array[i]; // сохраняем первый элемент массива в переменной temp
        array[i] = array[array.Length - 1 - i]; // присваиваем первому элементу массива значение последнего
        array[array.Length - 1 - i] = temp; // записываем значение temp в последний элемент массива
    }
}

int[] arr = GetArray(5,0,10);
Console.WriteLine($"Исходный массив = {string.Join(", ", arr)}");
ReverseArray(arr);
Console.WriteLine($"Развернутый массив = {string.Join(", ", arr)}");
