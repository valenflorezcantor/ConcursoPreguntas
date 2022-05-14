namespace ConcursoPreguntas
{
    partial class Premio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Premio));
            this.lblPremio = new System.Windows.Forms.Label();
            this.pbPremio = new System.Windows.Forms.PictureBox();
            this.lblTextoPuntos = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblApodo = new System.Windows.Forms.Label();
            this.btnReclamar = new System.Windows.Forms.Button();
            this.btnPuntajes = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPremio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPremio
            // 
            this.lblPremio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPremio.AutoSize = true;
            this.lblPremio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPremio.Location = new System.Drawing.Point(400, 35);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(153, 32);
            this.lblPremio.TabIndex = 5;
            this.lblPremio.Text = "has ganado!";
            this.lblPremio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPremio
            // 
            this.pbPremio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPremio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPremio.BackgroundImage")));
            this.pbPremio.Location = new System.Drawing.Point(214, 146);
            this.pbPremio.Name = "pbPremio";
            this.pbPremio.Size = new System.Drawing.Size(428, 254);
            this.pbPremio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPremio.TabIndex = 4;
            this.pbPremio.TabStop = false;
            // 
            // lblTextoPuntos
            // 
            this.lblTextoPuntos.AutoSize = true;
            this.lblTextoPuntos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextoPuntos.Location = new System.Drawing.Point(347, 105);
            this.lblTextoPuntos.Name = "lblTextoPuntos";
            this.lblTextoPuntos.Size = new System.Drawing.Size(128, 25);
            this.lblTextoPuntos.TabIndex = 41;
            this.lblTextoPuntos.Text = "Total Puntos:";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuntos.Location = new System.Drawing.Point(481, 105);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(23, 25);
            this.lblPuntos.TabIndex = 40;
            this.lblPuntos.Text = "0";
            // 
            // lblApodo
            // 
            this.lblApodo.AutoSize = true;
            this.lblApodo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApodo.Location = new System.Drawing.Point(312, 35);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(91, 32);
            this.lblApodo.TabIndex = 39;
            this.lblApodo.Text = "Apodo";
            // 
            // btnReclamar
            // 
            this.btnReclamar.Location = new System.Drawing.Point(347, 492);
            this.btnReclamar.Name = "btnReclamar";
            this.btnReclamar.Size = new System.Drawing.Size(150, 23);
            this.btnReclamar.TabIndex = 42;
            this.btnReclamar.Text = "¡Reclamar mi premio!";
            this.btnReclamar.UseVisualStyleBackColor = true;
            this.btnReclamar.Click += new System.EventHandler(this.btnReclamar_Click);
            // 
            // btnPuntajes
            // 
            this.btnPuntajes.Location = new System.Drawing.Point(214, 492);
            this.btnPuntajes.Name = "btnPuntajes";
            this.btnPuntajes.Size = new System.Drawing.Size(114, 23);
            this.btnPuntajes.TabIndex = 43;
            this.btnPuntajes.Text = "Mejores puntajes";
            this.btnPuntajes.UseVisualStyleBackColor = true;
            this.btnPuntajes.Click += new System.EventHandler(this.btnPuntajes_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(528, 492);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 23);
            this.btnVolver.TabIndex = 44;
            this.btnVolver.Text = "Volver a jugar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Premio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 574);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnPuntajes);
            this.Controls.Add(this.btnReclamar);
            this.Controls.Add(this.lblTextoPuntos);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblApodo);
            this.Controls.Add(this.lblPremio);
            this.Controls.Add(this.pbPremio);
            this.Name = "Premio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premio";
            ((System.ComponentModel.ISupportInitialize)(this.pbPremio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPremio;
        private PictureBox pbPremio;
        private Label lblTextoPuntos;
        public Label lblPuntos;
        public Label lblApodo;
        private Button btnReclamar;
        private Button btnPuntajes;
        private Button btnVolver;
    }
}