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

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Movie> movieList;
        public MainWindow()
        {
            InitializeComponent();

            movieList = new List<Movie>();
        }

        private void buttonAddMovie_Click(object sender, RoutedEventArgs e)
        {
            string name = MovieName.Text;
            int year = Convert.ToInt32(ReleaseYear.Text);
            double length = Convert.ToDouble(MovieLength.Text);
            Movie newMovie = new MovieList.Movie(name, year, length);
            movieList.Add(newMovie);
            MovieName.Clear();
            ReleaseYear.Clear();
            MovieLength.Clear();
        }

        private void buttonReleaseYear_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie mov in movieList)
            {
                mov.ShowMovie();
            }
        }


    }
}
