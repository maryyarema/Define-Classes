using System;
public static class DateModifier
{
    public static long GetDaysBetweenTwoDates(string firstDateAsStr, string secondDateAsStr)
    {
        var firstDate = DateTime.ParseExact(firstDateAsStr, "yyyy MM dd", CultureInfo.InvariantCulture);
        var secondDate = DateTime.ParseExact(secondDateAsStr, "yyyy MM dd", CultureInfo.InvariantCulture);

        return Math.Abs((firstDate - secondDate).Days);
    }
}
public class Startup
{
    public static void Main()
    {
        var firstDateAsStr = Console.ReadLine();
        var secondDateAsStr = Console.ReadLine();

        Console.WriteLine(DateModifier.GetDaysBetweenTwoDates(firstDateAsStr, secondDateAsStr));
    }
}

