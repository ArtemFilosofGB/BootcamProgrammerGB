// Урок 4. Алгоритм «Сортировка выбором»

int[] SortSelection(int[] collection)
{
    int size = collection.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        int pos = i;
        for (int j = i; j < size; j++)
        {
            if (collection[j] > collection[pos]) pos = j;
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
    return collection;
}


void PrintArray(int[] arr) //Метод, который выводит массив
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        Console.Write($"{arr[i]} "); // формат вывода в 5 символов
    }
    Console.WriteLine();

}

int[]  array = { 2, 3, 5, 8, 7, 3, 4,-2, 0 };

PrintArray(array);

SortSelection(array);
PrintArray(array);