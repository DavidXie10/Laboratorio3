using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3.Models;

namespace Laboratorio3.Controllers
{
    public class CalculadoraIMCController : Controller
    {
        // GET: CalculadoraIMC
        public ActionResult ResultadoIMC()
        {
            PersonaModel persona = new PersonaModel(1, "Cristiano Ronaldo", 84.0, 1.87);
            double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
            ViewBag.IMC = IMC;
            ViewBag.persona = persona;
            return View();
        }
    }
}