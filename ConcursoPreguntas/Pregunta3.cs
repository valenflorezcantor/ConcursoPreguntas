using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcursoPreguntas
{
    public partial class Pregunta3 : Form
    {
        public Pregunta3()
        {
            InitializeComponent();
        }

        public Pregunta preguntaSeleccionada = new Pregunta();
        int puntos = 0;

        /// <summary>
        /// Evento del botón responder, recibe la validación de la respuesta
        /// Y controla el flujo para la próxima respuesta o el fin del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResponder_Click(object sender, EventArgs e)
        {
            bool respuestaCorrecta = ValidarRespuesta(txtRespuesta.Text);
            if (respuestaCorrecta)
            {
                puntos += 700;
                Pregunta4 pregunta4 = new Pregunta4();
                pregunta4.lblApodo.Text = lblApodo.Text;
                pregunta4.lblPuntos.Text = puntos.ToString();
                MessageBox.Show("¡Respuesta Correcta!" + "\n" + " has ganado " + puntos + " puntos");
                pregunta4.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("¡Respuesta Incorrecta!" + "\n" + lblApodo.Text + " su puntaje es: 0");
                IntentarNuevamente();
                this.Close();
            }
        }

        /// <summary>
        /// Evento de carga de la pregunta, escoge una pregunta al azar y la pinta en el lbl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pregunta3_Load(object sender, EventArgs e)
        {
            puntos = Convert.ToInt32(lblPuntos.Text);
            Random objetoAleatorio = new Random();
            int numeroAleatorio = objetoAleatorio.Next(0, 4);
            List<Pregunta> preguntas = CrearPreguntas();
            preguntaSeleccionada = preguntas[numeroAleatorio];

            lblEnunciado.Text = preguntas[numeroAleatorio].Enunciado;
            lblEnunciado.Text += "\n";
            lblEnunciado.Text += "a. " + preguntas[numeroAleatorio].Respuestas[0].Enunciado;
            lblEnunciado.Text += "\n";
            lblEnunciado.Text += "b. " + preguntas[numeroAleatorio].Respuestas[1].Enunciado;
            lblEnunciado.Text += "\n";
            lblEnunciado.Text += "c. " + preguntas[numeroAleatorio].Respuestas[2].Enunciado;
            lblEnunciado.Text += "\n";
            lblEnunciado.Text += "d. " + preguntas[numeroAleatorio].Respuestas[3].Enunciado;
        }

        /// <summary>
        /// Método que comprueba si la respuesta del concursante es correcta
        /// </summary>
        /// <param name="opcion"></param>
        /// <returns> Retorna valor boleano referente a la validacion </returns>
        private bool ValidarRespuesta(string opcion)
        {
            bool validar = false;
            if (opcion == preguntaSeleccionada.RespuestaValida)
            {
                validar = true;
            }

            return validar;
        }

        /// <summary>
        /// Método que llena en memoria las preguntas de categoria 3
        /// </summary>
        /// <returns> Retorna una lista de preguntas </returns>
        private List<Pregunta> CrearPreguntas()
        {
            List<Pregunta> preguntas = new List<Pregunta>();
            Pregunta pregunta1 = new Pregunta();
            pregunta1.Enunciado = "¿En qué país nació Freddie Mercury?";
            pregunta1.Respuestas = new List<Respuesta>
            {
                new Respuesta("Inglaterra", "a"),
                new Respuesta("Irlanda", "b"),
                new Respuesta("Tanzania", "c"),
                new Respuesta("Austria", "d"),
            };
            pregunta1.Categoria = 3;
            pregunta1.RespuestaValida = "c";

            preguntas.Add(pregunta1);

            Pregunta pregunta2 = new Pregunta();
            pregunta2.Enunciado = "¿En qué mes el sol está más cerca de la Tierra?";

            pregunta2.Respuestas = new List<Respuesta>
            {
                new Respuesta("Enero", "a"),
                new Respuesta("Diciembre", "b"),
                new Respuesta("Junio", "c"),
                new Respuesta("Julio", "d")
            };
            pregunta2.Categoria = 3;
            pregunta2.RespuestaValida = "b";

            preguntas.Add(pregunta2);

            Pregunta pregunta3 = new Pregunta();
            pregunta3.Enunciado = "¿Quién fue el primer presidente de los Estados Unidos?";
            pregunta3.Respuestas = new List<Respuesta>
            {
                new Respuesta("Thomas Jefferson", "a"),
                new Respuesta("Benjamin Franklin", "b"),
                new Respuesta("John Adams", "c"),
                new Respuesta("George Washington", "d")
            };
            pregunta3.Categoria = 3;
            pregunta3.RespuestaValida = "d";

            preguntas.Add(pregunta3);

            Pregunta pregunta4 = new Pregunta();
            pregunta4.Enunciado = "¿Cómo se llama el líder de los Autobots en la saga de Transformers?";
            pregunta4.Respuestas = new List<Respuesta>
            {
                new Respuesta("Megatron", "a"),
                new Respuesta("War Machine", "b"),
                new Respuesta("Optimus Prime", "c"),
                new Respuesta("Megaman", "d")
            };
            pregunta4.Categoria = 3;

            preguntas.Add(pregunta4);
            pregunta4.RespuestaValida = "c";

            Pregunta pregunta5 = new Pregunta();
            pregunta5.Enunciado = "¿Cuál es el animal más venenoso del mundo?";
            pregunta5.Respuestas = new List<Respuesta>
            {
                new Respuesta("Medusa avispa de mar", "a"),
                new Respuesta("Serpiente marina", "b"),
                new Respuesta("Rana punta de flecha", "c"),
                new Respuesta("Araña bananera", "d")
            };
            pregunta5.Categoria = 3;
            pregunta5.RespuestaValida = "a";

            preguntas.Add(pregunta5);

            return preguntas;
        }

        /// <summary>
        /// Método que le pregunta al concursante si desea reiniciar el juego
        /// </summary>
        private void IntentarNuevamente()
        {
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult opciones = MessageBox.Show("¿Desea intentarlo nuevamente?", "", botones);
            if (opciones == DialogResult.OK)
            {
                Concurso concurso = new Concurso();
                concurso.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Evento del botón Retirarse, muestra una caja de texto con la respectiva validación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetirarse_Click_1(object sender, EventArgs e)
        {
            string mensaje = "¿Desea retirarse?";
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            DialogResult resultado = MessageBox.Show(mensaje, "", botones);
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("su puntaje es: " + puntos);
                IntentarNuevamente();
            }
        }
    }
}
