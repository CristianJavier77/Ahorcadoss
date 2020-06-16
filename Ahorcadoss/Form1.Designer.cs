namespace Ahorcadoss
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flFichasDeJuego = new System.Windows.Forms.FlowLayoutPanel();
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.Jugando = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarJuego = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jugando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // flFichasDeJuego
            // 
            this.flFichasDeJuego.Location = new System.Drawing.Point(12, 98);
            this.flFichasDeJuego.Name = "flFichasDeJuego";
            this.flFichasDeJuego.Size = new System.Drawing.Size(445, 300);
            this.flFichasDeJuego.TabIndex = 0;
            // 
            // picAhorcado
            // 
            this.picAhorcado.Location = new System.Drawing.Point(463, 98);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(250, 300);
            this.picAhorcado.TabIndex = 1;
            this.picAhorcado.TabStop = false;
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(121, 400);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(608, 88);
            this.flPalabra.TabIndex = 2;
            // 
            // Jugando
            // 
            this.Jugando.Location = new System.Drawing.Point(0, 318);
            this.Jugando.Name = "Jugando";
            this.Jugando.Size = new System.Drawing.Size(115, 161);
            this.Jugando.TabIndex = 0;
            this.Jugando.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(568, 39);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(75, 13);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "LO MATASTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADIVINA LA PALABRA";
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Image = global::Ahorcadoss.Properties.Resources.BtnStart;
            this.btnIniciarJuego.Location = new System.Drawing.Point(14, 13);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(445, 46);
            this.btnIniciarJuego.TabIndex = 5;
            this.btnIniciarJuego.TabStop = false;
            this.btnIniciarJuego.Click += new System.EventHandler(this.BtnIniciarJuego_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 490);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.Jugando);
            this.Controls.Add(this.flPalabra);
            this.Controls.Add(this.picAhorcado);
            this.Controls.Add(this.flFichasDeJuego);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jugando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flFichasDeJuego;
        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.FlowLayoutPanel flPalabra;
        private System.Windows.Forms.PictureBox Jugando;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnIniciarJuego;
    }
}

