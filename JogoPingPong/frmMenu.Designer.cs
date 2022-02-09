namespace JogoPingPong
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciante = new System.Windows.Forms.Button();
            this.buttonIntermedia = new System.Windows.Forms.Button();
            this.buttonAvancado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o nível do jogo";
            // 
            // btnIniciante
            // 
            this.btnIniciante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIniciante.ForeColor = System.Drawing.Color.Black;
            this.btnIniciante.Location = new System.Drawing.Point(75, 124);
            this.btnIniciante.Name = "btnIniciante";
            this.btnIniciante.Size = new System.Drawing.Size(158, 36);
            this.btnIniciante.TabIndex = 1;
            this.btnIniciante.Text = "Iniciante";
            this.btnIniciante.UseVisualStyleBackColor = false;
            this.btnIniciante.Click += new System.EventHandler(this.BtnIniciante_Click);
            // 
            // buttonIntermedia
            // 
            this.buttonIntermedia.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonIntermedia.Location = new System.Drawing.Point(75, 200);
            this.buttonIntermedia.Name = "buttonIntermedia";
            this.buttonIntermedia.Size = new System.Drawing.Size(158, 36);
            this.buttonIntermedia.TabIndex = 2;
            this.buttonIntermedia.Text = "Intermédia";
            this.buttonIntermedia.UseVisualStyleBackColor = false;
            this.buttonIntermedia.Click += new System.EventHandler(this.ButtonIntermedia_Click);
            // 
            // buttonAvancado
            // 
            this.buttonAvancado.BackColor = System.Drawing.Color.Turquoise;
            this.buttonAvancado.Location = new System.Drawing.Point(75, 276);
            this.buttonAvancado.Name = "buttonAvancado";
            this.buttonAvancado.Size = new System.Drawing.Size(158, 36);
            this.buttonAvancado.TabIndex = 3;
            this.buttonAvancado.Text = "Avançado";
            this.buttonAvancado.UseVisualStyleBackColor = false;
            this.buttonAvancado.Click += new System.EventHandler(this.ButtonAvancado_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(325, 357);
            this.Controls.Add(this.buttonAvancado);
            this.Controls.Add(this.buttonIntermedia);
            this.Controls.Add(this.btnIniciante);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciante;
        private System.Windows.Forms.Button buttonIntermedia;
        private System.Windows.Forms.Button buttonAvancado;
    }
}