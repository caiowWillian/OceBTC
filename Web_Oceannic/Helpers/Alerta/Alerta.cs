using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Oceannic.Helpers.Alerta
{
    /// <summary>
    /// Classe de Alerta de Menssagem do Sistema
    /// </summary>
    public class Alertas
    {
        /// <summary>
        /// Constante para guardar o erro
        /// </summary>
        public const string TempDataKey = "TempDataAlerts";


        /// <summary>
        /// Estilo do alerta
        /// </summary>
        public string AlertStyle { get; set; }


        /// <summary>
        /// Menssagem para o alerta
        /// </summary>
        public string Message { get; set; }


        /// <summary>
        /// Permissão para fechar
        /// </summary>
        public bool Dismissable { get; set; }
    }

    /// <summary>
    /// Classe de estilo para as menssagens do sistema
    /// </summary>
    public static class AlertStyles
    {
        /// <summary>
        /// Estilo sucesso
        /// </summary>
        public const string Success = "success";


        /// <summary>
        /// Estilo informação
        /// </summary>
        public const string Information = "info";


        /// <summary>
        /// Estilo cuidado
        /// </summary>
        public const string Warning = "warning";


        /// <summary>
        /// Estilo Perigo
        /// </summary>
        public const string Danger = "danger";
    }
}
