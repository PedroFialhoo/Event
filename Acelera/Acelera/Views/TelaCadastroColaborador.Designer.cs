namespace Acelera.Views
{
    partial class TelaCadastroColaborador
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
            this.txtRepeteSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.rbCnpj = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtEmail.Location = new System.Drawing.Point(1007, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(760, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtSenha.Location = new System.Drawing.Point(1007, 612);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(760, 31);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtRepeteSenha
            // 
            this.txtRepeteSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtRepeteSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepeteSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtRepeteSenha.Location = new System.Drawing.Point(1007, 731);
            this.txtRepeteSenha.Name = "txtRepeteSenha";
            this.txtRepeteSenha.Size = new System.Drawing.Size(760, 31);
            this.txtRepeteSenha.TabIndex = 5;
            this.txtRepeteSenha.UseSystemPasswordChar = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(1629, 818);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(172, 54);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtCnpj.Location = new System.Drawing.Point(1007, 490);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(498, 31);
            this.txtCnpj.TabIndex = 7;
            // 
            // rbCnpj
            // 
            this.rbCnpj.AutoSize = true;
            this.rbCnpj.BackColor = System.Drawing.Color.Transparent;
            this.rbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCnpj.Location = new System.Drawing.Point(1007, 431);
            this.rbCnpj.Name = "rbCnpj";
            this.rbCnpj.Size = new System.Drawing.Size(74, 29);
            this.rbCnpj.TabIndex = 8;
            this.rbCnpj.TabStop = true;
            this.rbCnpj.Text = "Cnpj";
            this.rbCnpj.UseVisualStyleBackColor = false;
            this.rbCnpj.CheckedChanged += new System.EventHandler(this.rbCnpj_CheckedChanged);
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.BackColor = System.Drawing.Color.Transparent;
            this.rbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCpf.Location = new System.Drawing.Point(1102, 431);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(63, 29);
            this.rbCpf.TabIndex = 9;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "Cpf";
            this.rbCpf.UseVisualStyleBackColor = false;
            this.rbCpf.CheckedChanged += new System.EventHandler(this.rbCpf_CheckedChanged);
            // 
            // TelaCadastroColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Acelera.Properties.Resources.TelaCadastroColaborador1;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.rbCpf);
            this.Controls.Add(this.rbCnpj);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtRepeteSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Name = "TelaCadastroColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.TelaCadastroColaborador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtRepeteSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.RadioButton rbCnpj;
        private System.Windows.Forms.RadioButton rbCpf;
    }
}