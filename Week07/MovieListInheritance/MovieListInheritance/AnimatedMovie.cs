using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    class AnimatedMovie : Movie
    {
        public string AnimationStudio
        {
            get;
            set;
        }
        public string AnimationType
        {
            get;
            set;
        }
        public AnimatedMovie(string myTitle, int myReleaseYear, string myAnimationStudio, string myAnimationType)
        {
            this.AnimationStudio = myAnimationStudio;
            this.AnimationType = myAnimationType;
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
        }
        public override void ShowDetails()
        {
            //string ahhh = "Animated movie Info::\nMovie Name :: " + Title + " Release Year :: " + ReleaseYear + " Animation Studio :: " + AnimationStudio + " Animation Type :: " + AnimationType;
            //MessageBox.Show(ahhh);
            string uhhh = Title;
            uhhh.Replace(" ", "_");
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/" +uhhh);
        }
    }
}
