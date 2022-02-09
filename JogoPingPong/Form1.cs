using System;
using System.Drawing;
using System.Media;
using System.IO;
using System.Windows.Forms;

namespace JogoPingPong
{
    public partial class Form1 : Form
    {
        public Form1(int valor)
        {
            InitializeComponent();
            if (valor == 0)
            {
                valor = 100;
            }
            else
            {
                picRaquete.Height = valor;
            }
        }
        int velocidade = 10;
        int resultado;
        bool topo, esquerda;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'jogadoresDataSet.Jogadores'. Você pode movê-la ou removê-la conforme necessário.
            this.jogadoresTableAdapter.Fill(this.jogadoresDataSet.Jogadores);
            Random rand = new Random();
            picBola.Location = new Point(0, rand.Next(this.Height));
            topo = esquerda = true;
            timer1.Enabled = true;
            Som();
            this.jogadoresTableAdapter.FillByLogin(this.jogadoresDataSet.Jogadores,
              FormLogin.user, FormLogin.pass);
          
            userToolStripMenuItem.Text = "User: " + FormLogin.user;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (picBola.Left > picRaquete.Left)
            {
                timer1.Enabled = false; MessageBox.Show("Você perdeu :  " + resultado.ToString());
                resultado = 0;
            }
            if (picBola.Left + picBola.Width >= picRaquete.Left && picBola.Left + picBola.Width
                <= picRaquete.Left + picRaquete.Width
                && picBola.Top + picBola.Height >= picRaquete.Top && picBola.Top + picBola.Height
                <= picRaquete.Top + picRaquete.Height + picBola.Height)
            {
                esquerda = false;
                resultado += 1;
                this.Text = resultado.ToString();
            }
            if (esquerda)
                picBola.Left += velocidade;
            else
                picBola.Left -= velocidade;
            if (topo)
                picBola.Top += velocidade;
            else
                picBola.Top -= velocidade;
            if (picBola.Top >= this.Height - 50)
                topo = false;
            if (picBola.Top <= 0)
                topo = true;
            if (picBola.Left <= 0)
                esquerda = true;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            picRaquete.Top = e.Y;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UserRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewUser frm = new FormNewUser();
            frm.ShowDialog();
        }

        private void JogadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jogadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jogadoresDataSet);

        }

        private void Som()
        {
            System.IO.Stream str2 = Properties.Resources.somfundo;
            System.Media.SoundPlayer snd2 = new System.Media.SoundPlayer(str2);
            snd2.Play();
        }
    }
}
 