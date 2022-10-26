namespace Desktop_Biblioteca.Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnLimparUsuario = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.chkSenha = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblsenha.ForeColor = System.Drawing.Color.White;
            this.lblsenha.Location = new System.Drawing.Point(73, 147);
            this.lblsenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(74, 28);
            this.lblsenha.TabIndex = 40;
            this.lblsenha.Text = "Senha:";
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenhaUser.Location = new System.Drawing.Point(150, 148);
            this.txtSenhaUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaUser.MaxLength = 10;
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.Size = new System.Drawing.Size(245, 27);
            this.txtSenhaUser.TabIndex = 39;
            this.txtSenhaUser.UseSystemPasswordChar = true;
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailUser.Location = new System.Drawing.Point(150, 100);
            this.txtEmailUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailUser.MaxLength = 50;
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(245, 27);
            this.txtEmailUser.TabIndex = 37;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(73, 96);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(69, 28);
            this.lblemail.TabIndex = 38;
            this.lblemail.Text = "Email:";
            // 
            // btnLimparUsuario
            // 
            this.btnLimparUsuario.BackColor = System.Drawing.Color.Red;
            this.btnLimparUsuario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLimparUsuario.ForeColor = System.Drawing.Color.White;
            this.btnLimparUsuario.Location = new System.Drawing.Point(250, 243);
            this.btnLimparUsuario.Name = "btnLimparUsuario";
            this.btnLimparUsuario.Size = new System.Drawing.Size(112, 59);
            this.btnLimparUsuario.TabIndex = 36;
            this.btnLimparUsuario.Text = "Limpar";
            this.btnLimparUsuario.UseVisualStyleBackColor = false;
            this.btnLimparUsuario.Click += new System.EventHandler(this.btnLimparUsuario_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Lime;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(114, 243);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(112, 59);
            this.btnEntrar.TabIndex = 35;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLogin.Location = new System.Drawing.Point(13, 9);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(89, 37);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 61);
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
            this.btnFechar.Location = new System.Drawing.Point(410, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 61);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(109, 210);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(253, 30);
            this.lblErro.TabIndex = 41;
            this.lblErro.Text = "Email ou senha inválidos!";
            this.lblErro.Visible = false;
            // 
            // chkSenha
            // 
            this.chkSenha.AutoSize = true;
            this.chkSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.285714F, System.Drawing.FontStyle.Bold);
            this.chkSenha.ForeColor = System.Drawing.Color.White;
            this.chkSenha.Location = new System.Drawing.Point(150, 182);
            this.chkSenha.Name = "chkSenha";
            this.chkSenha.Size = new System.Drawing.Size(115, 25);
            this.chkSenha.TabIndex = 42;
            this.chkSenha.Text = "Exibir senha";
            this.chkSenha.UseVisualStyleBackColor = true;
            this.chkSenha.CheckedChanged += new System.EventHandler(this.chkSenha_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(483, 344);
            this.Controls.Add(this.chkSenha);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.txtEmailUser);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btnLimparUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
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
        private System.Windows.Forms.TextBox txtEmailUser;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnLimparUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.CheckBox chkSenha;
    }
}