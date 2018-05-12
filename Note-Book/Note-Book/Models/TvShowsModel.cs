using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Note_Book.Entity;

namespace Note_Book.Models
{
    public class TvShowsModel
    {
        public List<TvShow> TvShows { get; set; }

        public TvShowsModel()
        {
            TvShows = new List<TvShow>();
        }

        public TvShowsModel(List<TvShow> tvShow)
        {
            TvShows = tvShow;
        }

        public TvShowsModel Get_Fav()
        {
            this.TvShows.Add(new TvShow(1, "Altered Carbon", "~/images/tv-shows/ac.jpg"));
            this.TvShows.Add(new TvShow(2, "Breaking Bad", "~/images/tv-shows/bb.jpg"));
            this.TvShows.Add(new TvShow(3, "The Big Bang Theory", "~/images/tv-shows/bbt.jpg"));
            this.TvShows.Add(new TvShow(4, "Game of Thrones", "~/images/tv-shows/got.jpg"));
            this.TvShows.Add(new TvShow(5, "Supernatural", "~/images/tv-shows/sn.jpg"));
            this.TvShows.Add(new TvShow(6, "Stranger Things", "~/images/tv-shows/st.jpg"));
            this.TvShows.Add(new TvShow(7, "The Vampire Diaries", "~/images/tv-shows/vd.jpg"));
            this.TvShows.Add(new TvShow(8, "White Caller", "~/images/tv-shows/wc.jpg"));
            return this;
        }
    }
}
