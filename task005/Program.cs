/* Задан массив действительных чисел из N элементов (используйте генератор случайных чисел).
Определить количество элементов, значения которых находятся вне диапазона от -10 до +10. */

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
double[] array = FillDoubleArray(sizeArray, -100, 100);
int count = sizeArray;

double[] FillDoubleArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }

    return array;
}
void PrintArray(double[] arrayForPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayForPrint[i], 2));
        if (i < arrayForPrint.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

foreach (var item in array)
{
    if (item > -10 && item < 10) count--;
}

PrintArray(array);
Console.WriteLine(count);