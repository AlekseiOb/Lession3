// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateDoubleArray(int size)
{
    double [] array = new double [size];
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().NextDouble()*100;
    }
    return array;
}

void ShowArray(double [] array)
{
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
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
    Console.WriteLine($"Максимальное число в массиве: {max}");
    Console.WriteLine($"Минимальное число в массиве: {min}");
    double diff = max - min;
    return diff;
}

Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = CreateDoubleArray(size);
ShowArray(array);
Console.WriteLine();
double difference = Difference(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");