using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        private string Name;
        private int ReleaseDate;
        private double RunTime;
        public Movie(string name, int releaseDate, double runTime)
        {
            Name = name;
            ReleaseDate = releaseDate;
            RunTime = runTime;
        }
        public void ShowMovie()
        {
            MessageBox.Show(Name + Environment.NewLine + ReleaseDate + "\n" + RunTime);
        }
    }
}
