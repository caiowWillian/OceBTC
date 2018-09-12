using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OceannicAPI.Models;
using Web_Oceannic.Filter;

namespace Web_Oceannic.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        private HttpResponseMessage response;
        
        private readonly IAuthorizationService authService;
        // GET: User
        public ActionResult Index()
        {
               return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        //[AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UserViewModel model, IFormFile file)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                if(file != null)
                    model.ImgUser = await FileToImgAsync(file);

                model.Pw = Security.MD5.Encrypt(model.Pw, true);
                model.ConfPw = Security.MD5.Encrypt(model.ConfPw, true);

                string json = JsonConvert.SerializeObject(model);

                response = await ApiClient.PostAsync(GetUri("user"), Headers(json));

                if (response.IsSuccessStatusCode)
                    return RedirectToAction("Login", "Account", new { name = model.Name });
                else
                    return View(model);
            }
            catch(Exception e)
            {
                return View(model);
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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

        private async Task<ImgUserViewModel> FileToImgAsync(IFormFile file)
        {
            ImgUserViewModel img = null;
            using(Stream inputStream = file.OpenReadStream())
            {
                var memoryStream = inputStream as MemoryStream;
                if(memoryStream == null)
                {
                    memoryStream = new MemoryStream();
                    await inputStream.CopyToAsync(memoryStream);
                }

                img = new ImgUserViewModel()
                {
                    FileLenght = file.Length,
                    MimeType = file.ContentType,
                    FileName = file.FileName,
                    //FileContentBase64 = img.Base64Image()
                };

                img.FileContentBase64 = img.Base64Image(memoryStream.ToArray());
            }
            return img;
        }
    }
}