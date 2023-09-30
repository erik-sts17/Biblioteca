namespace Desktop_Biblioteca.Cadastro.Cliente
{
    partial class FrmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCadastroCliente = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNasc = new System.Windows.Forms.Label();
            this.dtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.btnBuscaCep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblSucesso = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.groupLogin = new System.Windows.Forms.GroupBox();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.clienteId = new System.Windows.Forms.Label();
            this.enderecoId = new System.Windows.Forms.Label();
            this.chkSenha = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.groupLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblCadastroCliente);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 53);
            this.panel2.TabIndex = 22;
            // 
            // lblCadastroCliente
            // 
            this.lblCadastroCliente.AutoSize = true;
            this.lblCadastroCliente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCadastroCliente.Location = new System.Drawing.Point(9, 9);
            this.lblCadastroCliente.Name = "lblCadastroCliente";
            this.lblCadastroCliente.Size = new System.Drawing.Size(203, 30);
            this.lblCadastroCliente.TabIndex = 4;
            this.lblCadastroCliente.Text = "Cadastro de Cliente";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(712, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 56);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(69, 152);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(435, 23);
            this.txtEmail.TabIndex = 32;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBairro.Location = new System.Drawing.Point(447, 50);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(154, 23);
            this.txtBairro.TabIndex = 30;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome.Location = new System.Drawing.Point(69, 93);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(435, 23);
            this.txtNome.TabIndex = 27;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(65, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 21);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(443, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bairro: *";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNome.Location = new System.Drawing.Point(64, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 21);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome: *";
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNasc.ForeColor = System.Drawing.Color.White;
            this.lblNasc.Location = new System.Drawing.Point(536, 67);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(180, 21);
            this.lblNasc.TabIndex = 44;
            this.lblNasc.Text = "Data de Nascimento: *";
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNascimento.Location = new System.Drawing.Point(540, 93);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.Size = new System.Drawing.Size(160, 23);
            this.dtDataNascimento.TabIndex = 41;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefone.Location = new System.Drawing.Point(357, 216);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(147, 23);
            this.txtTelefone.TabIndex = 43;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(351, 192);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(91, 21);
            this.lblTelefone.TabIndex = 42;
            this.lblTelefone.Text = "Telefone: *";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(400, 502);
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
            this.btnSalvar.Location = new System.Drawing.Point(292, 502);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 48);
            this.btnSalvar.TabIndex = 45;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 21);
            this.label11.TabIndex = 51;
            this.label11.Text = "Cep: *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(5, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 21);
            this.label12.TabIndex = 52;
            this.label12.Text = "UF: *";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(116, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 21);
            this.label13.TabIndex = 54;
            this.label13.Text = "Cidade: *";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCidade.Location = new System.Drawing.Point(120, 101);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(168, 23);
            this.txtCidade.TabIndex = 53;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEndereco.Location = new System.Drawing.Point(172, 50);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(249, 23);
            this.txtEndereco.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(168, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 21);
            this.label14.TabIndex = 55;
            this.label14.Text = "Endereço: *";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(330, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 21);
            this.label15.TabIndex = 58;
            this.label15.Text = "Nº *";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumero.Location = new System.Drawing.Point(334, 101);
            this.txtNumero.MaxLength = 100;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(61, 23);
            this.txtNumero.TabIndex = 57;
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.btnBuscaCep);
            this.gbEndereco.Controls.Add(this.label1);
            this.gbEndereco.Controls.Add(this.txtComplemento);
            this.gbEndereco.Controls.Add(this.cbUf);
            this.gbEndereco.Controls.Add(this.txtCep);
            this.gbEndereco.Controls.Add(this.label11);
            this.gbEndereco.Controls.Add(this.label2);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.txtEndereco);
            this.gbEndereco.Controls.Add(this.label15);
            this.gbEndereco.Controls.Add(this.label14);
            this.gbEndereco.Controls.Add(this.label13);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.label12);
            this.gbEndereco.ForeColor = System.Drawing.Color.White;
            this.gbEndereco.Location = new System.Drawing.Point(71, 289);
            this.gbEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Padding = new System.Windows.Forms.Padding(2);
            this.gbEndereco.Size = new System.Drawing.Size(629, 140);
            this.gbEndereco.TabIndex = 59;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // btnBuscaCep
            // 
            this.btnBuscaCep.BackColor = System.Drawing.Color.Lime;
            this.btnBuscaCep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCep.ForeColor = System.Drawing.Color.White;
            this.btnBuscaCep.Location = new System.Drawing.Point(67, 17);
            this.btnBuscaCep.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscaCep.Name = "btnBuscaCep";
            this.btnBuscaCep.Size = new System.Drawing.Size(52, 32);
            this.btnBuscaCep.TabIndex = 63;
            this.btnBuscaCep.Text = "buscar";
            this.btnBuscaCep.UseVisualStyleBackColor = false;
            this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 64;
            this.label1.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComplemento.Location = new System.Drawing.Point(447, 102);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(154, 23);
            this.txtComplemento.TabIndex = 63;
            // 
            // cbUf
            // 
            this.cbUf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUf.Location = new System.Drawing.Point(9, 101);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(61, 23);
            this.cbUf.TabIndex = 62;
            this.cbUf.SelectedIndexChanged += new System.EventHandler(this.cbUf_SelectedIndexChanged);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCep.Location = new System.Drawing.Point(9, 50);
            this.txtCep.Margin = new System.Windows.Forms.Padding(2);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(142, 23);
            this.txtCep.TabIndex = 61;
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblSucesso
            // 
            this.lblSucesso.AutoSize = true;
            this.lblSucesso.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSucesso.ForeColor = System.Drawing.Color.Lime;
            this.lblSucesso.Location = new System.Drawing.Point(269, 462);
            this.lblSucesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucesso.Name = "lblSucesso";
            this.lblSucesso.Size = new System.Drawing.Size(255, 25);
            this.lblSucesso.TabIndex = 60;
            this.lblSucesso.Text = "Dados gravados com sucesso!";
            this.lblSucesso.Visible = false;
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRg.Location = new System.Drawing.Point(540, 152);
            this.txtRg.Margin = new System.Windows.Forms.Padding(2);
            this.txtRg.Mask = "00.000.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(160, 23);
            this.txtRg.TabIndex = 62;
            this.txtRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRg.ForeColor = System.Drawing.Color.White;
            this.lblRg.Location = new System.Drawing.Point(536, 126);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(46, 21);
            this.lblRg.TabIndex = 61;
            this.lblRg.Text = "RG: *";
            // 
            // groupLogin
            // 
            this.groupLogin.Controls.Add(this.chkSenha);
            this.groupLogin.Controls.Add(this.txtSenhaUser);
            this.groupLogin.Controls.Add(this.lblSenha);
            this.groupLogin.ForeColor = System.Drawing.Color.White;
            this.groupLogin.Location = new System.Drawing.Point(68, 192);
            this.groupLogin.Margin = new System.Windows.Forms.Padding(2);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Padding = new System.Windows.Forms.Padding(2);
            this.groupLogin.Size = new System.Drawing.Size(267, 83);
            this.groupLogin.TabIndex = 64;
            this.groupLogin.TabStop = false;
            this.groupLogin.Text = "Login";
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenhaUser.Location = new System.Drawing.Point(11, 39);
            this.txtSenhaUser.MaxLength = 10;
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.Size = new System.Drawing.Size(143, 23);
            this.txtSenhaUser.TabIndex = 65;
            this.txtSenhaUser.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(6, 15);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(68, 21);
            this.lblSenha.TabIndex = 64;
            this.lblSenha.Text = "Senha *";
            // 
            // clienteId
            // 
            this.clienteId.AutoSize = true;
            this.clienteId.Location = new System.Drawing.Point(71, 473);
            this.clienteId.Name = "clienteId";
            this.clienteId.Size = new System.Drawing.Size(47, 13);
            this.clienteId.TabIndex = 65;
            this.clienteId.Text = "clienteId";
            this.clienteId.Visible = false;
            // 
            // enderecoId
            // 
            this.enderecoId.AutoSize = true;
            this.enderecoId.Location = new System.Drawing.Point(71, 502);
            this.enderecoId.Name = "enderecoId";
            this.enderecoId.Size = new System.Drawing.Size(61, 13);
            this.enderecoId.TabIndex = 66;
            this.enderecoId.Text = "enderecoId";
            this.enderecoId.Visible = false;
            // 
            // chkSenha
            // 
            this.chkSenha.AutoSize = true;
            this.chkSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.285714F, System.Drawing.FontStyle.Bold);
            this.chkSenha.ForeColor = System.Drawing.Color.White;
            this.chkSenha.Location = new System.Drawing.Point(163, 41);
            this.chkSenha.Margin = new System.Windows.Forms.Padding(2);
            this.chkSenha.Name = "chkSenha";
            this.chkSenha.Size = new System.Drawing.Size(100, 21);
            this.chkSenha.TabIndex = 66;
            this.chkSenha.Text = "Exibir senha";
            this.chkSenha.UseVisualStyleBackColor = true;
            this.chkSenha.CheckedChanged += new System.EventHandler(this.chkSenha_CheckedChanged);
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(767, 578);
            this.Controls.Add(this.enderecoId);
            this.Controls.Add(this.clienteId);
            this.Controls.Add(this.groupLogin);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblSucesso);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.dtDataNascimento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroFuncionario";
            this.Load += new System.EventHandler(this.FrmCadastroFuncionario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCadastroCliente;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.DateTimePicker dtDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label lblSucesso;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Button btnBuscaCep;
        private System.Windows.Forms.GroupBox groupLogin;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label clienteId;
        private System.Windows.Forms.Label enderecoId;
        private System.Windows.Forms.CheckBox chkSenha;
    }
}