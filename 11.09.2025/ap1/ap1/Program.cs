
namespace Kontener1
{
    using Kontener2;

    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Odejmij(6, 5);
            
            Kontener2.Program program1 = new Kontener2.Program();
            Dodawanie dodawanie = new Dodawanie();
            program1.Wypisz("Jakis tekst");
        }

        void WykonajOdejmowanie()
        {

            Program.Odejmij(6,5)
        }
        public void Odejmij(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
}

namespace Kontener2
{
    class Program
    {
            public void Wypisz(string tekst)
        {
            Console.WriteLine(tekst);
        }
    }
    class Dodawanie
    {
        public void Dodaj(int a, int b) 
        {
            Console.WriteLine(a + b);
        }

    }
}