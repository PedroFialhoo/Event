namespace Acelera.Views
{
    partial class TelaPerfilColaborador
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
            this.components = new System.ComponentModel.Container();
            this.picturePerfil = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.flowPanelEventos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menuOpcoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDeslogar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            this.menuOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturePerfil
            // 
            this.picturePerfil.Location = new System.Drawing.Point(48, 220);
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.Size = new System.Drawing.Size(300, 325);
            this.picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePerfil.TabIndex = 0;
            this.picturePerfil.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lblNome.Location = new System.Drawing.Point(443, 274);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 29);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "label1";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lblTelefone.Location = new System.Drawing.Point(1121, 257);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(79, 29);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "label1";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lblNomeEmpresa.Location = new System.Drawing.Point(443, 477);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(79, 29);
            this.lblNomeEmpresa.TabIndex = 9;
            this.lblNomeEmpresa.Text = "label1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1344, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 95);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowPanelEventos
            // 
            this.flowPanelEventos.AutoScroll = true;
            this.flowPanelEventos.Location = new System.Drawing.Point(0, 662);
            this.flowPanelEventos.Name = "flowPanelEventos";
            this.flowPanelEventos.Size = new System.Drawing.Size(1912, 382);
            this.flowPanelEventos.TabIndex = 11;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(12, 36);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(76, 55);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // menuOpcoes
            // 
            this.menuOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDeslogar});
            this.menuOpcoes.Name = "menuOpcoes";
            this.menuOpcoes.Size = new System.Drawing.Size(181, 48);
            // 
            // menuItemDeslogar
            // 
            this.menuItemDeslogar.Name = "menuItemDeslogar";
            this.menuItemDeslogar.Size = new System.Drawing.Size(180, 22);
            this.menuItemDeslogar.Text = "Sair da Conta";
            this.menuItemDeslogar.Click += new System.EventHandler(this.menuItemDeslogar_Click);
            // 
            // TelaPerfilColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Acelera.Properties.Resources.TelaPerfilColaborador;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.flowPanelEventos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.picturePerfil);
            this.MaximizeBox = false;
            this.Name = "TelaPerfilColaborador";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.TelaPerfilColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            this.menuOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePerfil;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowPanelEventos;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ContextMenuStrip menuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeslogar;
    }
}