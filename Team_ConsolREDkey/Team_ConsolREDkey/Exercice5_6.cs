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
        public Exercice5_6()
        {

        }
        //destructeur
        ~Exercice5_6()
        {

        }
        //Methode
        public int SommeENTIER(int select)
        {
            EntryINT
            select = EntryINT.Result(0);

            for (int i = 0; i < select + 1; i++)
            {
                m_Exercice5_6 += i;
            }

            return m_Exercice5_6;
        }
    }
}
