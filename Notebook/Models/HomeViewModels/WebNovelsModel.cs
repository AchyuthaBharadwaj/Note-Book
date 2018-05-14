using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notebook.Models;

namespace Notebook.Models.HomeViewModels
{
    public class WebNovelsModel
    {
        public List<WebNovel> WebNovels { get; set; }

        public WebNovelsModel()
        {
            WebNovels = new List<WebNovel>();
        }

        public WebNovelsModel(List<WebNovel> webNovels)
        {
            WebNovels = webNovels;
        }

        public WebNovelsModel Get_Fav()
        {
            this.WebNovels.Add(new WebNovel(1, "Martial World", "~/images/WebNovels/mw.jpg"));
            this.WebNovels.Add(new WebNovel(2, "Coiling Dragon", "~/images/WebNovels/cd.jpg"));
            this.WebNovels.Add(new WebNovel(3, "I Shall Seal The Heavens", "~/images/WebNovels/issth.jpg"));
            this.WebNovels.Add(new WebNovel(4, "Stellar Transformations", "~/images/WebNovels/st.jpg"));
            this.WebNovels.Add(new WebNovel(5, "True Martial World", "~/images/WebNovels/tmw.jpg"));
            this.WebNovels.Add(new WebNovel(6, "Battle Through The Heavens", "~/images/WebNovels/btth.jpg"));
            this.WebNovels.Add(new WebNovel(7, "Against The Gods", "~/images/WebNovels/atg.jpg"));
            this.WebNovels.Add(new WebNovel(8, "Ancient Godly Monarch", "~/images/WebNovels/agm.jpg"));
            return this;
        }
    }
}
