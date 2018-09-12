using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class ImgUser
    {
        public int Id { get; set; }

        public string MimeType { get; set; }

        public string FileName { get; set; }

        public string FileContentBase64 { get; set; }

        public int IdNews { get; set; }

        public bool Deletado { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public DateTime? DataAlteracao { get; set; }

        public long FileLenght { get; set; }

        //public virtual IList<User> User { get; set; }
        //[NotMapped]
        //public string Base64 { get { return Base64Image(); } }

        //public string Base64Image()
        //{
        //    if (FileContent != null && MimeType != null)
        //        return "data:" + MimeType + ";base64," + Convert.ToBase64String(FileContent);
        //    return "";
        //}
    }
}
