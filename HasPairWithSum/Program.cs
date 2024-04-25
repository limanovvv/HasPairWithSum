

class MyClass
{
    public static void Main()
    {
        int number1 = 8;
        int number2 = 13;
        Console.WriteLine($"{HasPairWithSum(new List<int> {10, 4, 3, 7}, number1)}");
        Console.WriteLine($"{HasPairWithSum(new List<int> {1, 4, 4, 9}, number1)}");
    }

    /// <summary>
    /// находит в листе пару чисел, составляющие заданную сумму
    /// </summary>
    /// <param name="list"> лист </param>
    /// <param name="number"> заданная сумма </param>
    /// <returns></returns>
    public static bool HasPairWithSum(List<int> list, int number)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] + list[i +1] == number)
            {
                return true;
            }
        }
        return false;
    }
}