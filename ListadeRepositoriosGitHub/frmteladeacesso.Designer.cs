﻿using System;
using System.Windows.Forms;

namespace ListadeRepositoriosGitHub
{
    partial class FrmTeladeAcesso
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.repositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchRepositoriesRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblConsulta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richtxtConsulta = new System.Windows.Forms.RichTextBox();
            this.btnNvConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchRepositoriesRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seus dados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleName = "usuario";
            this.txtUsuario.Location = new System.Drawing.Point(70, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.AccessibleName = "senha";
            this.txtSenha.Location = new System.Drawing.Point(70, 67);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(107, 93);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(63, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(204, 21);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(141, 16);
            this.lblLista.TabIndex = 6;
            this.lblLista.Text = "Lista de Repositórios :";
            // 
            // repositoryBindingSource
            // 
            this.repositoryBindingSource.DataSource = typeof(Octokit.Repository);
            // 
            // searchRepositoriesRequestBindingSource
            // 
            this.searchRepositoriesRequestBindingSource.DataSource = typeof(Octokit.SearchRepositoriesRequest);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(199, 41);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(0, 13);
            this.lblConsulta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // richtxtConsulta
            // 
            this.richtxtConsulta.Location = new System.Drawing.Point(200, 40);
            this.richtxtConsulta.Name = "richtxtConsulta";
            this.richtxtConsulta.Size = new System.Drawing.Size(583, 343);
            this.richtxtConsulta.TabIndex = 9;
            this.richtxtConsulta.Text = "";
            // 
            // btnNvConsulta
            // 
            this.btnNvConsulta.Location = new System.Drawing.Point(690, 14);
            this.btnNvConsulta.Name = "btnNvConsulta";
            this.btnNvConsulta.Size = new System.Drawing.Size(93, 23);
            this.btnNvConsulta.TabIndex = 10;
            this.btnNvConsulta.Text = "Nova Consulta";
            this.btnNvConsulta.UseVisualStyleBackColor = true;
            this.btnNvConsulta.Click += new System.EventHandler(this.BtnNvConsulta_Click_1);
            // 
            // FrmTeladeAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 395);
            this.Controls.Add(this.btnNvConsulta);
            this.Controls.Add(this.richtxtConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTeladeAcesso";
            this.Text = "VVS Sistemas - Consulta ao GitHub";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchRepositoriesRequestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblLista;
        private BindingSource searchRepositoriesRequestBindingSource;
        private BindingSource repositoryBindingSource;
        private Label lblConsulta;
        private Label label4;
        private RichTextBox richtxtConsulta;
        private Button btnNvConsulta;
    }
}