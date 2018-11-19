using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace SAERP.Utilitarios
{
    public class Util
    {
        public string geraHash(string senha)
        {
            string _senha = "";
            SHA512Managed hash = new SHA512Managed();
            byte[] senhaByte = Encoding.UTF8.GetBytes(senha);
            byte[] hashByte = hash.ComputeHash(senhaByte);
            hash.Clear();
            _senha = Convert.ToBase64String(hashByte);
            return _senha;
        }
    }
}