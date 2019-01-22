using System;

namespace Team_ConsolREDkey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est le nombre de départ ? ");
            int nombre = 0;
            int nombreDepart = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<11; i++)
            {
                nombre = nombreDepart*i;
                Console.WriteLine(nombre);
            }
            Console.ReadLine();
        }
    }
}
