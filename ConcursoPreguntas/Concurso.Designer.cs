namespace ConcursoPreguntas
{
    partial class Concurso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concurso));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pbConcurso = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblApodo = new System.Windows.Forms.Label();
            this.txtApodo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(336, 415);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(93, 23);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pbConcurso
            // 
            this.pbConcurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbConcurso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConcurso.BackgroundImage")));
            this.pbConcurso.Location = new System.Drawing.Point(274, 70);
            this.pbConcurso.Name = "pbConcurso";
            this.pbConcurso.Size = new System.Drawing.Size(214, 221);
            this.pbConcurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConcurso.TabIndex = 2;
            this.pbConcurso.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.Location = new System.Drawing.Point(192, 18);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(400, 30);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "¡Bienvenid@ al Concurso de Preguntas!";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApodo
            // 
            this.lblApodo.AutoSize = true;
            this.lblApodo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApodo.Location = new System.Drawing.Point(336, 312);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(96, 15);
            this.lblApodo.TabIndex = 4;
            this.lblApodo.Text = "Digite su apodo:";
            // 
            // txtApodo
            // 
            this.txtApodo.Location = new System.Drawing.Point(274, 341);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(214, 23);
            this.txtApodo.TabIndex = 5;
            // 
            // Concurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.txtApodo);
            this.Controls.Add(this.lblApodo);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pbConcurso);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Concurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concurso Preguntas";
            ((System.ComponentModel.ISupportInitialize)(this.pbConcurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnIniciar;
        private PictureBox pbConcurso;
        private Label lblBienvenida;
        private Label lblApodo;
        private TextBox txtApodo;
    }
}