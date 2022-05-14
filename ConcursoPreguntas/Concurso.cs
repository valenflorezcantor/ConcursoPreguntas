namespace ConcursoPreguntas
{
    public partial class Concurso : Form
    {
        public Concurso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del botón Iniciar, empieza el concurso y muestra la primera pregunta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Pregunta1 pregunta1 = new Pregunta1();
            pregunta1.lblApodo.Text = txtApodo.Text;
            pregunta1.Show();
            this.Close();
        }

    }
}