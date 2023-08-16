// В одномерном массиве из 100 чисел M[] подсчитайте количество элементов, удовлетворяющих условию 0 < M[i] <125.

int[] arrayM = FillRandomArray(20);
int count = 0;

int[] FillRandomArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }

    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

for (int i = 0; i < arrayM.Length; i++)
{
    if (arrayM[i] > 0 && arrayM[i] < 125) count++;
}

PrintArray(arrayM);
Console.WriteLine(count);