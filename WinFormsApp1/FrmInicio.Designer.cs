namespace WinFormsApp1
{
    partial class FrmInicio
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            equipamentoToolStripMenuItem = new ToolStripMenuItem();
            fabricanteToolStripMenuItem = new ToolStripMenuItem();
            departamentoToolStripMenuItem = new ToolStripMenuItem();
            equipamentoToolStripMenuItem1 = new ToolStripMenuItem();
            suprimentoToolStripMenuItem = new ToolStripMenuItem();
            setorToolStripMenuItem = new ToolStripMenuItem();
            linhaTelefonicaToolStripMenuItem = new ToolStripMenuItem();
            chipToolStripMenuItem = new ToolStripMenuItem();
            utilizadorToolStripMenuItem = new ToolStripMenuItem();
            controleToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlCommandBuilder1
            // 
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = CATI.Properties.Resources.closeNormal_Image;
            button1.Location = new Point(679, 12);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 47);
            label1.TabIndex = 1;
            label1.Text = "C.A.T.I";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(132, 26);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 2;
            label2.Text = "Controle de Ativos de T.I";
            // 
            // mySqlCommand1
            // 
            //mySqlCommand1.CommandTimeout = 0;
            //mySqlCommand1.Connection = null;
            //mySqlCommand1.Transaction = null;
            //mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 410);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = CATI.Properties.Resources.C_A_T_I_fundo;
            pictureBox1.Location = new Point(0, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(721, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Navy;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, cadastroToolStripMenuItem, controleToolStripMenuItem, relatóriosToolStripMenuItem, sistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(742, 24);
            menuStrip1.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(22, 20);
            toolStripMenuItem1.Text = " ";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { equipamentoToolStripMenuItem, setorToolStripMenuItem, linhaTelefonicaToolStripMenuItem });
            cadastroToolStripMenuItem.ForeColor = Color.White;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // equipamentoToolStripMenuItem
            // 
            equipamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fabricanteToolStripMenuItem, departamentoToolStripMenuItem, equipamentoToolStripMenuItem1, suprimentoToolStripMenuItem });
            equipamentoToolStripMenuItem.Name = "equipamentoToolStripMenuItem";
            equipamentoToolStripMenuItem.Size = new Size(180, 22);
            equipamentoToolStripMenuItem.Text = "Equipamento";
            // 
            // fabricanteToolStripMenuItem
            // 
            fabricanteToolStripMenuItem.Name = "fabricanteToolStripMenuItem";
            fabricanteToolStripMenuItem.Size = new Size(180, 22);
            fabricanteToolStripMenuItem.Text = "Fabricante";
            fabricanteToolStripMenuItem.Click += fabricanteToolStripMenuItem_Click;
            // 
            // departamentoToolStripMenuItem
            // 
            departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            departamentoToolStripMenuItem.Size = new Size(180, 22);
            departamentoToolStripMenuItem.Text = "Departamento";
            // 
            // equipamentoToolStripMenuItem1
            // 
            equipamentoToolStripMenuItem1.Name = "equipamentoToolStripMenuItem1";
            equipamentoToolStripMenuItem1.Size = new Size(180, 22);
            equipamentoToolStripMenuItem1.Text = "Equipamento";
            // 
            // suprimentoToolStripMenuItem
            // 
            suprimentoToolStripMenuItem.Name = "suprimentoToolStripMenuItem";
            suprimentoToolStripMenuItem.Size = new Size(180, 22);
            suprimentoToolStripMenuItem.Text = "Suprimento";
            // 
            // setorToolStripMenuItem
            // 
            setorToolStripMenuItem.Name = "setorToolStripMenuItem";
            setorToolStripMenuItem.Size = new Size(180, 22);
            setorToolStripMenuItem.Text = "Setor";
            // 
            // linhaTelefonicaToolStripMenuItem
            // 
            linhaTelefonicaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chipToolStripMenuItem, utilizadorToolStripMenuItem });
            linhaTelefonicaToolStripMenuItem.Name = "linhaTelefonicaToolStripMenuItem";
            linhaTelefonicaToolStripMenuItem.Size = new Size(180, 22);
            linhaTelefonicaToolStripMenuItem.Text = "Linha Telefonica";
            // 
            // chipToolStripMenuItem
            // 
            chipToolStripMenuItem.Name = "chipToolStripMenuItem";
            chipToolStripMenuItem.Size = new Size(124, 22);
            chipToolStripMenuItem.Text = "Chip";
            // 
            // utilizadorToolStripMenuItem
            // 
            utilizadorToolStripMenuItem.Name = "utilizadorToolStripMenuItem";
            utilizadorToolStripMenuItem.Size = new Size(124, 22);
            utilizadorToolStripMenuItem.Text = "Utilizador";
            // 
            // controleToolStripMenuItem
            // 
            controleToolStripMenuItem.ForeColor = Color.White;
            controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            controleToolStripMenuItem.Size = new Size(65, 20);
            controleToolStripMenuItem.Text = "Controle";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.ForeColor = Color.White;
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem, sairToolStripMenuItem });
            sistemaToolStripMenuItem.ForeColor = Color.White;
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(114, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(114, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Cornsilk;
            button2.Image = CATI.Properties.Resources.minimizeNormal_Image;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(643, 12);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = CATI.Properties.Resources.telaAzul;
            ClientSize = new Size(716, 430);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FrmInicio";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            MouseDown += FrmLogin_MouseDown_1;
            MouseMove += FrmLogin_MouseMove;
            MouseUp += FrmLogin_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Button button1;
        private Label label1;
        private Label label2;
       // private MySqlConnector.MySqlCommand mySqlCommand1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem equipamentoToolStripMenuItem;
        private ToolStripMenuItem fabricanteToolStripMenuItem;
        private ToolStripMenuItem departamentoToolStripMenuItem;
        private ToolStripMenuItem equipamentoToolStripMenuItem1;
        private ToolStripMenuItem suprimentoToolStripMenuItem;
        private ToolStripMenuItem setorToolStripMenuItem;
        private ToolStripMenuItem linhaTelefonicaToolStripMenuItem;
        private ToolStripMenuItem chipToolStripMenuItem;
        private ToolStripMenuItem utilizadorToolStripMenuItem;
        private ToolStripMenuItem controleToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private Button button2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
