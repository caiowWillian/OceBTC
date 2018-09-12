using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Application.Interface;
using Domain.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OceannicAPI.Models;
using Web_Oceannic.OData;
//using Oceannic_Web_Api.Models;

namespace Web_Oceannic.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
      
        private readonly IUserAppService _appUser;

        public AccountController(IUserAppService appUser)
        {
            _appUser = appUser;
        }


        public async Task<IActionResult> Index(bool alert = false, string type = null, string msg = null)
        {
            if (alert)
            {
                if(type == "Success")
                {
                    Success(msg);
                }
                else
                {
                    Warning(msg);
                }
            }

            string url = GetUri("deposit?$expand=Bank,Currency&$filter=UserId eq " + HttpContext.Session.GetInt32("IdUser")).ToString();

            var res = await ApiClient.GetAsync(url);


            ViewBag.Deposit = (JsonConvert.DeserializeObject<ODataObject<DepositViewModel>>(await res.Content.ReadAsStringAsync())).Value.Where(x => x.Ativo).ToList();
            ViewBag.DepositInactive = (JsonConvert.DeserializeObject<ODataObject<DepositViewModel>>(await res.Content.ReadAsStringAsync())).Value.Where(x => !x.Ativo).ToList();
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login(string name)
        {

            if(!string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name))
                Success(name + " Bem vindo a Oceannic");

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("login");
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (!ModelState.IsValid)
            {
                Warning("Usuario ou senha Invalido", true);
                return View(model);
            }

            User user = await _appUser.GetUserByLoginAsync(model.Usuario, Security.MD5.Encrypt(model.Senha,true));

            if(user == null)
            {
                Warning("Usuario ou senha Invalido", true);
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,model.Usuario)
            };

            var useridentity = new ClaimsIdentity(claims, "login");
            ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);

            await HttpContext.SignInAsync(principal);

            HttpContext.Session.SetString("ImgUser", user.ImgUser.FileContentBase64);
            HttpContext.Session.SetString("NameUser", user.Name);
            HttpContext.Session.SetInt32("IdUser", user.Id);
            return RedirectToAction("Index");
        }
    }
}