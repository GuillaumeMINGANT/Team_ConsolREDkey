using System;
using System.Collections.Generic;
using System.Text;

namespace Team_ConsolREDkey
{
    class exercice5_8
    {
        //Attributs
        protected int m_exercice5_8;
        //Constructeur
        public exercice5_8(int m_exercice5_8)
        {
            this.m_exercice5_8 = m_exercice5_8;
        }
        //destructeur
        ~exercice5_8()
        {

        }
        //Methode
        public void set_m_exercice5_8(int m_exercice5_8)
        {
            this.m_exercice5_8 = m_exercice5_8;
        }
        public int Get_m_m_Exercice5_8()
        {
            return m_exercice5_8;
        }

        public void Max_in_20_entry()
        {
            EntryINT e1 = new EntryINT(0);

            for (int i = 0; i<20; i++)
            {
                m_exercice5_8 = 0;
                Console.Write("nombre numero "+i+" : ")
                int value = e1.Result(0);
                Console.Write(value);
                if (m_exercice5_8==0)
                {

                }
            }
            return m_exercice5_8;
        }
    }
}
