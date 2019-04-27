using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.ObjectModel;
using System.Diagnostics;
using APIExperiment.Models;


namespace APIExperiment.Models
{
    public class ArtsyCallDocs
    {
        public ArtsyCallDocs()
        {
        }

		private static string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJyb2xlcyI6IiIsImV4cCI6MTU1NjkzMTg3MywiaWF0IjoxNTU2MzI3MDczLCJhdWQiOiI1YWUxMGUyM2NiNGMyNzZkNDY5MzQ4NDEiLCJpc3MiOiJHcmF2aXR5IiwianRpIjoiNWNjM2FhYTEyZTAwNjExZDc1MWFiOGU2In0.ysrjYlSm2lBXAxSnSqNqcGpDst7HPxeRUXQLjBVArLY";
        public static async Task<ObservableCollection<Artists>> getArtistDocs(string searchUrl, HttpsStack stack )
        {
            ObservableCollection<Artists> Artist = new ObservableCollection<Artists>();

            var client = new HttpClient();


            client.DefaultRequestHeaders.Add("X-Xapp-Token", token);
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.artsy-v2+json");
            var uri = new Uri(searchUrl);

            var result = await client.GetStringAsync(uri);
            ResultsBack deserialized = JsonConvert.DeserializeObject<ResultsBack>(result);


            stack.Push(deserialized._links.self.href, deserialized._links.next.href);
            ObservableCollection<Artists> artistsList=  deserialized._embedded.artists;

            return artistsList;


        }

        //USED FOR PREVIOUS PAGE COMMAND3
        /// <summary>
        /// Used for Previous Page command. Since we use a stack to keep track
        /// of HTPPS request url's, we need to pop the current,
        /// then move to previous node, which contains the url that will be used to
        /// call the desired page. Since we do not wish to push anything, we just pass 
        /// the new root's SelfHTPS parameter. 
        /// </summary>
        /// <returns>list of artist documents.</returns>
        public static async Task<ObservableCollection<Artists>> getArtistDocs(string searchUrl)
        {
            ObservableCollection<Artists> Artist = new ObservableCollection<Artists>();

            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("X-Xapp-Token", token);
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.artsy-v2+json");
            var uri = new Uri(searchUrl);

            var result = await client.GetStringAsync(uri);
            ResultsBack deserialized = JsonConvert.DeserializeObject<ResultsBack>(result);


            ObservableCollection<Artists> artistsList = deserialized._embedded.artists;

            return artistsList;
        }


    }



//INFO OF ARTISTS TO BE USED
    public class Artists
    {
        public Artists()
        {
            
        }

        public string id { get; set; }
        public string slug { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string biography { get; set; }
        public string birthday { get; set; }
        public string deathday { get; set; }
        public string hometown { get; set; }
        public string sortable_name { get; set; }
        public string location { get; set; }
        public string nationality { get; set; }
        public string next { get; set; }
        public string[] image_version { get; set; } 
        public LinksArtists _links { get; set; }

    }

    public class LinksArtists
    {
        
        public Interior permalink { get; set; }
        public Interior artworks { get; set; }
        public Interior published_artworks { get; set; }
        public Interior similar_artists { get; set; }
    }


    public class ArtWorks
    {
        public bool published { get; set; }
        public string title { get; set; }
        public LinksArtWorks _links { get; set; }

    }

    public class LinksArtWorks
    {
        public Interior permalink { get; set; }
        public Interior image { get; set; }
    }

    public class EmbeddedWorks
    {

        public string id { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public bool published { get; set; }
    }

//END OF INFO OF ARTISTS TO BE USED




    //START OF CLASSES OF WHAT THE HTTPS REQUEST RETURNS
    public class ResultsBack
    {
        ResultsBack() { }

        public Embedded _embedded { get; set; }
        public LinksResult _links { get; set; }
        public Object _total_count { get; set; }
       // public string next { get; set; }

    }

    public class Embedded
    {

        public ObservableCollection<Artists> artists;
    }

    public class LinksResult
    {
        public Interior self { get; set; }
        public Interior next { get; set; }
    }

    public class Interior 
    {
        public string href { get; set; }
    }
    //END OF CLASSES OF WHAT THE HTTPS REQUEST RETURNS

}
