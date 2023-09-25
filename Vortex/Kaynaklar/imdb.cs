using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Vortex
{
    class imdb
    {
        public string title { get; set; }//aktarım değişkenleri
        public string year { get; set; }
        public string rated { get; set; }
        public string released { get; set; }
        public string runtime { get; set; }
        public string genre { get; set; }
        public string director { get; set; }
        public string writer { get; set; }
        public string actors { get; set; }
        public string description { get; set; }
        public string language { get; set; }
        public string country { get; set; }
        public string award { get; set; }
        public string poster { get; set; }
        public string metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }

        public void xmlokuma(string id)
        {
            string reader = new WebClient().DownloadString("https://raw.githubusercontent.com/kmlsygn01/ArcHive/master/vortex/apikey");//anahtar kod
            string link = "http://www.omdbapi.com/?i=" + id + "&r=xml&apikey=" + reader;//site xml çekim adresi

            XmlReader xmlreader = XmlReader.Create(link);//xml veri tanımlama ve çekme
            while (xmlreader.Read())//okunan veriler
            {
                if ((xmlreader.NodeType == XmlNodeType.Element) && (xmlreader.Name == "movie"))//movie sınıf içeriğini çek
                {
                    if (xmlreader.HasAttributes)
                    {
                        //içerikleri değişkenlere aktar
                        title = xmlreader.GetAttribute("title");
                        rated = xmlreader.GetAttribute("rated");
                        year = xmlreader.GetAttribute("year");
                        released = xmlreader.GetAttribute("relased");
                        runtime = xmlreader.GetAttribute("runtime");
                        genre = xmlreader.GetAttribute("genre");
                        director = xmlreader.GetAttribute("director");
                        writer = xmlreader.GetAttribute("writer");
                        actors = xmlreader.GetAttribute("actors");
                        description = xmlreader.GetAttribute("plot");
                        language = xmlreader.GetAttribute("language");
                        country = xmlreader.GetAttribute("country");
                        award = xmlreader.GetAttribute("award");
                        poster = xmlreader.GetAttribute("poster");
                        metascore = xmlreader.GetAttribute("metascore");
                        imdbRating = xmlreader.GetAttribute("imdbRating");
                        imdbVotes = xmlreader.GetAttribute("imdbVotes");

                    }
                }
            }
        }
    }
}
