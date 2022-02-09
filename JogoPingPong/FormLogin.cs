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
    public partial class FormLogin : Form
    {
        static public string user;
        static public string pass;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'jogadoresDataSet.Jogadores'. Você pode movê-la ou removê-la conforme necessário.
            this.jogadoresTableAdapter.Fill(this.jogadoresDataSet.Jogadores);

        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;

            int res = this.jogadoresTableAdapter.FillByLogin(this.jogadoresDataSet.Jogadores,
                  textBoxUsername.Text, textBoxPassword.Text);
            if (res == 1)
            {
                frmMenu frm = new frmMenu();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong username/password");
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
