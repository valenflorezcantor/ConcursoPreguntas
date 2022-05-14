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
    public partial class Premio : Form
    {
        public Premio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del botón Reclamar, muestra el dinero correspondiente a los puntos totales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReclamar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Tu premio es: $" + lblPuntos.Text + "!" + "\n" + " Nos pondremos en contacto contigo");
            btnReclamar.Enabled = false;
        }

        /// <summary>
        /// Evento del botón Puntajes, muestra al concursante la lista de los mejores puntajes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPuntajes_Click(object sender, EventArgs e)
        {
            Podio podio = new Podio();
            podio.lblApodo.Text = lblApodo.Text;
            podio.lblPuntos.Text = lblPuntos.Text;
            podio.Show();
            this.Close();
        }

        /// <summary>
        /// Evento del botón Volver a intentarlo, reinicia el juego en caso de que el concursante lo requiera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
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
