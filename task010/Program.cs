/* Задан массив целых чисел A[20].
Создать другой массив целых чисел B[ ], в который войдут все числа исходного массива,
удовлетворяющие условию: А[i] <= 888, после чего отсортировать элементы массива В[ ] по убыванию. */

int[] arrayA = new int[20];
for (int i = 0; i < arrayA.Length; i++)
{
    arrayA[i] = new Random().Next(0, 1000);
}
Console.WriteLine(string.Join(", ", arrayA));

int[] arrayB = FillFromArray(arrayA);
Console.WriteLine(string.Join(", ", arrayB));

int[] sortArrayB = SortArrayDescending(arrayB);
Console.WriteLine(string.Join(", ", sortArrayB));

int[] FillFromArray(int[] array)
{
    int length = 0;
    // считаем размернового массива
    foreach (int item in array)
    {
        if (item <= 888) length++;
    }
    // создаем новый массив
    int[] arrayB = new int[length];
    int index = 0; /* для нового массива */
    // заполняем новый массив по условию значениями с входного массива
    foreach (int item in array)
    {
        if (item <= 888)
        {
            arrayB[index] = item;
            index++;
        }
    }

    return arrayB;
}

int[] SortArrayDescending(int[] arrayForSort)
{
    for (int i = 0; i < arrayForSort.Length - 1; i++)
    {
        for (int j = 0; j < arrayForSort.Length - i - 1; j++)
        {
            if (arrayForSort[j] < arrayForSort[j + 1])
            {
                int temp = arrayForSort[j];
                arrayForSort[j] = arrayForSort[j + 1];
                arrayForSort[j + 1] = temp;
            }
        }
    }

    return arrayForSort;
}