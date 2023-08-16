// В заданном массиве действительных чисел найдите разность между максимальным и минимальным числом.

double[] array = FillDoubleArray(10, -100, 100);

double[] FillDoubleArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }

    return array;
}
void PrintArray(double[] arraytoprint)
{
    Console.Write("[");
    for (int i = 0; i < arraytoprint.Length; i++)
    {
        Console.Write(Math.Round(arraytoprint[i], 2));
        if (i != arraytoprint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

double min = array[0];
double max = array[0];
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
Console.WriteLine($"max = {max:N2}, min = {min:N2}, max-min = {(max - min):N2}");