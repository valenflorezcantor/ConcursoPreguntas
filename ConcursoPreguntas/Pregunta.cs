using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPreguntas
{
    /// <summary>
    /// Clase pregunta, que usa la clase respuesta para el almacenamiento de datos en memoria
    /// </summary>
    public class Pregunta
    {
        public string Enunciado { get; set; }
        public List<Respuesta> Respuestas { get; set; }
        public int Categoria { get; set; }

        public string RespuestaValida { get; set; }

    }
}
