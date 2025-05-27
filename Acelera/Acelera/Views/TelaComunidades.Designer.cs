namespace Acelera.Views
{
    partial class TelaComunidades
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
            this.opEducacao = new System.Windows.Forms.RadioButton();
            this.opEmpreendedorismo = new System.Windows.Forms.RadioButton();
            this.opSaude = new System.Windows.Forms.RadioButton();
            this.opMusica = new System.Windows.Forms.RadioButton();
            this.opComputacao = new System.Windows.Forms.RadioButton();
            this.opEsporte = new System.Windows.Forms.RadioButton();
            this.flowPanelComentarios = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // opEducacao
            // 
            this.opEducacao.AutoSize = true;
            this.opEducacao.BackColor = System.Drawing.Color.Transparent;
            this.opEducacao.Location = new System.Drawing.Point(73, 295);
            this.opEducacao.Name = "opEducacao";
            this.opEducacao.Size = new System.Drawing.Size(14, 13);
            this.opEducacao.TabIndex = 0;
            this.opEducacao.TabStop = true;
            this.opEducacao.UseVisualStyleBackColor = false;
            // 
            // opEmpreendedorismo
            // 
            this.opEmpreendedorismo.AutoSize = true;
            this.opEmpreendedorismo.BackColor = System.Drawing.Color.Transparent;
            this.opEmpreendedorismo.Location = new System.Drawing.Point(73, 455);
            this.opEmpreendedorismo.Name = "opEmpreendedorismo";
            this.opEmpreendedorismo.Size = new System.Drawing.Size(14, 13);
            this.opEmpreendedorismo.TabIndex = 1;
            this.opEmpreendedorismo.TabStop = true;
            this.opEmpreendedorismo.UseVisualStyleBackColor = false;
            // 
            // opSaude
            // 
            this.opSaude.AutoSize = true;
            this.opSaude.BackColor = System.Drawing.Color.Transparent;
            this.opSaude.Location = new System.Drawing.Point(73, 375);
            this.opSaude.Name = "opSaude";
            this.opSaude.Size = new System.Drawing.Size(14, 13);
            this.opSaude.TabIndex = 2;
            this.opSaude.TabStop = true;
            this.opSaude.UseVisualStyleBackColor = false;
            // 
            // opMusica
            // 
            this.opMusica.AutoSize = true;
            this.opMusica.BackColor = System.Drawing.Color.Transparent;
            this.opMusica.Location = new System.Drawing.Point(73, 795);
            this.opMusica.Name = "opMusica";
            this.opMusica.Size = new System.Drawing.Size(14, 13);
            this.opMusica.TabIndex = 3;
            this.opMusica.TabStop = true;
            this.opMusica.UseVisualStyleBackColor = false;
            // 
            // opComputacao
            // 
            this.opComputacao.AutoSize = true;
            this.opComputacao.BackColor = System.Drawing.Color.Transparent;
            this.opComputacao.Location = new System.Drawing.Point(73, 563);
            this.opComputacao.Name = "opComputacao";
            this.opComputacao.Size = new System.Drawing.Size(14, 13);
            this.opComputacao.TabIndex = 3;
            this.opComputacao.TabStop = true;
            this.opComputacao.UseVisualStyleBackColor = false;
            // 
            // opEsporte
            // 
            this.opEsporte.AutoSize = true;
            this.opEsporte.BackColor = System.Drawing.Color.Transparent;
            this.opEsporte.Location = new System.Drawing.Point(73, 717);
            this.opEsporte.Name = "opEsporte";
            this.opEsporte.Size = new System.Drawing.Size(14, 13);
            this.opEsporte.TabIndex = 4;
            this.opEsporte.TabStop = true;
            this.opEsporte.UseVisualStyleBackColor = false;
            // 
            // flowPanelComentarios
            // 
            this.flowPanelComentarios.AutoScroll = true;
            this.flowPanelComentarios.Location = new System.Drawing.Point(464, 186);
            this.flowPanelComentarios.Name = "flowPanelComentarios";
            this.flowPanelComentarios.Size = new System.Drawing.Size(1406, 737);
            this.flowPanelComentarios.TabIndex = 5;
            // 
            // TelaComunidades
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Acelera.Properties.Resources.TelaComunidades;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.flowPanelComentarios);
            this.Controls.Add(this.opEsporte);
            this.Controls.Add(this.opComputacao);
            this.Controls.Add(this.opMusica);
            this.Controls.Add(this.opSaude);
            this.Controls.Add(this.opEmpreendedorismo);
            this.Controls.Add(this.opEducacao);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "TelaComunidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.TelaComunidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton opEducacao;
        private System.Windows.Forms.RadioButton opEmpreendedorismo;
        private System.Windows.Forms.RadioButton opSaude;
        private System.Windows.Forms.RadioButton opMusica;
        private System.Windows.Forms.RadioButton opComputacao;
        private System.Windows.Forms.RadioButton opEsporte;
        private System.Windows.Forms.FlowLayoutPanel flowPanelComentarios;
    }
}