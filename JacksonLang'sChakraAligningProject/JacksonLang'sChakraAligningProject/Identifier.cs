using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JacksonLangsChakraAligningProject
{
    public class Identifier
    {
        string LongString;
        string ahhh;
        public Identifier(string streng, string sar)
        {
            LongString = streng;
            ahhh = sar;
        }



        public void Identify()
        {
            WikiPage identifiedItem = null;

            if (LongString.IndexOf("genus  =") > -1 || LongString.IndexOf("authority = ") > -1 || LongString.IndexOf("Felis") > -1)
            {
                Animal ehh= new Animal();
                ehh.Inform(LongString, ahhh);
                //WikiPage wiki = new WikiPage();
                

            }
            else if (LongString.IndexOf("birth_date = ") > -1 || LongString.IndexOf("birth") > -1)
            {
                Person ga = new Person();
                ga.Inform(LongString, ahhh);
            }
            else if (LongString.IndexOf("chemical element") > -1)
            {
                MessageBox.Show("You searched for the chemical element " + ahhh);
            }
            else
            {
                MessageBox.Show("As of now, I cannot determine what you searched. \nMake sure you are capitalizing each letter. \nIf you still see this message, dont fret:\nTHis program is still not complete");
            }
            //return identifiedItem;
        }


    }
}
