namespace Desktop_Biblioteca.Consulta
{
    partial class FrmConsultaEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaEmprestimo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConsultaEmprestimos = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.dgrEmprestimos = new System.Windows.Forms.DataGridView();
            this.gpFiltro = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmprestimos)).BeginInit();
            this.gpFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblConsultaEmprestimos);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 50);
            this.panel1.TabIndex = 3;
            // 
            // lblConsultaEmprestimos
            // 
            this.lblConsultaEmprestimos.AutoSize = true;
            this.lblConsultaEmprestimos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaEmprestimos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblConsultaEmprestimos.Location = new System.Drawing.Point(10, 7);
            this.lblConsultaEmprestimos.Name = "lblConsultaEmprestimos";
            this.lblConsultaEmprestimos.Size = new System.Drawing.Size(261, 30);
            this.lblConsultaEmprestimos.TabIndex = 2;
            this.lblConsultaEmprestimos.Text = "Consulta de Empréstimos";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(680, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 50);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.Red;
            this.btnDevolver.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(313, 549);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(112, 48);
            this.btnDevolver.TabIndex = 27;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Visible = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // dgrEmprestimos
            // 
            this.dgrEmprestimos.AllowUserToAddRows = false;
            this.dgrEmprestimos.AllowUserToDeleteRows = false;
            this.dgrEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEmprestimos.Location = new System.Drawing.Point(15, 192);
            this.dgrEmprestimos.Name = "dgrEmprestimos";
            this.dgrEmprestimos.ReadOnly = true;
            this.dgrEmprestimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrEmprestimos.Size = new System.Drawing.Size(706, 324);
            this.dgrEmprestimos.TabIndex = 34;
            this.dgrEmprestimos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgrEmprestimos_CellFormatting);
            // 
            // gpFiltro
            // 
            this.gpFiltro.Controls.Add(this.btnLimpar);
            this.gpFiltro.Controls.Add(this.lblStatus);
            this.gpFiltro.Controls.Add(this.lblEmailCliente);
            this.gpFiltro.Controls.Add(this.btnConfirmar);
            this.gpFiltro.Controls.Add(this.cbStatus);
            this.gpFiltro.Controls.Add(this.txtEmailCliente);
            this.gpFiltro.ForeColor = System.Drawing.SystemColors.Control;
            this.gpFiltro.Location = new System.Drawing.Point(45, 55);
            this.gpFiltro.Name = "gpFiltro";
            this.gpFiltro.Size = new System.Drawing.Size(638, 114);
            this.gpFiltro.TabIndex = 36;
            this.gpFiltro.TabStop = false;
            this.gpFiltro.Text = "Filtro";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(540, 45);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 32);
            this.btnLimpar.TabIndex = 81;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(242, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 79;
            this.lblStatus.Text = "Status";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(20, 36);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(70, 13);
            this.lblEmailCliente.TabIndex = 78;
            this.lblEmailCliente.Text = "Email Cliente:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(453, 45);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(76, 32);
            this.btnConfirmar.TabIndex = 76;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(245, 52);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(188, 21);
            this.cbStatus.TabIndex = 1;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(20, 52);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(198, 20);
            this.txtEmailCliente.TabIndex = 0;
            // 
            // FrmConsultaEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(735, 618);
            this.Controls.Add(this.gpFiltro);
            this.Controls.Add(this.dgrEmprestimos);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConsultaEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCosultaAutor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEmprestimos)).EndInit();
            this.gpFiltro.ResumeLayout(false);
            this.gpFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConsultaEmprestimos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.DataGridView dgrEmprestimos;
        private System.Windows.Forms.GroupBox gpFiltro;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Button btnLimpar;
    }
}