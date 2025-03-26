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
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.campoRepetirSenha = new System.Windows.Forms.TextBox();
            this.botaoConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoEmail
            // 
            this.campoEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.campoEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.campoEmail.Location = new System.Drawing.Point(1009, 368);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(760, 37);
            this.campoEmail.TabIndex = 2;
            // 
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
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acelera.Properties.Resources.TelaCadastro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.botaoConfirmar);
            this.Controls.Add(this.campoRepetirSenha);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoEmail);
            this.Name = "TelaCadastro";
            this.ShowIcon = false;
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.TextBox campoRepetirSenha;
        private System.Windows.Forms.Button botaoConfirmar;
    }
}