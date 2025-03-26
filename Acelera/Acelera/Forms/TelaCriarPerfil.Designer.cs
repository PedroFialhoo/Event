namespace Acelera.Forms
{
    partial class TelaCriarPerfil
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
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoCidade = new System.Windows.Forms.TextBox();
            this.campoEstado = new System.Windows.Forms.ComboBox();
            this.campoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.campoCPF = new System.Windows.Forms.MaskedTextBox();
            this.campoIdade = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // campoNome
            // 
<<<<<<< HEAD
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.campoNome.Location = new System.Drawing.Point(439, 367);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(678, 38);
            this.campoNome.TabIndex = 0;
=======
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.textBox1.Location = new System.Drawing.Point(439, 367);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(678, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
            // 
            // campoCidade
            // 
            this.campoCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.campoCidade.Location = new System.Drawing.Point(439, 787);
            this.campoCidade.Name = "campoCidade";
            this.campoCidade.Size = new System.Drawing.Size(678, 38);
            this.campoCidade.TabIndex = 4;
            this.campoCidade.Text = "\n\r\n";
            // 
            // campoEstado
            // 
            this.campoEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.campoEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.campoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.campoEstado.FormattingEnabled = true;
            this.campoEstado.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia - BA",
            "Ceará - CE",
            "Distrito Federal - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO"});
            this.campoEstado.Location = new System.Drawing.Point(439, 933);
            this.campoEstado.Name = "campoEstado";
            this.campoEstado.Size = new System.Drawing.Size(452, 39);
            this.campoEstado.TabIndex = 5;
            // 
            // campoTelefone
            // 
            this.campoTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.campoTelefone.HidePromptOnLeave = true;
            this.campoTelefone.Location = new System.Drawing.Point(439, 520);
            this.campoTelefone.Mask = "(00) 00000-0000";
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(213, 38);
            this.campoTelefone.TabIndex = 7;
            // 
            // campoCPF
            // 
            this.campoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.campoCPF.HidePromptOnLeave = true;
            this.campoCPF.Location = new System.Drawing.Point(439, 661);
            this.campoCPF.Mask = "000,000,000-00";
            this.campoCPF.Name = "campoCPF";
            this.campoCPF.Size = new System.Drawing.Size(213, 38);
            this.campoCPF.TabIndex = 8;
            // 
            // campoIdade
            // 
            this.campoIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.campoIdade.Location = new System.Drawing.Point(1286, 367);
            this.campoIdade.Name = "campoIdade";
            this.campoIdade.Size = new System.Drawing.Size(100, 38);
            this.campoIdade.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Acelera.Properties.Resources.cara;
            this.pictureBox1.Location = new System.Drawing.Point(50, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TelaCriarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acelera.Properties.Resources.TelaCriarPerfil;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.campoIdade);
            this.Controls.Add(this.campoCPF);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.campoEstado);
            this.Controls.Add(this.campoCidade);
            this.Controls.Add(this.campoNome);
            this.Name = "TelaCriarPerfil";
<<<<<<< HEAD
            this.ShowIcon = false;
            this.Text = "Event";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
=======
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCriarPerfil_FormClosed);
>>>>>>> a9db86ca44f3c909c975eafb6a07f5db9d061e37
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoCidade;
        private System.Windows.Forms.ComboBox campoEstado;
        private System.Windows.Forms.MaskedTextBox campoTelefone;
        private System.Windows.Forms.MaskedTextBox campoCPF;
        private System.Windows.Forms.TextBox campoIdade;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}