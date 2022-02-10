using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoctelesActinver.Models
{
    public class drinks: ACoctel
    {
        public string strGlass { get; set; }
        public string strDrink { get; set; }
        public string idDrink { get; set; }
        public string strCategory { get; set; }
        public string strDrinkThumb { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
        public string strIngredient4 { get; set; }
    }

    public class Cocteles
    {
        public List<drinks> drinks { get; set; }
    }

    public abstract class ACoctel
    {
        public  drinks getFirstElement(Cocteles cocteles)
        {
            return cocteles.drinks.FirstOrDefault();
        }
    }
}
