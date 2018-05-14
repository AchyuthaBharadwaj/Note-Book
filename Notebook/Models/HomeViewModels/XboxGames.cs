using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notebook.Models;

namespace Notebook.Models.HomeViewModels
{
    public class XboxGamesModel
    {
        public List<XboxGame> XboxGames { get; set; }

        public XboxGamesModel()
        {
            XboxGames = new List<XboxGame>();
        }

        public XboxGamesModel(List<XboxGame> pcGames)
        {
            XboxGames = pcGames;
        }

        public XboxGamesModel Get_Fav()
        {
            this.XboxGames.Add(new XboxGame(1, "Call Of Duty", "~/images/xbox-games/call-of-duty.jpg"));
            this.XboxGames.Add(new XboxGame(2, "Destiny", "~/images/xbox-games/destiny.jpg"));
            this.XboxGames.Add(new XboxGame(3, "Fifa 2k17", "~/images/xbox-games/fifa.jpg"));
            this.XboxGames.Add(new XboxGame(4, "Forza Horizon 3", "~/images/xbox-games/forza.jpg"));
            this.XboxGames.Add(new XboxGame(5, "Gears of War 4", "~/images/xbox-games/gears-of-war.jpg"));
            this.XboxGames.Add(new XboxGame(6, "Halo 5", "~/images/xbox-games/halo5.jpg"));
            this.XboxGames.Add(new XboxGame(7, "Mass Effect", "~/images/xbox-games/mass-effect.jpg"));
            this.XboxGames.Add(new XboxGame(8, "Dragon Age Inquisition", "~/images/xbox-games/dragon-age.jpg"));
            return this;
        }
    }
}
