using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Web_Oceannic.Helpers.Alerta;

namespace Web_Oceannic.Controllers
{
    public class BaseController : Controller
    {
        protected Uri ApiUri { get; set; }
        protected const string Url = "http://localhost:63905/v2/";
        protected HttpClient ApiClient;

        public BaseController()
        {
            ApiClient = new HttpClient();
            //ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json;odata.metadata=none"));
            ApiClient.DefaultRequestHeaders.Add("Accept", "application/json;odata.metadata=none");
        }

        public StringContent Headers(string json)
        {
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        /// <summary>
        /// Método utilizado para retornar a URI da API da aplicação
        /// <param name="partUrl"></param>
        /// <returns>Uri referente a api da aplicação</returns>
        /// <remarks>partUrl deve ser o controller da api. Exemplo: localhost/api/${partUrl}</remarks>
        /// </summary>
        protected Uri GetUri(string partUrl)
        {
            return new Uri(Url + partUrl);
        }

        protected string JsonResult(HttpResponseMessage response)
        {
            if (response == null)
                return null;
            if (!response.IsSuccessStatusCode)
                return null;

            return response.Content.ReadAsStringAsync().Result;
        }

        protected async Task<string> JsonResultAsync(HttpResponseMessage response)
        {
            if (response == null)
                return null;
            if (!response.IsSuccessStatusCode)
                return null;



            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Mensagem de Sucesso
        /// </summary>
        /// <param name="message">Escrito da Menssagem</param>
        /// <param name="dismissable">Permissão para fechar a Menssagem</param>
        public void Success(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Success, message, dismissable);
        }

        /// <summary>
        /// Mensagem de Informação
        /// </summary>
        /// <param name="message">Escrito da Menssagem</param>
        /// <param name="dismissable">Permissão para fechar a Menssagem</param>
        public void Information(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Information, message, dismissable);
        }

        /// <summary>
        /// Mensagem de Cuidado
        /// </summary>
        /// <param name="message">Escrito da Menssagem</param>
        /// <param name="dismissable">Permissão para fechar a Menssagem</param>
        public void Warning(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Warning, message, dismissable);
        }

        /// <summary>
        /// Mensagem de Alerta
        /// </summary>
        /// <param name="message">Escrito da Menssagem</param>
        /// <param name="dismissable">Permissão para fechar a Menssagem</param>
        public void Danger(string message, bool dismissable = false)
        {
            AddAlert(AlertStyles.Danger, message, dismissable);
        }

        private void AddAlert(string alertStyle, string message, bool dismissable)
        {
            //var alerts = TempData.ContainsKey(Alertas.TempDataKey)
            //    ? (List<Alertas>)TempData[Alertas.TempDataKey]
            //    : new List<Alertas>();


            var alerts = new List<Alertas>
            {
                new Alertas
                {
                    AlertStyle = alertStyle,
                    Message = message,
                    Dismissable = dismissable
                }
            };


            TempData[Alertas.TempDataKey] = JsonConvert.SerializeObject(alerts);
        }
    }
}