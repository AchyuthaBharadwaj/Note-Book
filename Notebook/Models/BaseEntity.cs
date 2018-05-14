using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook.Models
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
        }

        public BaseEntity(int id, string name, string icoUri, string desc, 
            string airDate, string bannerUri, string genres, double rating) : this(id, name, icoUri)
        {
            Desc = desc;
            AirDate = airDate;
            BannerUri = bannerUri;
            Genres = genres;
            Rating = rating;
        }

        protected BaseEntity(int id, string name, string icoUri)
        {
            Id = id;
            Name = name;
            IcoUri = icoUri;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string IcoUri { get; set; }
        public string Desc { get; set; }
        public string AirDate { get; set; }
        public string BannerUri { get; set; }
        public string Genres { get; set; }
        public double Rating { get; set; }
    }
}
