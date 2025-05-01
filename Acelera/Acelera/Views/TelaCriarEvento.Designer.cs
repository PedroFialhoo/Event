namespace Acelera.Views
{
    partial class TelaCriarEvento
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
            this.pictureEvento = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEvento
            // 
            this.pictureEvento.Location = new System.Drawing.Point(28, 308);
            this.pictureEvento.Name = "pictureEvento";
            this.pictureEvento.Size = new System.Drawing.Size(383, 330);
            this.pictureEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEvento.TabIndex = 0;
            this.pictureEvento.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtNome.Location = new System.Drawing.Point(531, 342);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(678, 31);
            this.txtNome.TabIndex = 1;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtCidade.Location = new System.Drawing.Point(531, 863);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(678, 31);
            this.txtCidade.TabIndex = 4;
            // 
            // txtLocal
            // 
            this.txtLocal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtLocal.Location = new System.Drawing.Point(1372, 342);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(506, 31);
            this.txtLocal.TabIndex = 5;
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
            this.txtEstado.Location = new System.Drawing.Point(531, 981);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(452, 39);
            this.txtEstado.TabIndex = 6;
            // 
            // cbTipo
            // 
            this.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Educação",
            "Saúde e bem-estar",
            "Empreendedorismo e inovação",
            "Computação e tecnologias da informação",
            "Esportes",
            "Música ",
            "Outros"});
            this.cbTipo.Location = new System.Drawing.Point(1372, 493);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(452, 39);
            this.cbTipo.TabIndex = 7;
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtCep.HidePromptOnLeave = true;
            this.txtCep.Location = new System.Drawing.Point(531, 739);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(213, 31);
            this.txtCep.TabIndex = 9;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(125, 785);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 71);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtDescricao.Location = new System.Drawing.Point(1372, 595);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(506, 425);
            this.txtDescricao.TabIndex = 15;
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
            this.button1.Location = new System.Drawing.Point(378, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 47);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtData.HidePromptOnLeave = true;
            this.txtData.Location = new System.Drawing.Point(531, 483);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(160, 31);
            this.txtData.TabIndex = 17;
            // 
            // txtHorario
            // 
            this.txtHorario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtHorario.HidePromptOnLeave = true;
            this.txtHorario.Location = new System.Drawing.Point(531, 621);
            this.txtHorario.Mask = "00:00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(86, 31);
            this.txtHorario.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1377, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descrição";
            // 
            // TelaCriarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Acelera.Properties.Resources.TelaCriarEvento;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureEvento);
            this.Name = "TelaCriarEvento";
            this.Text = "Event";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureEvento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtHorario;
        private System.Windows.Forms.Label label1;
    }
}