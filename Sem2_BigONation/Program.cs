//Big O Nation

using System.Diagnostics;

/*
int n =5;

int[] array = new int[n];
for (int i = 0; i < 5; i++) 
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("["+string.Join(", ",array)+"]");
Console.WriteLine(array[3]);
//[4,5,3,1,2]
//Сложность О(n)
//Сртировка [1,2,3,4,5] = О(n * log n)
//сумма арифмитической прогрессии ((5+1)/2)*5 = Сложность О(1)

//Сумма массива - Сложность О(n) n - количество элементов
int summ=0;
for (int i = 0; i < n; i++)
summ+=array[i];
Console.WriteLine(summ);
*/
//==============================================================
void PrintMatrixInt(int[,] arr) //Метод, который выводит массив
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5} "); // формат вывода в 5 символов
        }
        Console.WriteLine();
    }
}



int n=9;
int[,] matrix = new int[n, n];

int[,] MultyTable(int n)
{

int[,] matrix = new int[n+1, n+1];
for (int i = 1; i <= n; i++) 
{
    for (int j = 1; j <= n; j++)
    {
        
            matrix[i, j] = i * j;
            matrix[j, i] = i * j;
        
    }
   // Console.WriteLine();
}
return matrix;
}


// Сложность алгоритма составляет O(n) = (n)*(n/2)
// Упрощенная запись O(n^2/2)
int[,] MultiplyTableFast(int n)
{
    int[,] result = new int[n +1, n+1];
    for (int i = 0; i <= n; i++)
    {
        for (int j = i; j <= n; j++)
        {
            result[i, j] = i * j;
            result[j, i] = result[i, j];
        }
    }
    return result;
}
Stopwatch sw = new Stopwatch();//таймер для оценки скорости исполнения алгоритмов

Console.WriteLine("Slow");
sw.Start();
PrintMatrixInt(MultyTable(9));
sw.Stop();
Console.WriteLine($"Slow => {sw.ElapsedMilliseconds} milliseconds");


Console.WriteLine("Fast");
sw.Start();
PrintMatrixInt(MultiplyTableFast(9));
sw.Stop();
Console.WriteLine($"Fast => {sw.ElapsedMilliseconds} milliseconds");
