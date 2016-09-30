using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Riot01.Controllers;

namespace Riot01.Models
{
    public class APICalls
    {
        public static string region = "na";
        public static string baseURI = $"{"https://"}{region}{".api.pvp.net/api/lol/"}";
        public static string apiKeyQuery = $"{"?api_key="}";
        public static string API_KEY = $"{"RGAPI-7764feab-9b9f-46e6-8d3a-4ad1216234f3"}";

        public static string query_champion = $"{"static-data/"}{region}{"/v1.2/champion"}";

        public string query = query_champion;

        public static RiotDataObject QueryChampions()
        {
            return RiotCaller.MakeCallToAPI<RiotDataObject>($"{baseURI}{query_champion}", $"{apiKeyQuery}{API_KEY}");
        }
    }
}
