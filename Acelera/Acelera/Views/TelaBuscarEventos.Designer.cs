namespace Acelera.Views
{
    partial class TelaBuscarEventos
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
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.flowPanelEventos = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtNomeEvento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.txtNomeEvento.Location = new System.Drawing.Point(506, 48);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(757, 36);
            this.txtNomeEvento.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1325, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 64);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flowPanelEventos
            // 
            this.flowPanelEventos.AutoScroll = true;
            this.flowPanelEventos.BackColor = System.Drawing.Color.White;
            this.flowPanelEventos.Location = new System.Drawing.Point(0, 119);
            this.flowPanelEventos.Name = "flowPanelEventos";
            this.flowPanelEventos.Size = new System.Drawing.Size(1907, 924);
            this.flowPanelEventos.TabIndex = 5;
            this.flowPanelEventos.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelEventos_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(122, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 93);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaBuscarEventos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Acelera.Properties.Resources.TelaBuscarEventos;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowPanelEventos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNomeEvento);
            this.MaximizeBox = false;
            this.Name = "TelaBuscarEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.TelaBuscarEventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeEvento;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowPanelEventos;
        private System.Windows.Forms.Button button1;
    }
}