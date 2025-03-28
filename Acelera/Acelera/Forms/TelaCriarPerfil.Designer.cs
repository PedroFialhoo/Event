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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCriarPerfil));
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoCidade = new System.Windows.Forms.TextBox();
            this.campoEstado = new System.Windows.Forms.ComboBox();
            this.campoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.campoCPF = new System.Windows.Forms.MaskedTextBox();
            this.campoIdade = new System.Windows.Forms.TextBox();
            this.picturePerfil = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.campoNome.Location = new System.Drawing.Point(439, 367);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(678, 38);
            this.campoNome.TabIndex = 0;
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
            // picturePerfil
            // 
            this.picturePerfil.Image = global::Acelera.Properties.Resources.cara;
            this.picturePerfil.Location = new System.Drawing.Point(50, 308);
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.Size = new System.Drawing.Size(298, 325);
            this.picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePerfil.TabIndex = 10;
            this.picturePerfil.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Acelera.Properties.Resources.adicionar_foto;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(315, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 47);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntrar.Location = new System.Drawing.Point(1752, 934);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(123, 95);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(94, 861);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 71);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TelaCriarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picturePerfil);
            this.Controls.Add(this.campoIdade);
            this.Controls.Add(this.campoCPF);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.campoEstado);
            this.Controls.Add(this.campoCidade);
            this.Controls.Add(this.campoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaCriarPerfil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCriarPerfil_FormClosed);
            this.Load += new System.EventHandler(this.TelaCriarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
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
        private System.Windows.Forms.PictureBox picturePerfil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button button2;
    }
}
