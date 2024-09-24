namespace CalcDateByG;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type date in next format: dd.mm.yyyy");
        string[] date = Console.ReadLine().Split('.');
                
        int day = Convert.ToInt32(date[0]);
        int month = Convert.ToInt32(date[1]);
        int year = Convert.ToInt32(date[2]);
        
        if(month != 2 && month != 12)
        {
            int maxDayInMonth = 30 + (month + (month / 8)) % 2;

            if (day < maxDayInMonth)
            {
                day += 1;   
            }
            else
            {
                day = 1;
                month += 1;
            }
        }
        else if (month == 12)
        {
            if (day < 31)
            {
                day += 1;
            }
            else
            {
                day = 1;
                month = 1;
                year += 1;
            }
        }
        else if (month == 2)
        {
            if (IsLoopYear(year) && day < 29)
            {
                day += 1;
            }
            else if (IsLoopYear(year) && day == 29)
            {
                day = 1;
                month += 1;
            }
            else if (day < 28)
            {
                day += 1;
            }
            else
            {
                day = 1;
                month += 1;
            }
        }
        
        Console.WriteLine($"Next date: {day}.{month}.{year}");
    }

    static bool IsLoopYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}