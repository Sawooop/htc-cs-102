using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PolymorphismIntro
{
    public class Duck : Animal
    {
        public override void Speak()
        {
            MessageBox.Show("Quack");
        }

        public Duck() { }

        public Duck(int height, string name, int weight)
        {
            this.Height = height;
            this.Name = name;
            this.Weight = weight;
            ImageSource = "https://images-na.ssl-images-amazon.com/images/I/8166xCVDGnL._SY355_.jpg";

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Window3 p = new Window3();
            //
            p.info.Text = "Name ::" + Name + " Weight ::" + Weight + " Height ::" + Height;

            p.Show();
            //MessageBox.Show("Name ::" + Name +  " Weight ::" + Weight + " Height ::" + Height);
        }
    }
}