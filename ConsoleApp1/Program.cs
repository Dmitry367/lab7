using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        Console.Write("x = ");
        //double x = double.Parse(Console.ReadLine());
        double y, j;
        try
        {
            y = Math.Sqrt(double.Parse(Console.ReadLine()) + 1);
            j = y;
        }
        catch
        {
            Console.WriteLine("Невозможно извлечь квадратный корень из данного числа.");
            return;
        }
        try
        {
            y = Math.Cbrt(9 - y);
        }
        catch
        {
            Console.WriteLine("Невозможно извлечь кубический корень из данного выражения.");
            return;
        }
        try
        {
            y += Math.Cbrt(7 + j);
            Console.WriteLine(y);
            if (y == 4) Console.WriteLine("Выражение равно 4-ём.");
            else Console.WriteLine("Выражение не равно 4-ём.");
        }
        catch
        {
            Console.WriteLine("Невозможно извлечь кубический корень из данного выражения.");
        }
    }
}
