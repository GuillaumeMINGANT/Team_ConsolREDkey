using System;
using System.Collections.Generic;
using System.Text;

namespace Team_ConsolREDkey
{
    class EntryINT
    {
        //attributs
        protected int m_verifEQUAL0;
        protected int m_EntryINT;

        //constructeur
        public EntryINT(int m_verifEQUAL0, int m_EntryINT)
        {
            this.m_EntryINT = m_EntryINT;
        }

        //destructeur
        ~EntryINT()
        {
            this.m_verifEQUAL0 = m_verifEQUAL0;
        }

        //méthode
        public void Set_m_EntryINT(int m_EntryINT)
        {
            this.m_EntryINT = m_EntryINT;
        }
        public void Set_m_verifEQUAL0(int m_verifEQUAL0)
        {
            this.m_verifEQUAL0 = m_verifEQUAL0;
        }

        public int Get_m_EntryINT(int m_EntryINT)
        {
            return m_EntryINT;
        }
        public int Get_m_verifEQUAL0(int m_verifEQUAL0)
        {
            return m_verifEQUAL0;
        }

        public int Result(int m_EntryINT)
        {
            if (m_EntryINT == 0)
            {
                while (m_EntryINT == 0)
                {
                    Console.Write("erreur, l'entrée est nul, veuillez saisir une nouvelle variable: ");
                    m_verifEQUAL0 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                }
            }
            else
            {
                m_verifEQUAL0 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Done. ");
            return m_verifEQUAL0;
        }

    }
}