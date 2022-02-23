using System;
using desafio_iniciante.src.Entities;

namespace desafio_iniciante
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 12, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            BlackWizard topapa = new BlackWizard("Topapa", 43, "Black Wizard");

            Console.WriteLine(arus.Attack(7));
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(topapa.Attack(5));
        }
    }
}
