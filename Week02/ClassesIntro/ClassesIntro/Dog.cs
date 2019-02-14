using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Dog
    {
        public string Breed;
        public int height;
        public string name;

        public void Bark()
        {
            MessageBox.Show("No");
        }
        public void SayName()
        {
            MessageBox.Show("My name is " + name);
        }
    }
}