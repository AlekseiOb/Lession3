// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

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

int CountElements(int[] array, int minElem, int maxElem)
{
int count = 0;
    for(int i = 0; i<array.Length;i++)
    {
        if (array[i] >= minElem && array[i] <= maxElem)
        {
            count++;
        }
    }
    return count;
}


Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter range number min");
int minElem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter range number max");
int maxElem = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);
ShowArray(array);
Console.WriteLine();
int elenentsInRahge = CountElements(array, minElem, maxElem);
Console.WriteLine($"Количество элементов в указанном диапазоне: {elenentsInRahge}");
