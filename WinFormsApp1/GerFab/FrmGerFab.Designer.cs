namespace CATI.GerFab
{
    partial class FrmGerFab
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            BtnFabCad = new Button();
            GridFab = new DataGridView();
            PesquisaFab = new Button();
            DTfimcad = new DateTimePicker();
            CmbSituacao = new ComboBox();
            DTinicioCad = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            TxtNomeFab = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridFab).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.closeNormal_Image;
            button1.Location = new Point(434, 12);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.minimizeNormal_Image;
            button2.Location = new Point(398, 12);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 47);
            label1.TabIndex = 2;
            label1.Text = "C.A.T.I";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(189, 43);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 3;
            label2.Text = "Fabricantes";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(BtnFabCad);
            groupBox1.Controls.Add(GridFab);
            groupBox1.Controls.Add(PesquisaFab);
            groupBox1.Controls.Add(DTfimcad);
            groupBox1.Controls.Add(CmbSituacao);
            groupBox1.Controls.Add(DTinicioCad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtNomeFab);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 338);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.FlatAppearance.BorderColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = Properties.Resources.remover_usuario;
            button5.Location = new Point(355, 278);
            button5.Name = "button5";
            button5.Size = new Size(88, 46);
            button5.TabIndex = 13;
            button5.Text = "  Deletar";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.FlatAppearance.BorderColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Image = Properties.Resources.lapis;
            button4.Location = new Point(355, 197);
            button4.Name = "button4";
            button4.Size = new Size(88, 46);
            button4.TabIndex = 12;
            button4.Text = " Editar";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // BtnFabCad
            // 
            BtnFabCad.BackColor = SystemColors.Control;
            BtnFabCad.FlatAppearance.BorderColor = Color.Silver;
            BtnFabCad.FlatStyle = FlatStyle.Flat;
            BtnFabCad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFabCad.Image = Properties.Resources.adicionar_usuario;
            BtnFabCad.Location = new Point(355, 116);
            BtnFabCad.Name = "BtnFabCad";
            BtnFabCad.Size = new Size(88, 46);
            BtnFabCad.TabIndex = 11;
            BtnFabCad.Text = "  Novo";
            BtnFabCad.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFabCad.UseVisualStyleBackColor = false;
            BtnFabCad.Click += BtnFabCad_Click;
            // 
            // GridFab
            // 
            GridFab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridFab.BackgroundColor = Color.White;
            GridFab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridFab.Location = new Point(22, 116);
            GridFab.Name = "GridFab";
            GridFab.ReadOnly = true;
            GridFab.RowHeadersVisible = false;
            GridFab.Size = new Size(323, 208);
            GridFab.TabIndex = 10;
            // 
            // PesquisaFab
            // 
            PesquisaFab.FlatAppearance.BorderColor = Color.Silver;
            PesquisaFab.FlatStyle = FlatStyle.Flat;
            PesquisaFab.Location = new Point(365, 37);
            PesquisaFab.Name = "PesquisaFab";
            PesquisaFab.Size = new Size(74, 25);
            PesquisaFab.TabIndex = 9;
            PesquisaFab.Text = "Pesquisar";
            PesquisaFab.UseVisualStyleBackColor = true;
            PesquisaFab.Click += PesquisaFab_Click;
            // 
            // DTfimcad
            // 
            DTfimcad.Format = DateTimePickerFormat.Short;
            DTfimcad.Location = new Point(110, 81);
            DTfimcad.Name = "DTfimcad";
            DTfimcad.Size = new Size(83, 23);
            DTfimcad.TabIndex = 8;
            // 
            // CmbSituacao
            // 
            CmbSituacao.FlatStyle = FlatStyle.System;
            CmbSituacao.FormattingEnabled = true;
            CmbSituacao.Items.AddRange(new object[] { "Ativo", "Inativo" });
            CmbSituacao.Location = new Point(229, 37);
            CmbSituacao.Name = "CmbSituacao";
            CmbSituacao.Size = new Size(121, 23);
            CmbSituacao.TabIndex = 7;
            // 
            // DTinicioCad
            // 
            DTinicioCad.CalendarForeColor = Color.Navy;
            DTinicioCad.CalendarTitleForeColor = Color.Navy;
            DTinicioCad.Format = DateTimePickerFormat.Short;
            DTinicioCad.Location = new Point(22, 81);
            DTinicioCad.Name = "DTinicioCad";
            DTinicioCad.Size = new Size(82, 23);
            DTinicioCad.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(22, 63);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 4;
            label5.Text = "Data Cadastro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(234, 19);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 2;
            label4.Text = "Situação:";
            // 
            // TxtNomeFab
            // 
            TxtNomeFab.BorderStyle = BorderStyle.FixedSingle;
            TxtNomeFab.Location = new Point(22, 37);
            TxtNomeFab.Name = "TxtNomeFab";
            TxtNomeFab.Size = new Size(184, 23);
            TxtNomeFab.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(22, 19);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 0;
            label3.Text = "Nome Fabricante:";
            // 
            // FrmGerFab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.telaAzul;
            ClientSize = new Size(481, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGerFab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGerFab";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridFab).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox TxtNomeFab;
        private Button PesquisaFab;
        private DateTimePicker DTfimcad;
        private ComboBox CmbSituacao;
        private DateTimePicker DTinicioCad;
        private Label label5;
        private Label label4;
        private Button BtnFabCad;
        private DataGridView GridFab;
        private Button button4;
        private Button button5;
    }
}