using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace iTunesAPICalls
{
    class APICallMethods
    {
        //Holds the API URL
        String apiUrl;

        private static APICallMethods instance = null;

        private APICallMethods()
        {
            //API URL initialization
            apiUrl = "https://itunes.apple.com/search?";
        }

        public static APICallMethods getInstance()
        {
            if (instance == null)
            {
                instance = new APICallMethods();
            }
            return instance;
        }

        //Search 
        public ITunesItem[] search(String searchText)
        {
            searchText = searchText.Replace(" ", "+");
		    String query = "term=" + searchText;
		    return searchQuery(query);
        }

        //Search with more than 1 key 
        public ITunesItem[] searchMultipleKey(String searchText, String country, String media)
        {
            searchText = searchText.Replace(" ", "+");
            String query = "term=" + searchText;
		    if(!string.IsNullOrEmpty(country))

            {
                query = query + "&country=" + country;
            }
		    if(!string.IsNullOrEmpty(media))

            {
                query = query + "&media=" + media;
            }
		    return searchQuery(query);
        }

        //Get Albums 1 and more 
        public ITunesItem[] getAlbums(String searchText)
        {
            searchText = searchText.Replace(" ", "+");
            String query = "term=" + searchText + "&entity=album&attribute=albumTerm";
		    return searchQuery(query);
        }

        //Get Artist 1 and more
        public ITunesItem[] getArtists(String searchText)
        {
            searchText = searchText.Replace(" ", "+");
            String query = "term=" + searchText + "&entity=musicArtist&attribute=artistTerm";
		    return searchQuery(query);
        }

        private ITunesItem[] searchQuery(String query)
        {
            ResponseObject responseObject = null;
            ITunesItem[] result = null;


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl + query);

            request.Method = "GET";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string str = reader.ReadToEnd();
                    responseObject = JsonConvert.DeserializeObject<ResponseObject>(str);
                    result = responseObject.Results;
                }
                else
                {
                    Console.WriteLine("ERROR: Connection refused");
                }
            }

	        return result;
	    }
    }
}