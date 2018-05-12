using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Note_Book.Entity;

namespace Note_Book.Models
{
    public class PcGamesModel
    {
        public List<PcGame> PcGames { get; set; }

        public PcGamesModel()
        {
            PcGames = new List<PcGame>();
        }

        public PcGamesModel(List<PcGame> pcGames)
        {
            PcGames = pcGames;
        }

        public PcGamesModel Get_Fav()
        {
            this.PcGames.Add(new PcGame(1, "Assassin's Creed", "~/images/pc-games/ac2.jpg"));
            this.PcGames.Add(new PcGame(2, "GTA V", "~/images/pc-games/gta5.jpg"));
            this.PcGames.Add(new PcGame(3, "Counter Strike", "~/images/pc-games/cs-go.jpeg"));
            this.PcGames.Add(new PcGame(4, "Dota 2", "~/images/pc-games/dota2.jpg"));
            this.PcGames.Add(new PcGame(5, "Farcry 5", "~/images/pc-games/far-cry-5.jpg"));
            this.PcGames.Add(new PcGame(6, "Overwatch", "~/images/pc-games/over-watch.jpg"));
            this.PcGames.Add(new PcGame(7, "Rocket League", "~/images/pc-games/rl.jpg"));
            this.PcGames.Add(new PcGame(8, "World of Warcraft", "~/images/pc-games/wow.jpg"));
            return this;
        }
    }
}
