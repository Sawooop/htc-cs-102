using JacksonLangsChakraAligningProject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JacksonLang_sChakraAligningProject
{
    class BaseSearch
    {
        private string Search;
        public WikiPage wp;
        public BaseSearch(string sarch)
        {
            Search = sarch.Replace(' ', '_'); ;
        }
        public async void  WikipediaPage()
        {

            {
                // Create a New HttpClient object and dispose it when done, so the app doesn't leak resources
                using (HttpClient client = new HttpClient())
                {
                    // Call asynchronous network methods in a try/catch block to handle exceptions
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync("https://en.wikipedia.org/api/rest_v1/page/summary/"+Search);
                        HttpResponseMessage reeesponse = await client.GetAsync("https://en.wikipedia.org/w/api.php?action=query&prop=revisions&rvprop=content&format=xmlfm&titles="+Search+"&rvsection=0");
                        string gaaa = await reeesponse.Content.ReadAsStringAsync();
                        //MessageBox.Show(gaaa);
                        Identifier Id = new Identifier(gaaa);
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        // Above three lines can be replaced with new helper method below
                        // string responseBody = await client.GetStringAsync(uri);
                        wp = JsonConvert.DeserializeObject<WikiPage>(responseBody);

                        //MessageBox.Show(responseBody);
                    }
                    catch (HttpRequestException e)
                    {
                        Console.WriteLine("\nException Caught!");
                        Console.WriteLine("Message :{0} ", e.Message);
                    }
                }
            }

            Search.Replace(" ", "_");
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/" + Search);
            //analyze wiki page for keywords
            //make a few base classes (people, animals, objects, etc) based on the keywords
            //create a summary of the search in a window that appears alongside the wiki page
        }
        public IIndentified Question()
        {
            //search google or maybe look up wiki for keywords and return a window that rooughly answers the question
        }

    }
}
