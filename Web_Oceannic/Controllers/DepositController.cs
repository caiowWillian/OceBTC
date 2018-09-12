using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OceannicAPI.Models;
using Web_Oceannic.Models;

namespace Web_Oceannic.Controllers
{
    public class DepositController : BaseController
    {
        // GET: Deposit
        public ActionResult Index()
        {
            return View();
        }

        // GET: Deposit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Deposit/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AllDepositViewModel model)
        {
            try
            {
                DepositViewModel deposit = new DepositViewModel()
                {
                    UserId = Convert.ToInt32(HttpContext.Session.GetInt32("IdUser")),
                    Ativo = false,
                    Value = model.ValorDeposito,
                    CurrencyId = model.Moedas,
                    UserWallet = model.WalletGuid,
                    Guid = model.WalletGuid,
                    BankId = model.SelectBancos
                };

                string json = JsonConvert.SerializeObject(deposit);

                var resp = await ApiClient.PostAsync(GetUri("deposit"), Headers(json));

                if (resp.IsSuccessStatusCode)
                {
                    Success("Deposito realizado com sucesso");
                    return RedirectToAction("Index", "Account");
                }
                    
                    
            }
            catch
            {
            }

            Warning("Houve um problema, por favor tente novamente");
            return View(model);
        }

        // GET: Deposit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Deposit/Edit/5
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

        // GET: Deposit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Deposit/Delete/5
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