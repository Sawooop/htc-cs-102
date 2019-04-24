using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksonLangsChakraAligningProject
{
    public class WikiPage
    {
        public string title { get; set; }
        public string extract { get; set; }
        public string[] originalimage { get; set; }

        public string ImageURL { get { return originalimage[0]; } }


        //public string info ()
    }
}
