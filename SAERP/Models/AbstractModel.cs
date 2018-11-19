using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAERP.Models
{
    public abstract class AbstractModel
    {
        [Required(ErrorMessage = "Ukey é Obrigatória!")]
        private string ukey;
        [Required(ErrorMessage = "TimesTamp é Obrigatória!")]
        private DateTime timestamp;
        [Required(ErrorMessage = "Cia Ukey é Obrigatória!")]
        private string cia_ukey;
        private string usr_note;
        private string sqlcmd;

        public string Ukey { get => ukey; set => ukey = value; }
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }
        public string Cia_ukey { get => cia_ukey; set => cia_ukey = value; }
        public string Usr_note { get => usr_note; set => usr_note = value; }
        public string Sqlcmd { get => sqlcmd; set => sqlcmd = value; }
    }
}