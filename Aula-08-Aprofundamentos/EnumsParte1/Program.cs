using System;
namespace EnumsParte1;

public class EnumConversionExample
{
    public static void Main ()
    {
        Meses a = Meses.Outubro;
        Console.WriteLine(a.ToFriendlyString());

        Console.ReadLine ();
    }
}