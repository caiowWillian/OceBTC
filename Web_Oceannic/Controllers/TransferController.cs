using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OceannicAPI.Models;
using System;
using System.Threading.Tasks;
using Web_Oceannic.OData;

namespace Web_Oceannic.Controllers
{
    public class TransferController : BaseController
    {

        // GET: Transfer
        public async Task<ActionResult> Index()
        {
            string url = GetUri("transfer?$expand=UserBanks,Currency&$filter=UserId eq " + HttpContext.Session.GetInt32("IdUser")).ToString();
            var res = await ApiClient.GetAsync(url);

            ODataObject<TransferViewModel> odataObejct = JsonConvert.DeserializeObject<ODataObject<TransferViewModel>>(await res.Content.ReadAsStringAsync());
            return View(odataObejct.Value);
        }

        // GET: Transfer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Transfer/Create
        public async Task<ActionResult> Create()
        {
            var res = await ApiClient.GetAsync(GetUri("Coin"));


            ODataObject<CurrencyViewModel> odataObj = JsonConvert.DeserializeObject<ODataObject<CurrencyViewModel>>(await res.Content.ReadAsStringAsync());
            ViewBag.CurrencyId = new SelectList(odataObj.Value, "Id","Describe");

            return View();
        }

        // POST: Transfer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TransferViewModel model)
        {
            try
            {

                model.UserId = Convert.ToInt32(HttpContext.Session.GetInt32("IdUser"));
                var res = await ApiClient.GetAsync(GetUri("Coin"));

                ODataObject<CurrencyViewModel> odataObj = JsonConvert.DeserializeObject<ODataObject<CurrencyViewModel>>(await res.Content.ReadAsStringAsync());
                ViewBag.CurrencyId = new SelectList(odataObj.Value, "Id", "Describe");

                if (!ModelState.IsValid)
                    return View(model);

                var resp = await ApiClient.GetAsync(GetUri(string.Format("TotalCurrency(userId={0},currencyId={1})", Convert.ToInt32(HttpContext.Session.GetInt32("IdUser")), model.CurrencyId)));

                string teste = await resp.Content.ReadAsStringAsync();

                string json = JsonConvert.SerializeObject(model);

                if((double)((dynamic)JObject.Parse(await resp.Content.ReadAsStringAsync())).value < model.Value)
                {
                    Warning("Saldo insuficiente");
                    return View(model);
                }

                resp = await ApiClient.PostAsync(GetUri("transfer"), Headers(json));

                if (!resp.IsSuccessStatusCode)
                {
                    Warning("Houve um erro, por favor tente novamente");
                    return View(model);
                }

                //TempData["Success"] = "Bla";

               
                Success("Transferencia solicitada com sucesso");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Transfer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transfer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Transfer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transfer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}