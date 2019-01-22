using System;
using System.Collections.Generic;
using System.Text;

namespace Team_ConsolREDkey
{
    class exercice5_7
    {
        //Attributs
        protected int m_exercice5_7;
        //Constructeur
        public exercice5_7(int m_exercice5_7)
        {
            this.m_exercice5_7 = m_exercice5_7;
        }
        //destructeur
        ~exercice5_7()
        {

        }
        //Methode
        public void set_m_exercice5_7(int m_exercice5_7)
        {
            this.m_exercice5_7 = m_exercice5_7;
        }
        public int Get_m_m_Exercice5_7()
        {
            return m_exercice5_7;
        }
        public int factoriel()
        {
            for(int i=1; i < m_exercice5_7+1;i++)
            {
                m_exercice5_7 = m_exercice5_7*i;
            }
            return m_exercice5_7;
        }
            

    }
}
