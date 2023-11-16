namespace EmpresaX2A
{
    partial class CadFun
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
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_nascimento = new System.Windows.Forms.DateTimePicker();
            this.tx_estadocivil = new System.Windows.Forms.ComboBox();
            this.b_voltar = new System.Windows.Forms.PictureBox();
            this.b_salvar = new System.Windows.Forms.PictureBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.tx_estado = new System.Windows.Forms.TextBox();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tx_rg = new System.Windows.Forms.MaskedTextBox();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.tx_funcao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_salvar)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.Color.Tan;
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_nome.Location = new System.Drawing.Point(39, 118);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(281, 22);
            this.tx_nome.TabIndex = 11;
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.Color.Tan;
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_email.Location = new System.Drawing.Point(39, 251);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(281, 22);
            this.tx_email.TabIndex = 14;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BackColor = System.Drawing.Color.Tan;
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_endereco.Location = new System.Drawing.Point(39, 323);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(256, 22);
            this.tx_endereco.TabIndex = 16;
            // 
            // tx_nascimento
            // 
            this.tx_nascimento.CalendarMonthBackground = System.Drawing.Color.Tan;
            this.tx_nascimento.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.tx_nascimento.CalendarTrailingForeColor = System.Drawing.Color.DarkGoldenrod;
            this.tx_nascimento.Location = new System.Drawing.Point(39, 184);
            this.tx_nascimento.Name = "tx_nascimento";
            this.tx_nascimento.Size = new System.Drawing.Size(256, 22);
            this.tx_nascimento.TabIndex = 18;
            // 
            // tx_estadocivil
            // 
            this.tx_estadocivil.BackColor = System.Drawing.Color.Tan;
            this.tx_estadocivil.ForeColor = System.Drawing.Color.Black;
            this.tx_estadocivil.FormattingEnabled = true;
            this.tx_estadocivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Divorciado(a)",
            "Casado(a)",
            "Viúvo(a)"});
            this.tx_estadocivil.Location = new System.Drawing.Point(335, 118);
            this.tx_estadocivil.Name = "tx_estadocivil";
            this.tx_estadocivil.Size = new System.Drawing.Size(196, 24);
            this.tx_estadocivil.TabIndex = 19;
            this.tx_estadocivil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // b_voltar
            // 
            this.b_voltar.BackgroundImage = global::EmpresaX2A.Properties.Resources.BotaoVoltar2;
            this.b_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_voltar.Location = new System.Drawing.Point(39, 384);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(153, 51);
            this.b_voltar.TabIndex = 21;
            this.b_voltar.TabStop = false;
            // 
            // b_salvar
            // 
            this.b_salvar.BackgroundImage = global::EmpresaX2A.Properties.Resources.BotaoSalvar1;
            this.b_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_salvar.Location = new System.Drawing.Point(606, 384);
            this.b_salvar.Name = "b_salvar";
            this.b_salvar.Size = new System.Drawing.Size(146, 51);
            this.b_salvar.TabIndex = 22;
            this.b_salvar.TabStop = false;
            this.b_salvar.Click += new System.EventHandler(this.b_salvar_Click);
            // 
            // tx_cidade
            // 
            this.tx_cidade.BackColor = System.Drawing.Color.Tan;
            this.tx_cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_cidade.Location = new System.Drawing.Point(304, 323);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(208, 22);
            this.tx_cidade.TabIndex = 24;
            // 
            // tx_estado
            // 
            this.tx_estado.BackColor = System.Drawing.Color.Tan;
            this.tx_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_estado.Location = new System.Drawing.Point(525, 323);
            this.tx_estado.Name = "tx_estado";
            this.tx_estado.Size = new System.Drawing.Size(227, 22);
            this.tx_estado.TabIndex = 25;
            // 
            // tx_telefone
            // 
            this.tx_telefone.BackColor = System.Drawing.Color.BurlyWood;
            this.tx_telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_telefone.Location = new System.Drawing.Point(550, 119);
            this.tx_telefone.Mask = "(99) 0 0000-0000";
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(202, 22);
            this.tx_telefone.TabIndex = 27;
            // 
            // tx_rg
            // 
            this.tx_rg.BackColor = System.Drawing.Color.Tan;
            this.tx_rg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_rg.Location = new System.Drawing.Point(304, 184);
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(202, 22);
            this.tx_rg.TabIndex = 28;
            // 
            // tx_cpf
            // 
            this.tx_cpf.BackColor = System.Drawing.Color.Tan;
            this.tx_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_cpf.Location = new System.Drawing.Point(525, 184);
            this.tx_cpf.Mask = "000.000.000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(227, 22);
            this.tx_cpf.TabIndex = 29;
            // 
            // tx_salario
            // 
            this.tx_salario.BackColor = System.Drawing.Color.Tan;
            this.tx_salario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_salario.Location = new System.Drawing.Point(525, 251);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(227, 22);
            this.tx_salario.TabIndex = 23;
            // 
            // tx_funcao
            // 
            this.tx_funcao.BackColor = System.Drawing.Color.Tan;
            this.tx_funcao.ForeColor = System.Drawing.Color.Black;
            this.tx_funcao.FormattingEnabled = true;
            this.tx_funcao.Items.AddRange(new object[] {
            "Gerente",
            "Caixa",
            "Atendente",
            "Auxiliar de limpeza",
            "Analista",
            "Coordenador"});
            this.tx_funcao.Location = new System.Drawing.Point(335, 249);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(171, 24);
            this.tx_funcao.TabIndex = 30;
            // 
            // CadFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmpresaX2A.Properties.Resources.X2A___20_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.tx_estado);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.b_salvar);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.tx_estadocivil);
            this.Controls.Add(this.tx_nascimento);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_nome);
            this.DoubleBuffered = true;
            this.Name = "CadFun";
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_salvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.DateTimePicker tx_nascimento;
        private System.Windows.Forms.ComboBox tx_estadocivil;
        private System.Windows.Forms.PictureBox b_voltar;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox tx_estado;
        private System.Windows.Forms.PictureBox b_salvar;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.MaskedTextBox tx_rg;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.ComboBox tx_funcao;
    }
}

