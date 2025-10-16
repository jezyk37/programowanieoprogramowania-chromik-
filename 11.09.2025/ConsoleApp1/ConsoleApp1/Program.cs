class Program
{
    static void Main()
    {
        int doZakresu;

        Console.WriteLine("Podaj koniec zakresu:");
        doZakresu = int.Parse(Console.ReadLine());
        int od = 1;

        Random losowanie = new Random();
        int wylosowana = losowanie.Next(od,doZakresu + 1);

        int proba = 0;
        int strzal;


        do
        {
            Console.Write($"Zgdnij liczbe od {od} do {doZakresu}:  ");
            strzal = int.Parse(Console.ReadLine());
            proba++;

            if (strzal < wylosowana)
            {
                Console.WriteLine("Za mało!");
                if (strzal >= od)
                {
                    od = strzal;
                }
            }
            else if (strzal > wylosowana)
            {
                Console.WriteLine("Za dużo!");
                if (strzal >= od)
                {
                    doZakresu = strzal ;
                }
            }
            else
            {
                Console.WriteLine($"Brawo! Zgadłeś za {proba} razem!");
            }

        } while (strzal != wylosowana);
    }
}