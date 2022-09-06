using System;

namespace Odd;
public static class Program
{
    public static void Main(string[] args)
    {
        if (args == null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        var numbers = new List<int>()
            { 107, 92, 3, 46, 5096, 666, 85 };

        for (int i = 0; i < numbers.Count; i += 2)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}