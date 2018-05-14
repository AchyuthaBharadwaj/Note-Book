using System;
using System.Collections.Generic;

namespace Notebook.Models
{
    public class Anime : BaseEntity
    {
        public Dictionary<string, string> Related { get; set; }
        public List<string> Links { get; set; }
        public string AuthorName { get; set; }
        public int NumEpisodes { get; set; }
        
        public Anime()
        {
            Related = new Dictionary<string, string>();
            Links = new List<string>();
        }

        public Anime(int id, string name, string icoUri) : base(id, name, icoUri)
        {
            Related = new Dictionary<string, string>();
            Links = new List<string>();
        }

        public Anime(int id, string name, string icoUri, string desc,
            string airDate, string bannerUri, string genres, string authorName,
            int numEpisodes, double rating): base(id, name, icoUri, desc, airDate, bannerUri, genres, rating)
        {
            Related = new Dictionary<string, string>();
            Links = new List<string>();
            AuthorName = authorName;
            NumEpisodes = numEpisodes;
        }

        public Anime(int id, string name, string icoUri, string desc,
            string airDate, string bannerUri, string genres, string authorName,
            int numEpisodes, double rating, Dictionary<string, string> related, List<string> links) : base(id, name, icoUri, desc, airDate, bannerUri, genres, rating)
        {
            Related = related;
            Links = links;
            AuthorName = authorName;
            NumEpisodes = numEpisodes;
        }

        public Anime get_fav()
        {
            Id = 1;
            Name = "Fairy Tail";
            IcoUri = "~/images/Anime/fairy-tail/ico.jpg";
            Desc = "Set in an imaginary world, the Earth Land, there exists a Mage Guild called \"Fairy Tail\". Fairy Tail is stationed in the town Magnolia, residing in the Kingdom of Fiore, and is currently governed by Makarov, Guild's master."
                + "\r\n\r\n" +
                "Lucy Heartfilia, a 17 - year old girl, wishes to become a full-fledged mage and join one of the most prestigious Mage Guilds in the world, Fairy Tail."
                + "\r\n\r\n" +
                "One day, out of pure coincidence, she meets Dragneel Natsu, a boy who is transportation - sick, but very cheerful in nature.However, the thing she does not know is that Natsu is the closest connection to Fairy Tail, as he is a Mage in Fairy Tail.";

            AirDate = "Aug 23, 2006";
            BannerUri = "~/images/Anime/fairy-tail/banner.jpg";
            Genres = "Action;Adventure;Comedy;Ecchi;Fantasy";
            AuthorName = "Hiro Mashima";
            NumEpisodes = 277;
            Rating = 3.7;
            Related.Add("Fairy Tail 2014", "~/images/Anime/fairy-tail/fairy-tail-2014.jpg");
            Related.Add("Fairy Tail Zero","~/images/Anime/fairy-tail/fairy-tail-zero.jpg");
            Related.Add("Fairy Tail Movie: Phoenix Priestess", "~/images/Anime/fairy-tail/fairy-tail-movie-1.jpg");
            Related.Add("Fairy Tail Movie: Dragon Cry", "~/images/Anime/fairy-tail/fairy-tail-movie-2.jpg");
            Links.Add("http://kissanime.ru/Anime/Fairy-Tail");
            Links.Add("http://www.animeshow.tv/Fairy-Tail/");
            return this;
        }
    }
}
