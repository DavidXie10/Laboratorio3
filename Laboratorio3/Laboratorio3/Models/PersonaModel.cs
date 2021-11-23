using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio3.Models
{
    public class PersonaModel
    {
        // Propiedades: cuando se instancia una persona se puede hacer persona.Peso=valor

        public String Nombre { get; set; }
        public int id { get; set; }
        public double Peso { get; set; }
        public double Estatura { get; set; }
        public double IMC { get; set; }

        // Constructores 
        public PersonaModel()
        {
            this.Nombre = "Sin nombre";
            this.id = 0;
            this.Peso = 0.0;
            this.Estatura = 0.0;
            this.IMC = 0.0;
        }

        public PersonaModel(int Id, string Nombre, double Peso, double Estatura, double IMC)
        {
            this.Nombre = Nombre;
            this.id = Id;
            this.Peso = Peso;
            this.Estatura = Estatura;
            this.IMC = IMC;
        }
    }
}