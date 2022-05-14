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
    public partial class Pregunta5 : Form
    {
        public Pregunta5()
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
                puntos += 1200;
                Premio premio = new Premio();
                premio.lblApodo.Text = lblApodo.Text;
                premio.lblPuntos.Text = puntos.ToString();
                MessageBox.Show("¡Respuesta Correcta!" + "\n" + " has ganado " + puntos + " puntos");
                premio.Show();
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
        private void Pregunta5_Load(object sender, EventArgs e)
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

            return validar; ;
        }

        /// <summary>
        /// Método que llena en memoria las preguntas de categoria 5
        /// </summary>
        /// <returns> Retorna una lista de preguntas </returns>
        private List<Pregunta> CrearPreguntas()
        {
            List<Pregunta> preguntas = new List<Pregunta>();
            Pregunta pregunta1 = new Pregunta();
            pregunta1.Enunciado = "¿En qué año cayó el Imperio Romano de Occidente?";
            pregunta1.Respuestas = new List<Respuesta>
            {
                new Respuesta("320", "a"),
                new Respuesta("476", "b"),
                new Respuesta("27", "c"),
                new Respuesta("150", "d")
            };
            pregunta1.Categoria = 5;
            pregunta1.RespuestaValida = "b";

            preguntas.Add(pregunta1);

            Pregunta pregunta2 = new Pregunta();
            pregunta2.Enunciado = "¿Cuál es la obra más famosa de Edvard Munch?";

            pregunta2.Respuestas = new List<Respuesta>
            {
                new Respuesta("El Grito", "a"),
                new Respuesta("Guemica", "b"),
                new Respuesta("Las señoritas de Avignon", "c"),
                new Respuesta("El jardín de las delicias", "d")
            };
            pregunta2.Categoria = 5;
            pregunta2.RespuestaValida = "a";

            preguntas.Add(pregunta2);

            Pregunta pregunta3 = new Pregunta();
            pregunta3.Enunciado = "¿Cuántas zonas horarias tiene Rusia?";
            pregunta3.Respuestas = new List<Respuesta>
            {
                new Respuesta("3", "a"),
                new Respuesta("5", "b"),
                new Respuesta("11", "c"),
                new Respuesta("7", "d")
            };
            pregunta3.Categoria = 5;
            pregunta3.RespuestaValida = "c";

            preguntas.Add(pregunta3);

            Pregunta pregunta4 = new Pregunta();
            pregunta4.Enunciado = "¿Qué batalla marítima tuvo lugar en el año 1805?";
            pregunta4.Respuestas = new List<Respuesta>
            {
                new Respuesta("Yamen", "a"),
                new Respuesta("Lepanto", "b"),
                new Respuesta("Trafalgar", "c"),
                new Respuesta("Armada Invencible", "d"),
            };
            pregunta4.Categoria = 5;
            pregunta4.RespuestaValida = "c";

            preguntas.Add(pregunta4);

            Pregunta pregunta5 = new Pregunta();
            pregunta5.Enunciado = "¿Cómo se llamó al levantamiento que acabó con la dictadura de Salazar en Portugal?";
            pregunta5.Respuestas = new List<Respuesta>
            {
                new Respuesta("La revolución de los claveles", "a"),
                new Respuesta("La revolución de los tulipanes", "b"),
                new Respuesta("La revolución de las rosas", "c"),
                new Respuesta("La revolución de noviembre", "d")
            };
            pregunta5.Categoria = 5;
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
