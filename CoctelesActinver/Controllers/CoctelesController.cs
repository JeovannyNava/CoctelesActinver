using CoctelesActinver.Data;
using CoctelesActinver.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoctelesActinver.Controllers
{
    public class CoctelesController : Controller
    {
        public async Task<PartialViewResult> _GetByName(string name)
        {

            IDataAPI getByName = new GetByName();
            CoctelesAPI coctelesAPI = new CoctelesAPI(getByName);
            Cocteles model = await coctelesAPI.GetCocteles(name);

            return PartialView("_Cocteles",model);
        }

        public async Task<PartialViewResult> _GetByIngredent(string ingredent)
        {

            IDataAPI getByIngredent = new GetByIngredent();
            CoctelesAPI coctelesAPI = new CoctelesAPI(getByIngredent);
            Cocteles model = await coctelesAPI.GetCocteles(ingredent);

            return PartialView("_Cocteles",model);
        }

        public async Task<PartialViewResult> _DetailCoctel(string idDrink)
        {

            IDataAPI getDetail = new GetDetail();
            CoctelesAPI coctelesAPI = new CoctelesAPI(getDetail);
            Cocteles model = await coctelesAPI.GetCocteles(idDrink);

            return PartialView(model);
        }

    }
}
