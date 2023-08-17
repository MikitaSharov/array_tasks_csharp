/* Сформируйте массив целых чисел по алгоритму Фибоначчи: 1-й и 2-й элемент равны 1,
а каждый последующий равен сумме двух предыдущих,т.е.: 1, 1, 2, 3, 5, 8, … .
Найдите сумму и произведение его N членов. */

int[] array = FillFibArray();
int sum = 0;
int product = 1;

int[] FillFibArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    Console.Write("Введите первый элемент масства: ");
    array[0] = Convert.ToInt32(Console.ReadLine());
    array[1] = array[0];

    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }

    return array;
}

foreach (int item in array)
{
    sum = sum + item;
    product = product*item;
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine(sum);
Console.WriteLine(product);