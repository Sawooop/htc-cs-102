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
        public Dog(string name, string breed, int height, bool isGoodDoggo)
        {
            IsGoodDoggo = true;
            Name = name;
            Breed = breed;
            Height = height;

        }
        
        public void Bark()
        {
            MessageBox.Show("No");
        }
        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }










































































        public string Breed;
        public int Height;
        public string Name;
        public bool IsGoodDoggo;






























































































    }
}