using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            PersonaModel persona = new PersonaModel(1, "Cristiano Ronaldo", 84.0, 1.87);
            double IMC = persona.Peso / (persona.Estatura * persona.Estatura);
            ViewBag.IMC = IMC;
            ViewBag.persona = persona;
            return View();
        }


        public ActionResult ResultadosAleatoriosIMC()
        {
            PersonaModel[] personas = new PersonaModel[30];
            double[] IMCs = new double[30];
            Random random = new Random();

            for (int persona = 0; persona < 30; ++persona)
            {
                double pesoAleatorio = random.NextDouble(20, 150);
                double estaturaAleatoria = random.NextDouble(1, 2);
                personas[persona] = new PersonaModel(persona, "Lionel Messi", pesoAleatorio, estaturaAleatoria);
                IMCs[persona] = pesoAleatorio / (estaturaAleatoria * estaturaAleatoria);
            }

            ViewBag.personas = personas;
            ViewBag.IMCs = IMCs;
            return View();
        }
    }
}