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
            this.lblNasc = new System.Windows.Forms.Label();
            this.buttonLimpa = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSucesso = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxAutor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionaGenero = new System.Windows.Forms.Button();
            this.btnAdicionaCategoria = new System.Windows.Forms.Button();
            this.btnAdicionaAutor = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblLivro);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 65);
            this.panel2.TabIndex = 22;
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLivro.Location = new System.Drawing.Point(12, 11);
            this.lblLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(255, 37);
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
            this.btnFechar.Location = new System.Drawing.Point(843, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 69);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome.Location = new System.Drawing.Point(91, 111);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(579, 27);
            this.txtNome.TabIndex = 27;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(87, 155);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(85, 28);
            this.lblGenero.TabIndex = 31;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(86, 82);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 28);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNasc.ForeColor = System.Drawing.Color.White;
            this.lblNasc.Location = new System.Drawing.Point(731, 82);
            this.lblNasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(90, 28);
            this.lblNasc.TabIndex = 44;
            this.lblNasc.Text = "Páginas:";
            // 
            // buttonLimpa
            // 
            this.buttonLimpa.BackColor = System.Drawing.Color.Red;
            this.buttonLimpa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonLimpa.ForeColor = System.Drawing.Color.White;
            this.buttonLimpa.Location = new System.Drawing.Point(500, 363);
            this.buttonLimpa.Name = "buttonLimpa";
            this.buttonLimpa.Size = new System.Drawing.Size(112, 59);
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
            this.btnEntrar.Location = new System.Drawing.Point(340, 363);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(112, 59);
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
            this.lblSucesso.Location = new System.Drawing.Point(335, 320);
            this.lblSucesso.Name = "lblSucesso";
            this.lblSucesso.Size = new System.Drawing.Size(303, 30);
            this.lblSucesso.TabIndex = 60;
            this.lblSucesso.Text = "Dados gravados com sucesso!";
            this.lblSucesso.Visible = false;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaginas.Location = new System.Drawing.Point(736, 111);
            this.txtPaginas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaginas.MaxLength = 50;
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(85, 27);
            this.txtPaginas.TabIndex = 61;
            // 
            // cbxGenero
            // 
            this.cbxGenero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(92, 199);
            this.cbxGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(360, 28);
            this.cbxGenero.TabIndex = 62;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(500, 199);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(321, 28);
            this.cbxCategoria.TabIndex = 64;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(495, 155);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(108, 28);
            this.lblCategoria.TabIndex = 63;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbxAutor
            // 
            this.cbxAutor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxAutor.FormattingEnabled = true;
            this.cbxAutor.Location = new System.Drawing.Point(91, 288);
            this.cbxAutor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAutor.Name = "cbxAutor";
            this.cbxAutor.Size = new System.Drawing.Size(730, 28);
            this.cbxAutor.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 65;
            this.label2.Text = "Autor:";
            // 
            // btnAdicionaGenero
            // 
            this.btnAdicionaGenero.BackColor = System.Drawing.Color.Lime;
            this.btnAdicionaGenero.Font = new System.Drawing.Font("Segoe UI", 12.10084F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionaGenero.ForeColor = System.Drawing.Color.White;
            this.btnAdicionaGenero.Location = new System.Drawing.Point(179, 147);
            this.btnAdicionaGenero.Name = "btnAdicionaGenero";
            this.btnAdicionaGenero.Size = new System.Drawing.Size(123, 45);
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
            this.btnAdicionaCategoria.Location = new System.Drawing.Point(610, 147);
            this.btnAdicionaCategoria.Name = "btnAdicionaCategoria";
            this.btnAdicionaCategoria.Size = new System.Drawing.Size(117, 45);
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
            this.btnAdicionaAutor.Location = new System.Drawing.Point(179, 238);
            this.btnAdicionaAutor.Name = "btnAdicionaAutor";
            this.btnAdicionaAutor.Size = new System.Drawing.Size(123, 45);
            this.btnAdicionaAutor.TabIndex = 69;
            this.btnAdicionaAutor.Text = "Adicionar";
            this.btnAdicionaAutor.UseVisualStyleBackColor = false;
            this.btnAdicionaAutor.Visible = false;
            this.btnAdicionaAutor.Click += new System.EventHandler(this.btnAdicionaAutor_Click);
            // 
            // FrmCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(916, 435);
            this.Controls.Add(this.btnAdicionaAutor);
            this.Controls.Add(this.btnAdicionaCategoria);
            this.Controls.Add(this.btnAdicionaGenero);
            this.Controls.Add(this.cbxAutor);
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
            this.Name = "FrmCadastroLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroFuncionario";
            this.Load += new System.EventHandler(this.FrmCadastroFuncionario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.Button buttonLimpa;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSucesso;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionaGenero;
        private System.Windows.Forms.Button btnAdicionaCategoria;
        private System.Windows.Forms.Button btnAdicionaAutor;
    }
}