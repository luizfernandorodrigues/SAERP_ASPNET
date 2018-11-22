using SAERP.AcessaDados;
using SAERP.AcessaDados.Repositorio;
using SAERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SAERP.Controllers
{
    public class LoginController : Controller
    {
               
        [AllowAnonymous]
        public ActionResult Login(string retUrl)
        {
            ViewBag.ReturnUrl = retUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel login, string retUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            bool achou = false;
            string usuario = login.Usuario;
            string senha = login.Senha;
            bool lembrar = login.LembrarMe;
            using (var uow = UnitOfWorkFactory.Create())
            {
                var loginRepositorio = new LoginRepositorio(uow);
                achou = loginRepositorio.Login(usuario, senha);
            }
            if (achou)
            {
                FormsAuthentication.SetAuthCookie(usuario, lembrar);
                if (Url.IsLocalUrl(retUrl))
                {
                    return Redirect(retUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Login Inválido!!");
            }
            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
