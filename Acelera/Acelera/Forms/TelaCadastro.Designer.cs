﻿namespace Acelera.Forms
{
    partial class TelaCadastro
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.txtEmail.Location = new System.Drawing.Point(995, 313);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(760, 37);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.campoEmail_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.txtSenha.Location = new System.Drawing.Point(995, 429);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(760, 37);
            this.txtSenha.TabIndex = 3;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtConfirmaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.txtConfirmaSenha.Location = new System.Drawing.Point(995, 539);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(760, 37);
            this.txtConfirmaSenha.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(1618, 639);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(172, 57);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1234, 197);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 6;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acelera.Properties.Resources.TelaCadastro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastro_FormClosed);
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
