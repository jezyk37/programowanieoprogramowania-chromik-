using System.Collections.ObjectModel;

public class Program
{
    public static void Main(string[] args)
    {
        Zegar zegar1 = new Zegar();
        zegar1.Metoda("Warszawa", 1);
        Console.ReadKey();
    }
}

public class Zegar
{
    private string nazwaStrefy;
    private int numerLinii;
    ReadOnlyCollection<TimeZoneInfo> tzi;
    public void Metoda(string nazwaStrefy, int numerLinii)
    {
        this.nazwaStrefy = nazwaStrefy;
        this.numerLinii = numerLinii;

        System.Timers.Timer timer;
        timer = new System.Timers.Timer();
        timer.Interval = 1000;
        timer.Elapsed += Timer_Elapsed;

        timer.Start();
    }



    void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        tzi = TimeZoneInfo.GetSystemTimeZones();

        foreach (TimeZoneInfo timeZone in tzi)
        {
            if (timeZone.DisplayName.IndexOf(nazwaStrefy) > 0)
            {
                Console.SetCursorPosition(0, numerLinii);
                Console.WriteLine("\r" + $" {timeZone.DisplayName} {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, timeZone.Id).ToString()}");
            }
        }
    }
}