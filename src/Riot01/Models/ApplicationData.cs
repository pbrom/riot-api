using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riot01.Models
{
    public class ApplicationData
    {
        public static Dictionary<string, Champion> ChampionList { get; set; } = new Dictionary<string, Champion>();

        public static void CreateChampionList()
        {
            ChampionList.Clear();
            //ChampionList
        }
    }
}
