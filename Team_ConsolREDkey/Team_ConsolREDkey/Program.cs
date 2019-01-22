using System;

namespace Team_ConsolREDkey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 5.5");



            Console.WriteLine("Exo 5.6");
            EntryINT e1 = new EntryINT(0);
            int value = e1.Result(0);

            Exercice5_6 rep1 = new Exercice5_6(value);
            Console.WriteLine(rep1.SommeENTIER());

            Console.WriteLine("Exo 5.7");





            Console.WriteLine("Final Done. ");
            Console.ReadKey();
        }
    }
}
