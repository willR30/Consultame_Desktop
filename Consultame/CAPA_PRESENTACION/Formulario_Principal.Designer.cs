namespace CAPA_PRESENTACION
{
    partial class Formulario_Principal
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
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_center = new System.Windows.Forms.Panel();
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.panel_contenedor.SuspendLayout();
            this.panel_lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel_contenedor.Controls.Add(this.panel_center);
            this.panel_contenedor.Controls.Add(this.panel_lateral);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_contenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1924, 1050);
            this.panel_contenedor.TabIndex = 0;
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_center.Location = new System.Drawing.Point(261, 0);
            this.panel_center.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(1663, 1050);
            this.panel_center.TabIndex = 1;
            // 
            // panel_lateral
            // 
            this.panel_lateral.Controls.Add(this.btn_home);
            this.panel_lateral.Controls.Add(this.pictureBox1);
            this.panel_lateral.Controls.Add(this.btn_consultas);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(261, 1050);
            this.panel_lateral.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.LightGray;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(6, 262);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(252, 45);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_consultas
            // 
            this.btn_consultas.BackColor = System.Drawing.Color.LightGray;
            this.btn_consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultas.Location = new System.Drawing.Point(3, 313);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(252, 45);
            this.btn_consultas.TabIndex = 0;
            this.btn_consultas.Text = "Consultas";
            this.btn_consultas.UseVisualStyleBackColor = false;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // Formulario_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel_contenedor);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Formulario_Principal";
            this.Text = "Formulario_Principal";
            this.Load += new System.EventHandler(this.Formulario_Principal_Load);
            this.panel_contenedor.ResumeLayout(false);
            this.panel_lateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.Button btn_home;
    }
}