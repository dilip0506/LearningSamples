using System.Diagnostics;

namespace Recursion;

public class PrintString
{
    private const string ex = "Hello";

    static void PrintHelper(int index, string input)
    {
        Debug.Write('H');
        if (index <= input.Length)
            return;
        PrintHelper(index + 1, input);
        Console.WriteLine(input[index]);
    }

    public static void Run()
    {
        PrintHelper(0, ex);
    }
}
