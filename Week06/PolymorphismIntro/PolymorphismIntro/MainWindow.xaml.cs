using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;

        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();
            Frog frog = new Frog(4, "Kermit", false, 100);
            Dog dog = new Dog("Muppet", 20, "Rolf", 150);
            Duck duck = new Duck(9, "Donald", 1200000);
            Dog dogs = new Dog("red boy", 200, "Clifford", 1000);
            Duck ducks = new Duck(5, "Daffy", 60);
            Frog frogs = new Frog(3, "Jeremiah", false, 15);

            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);
            Animals.Add(dogs);
            Animals.Add(frogs);
            Animals.Add(ducks);

            lvAnimals.ItemsSource = Animals;

        }
        private void lvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                selectedAnimal.ShowInfo();
            }
        }



        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Animal a in Animals)
            {
                a.SayName();
            }
        }


        
    }
}
