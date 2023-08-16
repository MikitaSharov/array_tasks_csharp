// Напишите методы для ввода одномерного массива с клавиатуры и для вывода его содержимого на экран.

int[] array = FillArrayFromConsole();

int[] FillArrayFromConsole()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}
void PrintArray(int[] arrayForPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]);
        if (i < arrayForPrint.Length - 1) System.Console.Write(", ");
    }
    Console.WriteLine("]");
}

PrintArray(array);