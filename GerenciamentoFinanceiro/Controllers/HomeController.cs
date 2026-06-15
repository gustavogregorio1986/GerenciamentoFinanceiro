using GerenciamentoFinanceiro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GerenciamentoFinanceiro.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
