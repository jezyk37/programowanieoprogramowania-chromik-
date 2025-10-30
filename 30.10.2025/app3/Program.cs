using System;

internal class Program
{
    static void Main(string[] args)
    {
        new Program().PokazLiteryZeZdania();
    }

    private void PokazLiteryZeZdania()
    {
        Console.Write("Podaj zdanie: ");
        string zdanie = Console.ReadLine();

        Console.Write("Podaj liczbę: ");
        int liczba;

        int.TryParse(Console.ReadLine(), out liczba);
            

        Zdanie tekst = new Zdanie(zdanie, liczba);

        Console.WriteLine("\nWynik: " + tekst.WybierzLitery());

        tekst = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}

public class Zdanie
{
    private string tekst;
    private int krok;

    public Zdanie(string tekst, int krok)
    {
        this.tekst = tekst;
        this.krok = krok;
        
    }

    public string WybierzLitery()
    {
        var wynik = "";
        for (int i = krok-1; i < tekst.Length; i += krok)
        
            wynik += tekst[i];
            return wynik;
        
           
    }

    ~Zdanie()
    {
        Console.WriteLine("Destruktor klasy Zdanie wywołany.");
    }
}
