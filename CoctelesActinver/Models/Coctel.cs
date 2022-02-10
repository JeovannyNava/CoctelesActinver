using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoctelesActinver.Models
{
    public class drinks
    {
        public string strGlass { get; set; }
        public string strDrink { get; set; }
        public string idDrink { get; set; }
        public string strCategory { get; set; }
        public string strDrinkThumb { get; set; }
        public string strIngredient1 { get; set; }
    }

    public class Cocteles
    {
        public List<drinks> drinks { get; set; }
    }
}
