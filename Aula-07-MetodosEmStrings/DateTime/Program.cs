using System;
using System.Globalization;
namespace AulaDateTime;
class Program
{
    static void Main (string[] args)
    {
        DateTime data1 = DateTime.Parse ("2000-08-15");
        DateTime data2 = DateTime.Parse ("01/07/2004 13:02:47");
        DateTime data3 = DateTime.ParseExact ("01/07/2004 13:02:47", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        Console.WriteLine (data1);
        Console.WriteLine (data2);
        Console.WriteLine (data3);

        Console.ReadLine ();
    }
}