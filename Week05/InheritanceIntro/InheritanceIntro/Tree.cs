using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Tree : Organism
    {
        public bool GARBAGE;

        public Tree()
        {
            GARBAGE = true;
        }

        public void NotGarbage()
        {
            GARBAGE = false;
        }

        public void IsDumb()
        {
            MessageBox.Show("IM AN IMMOBILE PLANT HAHAHA I actually enjoyed suicide squad seriously what must be wrong with you to photosynthesize??????? oxygen >>>>>>>>>>>>>>>>>>>> co2 MADE BY AMINAL/protea/fungi/archea GANG");
        }

        public override string ToString()
        {
            return "Is this Tree Garbage? " + GARBAGE;
        }
    }
}
