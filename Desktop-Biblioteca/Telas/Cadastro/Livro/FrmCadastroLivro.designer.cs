namespace Desktop_Biblioteca.Cadastro
{
    partial class FrmCadastroLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroLivro));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLivro = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.buttonLimpa = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSucesso = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionaGenero = new System.Windows.Forms.Button();
            this.btnAdicionaCategoria = new System.Windows.Forms.Button();
            this.btnAdicionaAutor = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.checkedAutores = new System.Windows.Forms.CheckedListBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblLivro);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 53);
            this.panel2.TabIndex = 22;
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLivro.Location = new System.Drawing.Point(9, 9);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(193, 30);
            this.lblLivro.TabIndex = 4;
            this.lblLivro.Text = "Cadastro de Livros";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(807, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 56);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome.Location = new System.Drawing.Point(68, 90);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(549, 23);
            this.txtNome.TabIndex = 27;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(65, 126);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(69, 21);
            this.lblGenero.TabIndex = 31;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(64, 67);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 21);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // buttonLimpa
            // 
            this.buttonLimpa.BackColor = System.Drawing.Color.Red;
            this.buttonLimpa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonLimpa.ForeColor = System.Drawing.Color.White;
            this.buttonLimpa.Location = new System.Drawing.Point(422, 322);
            this.buttonLimpa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLimpa.Name = "buttonLimpa";
            this.buttonLimpa.Size = new System.Drawing.Size(92, 48);
            this.buttonLimpa.TabIndex = 46;
            this.buttonLimpa.Text = "Limpar";
            this.buttonLimpa.UseVisualStyleBackColor = false;
            this.buttonLimpa.Click += new System.EventHandler(this.buttonLimpa_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Lime;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(317, 322);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(84, 48);
            this.btnEntrar.TabIndex = 45;
            this.btnEntrar.Text = "Salvar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblSucesso
            // 
            this.lblSucesso.AutoSize = true;
            this.lblSucesso.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSucesso.ForeColor = System.Drawing.Color.Lime;
            this.lblSucesso.Location = new System.Drawing.Point(288, 288);
            this.lblSucesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucesso.Name = "lblSucesso";
            this.lblSucesso.Size = new System.Drawing.Size(255, 25);
            this.lblSucesso.TabIndex = 60;
            this.lblSucesso.Text = "Dados gravados com sucesso!";
            this.lblSucesso.Visible = false;
            // 
            // cbxGenero
            // 
            this.cbxGenero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(69, 162);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(271, 23);
            this.cbxGenero.TabIndex = 62;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(375, 162);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(242, 23);
            this.cbxCategoria.TabIndex = 64;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(371, 126);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(88, 21);
            this.lblCategoria.TabIndex = 63;
            this.lblCategoria.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Autores:";
            // 
            // btnAdicionaGenero
            // 
            this.btnAdicionaGenero.BackColor = System.Drawing.Color.Lime;
            this.btnAdicionaGenero.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionaGenero.ForeColor = System.Drawing.Color.White;
            this.btnAdicionaGenero.Location = new System.Drawing.Point(143, 119);
            this.btnAdicionaGenero.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionaGenero.Name = "btnAdicionaGenero";
            this.btnAdicionaGenero.Size = new System.Drawing.Size(99, 37);
            this.btnAdicionaGenero.TabIndex = 67;
            this.btnAdicionaGenero.Text = "Adicionar";
            this.btnAdicionaGenero.UseVisualStyleBackColor = false;
            this.btnAdicionaGenero.Visible = false;
            this.btnAdicionaGenero.Click += new System.EventHandler(this.btnAdicionaGenero_Click);
            // 
            // btnAdicionaCategoria
            // 
            this.btnAdicionaCategoria.BackColor = System.Drawing.Color.Lime;
            this.btnAdicionaCategoria.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionaCategoria.ForeColor = System.Drawing.Color.White;
            this.btnAdicionaCategoria.Location = new System.Drawing.Point(458, 119);
            this.btnAdicionaCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionaCategoria.Name = "btnAdicionaCategoria";
            this.btnAdicionaCategoria.Size = new System.Drawing.Size(98, 37);
            this.btnAdicionaCategoria.TabIndex = 68;
            this.btnAdicionaCategoria.Text = "Adicionar";
            this.btnAdicionaCategoria.UseVisualStyleBackColor = false;
            this.btnAdicionaCategoria.Visible = false;
            this.btnAdicionaCategoria.Click += new System.EventHandler(this.btnAdicionaCategoria_Click);
            // 
            // btnAdicionaAutor
            // 
            this.btnAdicionaAutor.BackColor = System.Drawing.Color.Lime;
            this.btnAdicionaAutor.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionaAutor.ForeColor = System.Drawing.Color.White;
            this.btnAdicionaAutor.Location = new System.Drawing.Point(143, 192);
            this.btnAdicionaAutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionaAutor.Name = "btnAdicionaAutor";
            this.btnAdicionaAutor.Size = new System.Drawing.Size(99, 37);
            this.btnAdicionaAutor.TabIndex = 69;
            this.btnAdicionaAutor.Text = "Adicionar";
            this.btnAdicionaAutor.UseVisualStyleBackColor = false;
            this.btnAdicionaAutor.Visible = false;
            this.btnAdicionaAutor.Click += new System.EventHandler(this.btnAdicionaAutor_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbxCliente
            // 
            this.pbxCliente.BackColor = System.Drawing.Color.White;
            this.pbxCliente.Location = new System.Drawing.Point(650, 91);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(140, 167);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCliente.TabIndex = 70;
            this.pbxCliente.TabStop = false;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.BackColor = System.Drawing.Color.Lime;
            this.btnCarregarImagem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnCarregarImagem.ForeColor = System.Drawing.Color.White;
            this.btnCarregarImagem.Location = new System.Drawing.Point(661, 273);
            this.btnCarregarImagem.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(117, 48);
            this.btnCarregarImagem.TabIndex = 71;
            this.btnCarregarImagem.Text = "Buscar";
            this.btnCarregarImagem.UseVisualStyleBackColor = false;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFoto.ForeColor = System.Drawing.Color.White;
            this.lblFoto.Location = new System.Drawing.Point(646, 67);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(52, 21);
            this.lblFoto.TabIndex = 73;
            this.lblFoto.Text = "Capa:";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNasc.ForeColor = System.Drawing.Color.White;
            this.lblNasc.Location = new System.Drawing.Point(371, 200);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(74, 21);
            this.lblNasc.TabIndex = 44;
            this.lblNasc.Text = "Páginas:";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaginas.Location = new System.Drawing.Point(375, 235);
            this.txtPaginas.MaxLength = 50;
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(65, 23);
            this.txtPaginas.TabIndex = 61;
            this.txtPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaginas_KeyPress);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantidade.Location = new System.Drawing.Point(501, 235);
            this.txtQuantidade.MaxLength = 50;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(65, 23);
            this.txtQuantidade.TabIndex = 75;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaginas_KeyPress);
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblquantidade.ForeColor = System.Drawing.Color.White;
            this.lblquantidade.Location = new System.Drawing.Point(497, 200);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(104, 21);
            this.lblquantidade.TabIndex = 74;
            this.lblquantidade.Text = "Quantidade:";
            // 
            // checkedAutores
            // 
            this.checkedAutores.FormattingEnabled = true;
            this.checkedAutores.Location = new System.Drawing.Point(69, 242);
            this.checkedAutores.Name = "checkedAutores";
            this.checkedAutores.Size = new System.Drawing.Size(214, 79);
            this.checkedAutores.TabIndex = 76;
            // 
            // FrmCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(862, 390);
            this.Controls.Add(this.checkedAutores);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.pbxCliente);
            this.Controls.Add(this.btnAdicionaAutor);
            this.Controls.Add(this.btnAdicionaCategoria);
            this.Controls.Add(this.btnAdicionaGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.lblSucesso);
            this.Controls.Add(this.buttonLimpa);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastroLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroLivros";
            this.Load += new System.EventHandler(this.FrmCadastroFuncionario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button buttonLimpa;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSucesso;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionaGenero;
        private System.Windows.Forms.Button btnAdicionaCategoria;
        private System.Windows.Forms.Button btnAdicionaAutor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.CheckedListBox checkedAutores;
    }
}