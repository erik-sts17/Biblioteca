namespace Desktop_Biblioteca.Login
{
    partial class FrmAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarSenha));
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.btnLimparUsuario = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblAlterarSenha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.chkSenha = new System.Windows.Forms.CheckBox();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.lblSucesso = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblsenha.ForeColor = System.Drawing.Color.White;
            this.lblsenha.Location = new System.Drawing.Point(12, 152);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(92, 21);
            this.lblsenha.TabIndex = 40;
            this.lblsenha.Text = "Confirmar:";
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenhaUser.Location = new System.Drawing.Point(122, 150);
            this.txtSenhaUser.MaxLength = 10;
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.Size = new System.Drawing.Size(185, 23);
            this.txtSenhaUser.TabIndex = 39;
            this.txtSenhaUser.UseSystemPasswordChar = true;
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNovaSenha.ForeColor = System.Drawing.Color.White;
            this.lblNovaSenha.Location = new System.Drawing.Point(11, 113);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(106, 21);
            this.lblNovaSenha.TabIndex = 38;
            this.lblNovaSenha.Text = "Nova Senha:";
            // 
            // btnLimparUsuario
            // 
            this.btnLimparUsuario.BackColor = System.Drawing.Color.Red;
            this.btnLimparUsuario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLimparUsuario.ForeColor = System.Drawing.Color.White;
            this.btnLimparUsuario.Location = new System.Drawing.Point(186, 240);
            this.btnLimparUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparUsuario.Name = "btnLimparUsuario";
            this.btnLimparUsuario.Size = new System.Drawing.Size(89, 48);
            this.btnLimparUsuario.TabIndex = 36;
            this.btnLimparUsuario.Text = "Limpar";
            this.btnLimparUsuario.UseVisualStyleBackColor = false;
            this.btnLimparUsuario.Click += new System.EventHandler(this.btnLimparUsuario_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Yellow;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Location = new System.Drawing.Point(83, 240);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 48);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAlterarSenha.Location = new System.Drawing.Point(10, 7);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.Size = new System.Drawing.Size(146, 30);
            this.lblAlterarSenha.TabIndex = 2;
            this.lblAlterarSenha.Text = "Alterar Senha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblAlterarSenha);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 50);
            this.panel1.TabIndex = 34;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(327, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 50);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // chkSenha
            // 
            this.chkSenha.AutoSize = true;
            this.chkSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.285714F, System.Drawing.FontStyle.Bold);
            this.chkSenha.ForeColor = System.Drawing.Color.White;
            this.chkSenha.Location = new System.Drawing.Point(122, 179);
            this.chkSenha.Margin = new System.Windows.Forms.Padding(2);
            this.chkSenha.Name = "chkSenha";
            this.chkSenha.Size = new System.Drawing.Size(100, 21);
            this.chkSenha.TabIndex = 42;
            this.chkSenha.Text = "Exibir senha";
            this.chkSenha.UseVisualStyleBackColor = true;
            this.chkSenha.CheckedChanged += new System.EventHandler(this.chkSenha_CheckedChanged);
            // 
            // txtSenha1
            // 
            this.txtSenha1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenha1.Location = new System.Drawing.Point(123, 115);
            this.txtSenha1.MaxLength = 10;
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.Size = new System.Drawing.Size(185, 23);
            this.txtSenha1.TabIndex = 43;
            this.txtSenha1.UseSystemPasswordChar = true;
            // 
            // lblSucesso
            // 
            this.lblSucesso.AutoSize = true;
            this.lblSucesso.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSucesso.ForeColor = System.Drawing.Color.Lime;
            this.lblSucesso.Location = new System.Drawing.Point(54, 203);
            this.lblSucesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucesso.Name = "lblSucesso";
            this.lblSucesso.Size = new System.Drawing.Size(254, 25);
            this.lblSucesso.TabIndex = 61;
            this.lblSucesso.Text = "Dados alterados com sucesso!";
            this.lblSucesso.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(12, 63);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 21);
            this.lblUsuario.TabIndex = 62;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(118, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 21);
            this.lblEmail.TabIndex = 63;
            this.lblEmail.Text = "email";
            // 
            // FrmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(381, 299);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSucesso);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.chkSenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.btnLimparUsuario);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Button btnLimparUsuario;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblAlterarSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.CheckBox chkSenha;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.Label lblSucesso;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEmail;
    }
}