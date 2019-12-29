using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTunesAPICalls
{
    //The object that iTunes API response in the list
    class ITunesItem
    {
        String wrapperType;
        String kind;
        int artistId;
        int collectionId;
        int trackId;
        String artistName;
        String collectionName;
        String trackName;
        String collectionCensoredName;
        String trackCensoredName;
        String artistViewUrl;
        String collectionViewUrl;
        String trackViewUrl;
        String previewUrl;
        String artworkUrl60;
        String artworkUrl100;
        String collectionPrice;
        String trackPrice;
        String collectionExplicitness;
        String trackExplicitness;
        int discCount;
        int discNumber;
        int trackCount;
        int trackNumber;
        int trackTimeMillis;
        String country;
        String currency;
        String primaryGenreName;

        public string WrapperType { get => wrapperType; set => wrapperType = value; }
        public string Kind { get => kind; set => kind = value; }
        public int ArtistId { get => artistId; set => artistId = value; }
        public int CollectionId { get => collectionId; set => collectionId = value; }
        public int TrackId { get => trackId; set => trackId = value; }
        public string ArtistName { get => artistName; set => artistName = value; }
        public string CollectionName { get => collectionName; set => collectionName = value; }
        public string TrackName { get => trackName; set => trackName = value; }
        public string CollectionCensoredName { get => collectionCensoredName; set => collectionCensoredName = value; }
        public string TrackCensoredName { get => trackCensoredName; set => trackCensoredName = value; }
        public string ArtistViewUrl { get => artistViewUrl; set => artistViewUrl = value; }
        public string CollectionViewUrl { get => collectionViewUrl; set => collectionViewUrl = value; }
        public string TrackViewUrl { get => trackViewUrl; set => trackViewUrl = value; }
        public string PreviewUrl { get => previewUrl; set => previewUrl = value; }
        public string ArtworkUrl60 { get => artworkUrl60; set => artworkUrl60 = value; }
        public string ArtworkUrl100 { get => artworkUrl100; set => artworkUrl100 = value; }
        public string CollectionPrice { get => collectionPrice; set => collectionPrice = value; }
        public string TrackPrice { get => trackPrice; set => trackPrice = value; }
        public string CollectionExplicitness { get => collectionExplicitness; set => collectionExplicitness = value; }
        public string TrackExplicitness { get => trackExplicitness; set => trackExplicitness = value; }
        public int DiscCount { get => discCount; set => discCount = value; }
        public int DiscNumber { get => discNumber; set => discNumber = value; }
        public int TrackCount { get => trackCount; set => trackCount = value; }
        public int TrackNumber { get => trackNumber; set => trackNumber = value; }
        public int TrackTimeMillis { get => trackTimeMillis; set => trackTimeMillis = value; }
        public string Country { get => country; set => country = value; }
        public string Currency { get => currency; set => currency = value; }
        public string PrimaryGenreName { get => primaryGenreName; set => primaryGenreName = value; }

        public String toString()
        {
            return "ITunesItem [wrapperType=" + wrapperType + ", kind=" + kind + ", artistId=" + artistId
                    + ", collectionId=" + collectionId + ", trackId=" + trackId + ", artistName=" + artistName
                    + ", collectionName=" + collectionName + ", trackName=" + trackName + ", collectionCensoredName="
                    + collectionCensoredName + ", trackCensoredName=" + trackCensoredName + ", artistViewUrl="
                    + artistViewUrl + ", collectionViewUrl=" + collectionViewUrl + ", trackViewUrl=" + trackViewUrl
                    + ", previewUrl=" + previewUrl + ", artworkUrl60=" + artworkUrl60 + ", artworkUrl100=" + artworkUrl100
                    + ", collectionPrice=" + collectionPrice + ", trackPrice=" + trackPrice + ", collectionExplicitness="
                    + collectionExplicitness + ", trackExplicitness=" + trackExplicitness + ", discCount=" + discCount
                    + ", discNumber=" + discNumber + ", trackCount=" + trackCount + ", trackNumber=" + trackNumber
                    + ", trackTimeMillis=" + trackTimeMillis + ", country=" + country + ", currency=" + currency
                    + ", primaryGenreName=" + primaryGenreName + "]";
        }

    }
}
