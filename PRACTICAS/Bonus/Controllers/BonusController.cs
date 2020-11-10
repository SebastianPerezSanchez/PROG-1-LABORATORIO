using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BonusF.Models;
using Bonus.Data;

namespace Bonus.Controllers
{
        public class BonusController : Controller
        {

            private readonly ILogger<BonusController> _logger;

            private readonly DatabaseContext _context;

            public BonusController(ILogger<BonusController> logger,
             DatabaseContext context)
            {
                _logger = logger;
                _context = context;
                
            }

            public IActionResult Index()
            {
                 var model = new BonusC();
                model.Bank = " ";
                return View(model);
                
            }

            [HttpPost]
            public IActionResult Registrar(BonusC objBonus)
            {

                if (ModelState.IsValid)
                {
                    _context.Add(objBonus);
                    _context.SaveChanges();
                    objBonus.Response = "Gracias. Formulario enviado";
                    
                }

            return View("index", objBonus);
            }

           


        }
}