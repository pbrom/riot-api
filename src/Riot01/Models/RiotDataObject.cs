using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Riot01.Models
{
    public class RiotDataObject
    {
        public string type;
        public string version;
        public Dictionary<string, Dictionary<string, string>> data;
    }
}
