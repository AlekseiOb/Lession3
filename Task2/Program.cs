// Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

int [] CreateArray(int min, int max, int size)
{
    int [] array = new int [size];
    for(int i = 0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

int CountEven (int[] array)
{
    int countEven = 0;
    for(int i = 0; i<array.Length;i++)
    {
        if (array[i] % 2 == 0)
        {
            countEven++;
        }
    }
    return countEven;
}

Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);
ShowArray(array);
Console.WriteLine();
int evenNumbers = CountEven(array);
Console.WriteLine($"Количество четных чисел в массиве: {evenNumbers}");