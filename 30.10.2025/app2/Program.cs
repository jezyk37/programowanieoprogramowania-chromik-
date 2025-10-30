using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Program
    {
        static void Main(string[] args)
        {
        Program program = new Program();
        program.ObliczPoleProstokata();
        }

        private void ObliczPoleProstokata()
        {
        Prostokat prostokat = new Prostokat(10, 10);
        Console.WriteLine(prostokat.WyliczPole());
        prostokat = null;
        object ob = prostokat;
        GC.SuppressFinalize(prostokat);
        GC.Collect();   
        Console.ReadLine();
        }
    }

public class Prostokat
{
    private double BokA;
    private double BokB;

    public Prostokat(double bokA, double bokB)
    {
        this.BokA = bokA;
        this.BokB = bokB;
    }

    public double WyliczPole()
    {
        return BokA * BokB;
    }
    ~Prostokat()
    {
        Console.WriteLine("DESTRUKCJA");
    }
}

