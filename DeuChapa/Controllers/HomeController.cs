using DeuChapa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeuChapa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _contexto;

        public HomeController(ILogger<HomeController> logger, ApplicationContext contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

        //=======================Index==============================

        public IActionResult Index()
        {
            return View();
        }
        //=======================CadastroLanche==============================
        public IActionResult CadastroLanche()
        {
            return View();
        }

        public IActionResult _CadastroLanche(Lanche lanche)
        {
            _contexto.Add(lanche);
            _contexto.SaveChanges();

            if (lanche.Ingredientes.Tomate == true)
            {
                lanche.Ingredientes._Tomate = "Tomate";
            }
            else
            {
                lanche.Ingredientes._Tomate = "Não tem Tomate";
            }

            if (lanche.Ingredientes.Alface == true)
            {
                lanche.Ingredientes._Alface = "Alface";
            }
            else
            {
                lanche.Ingredientes._Alface = "Não tem Tomate";
            }

            return View("ExibirResumo");
        }

        public IActionResult ExibirResumo(Lanche lanche)
        {
            return View("Resumo/ResumoLanche", lanche);
        }


        //=======================CadastroBebida==============================

        public IActionResult CadastroBebida()
        {
            return View();
        }

        public IActionResult _CadastroBebida(Bebida bebida)
        {
            _contexto.Add(bebida);
            _contexto.SaveChanges();

            return View("Resumo/ResumoBebida", bebida);
        }

        //======================Lanches e Bebidas Cadastrados===============================

        public IActionResult Cadastrados()
        {
            ViewBag.Lanche = new SelectList(_contexto.Lanche.ToList(), "Id_Lanche", "Nome");
            ViewBag.Bebida = new SelectList(_contexto.Bebida.ToList(), "Id_Bebida", "Nome");

            return View();
        }


        //=======================Ingredientes==============================

        public IActionResult Ingredientes()
        {
            return View();
        }

        //=====================================================

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
