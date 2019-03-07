using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Froggo : Aminal
    {
        public bool Poison;
        public Froggo()
        {

        }
        public void RIBBIT()
        {
            MessageBox.Show("AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH");
            MessageBox.Show("RIBBIT");
        }
        public void isPoisonous()
        {
            if (Poison == true)
            {
                MessageBox.Show("he poisonouse");
            }
            else
            {
                MessageBox.Show("Un GUD frogger");
            }
        }
        public Froggo(int height, string name, bool poison)
        {
            Poison = poison;
            Height = height;
            Name = name;
        }
    }
}
