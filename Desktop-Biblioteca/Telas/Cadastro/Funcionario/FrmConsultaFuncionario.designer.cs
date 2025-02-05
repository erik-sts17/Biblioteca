﻿namespace Desktop_Biblioteca.Consulta
{
    partial class FrmConsultaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaFuncionario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConsultaFuncionario = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dgrFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblConsultaFuncionario);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 50);
            this.panel1.TabIndex = 3;
            // 
            // lblConsultaFuncionario
            // 
            this.lblConsultaFuncionario.AutoSize = true;
            this.lblConsultaFuncionario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblConsultaFuncionario.Location = new System.Drawing.Point(10, 7);
            this.lblConsultaFuncionario.Name = "lblConsultaFuncionario";
            this.lblConsultaFuncionario.Size = new System.Drawing.Size(252, 30);
            this.lblConsultaFuncionario.TabIndex = 2;
            this.lblConsultaFuncionario.Text = "Consulta de Funcionário";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(670, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 50);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(611, 134);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(90, 48);
            this.btnApagar.TabIndex = 27;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgrFuncionarios
            // 
            this.dgrFuncionarios.AllowUserToAddRows = false;
            this.dgrFuncionarios.AllowUserToDeleteRows = false;
            this.dgrFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrFuncionarios.Location = new System.Drawing.Point(25, 74);
            this.dgrFuncionarios.Name = "dgrFuncionarios";
            this.dgrFuncionarios.ReadOnly = true;
            this.dgrFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrFuncionarios.Size = new System.Drawing.Size(553, 246);
            this.dgrFuncionarios.TabIndex = 34;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Yellow;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAlterar.Location = new System.Drawing.Point(611, 198);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 48);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Editar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // FrmConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(725, 379);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgrFuncionarios);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConsultaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCosultaAutor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConsultaFuncionario;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridView dgrFuncionarios;
        private System.Windows.Forms.Button btnAlterar;
    }
}