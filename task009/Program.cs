/* Сформируйте одномерный массив действительных чисел как геометрическую последовательность со знаменателем ½,
начиная с 1, т.е.: 1,0 0,5 0,25 0,125 и т.д. */

Console.Write("Enter array length: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
array[0] = 1;

for (int i = 1; i < length; i++)
{
    array[i] = array[i-1]/2;
}

Console.WriteLine(string.Join(", ", array));