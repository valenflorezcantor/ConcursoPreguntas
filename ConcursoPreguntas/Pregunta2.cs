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
    public partial class Pregunta2 : Form
    {
        public Pregunta2()
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
                puntos += 450;
                Pregunta3 pregunta3 = new Pregunta3();
                pregunta3.lblApodo.Text = lblApodo.Text;
                pregunta3.lblPuntos.Text = puntos.ToString();
                MessageBox.Show("¡Respuesta Correcta!" + "\n" + " has ganado " + puntos + " puntos");
                pregunta3.Show();
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
        private void Pregunta2_Load(object sender, EventArgs e)
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
        /// Método que llena en memoria las preguntas de categoria 2
        /// </summary>
        /// <returns> Retorna una lista de preguntas </returns>
        private List<Pregunta> CrearPreguntas()
        {
            List<Pregunta> preguntas = new List<Pregunta>();
            Pregunta pregunta1 = new Pregunta();
            pregunta1.Enunciado = "¿Cuál fue el campeón del mundial FIFA 2018?";
            pregunta1.Respuestas = new List<Respuesta>
            {
                new Respuesta("Brasil", "a"),
                new Respuesta("Inglaterra", "b"),
                new Respuesta("Rusia", "c"),
                new Respuesta("Francia", "d")
            };
            pregunta1.Categoria = 2;
            pregunta1.RespuestaValida = "d";

            preguntas.Add(pregunta1);

            Pregunta pregunta2 = new Pregunta();
            pregunta2.Enunciado = "¿Cuál es el país más pequeño del mundo?";

            pregunta2.Respuestas = new List<Respuesta>
            {
                new Respuesta("Panama", "a"),
                new Respuesta("Vaticano", "b"),
                new Respuesta("Cuba", "c"),
                new Respuesta("Jamaica", "d")
            };
            pregunta2.Categoria = 2;
            pregunta2.RespuestaValida = "b";

            preguntas.Add(pregunta2);

            Pregunta pregunta3 = new Pregunta();
            pregunta3.Enunciado = "¿En qué año descubrió Cristóbal Colón, América?";
            pregunta3.Respuestas = new List<Respuesta>
            {
                new Respuesta("1592", "a"),
                new Respuesta("1498", "b"),
                new Respuesta("1900", "c"),
                new Respuesta("1492", "d")
            };
            pregunta3.Categoria = 2;
            pregunta3.RespuestaValida = "d";

            preguntas.Add(pregunta3);

            Pregunta pregunta4 = new Pregunta();
            pregunta4.Enunciado = "¿Qué cantante es reconocido por éxitos como Thriller, Beat It y Smooth Criminal?";
            pregunta4.Respuestas = new List<Respuesta>
            {
                new Respuesta("Slash", "a"),
                new Respuesta("Michael Jackson", "b"),
                new Respuesta("Freddy Mercury", "c"),
                new Respuesta("Dio", "d")
            };
            pregunta4.Categoria = 2;
            pregunta4.RespuestaValida = "b";

            preguntas.Add(pregunta4);

            Pregunta pregunta5 = new Pregunta();
            pregunta5.Enunciado = "¿En qué parte del cuerpo se encuentra la piel más gruesa?";
            pregunta5.Respuestas = new List<Respuesta>
            {
                new Respuesta("Planta de las piernas", "a"),
                new Respuesta("Nudillos", "b"),
                new Respuesta("Espalda", "c"),
                new Respuesta("Cuello", "d")
            };
            pregunta5.Categoria = 2;
            pregunta5.RespuestaValida = "c";

            preguntas.Add(pregunta5);

            return preguntas;
        }

        /// <summary>
        /// Evento del botón Retirarse, muestra una caja de texto con la respectiva validación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetirarse_Click(object sender, EventArgs e)
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
    }
}
