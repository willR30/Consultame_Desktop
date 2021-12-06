namespace CAPA_PRESENTACION
{
    partial class Vista_asignaturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.DgAsig = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgAsig)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarC.Location = new System.Drawing.Point(919, 20);
            this.btnAgregarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(165, 29);
            this.btnAgregarC.TabIndex = 27;
            this.btnAgregarC.Text = "Nueva";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // DgAsig
            // 
            this.DgAsig.AllowDrop = true;
            this.DgAsig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgAsig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgAsig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgAsig.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgAsig.Location = new System.Drawing.Point(11, 64);
            this.DgAsig.Margin = new System.Windows.Forms.Padding(2);
            this.DgAsig.Name = "DgAsig";
            this.DgAsig.RowHeadersWidth = 62;
            this.DgAsig.RowTemplate.Height = 28;
            this.DgAsig.Size = new System.Drawing.Size(1096, 505);
            this.DgAsig.TabIndex = 26;
            // 
            // Vista_asignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 625);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.DgAsig);
            this.Name = "Vista_asignaturas";
            this.Text = "Vista_asignaturas";
            this.Load += new System.EventHandler(this.Vista_asignaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgAsig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.DataGridView DgAsig;
    }
}