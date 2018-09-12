using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OceannicAPI.Models;
using Web_Oceannic.OData;

namespace Web_Oceannic.Controllers
{
    public class CoinController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> TotalRetido()
        {
            var res = await ApiClient.GetAsync(GetUri("Coin"));

            IList<TotalCurrencyViewModel> totalCurrency = new List<TotalCurrencyViewModel>();

            ODataObject<CurrencyViewModel> odataObj = JsonConvert.DeserializeObject<ODataObject<CurrencyViewModel>>(await res.Content.ReadAsStringAsync());

            foreach(var item in odataObj.Value)
            {
                res = await ApiClient.GetAsync(GetUri(string.Format("TotalCurrency(userId={0},currencyId={1})",Convert.ToInt32(HttpContext.Session.GetInt32("IdUser")), item.Id)));
                totalCurrency.Add(new TotalCurrencyViewModel()
                {
                    Describe = item.Describe,
                    Value = (double)((dynamic)JObject.Parse(await res.Content.ReadAsStringAsync())).value
                });
            }

            return Json(new
            {
                data = totalCurrency
            });
        }
    }
}