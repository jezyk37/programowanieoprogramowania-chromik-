namespace Kontener
{
    public class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mojaKlasa = new MojaKlasa();
            mojaKlasa.MojaMetoda();
            mojaKlasa.InnaMetoda();
                
            Klasa4CT.MojaMetoda();

            string liczba = "5";
            int liczba2 = Klasa4CT.MojaMetoda();
        }
    }
    public class MojaKlasa
    {
        //w klasie instancjowanej mozemy tworzyc metody zarowno statyczne jak i niestatyczne
        public void MojaMetoda()
        {
            InnaMetoda();
        }
        public static void InnaMetoda()
        {


        }
    }
        public static class Klasa4CT
    {
        //klasy statycznej nie mozemy instancjowac
        //w klasie statycznej mozemy tworzyc tylko i wylacznie metody statyczne

        public static void MojaMetoda()
        {

        }
        public static void InnaMetoda()
        {

        }

    }

}