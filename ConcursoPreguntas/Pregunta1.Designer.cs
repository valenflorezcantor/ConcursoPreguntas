namespace ConcursoPreguntas
{
    partial class Pregunta1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregunta1));
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnRetirarse = new System.Windows.Forms.Button();
            this.lblApodo = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.pbPregunta1 = new System.Windows.Forms.PictureBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.lblEnunciado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPregunta1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPregunta1.Location = new System.Drawing.Point(180, 9);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(122, 25);
            this.lblPregunta1.TabIndex = 0;
            this.lblPregunta1.Text = "Pregunta #1";
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(108, 578);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(75, 23);
            this.btnResponder.TabIndex = 1;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnRetirarse
            // 
            this.btnRetirarse.Location = new System.Drawing.Point(290, 578);
            this.btnRetirarse.Name = "btnRetirarse";
            this.btnRetirarse.Size = new System.Drawing.Size(75, 23);
            this.btnRetirarse.TabIndex = 2;
            this.btnRetirarse.Text = "Retirarse";
            this.btnRetirarse.UseVisualStyleBackColor = true;
            this.btnRetirarse.Click += new System.EventHandler(this.btnRetirarse_Click);
            // 
            // lblApodo
            // 
            this.lblApodo.AutoSize = true;
            this.lblApodo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApodo.Location = new System.Drawing.Point(12, 9);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(43, 15);
            this.lblApodo.TabIndex = 3;
            this.lblApodo.Text = "Apodo";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuntos.Location = new System.Drawing.Point(12, 38);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(58, 15);
            this.lblPuntos.TabIndex = 4;
            this.lblPuntos.Text = "Puntos: 0";
            // 
            // pbPregunta1
            // 
            this.pbPregunta1.Image = ((System.Drawing.Image)(resources.GetObject("pbPregunta1.Image")));
            this.pbPregunta1.Location = new System.Drawing.Point(108, 37);
            this.pbPregunta1.Name = "pbPregunta1";
            this.pbPregunta1.Size = new System.Drawing.Size(257, 212);
            this.pbPregunta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPregunta1.TabIndex = 5;
            this.pbPregunta1.TabStop = false;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPregunta.Location = new System.Drawing.Point(108, 493);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(116, 15);
            this.lblPregunta.TabIndex = 6;
            this.lblPregunta.Text = "Digite su respuesta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(265, 490);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(100, 23);
            this.txtRespuesta.TabIndex = 7;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(108, 253);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(63, 15);
            this.lblEnunciado.TabIndex = 8;
            this.lblEnunciado.Text = "Enunciado";
            // 
            // Pregunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(477, 633);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.pbPregunta1);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblApodo);
            this.Controls.Add(this.btnRetirarse);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.lblPregunta1);
            this.Name = "Pregunta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta1";
            this.Load += new System.EventHandler(this.Pregunta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPregunta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPregunta1;
        private Button btnResponder;
        private Button btnRetirarse;
        private Label lblPuntos;
        private PictureBox pbPregunta1;
        private Label lblPregunta;
        private TextBox txtRespuesta;
        private Label lblEnunciado;
        public Label lblApodo;
    }
}