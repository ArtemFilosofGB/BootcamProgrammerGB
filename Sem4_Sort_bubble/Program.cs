/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/

using System.Diagnostics;


bool CheckSort(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size - 1; i++)
    {
        if (array[i] > array[i + 1]) return false;
    }
    return true;
}

int[] CreateArrRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

int[] SortBubble(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
        //Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
        // Console.WriteLine($"Sost quality : {CheckSort(array)}");
    }
    return array;
}

int[] SortBubble2(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
        // Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
        // Console.WriteLine($"Sort log : {CheckSort(array)}");
    }
    return array;
}

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrRndInt(n, 0, 1000);

Stopwatch sw = new Stopwatch();//таймер для оценки скорости исполнения алгоритмов
int[] resulrArray;

sw.Start();
resulrArray = SortBubble(array, n);
sw.Stop();
Console.WriteLine($"SortBubble => {sw.ElapsedMilliseconds} mls");
Console.WriteLine($"Check sort quality : {CheckSort(array)}");

sw.Reset();
sw.Start();
resulrArray = SortBubble2(array, n);
sw.Stop();
Console.WriteLine($"SortBubble2 => {sw.ElapsedMilliseconds} mls");
Console.WriteLine($"Check sort quality : {CheckSort(array)}");