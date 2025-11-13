namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uzytkownik biblioteka = new Uzytkownik("biblioteka");
            Uzytkownik userl = new Uzytkownik("Bez Solo");

            Ksiazka ksiazka1 = new Ksiazka(biblioteka, "Solaris", "Stanisław Lem");
        }
    }
}

public class Biblioteka
{
        List<Ksiazka> list = new List<Ksiazka>();
    List<Uzytkownik> listaUzytkownikow = new List<Uzytkownik>();
}
public class Uzytkownik
{ 
    public string _nazwaUzytkownika { get { return nazwaUzytkownika; } set { nazwaUzytkownika = value; } }
    private string nazwaUzytkownika; 
    public Uzytkownik(string nazwaUzytkownika) 
    {
        this.nazwaUzytkownika = nazwaUzytkownika;
    }
}

public class Ksiazka
{
    public string tytul { get { return _tytul; } set { _tytul = value; } }
    public string autor { get { return _autor; } set { _autor = value; } }
    public Uzytkownik nazwaUzytkownika { get { return _nazwaUzytkownika; } set { _nazwaUzytkownika = value; } }


    private string _tytul;
    private string _autor;
    private Uzytkownik _nazwaUzytkownika;

    public Ksiazka(Uzytkownik nazwaUzytkownika, string tytul, string autor)
    {
        _tytul = tytul;
        _autor = autor;
        _nazwaUzytkownika = nazwaUzytkownika;
    } 

}