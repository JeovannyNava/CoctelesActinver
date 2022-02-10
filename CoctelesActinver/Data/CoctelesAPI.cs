using CoctelesActinver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoctelesActinver.Data
{
    public class CoctelesAPI
    {
        IDataAPI dataAPI;

        public CoctelesAPI(IDataAPI _dataAPI)
        {
            dataAPI = _dataAPI;
        }

        public async Task<Cocteles> GetCocteles(string parameter)
        {
            return await dataAPI.getCocteles(parameter);
        }
    }
}
