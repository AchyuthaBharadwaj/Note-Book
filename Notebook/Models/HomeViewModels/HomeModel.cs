using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Models.HomeViewModels
{
    public class HomeModel
    {
        public AnimeModel AnimeModel { get; set; }
        public WebNovelsModel WebNovelsModel { get; set; }
        public TvShowsModel TvShowsModel { get; set; }
        public PcGamesModel PcGamesModel { get; set; }
        public XboxGamesModel XboxGamesModel { get; set; }

        public HomeModel()
        {
            AnimeModel = new AnimeModel().Get_Fav();
            WebNovelsModel = new WebNovelsModel().Get_Fav();
            TvShowsModel = new TvShowsModel().Get_Fav();
            PcGamesModel = new PcGamesModel().Get_Fav();
            XboxGamesModel = new XboxGamesModel().Get_Fav();
        }
    }
}
