namespace Acelera.Forms
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
<<<<<<< HEAD
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.campoRepetirSenha = new System.Windows.Forms.TextBox();
            this.botaoConfirmar = new System.Windows.Forms.Button();
=======
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.txtEmail.Location = new System.Drawing.Point(1009, 368);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(760, 37);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.campoEmail_TextChanged);
            // 
<<<<<<< HEAD
            // campoSenha
            // 
            this.campoSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.campoSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.campoSenha.Location = new System.Drawing.Point(1009, 480);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(760, 37);
            this.campoSenha.TabIndex = 3;
            // 
            // campoRepetirSenha
            // 
            this.campoRepetirSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.campoRepetirSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.campoRepetirSenha.Location = new System.Drawing.Point(1009, 590);
            this.campoRepetirSenha.Name = "campoRepetirSenha";
            this.campoRepetirSenha.Size = new System.Drawing.Size(760, 37);
            this.campoRepetirSenha.TabIndex = 4;
            // 
            // botaoConfirmar
            // 
            this.botaoConfirmar.BackColor = System.Drawing.Color.Orange;
            this.botaoConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoConfirmar.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoConfirmar.Location = new System.Drawing.Point(1780, 684);
            this.botaoConfirmar.Name = "botaoConfirmar";
            this.botaoConfirmar.Size = new System.Drawing.Size(84, 30);
            this.botaoConfirmar.TabIndex = 5;
            this.botaoConfirmar.Text = "Confirmar";
            this.botaoConfirmar.UseVisualStyleBackColor = false;
            this.botaoConfirmar.Click += new System.EventHandler(this.botaoEntrar_Click);
=======
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.txtSenha.Location = new System.Drawing.Point(1009, 480);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(760, 37);
            this.txtSenha.TabIndex = 3;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtConfirmaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.txtConfirmaSenha.Location = new System.Drawing.Point(1009, 590);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(760, 37);
            this.txtConfirmaSenha.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(1664, 694);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acelera.Properties.Resources.TelaCadastro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
<<<<<<< HEAD
            this.Controls.Add(this.botaoConfirmar);
            this.Controls.Add(this.campoRepetirSenha);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoEmail);
            this.Name = "TelaCadastro";
            this.ShowIcon = false;
            this.Text = "Event";
=======
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastro_FormClosed);
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.TextBox campoRepetirSenha;
        private System.Windows.Forms.Button botaoConfirmar;
=======
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Button btnSalvar;
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
    }
}