namespace Acelera.Forms
{
    partial class Event
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
            this.button1 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.botaoEntrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
=======
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1271, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtEmail
            // 
<<<<<<< HEAD
            this.campoEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.campoEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.campoEmail.Location = new System.Drawing.Point(1007, 431);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(760, 37);
            this.campoEmail.TabIndex = 1;
            this.campoEmail.TextChanged += new System.EventHandler(this.campoEmail_TextChanged);
=======
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.txtEmail.Location = new System.Drawing.Point(1007, 431);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(760, 37);
            this.txtEmail.TabIndex = 1;
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.txtSenha.Location = new System.Drawing.Point(1007, 543);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(760, 37);
            this.txtSenha.TabIndex = 2;
            // 
            // btnEntrar
            // 
<<<<<<< HEAD
            this.botaoEntrar.BackColor = System.Drawing.Color.Orange;
            this.botaoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEntrar.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoEntrar.Location = new System.Drawing.Point(1757, 653);
            this.botaoEntrar.Name = "botaoEntrar";
            this.botaoEntrar.Size = new System.Drawing.Size(61, 30);
            this.botaoEntrar.TabIndex = 3;
            this.botaoEntrar.Text = "Entrar";
            this.botaoEntrar.UseVisualStyleBackColor = false;
            this.botaoEntrar.Click += new System.EventHandler(this.botaoEntrar_Click);
=======
            this.btnEntrar.BackColor = System.Drawing.Color.Wheat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntrar.Location = new System.Drawing.Point(1743, 653);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 30);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.botaoEntrar_Click);
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1337, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "só pra facilitar abrir o criarPerfil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acelera.Properties.Resources.TelaLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
<<<<<<< HEAD
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botaoEntrar);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoEmail);
=======
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
            this.Controls.Add(this.button1);
            this.Name = "Event";
            this.ShowIcon = false;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Button botaoEntrar;
        private System.Windows.Forms.Button button2;
=======
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
    }
}