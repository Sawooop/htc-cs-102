using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksonLang_sChakraAligningProject
{
    class BaseSearch
    {
        private string Search;
        public BaseSearch(string sarch)
        {
            Search = sarch;
        }
        public void WikipediaPage()
        {

            Search.Replace(" ", "_");
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/" + Search);
            //analyze wiki page for keywords
            //make a few base classes (people, animals, objects, etc) based on the keywords
            //create a summary of the search in a window that appears alongside the wiki page
        }
        public void Question()
        {
            //search google or maybe look up wiki for keywords and return a window that rooughly answers the question
        }
    }
}
