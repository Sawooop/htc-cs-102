using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Duck : Aminal
    {

        public Duck()
        {

        }
        public void Quack()
        {
            MessageBox.Show(this.ToString());

        }



        public Duck(int height, string name)
        {
            Height = height;
            Name = name;
        }
    }
}
