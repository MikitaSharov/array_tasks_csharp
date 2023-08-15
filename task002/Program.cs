int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}

int min = array[0];
int max = array[0];

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

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}
PrintArray(array);
Console.WriteLine(max);
Console.Write(min);