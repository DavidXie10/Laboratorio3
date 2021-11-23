using Laboratorio3.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio3.Handlers {
    public class CalculadoraHandler {
        private SqlConnection conexion;
        private string rutaConexion;

        public CalculadoraHandler() {
            rutaConexion =
           ConfigurationManager.ConnectionStrings["CalculadoraConnection"].ToString();
            conexion = new SqlConnection(rutaConexion);
        }

        private DataTable CrearTablaConsulta(string consulta) {
            SqlCommand comandoParaConsulta = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptadorParaTabla = new
           SqlDataAdapter(comandoParaConsulta);
            DataTable consultaFormatoTabla = new DataTable();
            conexion.Open();
            adaptadorParaTabla.Fill(consultaFormatoTabla);
            conexion.Close();
            return consultaFormatoTabla;
        }

        public List<PersonaModel> ObtenerTodaslasPersonas() {
            List<PersonaModel> personas = new List<PersonaModel>();
            string consulta = "SELECT personaId, nombre, pesoAleatorio, estaturaAleatorio, pesoAleatorio / (estaturaAleatorio * estaturaAleatorio) AS 'IMC' FROM ImcPersonas; ";
            DataTable tablaResultado = CrearTablaConsulta(consulta);
            foreach (DataRow columna in tablaResultado.Rows) {
                personas.Add(
                new PersonaModel {
                    id = Convert.ToInt32(columna["personaId"]),
                    Nombre = Convert.ToString(columna["nombre"]),
                    Peso = Convert.ToDouble(columna["pesoAleatorio"]),
                    Estatura = Convert.ToDouble(columna["estaturaAleatorio"]),
                    IMC = Convert.ToDouble(columna["IMC"])
                });
            }
            return personas;
        }
    }
}