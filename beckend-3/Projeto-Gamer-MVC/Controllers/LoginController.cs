using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer_MVC.Models;
using Projeto_Gamer_MVC.Infra;

namespace Projeto_Gamer_MVC.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [TempData]
        public string Message {get; set;}
        Context c = new Context();

        [Route("Login")]
        public IActionResult Index()
        {
           ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            string email = form["Email"].ToString();
            string senha = form["Senha"].ToString();

            Jogador jogadorBuscado = c.Jogador.FirstOrDefault(J => J.Email == email && J.Senha == senha)!;


            // Logica da sessao

            if (jogadorBuscado != null)
            {
                HttpContext.Session.SetString("UserName", jogadorBuscado.Nome);
                return LocalRedirect("~/");
            }





            Message="Dados invalidos, tente novamente";
            return LocalRedirect("~/Login/Login");
        }


        [Route("Logout")]
        public IActionResult Logout(){
            HttpContext.Session.Remove("UserName");
            return LocalRedirect("~/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public override bool Equals(object? obj)
        {
            return obj is LoginController controller &&
                   EqualityComparer<Context>.Default.Equals(c, controller.c);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(c);
        }
    }
}