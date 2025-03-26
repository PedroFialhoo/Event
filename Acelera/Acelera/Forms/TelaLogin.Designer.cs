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
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.botaoEntrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // campoEmail
            // 
            this.campoEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.campoEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.campoEmail.Location = new System.Drawing.Point(1007, 431);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(760, 37);
            this.campoEmail.TabIndex = 1;
            this.campoEmail.TextChanged += new System.EventHandler(this.campoEmail_TextChanged);
            // 
            // campoSenha
            // 
            this.campoSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.campoSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.campoSenha.Location = new System.Drawing.Point(1007, 543);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(760, 37);
            this.campoSenha.TabIndex = 2;
            // 
            // botaoEntrar
            // 
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botaoEntrar);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoEmail);
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
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Button botaoEntrar;
        private System.Windows.Forms.Button button2;
    }
}