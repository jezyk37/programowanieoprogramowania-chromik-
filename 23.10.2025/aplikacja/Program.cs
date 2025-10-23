using System.Security.Cryptography.X509Certificates;
namespace StartProgram
{
    using Rachunkowosc;
    class Program
    {
        static void Main(string[] args)
        {
            
           Rachunki rachunek = new Rachunki();

            Console.WriteLine("Podaj Wartosc oprocetowania");
            rachunek.procet = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj Wartosc podatku");
            rachunek.netto = double.Parse(Console.ReadLine());


            Console.WriteLine(rachunek.netto);
           

        }
    }


}

namespace Rachunkowosc
{
    class Rachunki
    {
        
        public double procet;
       
        private double brutto;

        public double netto
        {
            get { return brutto; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Jak chcesz obliczyc debilu podatek mniejszy od zera 😂😂");
                }
                else
                {
                    procet = (procet / 100) + 1;
                    
                    brutto = value * procet;
                }
                    
            }
        }
        
    }
}