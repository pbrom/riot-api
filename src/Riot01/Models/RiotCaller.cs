using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Riot01.Models
{
    public class RiotCaller
    {
        /// <summary>
        /// This will be used to make calls to the Riot API
        /// </summary>
        /// <param name="baseURL">base riot url</param>
        /// <param name="apiCallPath">call to make</param>
        /// 
        public static T MakeCallToAPI<T>(string baseURL, string apiCallPath)
        {            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var completeURL = $"{baseURL}{apiCallPath}";

                HttpResponseMessage response = client.GetAsync(completeURL).Result;
                if(response.IsSuccessStatusCode)
                {
                    var responseJSON = response.Content.ReadAsStringAsync().Result;
                    try
                    {
                        T rdo = JsonConvert.DeserializeObject<T>(responseJSON);
                        //string rdoString = JsonConvert.SerializeObject(rdo);
                        //string str = rdo.data["Jax"]["id"].ToString();                        
                        return rdo;
                    }
                    catch (Exception exception)
                    {
                        throw (exception);
                    }
                }                
            }
            return default(T);
        }
    }
}
