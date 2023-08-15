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
        if (i!= arraytoprint.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
int[] userarray = GetRandomArray(10);
PrintArray(userarray);
int[] GetEvenArray(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            even++;
        }

    }
    int[] result = new int[even];
    int[] result1 = new int[array.Length-even];
    for (int i = 0; i < even; i++)
    {
        if (array[i]%2==0)
        {
            result[i]=array[i];
        }
        else
        {
            result1[i]= array[i];
        }
    }
    return result;
    return result1;

}
int[] evenarray = GetEvenArray(userarray);
PrintArray(evenarray);