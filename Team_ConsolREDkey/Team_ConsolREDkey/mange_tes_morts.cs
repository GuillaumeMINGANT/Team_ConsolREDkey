using System;
using System.Collections.Generic;
using System.Text;

namespace Team_ConsolREDkey
{
    class mange_tes_morts
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXO 5.5");
            Console.Write("Choisir un nombre: ");
            int nombre = 0;
            int nombreDepart = Convert.ToInt32(Console.ReadLine());
            Console.Write("/n");

            for (int i = 1; i < 11; i++)
            {
                nombre = nombreDepart * i;
                Console.Write(nombreDepart + " * " + i + " = " + nombre+ "/n");
            }
            Console.WriteLine("EXO 5.5 Done.  ");

            Console.WriteLine("======================================");
            Console.WriteLine("EXO 5.6");
            
            Console.Write("Choisir un nombre: ");
            int m_Exercice5_6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("/n");

            Console.Write("la somme des entiers jusqu'a "+ m_Exercice5_6 + "est :");
            for (int i = 0; i < m_Exercice5_6 + 1; i++)
            {
                m_Exercice5_6 += i;
            }
            Console.Write(m_Exercice5_6 + " /n");

            Console.WriteLine("EXO 5.6 Done.  ");

            Console.WriteLine("======================================");
            Console.WriteLine("EXO 5.7");
            Console.Write("Choisir un nombre: ");
            int m_exercice5_7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("/n");
            Console.Write(m_exercice5_7 + "! =")
            for (int i = 1; i < m_exercice5_7 + 1; i++)
            {
                m_exercice5_7 = m_exercice5_7 * i;
            }

            Console.Write(m_exercice5_7 + "/n");

             Console.WriteLine("EXO 5.7 Done.  ");

            Console.WriteLine("======================================");
            Console.WriteLine("EXO 5.8");
            int m_exercice5_8;
            int value;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("nombre numero " + i + " : ");
                value = Convert.ToInt32(Console.ReadLine());
                Console.Write("/n");
                if (m_exercice5_8 < value)
                {
                    m_exercice5_8 = value;
                }
            }
            Console.Write("la valeur max est :"+ m_exercice5_8+ "/n");

            Console.WriteLine("EXO 5.8 Done.  ");

            Console.WriteLine("======================================");
            Console.WriteLine("EXO 5.9");
            Console.Write("Combien de valeur? ");
            int nb_valeur = Convert.ToInt32(Console.ReadLine());
            Console.Write("/n");
            int m_exercice5_9;
            int i59 = 1;

            for (; ; )
            {
                Console.Write("nombre numero " + i + " : ");
                value = Convert.ToInt32(Console.ReadLine());
                Console.Write("/n");
                if (m_exercice5_9 < value)
                {
                    m_exercice5_9 = value;
                }
                else if (value==0)
                {
                    break;
                }
                i59++;
            }

            Console.Write("la valeur max est :" + m_exercice5_8 + "/n");

            Console.WriteLine("EXO 5.9 Done.  ");
            Console.WriteLine("======================================");
            Console.WriteLine("EXO 5.10");

            Console.WriteLine("EXO 5.10 Done.  ");

            Console.WriteLine("======================================");
            Console.WriteLine("EXO 5.11");



            Console.WriteLine("EXO 5.11 Done.  ");
            Console.WriteLine("======================================");
        }
    }
}
