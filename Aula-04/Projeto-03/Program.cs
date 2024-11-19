using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int> { 1, 2, 4 };
        List<int> list2 = new List<int> { 1, 3, 4 };
        
        List<int> list = new List<int>();
        
        foreach (int num in list1)
        {
            list.Add(num);
        }

        foreach (int num in list2)
        {
            list.Add(num);
        }

        list.Sort();

        foreach (var index in list)
        {
            System.Console.WriteLine(index.ToString());
        }
    }
}