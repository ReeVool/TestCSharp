//Дан целочисленный массив размера N. Вывести все содержащиеся в данном массиве четные числа в порядке возрастания их индексов, а также их количество.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];

        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Чётные числа в порядке возрастания их индексов:");

        int count = 0;

        for (int i = 0; i < N; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine($"Индекс: {i}, Значение: {arr[i]}");
                count++;
            }

        }

        Console.WriteLine($"Количество чётных чисел: {count}");

        Console.ReadKey();
    }
}