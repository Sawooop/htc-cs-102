using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksonLangsChakraAligningProject
{
    public class Identifier
    {
        string LongString;
        public Identifier(string streng)
        {
            LongString = streng;
        }



        public WikiPage Identify()
        {
            WikiPage identifiedItem = null;

            if (LongString.IndexOf("genus  =") > -1 || LongString.IndexOf("authority = ") > -1)
            {
                identifiedItem = new Animal();
                //identifiedItem.Information = 

            }

            return identifiedItem;
        }


    }
}
