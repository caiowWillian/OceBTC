using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_Oceannic.Controllers
{
    public class WalletController : BaseController
    {
        // GET: Wallet
        public ActionResult Index()
        {
            return View();
        }

        // GET: Wallet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Wallet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wallet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Wallet/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Wallet/Edit/5
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

        // GET: Wallet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Wallet/Delete/5
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

        public async Task<JsonResult> GetWallet(int id)
        {
            string url = GetUri("wallet/"+id.ToString()).ToString();
            var res = await ApiClient.GetAsync(url);


            string guid = await res.Content.ReadAsStringAsync();

            guid = guid.Replace('"', ' ');

            guid = guid.Trim();

            return Json(new
            {
                guid = guid
            });

        }
    }
}