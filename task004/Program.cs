/* Задан массив действительных чисел из N элементов (используйте генератор случайных чисел).
Определить количество элементов, значения которых находятся в диапазоне от -100 до +100. */
Console.Write("Введите размер массива: ");
int arrayRLength = Convert.ToInt32(Console.ReadLine());
double[] arrayR = FillRandomArray(arrayRLength, -1000, 1000);
int count = 0;

double[] FillRandomArray(int length, double minValue, double maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }

    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], 2));
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

for (int i = 0; i < arrayR.Length; i++)
{
    if (arrayR[i] >= -100 && arrayR[i] <= 100) count++;
}

PrintArray(arrayR);
Console.WriteLine(count);