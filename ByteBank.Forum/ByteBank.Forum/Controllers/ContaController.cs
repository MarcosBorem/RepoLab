using ByteBank.Forum.Models;
using ByteBank.Forum.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ByteBank.Forum.Controllers
{
    public class ContaController : Controller
    {
        private UserManager<UsuarioAplicacao> _userManager;
        public UserManager<UsuarioAplicacao> UserManager
        {
            get
            {
                if (_userManager == null)
                {
                    var contextOwin = HttpContext.GetOwinContext();
                    _userManager = contextOwin.GetUserManager<UserManager<UsuarioAplicacao>>();
                }
                return _userManager;
            }
            set
            {
                _userManager = value;
            }
        }
        // usuario acessar a pagina
        public ActionResult Registrar()
        {
            return View();
        }
        //post das informações
        [HttpPost]
        public async Task<ActionResult> Registrar(ContaRegistrarViewModel modelo)
        {
            //saber se o estado do modelo é valido
            if (ModelState.IsValid)
            {
                
                var novoUsuario = new UsuarioAplicacao();

                novoUsuario.Email = modelo.Email;
                novoUsuario.UserName = modelo.UserName;
                novoUsuario.NomeCompleto = modelo.NomeCompleto;

                var resultado = await UserManager.CreateAsync(novoUsuario, modelo.Senha);

                if (resultado == null)
                {
                    // usuário cadastrado e redirecionado para a home da aplicação
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    AdicionaErros(resultado);
                }
            }
            //Algo errado aconteceu
            
            return View(modelo);
        }

        private void AdicionaErros(IdentityResult resultado)
        {
            foreach (var erro in resultado.Errors)
            {

                ModelState.AddModelError("", erro);
            }
        }
    }
}