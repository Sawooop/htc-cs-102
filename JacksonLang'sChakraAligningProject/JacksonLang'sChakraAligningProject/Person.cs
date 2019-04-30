using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JacksonLangsChakraAligningProject
{
    class Person
    {



        string sent;

        public string ImageURL
        {
            get;

            set;
        }

        public string Information
        {
            get;


            set;

        }

        public void Inform(string oof, string sarc)
        {
            string output = "";
            output += "You searched for a Person!\nTheir name is " + sarc+"\n";
            string bir = oof.Substring(oof.IndexOf("birth_date") + 50);
            output += "Birth Place " + bir.Substring(0, bir.IndexOf("|"));
            MessageBox.Show(output);
        }
    }
}

