using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPreguntas
{
    /// <summary>
    /// Clase respuesta, usada por la clase Pregunta para almacenar datos en memoria
    /// </summary>
    public class Respuesta
    {
        public Respuesta(string enunciado, string opcion)
        {
            Enunciado = enunciado;
            Opcion = opcion;
        }
        public string Enunciado { get; }
        public string Opcion { get; }
    }
}
