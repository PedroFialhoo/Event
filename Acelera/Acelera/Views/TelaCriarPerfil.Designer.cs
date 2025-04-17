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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.picturePerfil = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtNome.Location = new System.Drawing.Point(439, 367);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(678, 31);
            this.txtNome.TabIndex = 0;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtCidade.Location = new System.Drawing.Point(439, 787);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(678, 31);
            this.txtCidade.TabIndex = 4;
            this.txtCidade.Text = "\n\r\n";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtEstado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
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
            this.txtEstado.Location = new System.Drawing.Point(439, 933);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(452, 39);
            this.txtEstado.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtTelefone.HidePromptOnLeave = true;
            this.txtTelefone.Location = new System.Drawing.Point(439, 520);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(213, 31);
            this.txtTelefone.TabIndex = 7;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtCPF.HidePromptOnLeave = true;
            this.txtCPF.Location = new System.Drawing.Point(439, 661);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(213, 31);
            this.txtCPF.TabIndex = 8;
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtIdade.Location = new System.Drawing.Point(1286, 367);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 31);
            this.txtIdade.TabIndex = 9;
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
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Educação",
            "Esporte",
            "Saúde",
            "Musica",
            "Workshops"});
            this.checkedListBox1.Location = new System.Drawing.Point(1286, 546);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(378, 312);
            this.checkedListBox1.TabIndex = 14;
            // 
            // TelaCriarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picturePerfil);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
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

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.PictureBox picturePerfil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
