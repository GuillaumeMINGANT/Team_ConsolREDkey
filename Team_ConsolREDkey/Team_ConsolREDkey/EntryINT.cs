using System;
using System.Collections.Generic;
using System.Text;

namespace Team_ConsolREDkey
{
    class EntryINT
    {
        //attributs
        protected int m_EntryINT;

        //constructeur
        public EntryINT( int m_EntryINT)
        {
            this.m_EntryINT = m_EntryINT;
        }

        //destructeur
        ~EntryINT()
        {
        }

        //méthode
        public void Set_m_EntryINT(int m_EntryINT)
        {
            this.m_EntryINT = m_EntryINT;
        }

        public int Get_m_EntryINT(int m_EntryINT)
        {
            return m_EntryINT;
        }

        public int Result(int m_EntryINT)
        {
            if (m_EntryINT == 0)
            {
                while (m_EntryINT == 0)
                {
                    Console.Write("erreur, l'entrée est nul, veuillez saisir une nouvelle variable: ");
                    m_EntryINT = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                }
            }
            else
            {
                m_EntryINT = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Done. ");
            return m_EntryINT;
        }

    }
}