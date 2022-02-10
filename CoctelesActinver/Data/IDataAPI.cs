using CoctelesActinver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoctelesActinver.Data
{
    public interface IDataAPI
    {
         Task<Cocteles> getCocteles(string parameter);
    }
}
