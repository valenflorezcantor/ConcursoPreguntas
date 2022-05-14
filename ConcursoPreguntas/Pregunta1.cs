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
    public partial class Pregunta1 : Form
    {
        public Pregunta1()
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
                puntos += 200;
                Pregunta2 pregunta2 = new Pregunta2();
                pregunta2.lblApodo.Text = lblApodo.Text;
                pregunta2.lblPuntos.Text = puntos.ToString();
                MessageBox.Show("¡Respuesta Correcta!" + "\n" + " has ganado " + puntos + " puntos");
                pregunta2.Show();
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
        private void Pregunta1_Load(object sender, EventArgs e)
        {
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
        /// Método que llena en memoria las preguntas de categoria 1
        /// </summary>
        /// <returns> Retorna una lista de preguntas </returns>
        private List<Pregunta> CrearPreguntas()
        {
            List<Pregunta> preguntas = new List<Pregunta>();
            Pregunta pregunta1 = new Pregunta();
            pregunta1.Enunciado = "¿Cuáles son los colores de la bandera de Brasil?";
            pregunta1.Respuestas = new List<Respuesta>
            {
                new Respuesta("Amarillo, azul y rojo", "a"),
                new Respuesta("Verde y Amarillo", "b"),
                new Respuesta("Morado", "c"),
                new Respuesta("Negro y blanco", "d")
            };
            pregunta1.Categoria = 1;
            pregunta1.RespuestaValida = "b";

            preguntas.Add(pregunta1);

            Pregunta pregunta2 = new Pregunta();
            pregunta2.Enunciado = "¿Cuál es el país del mundo con mayor población?";

            pregunta2.Respuestas = new List<Respuesta>
            {
                new Respuesta("China", "a"),
                new Respuesta("Haiti", "b"),
                new Respuesta("Colombia", "c"),
                new Respuesta("Perú", "d")
            };
            pregunta2.Categoria = 1;
            pregunta2.RespuestaValida = "a";

            preguntas.Add(pregunta2);

            Pregunta pregunta3 = new Pregunta();
            pregunta3.Enunciado = "¿Cuál es el presidente de Venezuela?";
            pregunta3.Respuestas = new List<Respuesta>
            {
                new Respuesta("Hugo Chávez", "a"),
                new Respuesta("Alvaro Uribe", "b"),
                new Respuesta("Guillermo Lasso", "c"),
                new Respuesta("Nicolás Maduro", "d")
            };
            pregunta3.Categoria = 1;
            pregunta3.RespuestaValida = "d";

            preguntas.Add(pregunta3);

            Pregunta pregunta4 = new Pregunta();
            pregunta4.Enunciado = "¿Cuál es el mes que menos días tiene?";
            pregunta4.Respuestas = new List<Respuesta>
            {
                new Respuesta("Diciembre", "a"),
                new Respuesta("Junio", "b"),
                new Respuesta("Febrero", "c"),
                new Respuesta("Agosto", "d")
            };
            pregunta4.Categoria = 1;
            pregunta4.RespuestaValida = "c";

            preguntas.Add(pregunta4);

            Pregunta pregunta5 = new Pregunta();
            pregunta5.Enunciado = "¿Cómo se llaman las células nerviosas?";
            pregunta5.Respuestas = new List<Respuesta>
            {
                new Respuesta("Neumocitos", "a"),
                new Respuesta("Glóbulos rojos", "b"),
                new Respuesta("Neuronas", "c"),
                new Respuesta("Pigmentadas", "d")
            };
            pregunta5.Categoria = 1;
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
