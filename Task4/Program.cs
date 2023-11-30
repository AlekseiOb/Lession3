// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, 
// состоящий из цифр этого числа. Старший разряд числа должен 
// располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

void Test(int num)
{
    int count = 0;
    int num1 = num;

    while (num1 != 0)
    {
        num1 = num1 / 10;
        count++;
    }
    int[] array = new int[count];

    for (int i = 0; i < count; i++)
    {
        array[i] = num %10;
        num = num /10;
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите натуральное число от 1 до 100 000: ");
int inputNum = Convert.ToInt32(Console.ReadLine());
if (inputNum < 1 || inputNum > 100000)
{
    Console.WriteLine("Число должно быть в диапазоне от 1 до 100 000.");
    return;
}

Test(inputNum);