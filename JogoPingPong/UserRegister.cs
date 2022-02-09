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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void JogadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jogadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jogadoresDataSet);

        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'jogadoresDataSet.Jogadores'. Você pode movê-la ou removê-la conforme necessário.
            this.jogadoresTableAdapter.Fill(this.jogadoresDataSet.Jogadores);

        }

        private void TextBoxUserName_TextChanged(object sender, EventArgs e)
        {
            this.jogadoresTableAdapter.FillByJogadores(this.jogadoresDataSet.Jogadores, 
                textBoxUserName.Text);
        }
    }
}
