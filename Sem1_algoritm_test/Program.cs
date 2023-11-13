using static ArrayCreater;
using static ArrayMath;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
int[] array = 1_000_000.Create() //Колличество элементов массива
                .Fill(1, 5);
//array.ConvertToStringAndPrint();

int m = 10_000; //Колличество суммируемых элементов
Stopwatch sw = new Stopwatch();//таймер для оценки скорости исполнения алгоритмов
sw.Start();
int max = array.GetBadSum(m);
sw.Stop();
Console.Clear();
Console.WriteLine($"Bad sum = {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max=array.GetGoodSum(m);
sw.Stop();
Console.WriteLine($"Good sum = {max} => {sw.ElapsedMilliseconds}");