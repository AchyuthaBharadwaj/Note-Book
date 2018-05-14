using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notebook.Models;

namespace Notebook.Models.HomeViewModels
{
    public class AnimeModel
    {
        public List<Anime> Anime { get; set; }

        public AnimeModel()
        {
            Anime = new List<Anime>();
        }

        public AnimeModel(List<Anime> anime)
        {
            Anime = anime;
        }

        public AnimeModel Get_Fav()
        {
            this.Anime.Add(new Anime(1, "Death Note", "~/images/Anime/death-note.jpg"));
            this.Anime.Add(new Anime(2, "Attack on Titan", "~/images/Anime/attack-on-titan.jpg"));
            this.Anime.Add(new Anime(3, "One Piece", "~/images/Anime/one-piece.jpg"));
            this.Anime.Add(new Anime(4, "Naruto", "~/images/Anime/naruto.jpg"));
            this.Anime.Add(new Anime(5, "Fairy Tail", "~/images/Anime/fairy-tail.jpg"));
            this.Anime.Add(new Anime(6, "Bleach", "~/images/Anime/bleach.jpg"));
            this.Anime.Add(new Anime(7, "Aldnoah Zero", "~/images/Anime/aldnoah-zero.jpg"));
            this.Anime.Add(new Anime(8, "Magi", "~/images/Anime/magi.jpg"));
            return this;
        }
    }
}
