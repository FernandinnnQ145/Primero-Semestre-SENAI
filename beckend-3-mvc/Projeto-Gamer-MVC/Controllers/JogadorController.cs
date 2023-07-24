using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer_MVC.Infra;
using Projeto_Gamer_MVC.Models;

namespace Projeto_Gamer_MVC.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipes = c.Equipes.ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }



        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipes = int.Parse(form["IdEquipes"].ToString());

            c.Jogador.Add(novoJogador);
            c.SaveChanges();


            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Excluir/{id}")]

        public IActionResult Excluir(int id)
        {
           

            Jogador j = c.Jogador.First(x => x.IdJogador == id);

            c.Remove(j);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }









        [Route("Edit/{id}")]
        public IActionResult Editar(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            Jogador j = c.Jogador.First(x => x.IdJogador == id);

            ViewBag.Jogador = j;
            ViewBag.Equipes = c.Equipes.ToList();

            return View("Edit");
        }




        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Jogador j)
        {
            
            Jogador novoJogador = new Jogador();

           novoJogador.IdJogador = int.Parse(form["IdJogador"].ToString());
           novoJogador.Nome = form["Nome"].ToString();
           novoJogador.Email = form["Email"].ToString();
           novoJogador.Senha = form["Senha"].ToString();
           novoJogador.IdEquipes = int.Parse(form["IdEquipes"].ToString());


            Jogador jogadorx = c.Jogador.First(x => x.IdJogador == novoJogador.IdJogador);
            jogadorx.Nome = novoJogador.Nome;
            jogadorx.Email = novoJogador.Email;
            jogadorx.Senha = novoJogador.Senha;
            jogadorx.IdEquipes = novoJogador.IdEquipes;

            c.Jogador.Update(jogadorx);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");

        }




    }
}