using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTunesAPICalls
{
    class ResponseObject
    {
        //Number of results it the list
        int resultCount;
        //List of results
        ITunesItem[] results;

        ResponseObject()
        {

        }

        public int ResultCount { get => resultCount; set => resultCount = value; }
        internal ITunesItem[] Results { get => results; set => results = value; }
    }
}
