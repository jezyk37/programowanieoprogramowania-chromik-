using System.Security.Cryptography.X509Certificates;

namespace StartProgram
{
    using Figury;
    class Program
    {
        static void Main(string[] args)
        {
            //Zinterpretowany kontener przez using
           Figury.Kwadrat kwadrat = new Figury.Kwadrat();
            kwadrat.bok = 12;
            kwadrat.obwod = -100;
            //bez importowania kontenera

            Console.WriteLine(kwadrat.obwod);
            kwadrat.obwod = 0;
            Console.ReadKey();

            Bryly.Szescian szescian = new Bryly.Szescian();

           

        }
    }


}

namespace Bryly
{
    class Szescian
    {
        public void ObliczPole()
        {

        }
    }
}

namespace Figury
{
    class Kwadrat
    {
        public int bok;//ten sposon jest jak najmniej zalecany

        public int obwod 
        { get { return _obwod; } 
            set {
                if (value < 0)
                {
                    _obwod = value * -1;
                }else if(value == 0)
                {
                    throw new ArgumentException("obwod nie moze byc zerem!");
                }
                else
                {
                    _obwod = value;
                }
            } }


        private int _obwod;
        public void ObliczPole() 
        {

        }
    }
}