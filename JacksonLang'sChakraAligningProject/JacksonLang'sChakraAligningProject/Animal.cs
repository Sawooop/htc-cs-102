using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JacksonLangsChakraAligningProject
{
    class Animal : WikiPage
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
            
            string small = oof.Substring(oof.IndexOf("name = ")+7);
            string speci = oof.Substring(oof.IndexOf("species = ") + 10);
            output += "You searched for an animal \n";
            output += "name = " + sarc+"\n";
            output += "species = " + speci.Substring(0,speci.IndexOf("|")-1);
            MessageBox.Show(output);
        }
    }
}
