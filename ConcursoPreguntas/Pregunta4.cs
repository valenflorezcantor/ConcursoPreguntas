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
    public partial class Pregunta4 : Form
    {
        public Pregunta4()
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
                puntos += 950;
                Pregunta5 pregunta5 = new Pregunta5();
                pregunta5.lblApodo.Text = lblApodo.Text;
                pregunta5.lblPuntos.Text = puntos.ToString();
                MessageBox.Show("¡Respuesta Correcta!" + "\n" + " has ganado " + puntos + " puntos");
                pregunta5.Show();
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
        private void Pregunta4_Load(object sender, EventArgs e)
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
        /// Método que llena en memoria las preguntas de categoria 4
        /// </summary>
        /// <returns> Retorna una lista de preguntas </returns>
        private List<Pregunta> CrearPreguntas()
        {
            List<Pregunta> preguntas = new List<Pregunta>();
            Pregunta pregunta1 = new Pregunta();
            pregunta1.Enunciado = "¿Cuál de los Siete Enanitos no tenía barba?";
            pregunta1.Respuestas = new List<Respuesta>
            {
                new Respuesta("Mudito", "a"),
                new Respuesta("Feliz", "b"),
                new Respuesta("Dormilón", "c"),
                new Respuesta("Mocoso", "d")
            };
            pregunta1.Categoria = 4;
            pregunta1.RespuestaValida = "a";

            preguntas.Add(pregunta1);

            Pregunta pregunta2 = new Pregunta();
            pregunta2.Enunciado = "¿En qué país nació Mozart?";

            pregunta2.Respuestas = new List<Respuesta>
            {
                new Respuesta("Suiza", "a"),
                new Respuesta("Polonia", "b"),
                new Respuesta("Austria", "c"),
                new Respuesta("Países bajos", "d"),
            };
            pregunta2.Categoria = 4;
            pregunta2.RespuestaValida = "c";

            preguntas.Add(pregunta2);

            Pregunta pregunta3 = new Pregunta();
            pregunta3.Enunciado = "¿Cuál es el idioma más hablado de Suiza?";
            pregunta3.Respuestas = new List<Respuesta>
            {
                new Respuesta("Romanche", "a"),
                new Respuesta("Italiano", "b"),
                new Respuesta("Francés", "c"),
                new Respuesta("Alemán", "d")
            };
            pregunta3.Categoria = 4;
            pregunta3.RespuestaValida = "d";

            preguntas.Add(pregunta3);

            Pregunta pregunta4 = new Pregunta();
            pregunta4.Enunciado = "¿Cuánto duró la guerra de los 100 años?";
            pregunta4.Respuestas = new List<Respuesta>
            {
                new Respuesta("100 años", "a"),
                new Respuesta("90 años", "b"),
                new Respuesta("116 años", "c"),
                new Respuesta("10 años", "d")
            };
            pregunta4.Categoria = 4;
            pregunta4.RespuestaValida = "c";

            preguntas.Add(pregunta4);

            Pregunta pregunta5 = new Pregunta();
            pregunta5.Enunciado = "¿Quién dijo que la tierra giraba alrededor del sol?";
            pregunta5.Respuestas = new List<Respuesta>
            {
                new Respuesta("Galileo Galilei", "a"),
                new Respuesta("Aristarco de Samos", "b"),
                new Respuesta("Nicolás Copérnico", "c"),
                new Respuesta("Marco Polo", "d")
            };
            pregunta5.Categoria = 4;
            pregunta5.RespuestaValida = "b";

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
    }
}
