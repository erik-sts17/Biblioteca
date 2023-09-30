namespace Desktop_Biblioteca.Cadastro.Emprestimo
{
    partial class FrmNovoEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovoEmprestimo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNovoEmprestimo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.lblSucesso = new System.Windows.Forms.Label();
            this.gbLivros = new System.Windows.Forms.GroupBox();
            this.lblSemLivros = new System.Windows.Forms.Label();
            this.btnAdicionaLivro = new System.Windows.Forms.Button();
            this.livrosDisponiveis = new System.Windows.Forms.CheckedListBox();
            this.confirmacaoEmprestimo = new System.Windows.Forms.GroupBox();
            this.txtTotalPaginas = new System.Windows.Forms.TextBox();
            this.lblTotalPaginas = new System.Windows.Forms.Label();
            this.txtTotalLivros = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.dtDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbLivros.SuspendLayout();
            this.confirmacaoEmprestimo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Controls.Add(this.lblNovoEmprestimo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 53);
            this.panel2.TabIndex = 22;
            // 
            // lblNovoEmprestimo
            // 
            this.lblNovoEmprestimo.AutoSize = true;
            this.lblNovoEmprestimo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNovoEmprestimo.Location = new System.Drawing.Point(9, 9);
            this.lblNovoEmprestimo.Name = "lblNovoEmprestimo";
            this.lblNovoEmprestimo.Size = new System.Drawing.Size(190, 30);
            this.lblNovoEmprestimo.TabIndex = 4;
            this.lblNovoEmprestimo.Text = "Novo Empréstimo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(297, 538);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(92, 48);
            this.btnLimpar.TabIndex = 46;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Lime;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(209, 538);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 48);
            this.btnSalvar.TabIndex = 45;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnBuscaCliente);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Controls.Add(this.lblNome);
            this.gbCliente.Controls.Add(this.txtRg);
            this.gbCliente.Controls.Add(this.txtNome);
            this.gbCliente.Controls.Add(this.lblErro);
            this.gbCliente.Controls.Add(this.txtEmail);
            this.gbCliente.Controls.Add(this.lblCpfCliente);
            this.gbCliente.ForeColor = System.Drawing.Color.White;
            this.gbCliente.Location = new System.Drawing.Point(11, 66);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gbCliente.Size = new System.Drawing.Size(605, 168);
            this.gbCliente.TabIndex = 59;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackColor = System.Drawing.Color.Lime;
            this.btnBuscaCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscaCliente.Location = new System.Drawing.Point(326, 47);
            this.btnBuscaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(52, 32);
            this.btnBuscaCliente.TabIndex = 74;
            this.btnBuscaCliente.Text = "buscar";
            this.btnBuscaCliente.UseVisualStyleBackColor = false;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(311, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 73;
            this.label4.Text = "Rg:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(8, 94);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 71;
            this.lblNome.Text = "Nome:";
            // 
            // txtRg
            // 
            this.txtRg.Enabled = false;
            this.txtRg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRg.Location = new System.Drawing.Point(315, 118);
            this.txtRg.MaxLength = 50;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(129, 23);
            this.txtRg.TabIndex = 70;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome.Location = new System.Drawing.Point(12, 118);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 23);
            this.txtNome.TabIndex = 68;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(391, 50);
            this.lblErro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(201, 25);
            this.lblErro.TabIndex = 67;
            this.lblErro.Text = "Cliente não encontrado!";
            this.lblErro.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(12, 53);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 23);
            this.txtEmail.TabIndex = 66;
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCpfCliente.ForeColor = System.Drawing.Color.White;
            this.lblCpfCliente.Location = new System.Drawing.Point(8, 29);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(57, 21);
            this.lblCpfCliente.TabIndex = 64;
            this.lblCpfCliente.Text = "Email:";
            // 
            // lblSucesso
            // 
            this.lblSucesso.AutoSize = true;
            this.lblSucesso.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSucesso.ForeColor = System.Drawing.Color.Lime;
            this.lblSucesso.Location = new System.Drawing.Point(159, 511);
            this.lblSucesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucesso.Name = "lblSucesso";
            this.lblSucesso.Size = new System.Drawing.Size(296, 25);
            this.lblSucesso.TabIndex = 60;
            this.lblSucesso.Text = "Empréstimo realizado com sucesso!";
            this.lblSucesso.Visible = false;
            // 
            // gbLivros
            // 
            this.gbLivros.Controls.Add(this.lblSemLivros);
            this.gbLivros.Controls.Add(this.btnAdicionaLivro);
            this.gbLivros.Controls.Add(this.livrosDisponiveis);
            this.gbLivros.ForeColor = System.Drawing.Color.White;
            this.gbLivros.Location = new System.Drawing.Point(11, 238);
            this.gbLivros.Margin = new System.Windows.Forms.Padding(2);
            this.gbLivros.Name = "gbLivros";
            this.gbLivros.Padding = new System.Windows.Forms.Padding(2);
            this.gbLivros.Size = new System.Drawing.Size(605, 177);
            this.gbLivros.TabIndex = 63;
            this.gbLivros.TabStop = false;
            this.gbLivros.Text = "Livros";
            // 
            // lblSemLivros
            // 
            this.lblSemLivros.AutoSize = true;
            this.lblSemLivros.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSemLivros.ForeColor = System.Drawing.Color.Red;
            this.lblSemLivros.Location = new System.Drawing.Point(57, 69);
            this.lblSemLivros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSemLivros.Name = "lblSemLivros";
            this.lblSemLivros.Size = new System.Drawing.Size(357, 25);
            this.lblSemLivros.TabIndex = 75;
            this.lblSemLivros.Text = "Nenhum livro disponivel, realize o cadastro!";
            this.lblSemLivros.Visible = false;
            // 
            // btnAdicionaLivro
            // 
            this.btnAdicionaLivro.BackColor = System.Drawing.Color.Lime;
            this.btnAdicionaLivro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionaLivro.ForeColor = System.Drawing.Color.White;
            this.btnAdicionaLivro.Location = new System.Drawing.Point(471, 64);
            this.btnAdicionaLivro.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionaLivro.Name = "btnAdicionaLivro";
            this.btnAdicionaLivro.Size = new System.Drawing.Size(85, 37);
            this.btnAdicionaLivro.TabIndex = 75;
            this.btnAdicionaLivro.Text = "Confirmar";
            this.btnAdicionaLivro.UseVisualStyleBackColor = false;
            this.btnAdicionaLivro.Click += new System.EventHandler(this.btnAdicionaLivro_Click);
            // 
            // livrosDisponiveis
            // 
            this.livrosDisponiveis.FormattingEnabled = true;
            this.livrosDisponiveis.Location = new System.Drawing.Point(12, 18);
            this.livrosDisponiveis.Name = "livrosDisponiveis";
            this.livrosDisponiveis.Size = new System.Drawing.Size(432, 139);
            this.livrosDisponiveis.TabIndex = 0;
            // 
            // confirmacaoEmprestimo
            // 
            this.confirmacaoEmprestimo.Controls.Add(this.txtTotalPaginas);
            this.confirmacaoEmprestimo.Controls.Add(this.lblTotalPaginas);
            this.confirmacaoEmprestimo.Controls.Add(this.txtTotalLivros);
            this.confirmacaoEmprestimo.Controls.Add(this.lblQuantidade);
            this.confirmacaoEmprestimo.Controls.Add(this.lblNasc);
            this.confirmacaoEmprestimo.Controls.Add(this.dtDataDevolucao);
            this.confirmacaoEmprestimo.ForeColor = System.Drawing.Color.White;
            this.confirmacaoEmprestimo.Location = new System.Drawing.Point(11, 419);
            this.confirmacaoEmprestimo.Margin = new System.Windows.Forms.Padding(2);
            this.confirmacaoEmprestimo.Name = "confirmacaoEmprestimo";
            this.confirmacaoEmprestimo.Padding = new System.Windows.Forms.Padding(2);
            this.confirmacaoEmprestimo.Size = new System.Drawing.Size(605, 90);
            this.confirmacaoEmprestimo.TabIndex = 64;
            this.confirmacaoEmprestimo.TabStop = false;
            this.confirmacaoEmprestimo.Text = "Confirmação Empréstimo";
            this.confirmacaoEmprestimo.Visible = false;
            // 
            // txtTotalPaginas
            // 
            this.txtTotalPaginas.Enabled = false;
            this.txtTotalPaginas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalPaginas.Location = new System.Drawing.Point(170, 49);
            this.txtTotalPaginas.MaxLength = 50;
            this.txtTotalPaginas.Name = "txtTotalPaginas";
            this.txtTotalPaginas.Size = new System.Drawing.Size(94, 23);
            this.txtTotalPaginas.TabIndex = 76;
            // 
            // lblTotalPaginas
            // 
            this.lblTotalPaginas.AutoSize = true;
            this.lblTotalPaginas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaginas.ForeColor = System.Drawing.Color.White;
            this.lblTotalPaginas.Location = new System.Drawing.Point(166, 25);
            this.lblTotalPaginas.Name = "lblTotalPaginas";
            this.lblTotalPaginas.Size = new System.Drawing.Size(116, 21);
            this.lblTotalPaginas.TabIndex = 75;
            this.lblTotalPaginas.Text = "Total Páginas:";
            // 
            // txtTotalLivros
            // 
            this.txtTotalLivros.Enabled = false;
            this.txtTotalLivros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalLivros.Location = new System.Drawing.Point(12, 49);
            this.txtTotalLivros.MaxLength = 50;
            this.txtTotalLivros.Name = "txtTotalLivros";
            this.txtTotalLivros.Size = new System.Drawing.Size(94, 23);
            this.txtTotalLivros.TabIndex = 74;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(8, 25);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(101, 21);
            this.lblQuantidade.TabIndex = 46;
            this.lblQuantidade.Text = "Total Livros:";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNasc.ForeColor = System.Drawing.Color.White;
            this.lblNasc.Location = new System.Drawing.Point(322, 25);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(183, 21);
            this.lblNasc.TabIndex = 45;
            this.lblNasc.Text = "Data limite devolução:";
            // 
            // dtDataDevolucao
            // 
            this.dtDataDevolucao.Enabled = false;
            this.dtDataDevolucao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataDevolucao.Location = new System.Drawing.Point(326, 49);
            this.dtDataDevolucao.Name = "dtDataDevolucao";
            this.dtDataDevolucao.Size = new System.Drawing.Size(130, 23);
            this.dtDataDevolucao.TabIndex = 42;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(572, -3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 56);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // FrmNovoEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(627, 607);
            this.Controls.Add(this.confirmacaoEmprestimo);
            this.Controls.Add(this.gbLivros);
            this.Controls.Add(this.lblSucesso);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNovoEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroFuncionario";
            this.Load += new System.EventHandler(this.FrmCadastroFuncionario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbLivros.ResumeLayout(false);
            this.gbLivros.PerformLayout();
            this.confirmacaoEmprestimo.ResumeLayout(false);
            this.confirmacaoEmprestimo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNovoEmprestimo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblSucesso;
        private System.Windows.Forms.GroupBox gbLivros;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox confirmacaoEmprestimo;
        private System.Windows.Forms.DateTimePicker dtDataDevolucao;
        private System.Windows.Forms.TextBox txtTotalLivros;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.CheckedListBox livrosDisponiveis;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Button btnAdicionaLivro;
        private System.Windows.Forms.TextBox txtTotalPaginas;
        private System.Windows.Forms.Label lblTotalPaginas;
        private System.Windows.Forms.Label lblSemLivros;
        private System.Windows.Forms.Button btnFechar;
    }
}