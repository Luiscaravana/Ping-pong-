namespace JogoPingPong
{
    partial class UserRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label pontosLabel;
            System.Windows.Forms.Label nºTelemovelLabel;
            this.jogadoresDataSet = new JogoPingPong.jogadoresDataSet();
            this.jogadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogadoresTableAdapter = new JogoPingPong.jogadoresDataSetTableAdapters.JogadoresTableAdapter();
            this.tableAdapterManager = new JogoPingPong.jogadoresDataSetTableAdapters.TableAdapterManager();
            this.jogadoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.jogadoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.pontosTextBox = new System.Windows.Forms.TextBox();
            this.nºTelemovelTextBox = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            pontosLabel = new System.Windows.Forms.Label();
            nºTelemovelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresBindingNavigator)).BeginInit();
            this.jogadoresBindingNavigator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            // jogadoresBindingNavigator
            // 
            this.jogadoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jogadoresBindingNavigator.BindingSource = this.jogadoresBindingSource;
            this.jogadoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jogadoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jogadoresBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.jogadoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.jogadoresBindingNavigatorSaveItem});
            this.jogadoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jogadoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jogadoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jogadoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jogadoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jogadoresBindingNavigator.Name = "jogadoresBindingNavigator";
            this.jogadoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jogadoresBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.jogadoresBindingNavigator.TabIndex = 0;
            this.jogadoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // jogadoresBindingNavigatorSaveItem
            // 
            this.jogadoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jogadoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jogadoresBindingNavigatorSaveItem.Image")));
            this.jogadoresBindingNavigatorSaveItem.Name = "jogadoresBindingNavigatorSaveItem";
            this.jogadoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.jogadoresBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.jogadoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.JogadoresBindingNavigatorSaveItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 299);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(iDLabel);
            this.tabPage1.Controls.Add(this.iDTextBox);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Controls.Add(loginLabel);
            this.tabPage1.Controls.Add(this.loginTextBox);
            this.tabPage1.Controls.Add(passwordLabel);
            this.tabPage1.Controls.Add(this.passwordTextBox);
            this.tabPage1.Controls.Add(pontosLabel);
            this.tabPage1.Controls.Add(this.pontosTextBox);
            this.tabPage1.Controls.Add(nºTelemovelLabel);
            this.tabPage1.Controls.Add(this.nºTelemovelTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UserData";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelUserName);
            this.tabPage2.Controls.Add(this.textBoxUserName);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consult";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(29, 33);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadoresBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(131, 30);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(235, 22);
            this.iDTextBox.TabIndex = 1;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(29, 61);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 17);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadoresBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(131, 58);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(235, 22);
            this.nomeTextBox.TabIndex = 3;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(29, 89);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(47, 17);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadoresBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(131, 86);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(235, 22);
            this.loginTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(29, 117);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(73, 17);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadoresBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(131, 114);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(235, 22);
            this.passwordTextBox.TabIndex = 7;
            // 
            // pontosLabel
            // 
            pontosLabel.AutoSize = true;
            pontosLabel.Location = new System.Drawing.Point(29, 145);
            pontosLabel.Name = "pontosLabel";
            pontosLabel.Size = new System.Drawing.Size(56, 17);
            pontosLabel.TabIndex = 8;
            pontosLabel.Text = "Pontos:";
            // 
            // pontosTextBox
            // 
            this.pontosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadoresBindingSource, "Pontos", true));
            this.pontosTextBox.Location = new System.Drawing.Point(131, 142);
            this.pontosTextBox.Name = "pontosTextBox";
            this.pontosTextBox.Size = new System.Drawing.Size(235, 22);
            this.pontosTextBox.TabIndex = 9;
            // 
            // nºTelemovelLabel
            // 
            nºTelemovelLabel.AutoSize = true;
            nºTelemovelLabel.Location = new System.Drawing.Point(29, 173);
            nºTelemovelLabel.Name = "nºTelemovelLabel";
            nºTelemovelLabel.Size = new System.Drawing.Size(96, 17);
            nºTelemovelLabel.TabIndex = 10;
            nºTelemovelLabel.Text = "Nº Telemovel:";
            // 
            // nºTelemovelTextBox
            // 
            this.nºTelemovelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadoresBindingSource, "NºTelemovel", true));
            this.nºTelemovelTextBox.Location = new System.Drawing.Point(131, 170);
            this.nºTelemovelTextBox.Name = "nºTelemovelTextBox";
            this.nºTelemovelTextBox.Size = new System.Drawing.Size(235, 22);
            this.nºTelemovelTextBox.TabIndex = 11;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(141, 61);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(75, 17);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "UserName";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(222, 58);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(397, 22);
            this.textBoxUserName.TabIndex = 5;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.TextBoxUserName_TextChanged);
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.jogadoresBindingNavigator);
            this.Name = "UserRegister";
            this.Text = "UserRegister";
            this.Load += new System.EventHandler(this.UserRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresBindingNavigator)).EndInit();
            this.jogadoresBindingNavigator.ResumeLayout(false);
            this.jogadoresBindingNavigator.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private jogadoresDataSet jogadoresDataSet;
        private System.Windows.Forms.BindingSource jogadoresBindingSource;
        private jogadoresDataSetTableAdapters.JogadoresTableAdapter jogadoresTableAdapter;
        private jogadoresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jogadoresBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton jogadoresBindingNavigatorSaveItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox pontosTextBox;
        private System.Windows.Forms.TextBox nºTelemovelTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
    }
}