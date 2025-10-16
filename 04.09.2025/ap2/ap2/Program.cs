class Program()
{
    public void WypiszWKonsoli(string text)
    {
        Console.WriteLine(text);
    }
    
    
}

class Obliczenia
{
    public void Dodawanie(int a, int b)
    {
        int c = a + b;
        Console.WriteLine(c);
    }
    public void Odejmowanie(int a, int b)
    {
        int c = a - b;
        Console.WriteLine(c);
    }
}

class Figury
{
    public void PoleKwadrat(int a, int b)
    {
        int c = a * b;
        Console.WriteLine(c);
    }
    public void PoleTrojkata(int a, int b)
    {
        int c = a * b / 2;
        Console.WriteLine(c);
    }
}
class Uruchomienie()
{
    static void Main(string[] args)
    {
        Console.WriteLine("Uruchomiony");

        //Program obiekt = new();//== new Program()
        //obiekt.WypiszWKonsoli("Witaj szkoło");

        //Uruchomienie uruchomienie = new();
        //uruchomienie.nazwa();

        Obliczenia oblicznie = new();
        Figury figury = new();

        oblicznie.Dodawanie(3, 4);
        oblicznie.Odejmowanie(10, 4);

        figury.PoleTrojkata(4, 6);
        figury.PoleKwadrat(10, 2);




    }
    void nazwa()
    {

    }
}