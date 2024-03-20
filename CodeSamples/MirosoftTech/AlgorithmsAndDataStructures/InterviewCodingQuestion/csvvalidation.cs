using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class FirstDataSet
{
    public int Year { get; set; }
    public string State { get; set; }
    public string Month { get; set; }
    public int Number { get; set; }
}

public class SecondDataSet
{
    public int Year { get; set; }
    public int Number { get; set; }
}
public static class TestRunner
{
    static void Test()
    {
        bool result = false;
        var firstSet = new List<FirstDataSet>();
        var secondSet = new List<SecondDataSet>();
        StreamReader reader = new StreamReader("D:\\sample-input-1.txt");
        FirstDataSet(ref reader, firstSet);
        SecondDataSet(ref reader, secondSet);

        foreach (var second in secondSet)
        {
            if (firstSet.Where(x => x.Year == second.Year).Sum(y => y.Number) != second.Number)
            {
                result = false;
                break;
            }
            else
            {
                result = true;
                continue;
            }
        }
        Console.WriteLine(result);
    }

    private static List<FirstDataSet> FirstDataSet(ref StreamReader reader, List<FirstDataSet> firstSet)
    {
        while (!reader.EndOfStream)
        {
            int index = 0;
            string line = reader.ReadLine();
            if (string.IsNullOrEmpty(line))
            {
                return firstSet;
            }
            var rowValues = line.Split(',');
            int.TryParse(rowValues[index], out int year);
            int.TryParse(rowValues[index + 3], out int number);
            firstSet.Add(new FirstDataSet
            {
                Year = year,
                State = rowValues[index + 1],
                Month = rowValues[index + 2],
                Number = number
            });
        }
        return firstSet;
    }
    private static List<SecondDataSet> SecondDataSet(ref StreamReader reader, List<SecondDataSet> secondSet)
    {
        while (!reader.EndOfStream)
        {
            int index = 0;
            string line = reader.ReadLine();
            if (!string.IsNullOrEmpty(line))
            {
                var columnValue = line.Split(',');
                int.TryParse(columnValue[index], out int year);
                int.TryParse(columnValue[index + 1], out int number);
                secondSet.Add(new SecondDataSet
                {
                    Year = year,
                    Number = number
                });
            }
        }
        return secondSet;
    }
}