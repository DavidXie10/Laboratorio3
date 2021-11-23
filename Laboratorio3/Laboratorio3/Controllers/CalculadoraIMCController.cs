using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3.Handlers;
using Laboratorio3.Models;

namespace Laboratorio3.Controllers
{
    // Tomado de https://www.it-swarm-es.com/es/c%23/numero-aleatorio-entre-2-numeros-dobles/967226729/
    public static class RandomExtensions
    {
        public static double NextDouble(this Random random, double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }

    public class CalculadoraIMCController : Controller
    {
        // GET: CalculadoraIMC
        public ActionResult ResultadoIMC()
        {
            PersonaModel persona = new PersonaModel(1, "Cristiano Ronaldo", 84.0, 1.87, 84.0 / (1.87 * 1.87));
            double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
            ViewBag.IMC = IMC;
            ViewBag.persona = persona;
            return View("ResultadoIMC");
        }


        public ActionResult ResultadosAleatoriosIMC()
        {
            CalculadoraHandler accesoDatos = new CalculadoraHandler();
            ViewBag.personas = accesoDatos.ObtenerTodaslasPersonas();
            return View();
        }
    }
}