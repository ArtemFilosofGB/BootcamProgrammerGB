/// <summary>
/// Это класс отвечающий за создание массива
/// </summary>

public static class ArrayCreater
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">Колличество элементов массива</param>
    /// <returns>Новый массив</returns>
    public static int[] Create(this int n)
    {
        return new int[n];
    }

    /// <summary>
    /// Составляет строку из массива
    /// </summary>
    /// <param name="array">Массив</param>
    /// <returns>Строку с представления массива</returns>
    public static string ConvertToStringAndPrint(this int[] array)
    {
        string str = $"[{String.Join(' ', array)}]";
        Console.WriteLine(str);
        return str;
    }
    /// <summary>
    /// Заполняет массив
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Минимальное значение случайных чисел</param>
    /// <param name="max">Максимально значение случайных чисел</param>
    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? new Random() : new Random(seed);
        return array.Select(item => random.Next(min, max)).ToArray();

        //return array = array.Select(item => Random.Shared.Next(min, max)).ToArray();

    }
}