using CoctelesActinver.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoctelesActinver.Data
{
    public class GetByIngredent:IDataAPI
    {
        public async Task<Cocteles> getCocteles(string ingredent)
        {

            var cocteles = new Cocteles();
            try
            {
                string url = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?i=" + ingredent;
                var httpClient = new HttpClient();
                var json = await httpClient.GetStringAsync(url);

                cocteles = JsonConvert.DeserializeObject<Cocteles>(json);
            }
            catch (Exception)
            {

              
            }
            return cocteles;
        }
    }
}
