using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPingPong
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void BtnIniciante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(200);
            frm1.Show();
        }

        private void ButtonIntermedia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(100);
            frm1.Show();
        }

        private void ButtonAvancado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1(50);
            frm1.Show();
        }
    }
}
