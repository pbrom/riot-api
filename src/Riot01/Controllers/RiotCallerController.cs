using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;


using Riot01.Models;

namespace Riot01.Controllers
{
    public class RiotCallerController : Controller
    {
        public string Index()
        {
            RiotDataObject response = RiotCaller.MakeCallToAPI<RiotDataObject>("https://na.api.pvp.net/api/lol/static-data/na/v1.2/champion", "?api_key=RGAPI-7764feab-9b9f-46e6-8d3a-4ad1216234f3");
            string responseString = JsonConvert.SerializeObject(response);


            return responseString;
        }

        /*public IActionResult Index()
        {
            string response = RiotCaller.MakeCallToAPI("https://na.api.pvp.net/api/lol/na/v1.2/champion", "?api_key=RGAPI-7764feab-9b9f-46e6-8d3a-4ad1216234f3");
            return View();
        }*/
    }
}