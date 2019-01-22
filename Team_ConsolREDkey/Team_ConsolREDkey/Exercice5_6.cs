using System;
using System.Collections.Generic;
using System.Text;

namespace Team_ConsolREDkey
{
    class Exercice5_6
    {
        //Attributs
        protected int m_Exercice5_6;
        //Constructeur
        public Exercice5_6(int m_Exercice5_6)
        {
            this.m_Exercice5_6 = m_Exercice5_6;
        }
        //destructeur
        ~Exercice5_6()
        {

        }
        //Methode
        public void set_m_Exercice5_6(int m_Exercice5_6)
        {
            this.m_Exercice5_6 = m_Exercice5_6;
        }

        public int SommeENTIER()
        {
            for (int i = 0; i < m_Exercice5_6 + 1; i++)
            {
                m_Exercice5_6 += i;
            }

            return m_Exercice5_6;
        }
    }
}
