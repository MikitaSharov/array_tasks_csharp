int[] userarray = GetRandomArray(10); //10 - размер массива
int[] evenarray = GetEvenArray(userarray);
int[] oddarray = GetOddArray(userarray);
// Метод по заполнению массива.
int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}
// Метод по выводу массива.
void PrintArray(int[] arraytoprint)
{
    Console.Write("[");
    for (int i = 0; i < arraytoprint.Length; i++)
    {
        Console.Write(arraytoprint[i]);
        if (i != arraytoprint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

// Метод по заполнению массива чётными значениями из другого массива
int[] GetEvenArray(int[] array)
{
    // Считаем кол-во четных элементов в массиве userarray и это будет размером нового массива
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCount++;
        }
    }
    int[] evenarray = new int[evenCount]; //создаём новый массив размером evenCount

    // заполняем новые значения evenarray[index] чётными значениями проверяя каждое значение item входного массива 
    int index = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            evenarray[index] = item;
            index++;
        }
    }
    return evenarray;
}

// Метод по заполнению массива нечётными значениями из другого массива
int[] GetOddArray(int[] array)
{
    int oddCount = 0;
    foreach (int item in array)
    {
        if (item % 2 == 1) oddCount++;
    }

    int[] oddarray = new int[oddCount];

    int index = 0;
    foreach (int item in array)
    {
        if (item % 2 == 1)
        {
            oddarray[index] = item;
            index++;
        }
    }
    return oddarray;
}

PrintArray(userarray);
PrintArray(evenarray);
PrintArray(oddarray);