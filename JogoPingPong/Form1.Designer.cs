namespace JogoPingPong
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picRaquete = new System.Windows.Forms.PictureBox();
            this.picBola = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.byLuísCaravanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.jogadoresDataSet = new JogoPingPong.jogadoresDataSet();
            this.jogadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogadoresTableAdapter = new JogoPingPong.jogadoresDataSetTableAdapters.JogadoresTableAdapter();
            this.tableAdapterManager = new JogoPingPong.jogadoresDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.picRaquete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBola)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // picRaquete
            // 
            this.picRaquete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picRaquete.Location = new System.Drawing.Point(779, 118);
            this.picRaquete.Name = "picRaquete";
            this.picRaquete.Size = new System.Drawing.Size(20, 237);
            this.picRaquete.TabIndex = 1;
            this.picRaquete.TabStop = false;
            this.picRaquete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // picBola
            // 
            this.picBola.Image = global::JogoPingPong.Properties.Resources.bola;
            this.picBola.Location = new System.Drawing.Point(83, 93);
            this.picBola.Name = "picBola";
            this.picBola.Size = new System.Drawing.Size(45, 55);
            this.picBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBola.TabIndex = 0;
            this.picBola.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.userToolStripMenuItem,
            this.toolStripMenuItem1,
            this.userToolStripMenuItem1,
            this.toolStripMenuItem7,
            this.byLuísCaravanaToolStripMenuItem,
            this.toolStripMenuItem8,
            this.scoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegisterToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.userToolStripMenuItem.Text = "Admistrador";
            // 
            // userRegisterToolStripMenuItem
            // 
            this.userRegisterToolStripMenuItem.Name = "userRegisterToolStripMenuItem";
            this.userRegisterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.userRegisterToolStripMenuItem.Text = "UserRegister";
            this.userRegisterToolStripMenuItem.Click += new System.EventHandler(this.UserRegisterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(31, 24);
            this.toolStripMenuItem1.Text = "||";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(31, 24);
            this.toolStripMenuItem2.Text = "||";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(48, 24);
            this.toolStripMenuItem3.Text = "Log";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem4.Text = "In";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem5.Text = "Out";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.OutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem6.Text = "Exit";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(52, 24);
            this.userToolStripMenuItem1.Text = "User";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(31, 24);
            this.toolStripMenuItem7.Text = "||";
            // 
            // byLuísCaravanaToolStripMenuItem
            // 
            this.byLuísCaravanaToolStripMenuItem.Name = "byLuísCaravanaToolStripMenuItem";
            this.byLuísCaravanaToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.byLuísCaravanaToolStripMenuItem.Text = "by Luís Caravana";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(31, 24);
            this.toolStripMenuItem8.Text = "||";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.scoreToolStripMenuItem.Text = "Score:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 22);
            this.textBox1.TabIndex = 3;
            // 
            // jogadoresDataSet
            // 
            this.jogadoresDataSet.DataSetName = "jogadoresDataSet";
            this.jogadoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jogadoresBindingSource
            // 
            this.jogadoresBindingSource.DataMember = "Jogadores";
            this.jogadoresBindingSource.DataSource = this.jogadoresDataSet;
            // 
            // jogadoresTableAdapter
            // 
            this.jogadoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JogadoresTableAdapter = this.jogadoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = JogoPingPong.jogadoresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picRaquete);
            this.Controls.Add(this.picBola);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jogo Ping Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRaquete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBola)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBola;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picRaquete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem byLuísCaravanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private jogadoresDataSet jogadoresDataSet;
        private System.Windows.Forms.BindingSource jogadoresBindingSource;
        private jogadoresDataSetTableAdapters.JogadoresTableAdapter jogadoresTableAdapter;
        private jogadoresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

