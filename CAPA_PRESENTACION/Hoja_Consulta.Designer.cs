
namespace CAPA_PRESENTACION
{
    partial class Hoja_Consulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.DgDatos = new System.Windows.Forms.DataGridView();
            this.IDConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Semanas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_estudA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemaConsult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VistBueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.cbx_asignaturas = new System.Windows.Forms.ComboBox();
            this.rbx_Asginaturas = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbx_carnet_estudiante = new System.Windows.Forms.RadioButton();
            this.rbx_num_semanas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cbx_num_semana = new System.Windows.Forms.ComboBox();
            this.txt_carnet_estudiante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "REGISTRO DE HORAS DE CONSULTA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DgDatos
            // 
            this.DgDatos.AllowDrop = true;
            this.DgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDConsulta,
            this.N_Semanas,
            this.Cant_estudA,
            this.Tipo_Consulta,
            this.TemaConsult,
            this.Fecha,
            this.Hora,
            this.NumCarnet,
            this.FirmaEst,
            this.Observaciones,
            this.VistBueno});
            this.DgDatos.Location = new System.Drawing.Point(8, 199);
            this.DgDatos.Margin = new System.Windows.Forms.Padding(2);
            this.DgDatos.Name = "DgDatos";
            this.DgDatos.RowHeadersWidth = 62;
            this.DgDatos.RowTemplate.Height = 28;
            this.DgDatos.Size = new System.Drawing.Size(954, 408);
            this.DgDatos.TabIndex = 15;
            this.DgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDatos_CellContentClick);
            this.DgDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDatos_CellDoubleClick);
            // 
            // IDConsulta
            // 
            this.IDConsulta.HeaderText = "ID Consulta";
            this.IDConsulta.MinimumWidth = 8;
            this.IDConsulta.Name = "IDConsulta";
            // 
            // N_Semanas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_Semanas.DefaultCellStyle = dataGridViewCellStyle1;
            this.N_Semanas.HeaderText = "Numero de semanas ";
            this.N_Semanas.MinimumWidth = 8;
            this.N_Semanas.Name = "N_Semanas";
            // 
            // Cant_estudA
            // 
            this.Cant_estudA.HeaderText = "Cantidad de estudiantes atendidos";
            this.Cant_estudA.MinimumWidth = 8;
            this.Cant_estudA.Name = "Cant_estudA";
            // 
            // Tipo_Consulta
            // 
            this.Tipo_Consulta.HeaderText = "Tipo de consulta";
            this.Tipo_Consulta.MinimumWidth = 8;
            this.Tipo_Consulta.Name = "Tipo_Consulta";
            // 
            // TemaConsult
            // 
            this.TemaConsult.HeaderText = "Tema de consulta";
            this.TemaConsult.MinimumWidth = 8;
            this.TemaConsult.Name = "TemaConsult";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 8;
            this.Hora.Name = "Hora";
            // 
            // NumCarnet
            // 
            this.NumCarnet.HeaderText = "Número de carnet estudiante";
            this.NumCarnet.MinimumWidth = 8;
            this.NumCarnet.Name = "NumCarnet";
            // 
            // FirmaEst
            // 
            this.FirmaEst.HeaderText = "Firma del estudiante";
            this.FirmaEst.MinimumWidth = 8;
            this.FirmaEst.Name = "FirmaEst";
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 8;
            this.Observaciones.Name = "Observaciones";
            // 
            // VistBueno
            // 
            this.VistBueno.HeaderText = "Vo.Bo. Jefe Dpto";
            this.VistBueno.MinimumWidth = 8;
            this.VistBueno.Name = "VistBueno";
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarC.Location = new System.Drawing.Point(726, 141);
            this.btnAgregarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(110, 54);
            this.btnAgregarC.TabIndex = 16;
            this.btnAgregarC.Text = "Agregar consulta";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_listar.Location = new System.Drawing.Point(852, 141);
            this.btn_listar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(110, 54);
            this.btn_listar.TabIndex = 17;
            this.btn_listar.Text = "Listar Todos";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // cbx_asignaturas
            // 
            this.cbx_asignaturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_asignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbx_asignaturas.FormattingEnabled = true;
            this.cbx_asignaturas.Location = new System.Drawing.Point(18, 149);
            this.cbx_asignaturas.Name = "cbx_asignaturas";
            this.cbx_asignaturas.Size = new System.Drawing.Size(331, 28);
            this.cbx_asignaturas.TabIndex = 18;
            this.cbx_asignaturas.SelectedIndexChanged += new System.EventHandler(this.cbx_asignaturas_SelectedIndexChanged);
            // 
            // rbx_Asginaturas
            // 
            this.rbx_Asginaturas.AutoSize = true;
            this.rbx_Asginaturas.Checked = true;
            this.rbx_Asginaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbx_Asginaturas.Location = new System.Drawing.Point(13, 12);
            this.rbx_Asginaturas.Name = "rbx_Asginaturas";
            this.rbx_Asginaturas.Size = new System.Drawing.Size(112, 24);
            this.rbx_Asginaturas.TabIndex = 19;
            this.rbx_Asginaturas.TabStop = true;
            this.rbx_Asginaturas.Text = "Asignaturas";
            this.rbx_Asginaturas.UseVisualStyleBackColor = true;
            this.rbx_Asginaturas.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.rbx_carnet_estudiante);
            this.panel1.Controls.Add(this.rbx_num_semanas);
            this.panel1.Controls.Add(this.rbx_Asginaturas);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 49);
            this.panel1.TabIndex = 20;
            // 
            // rbx_carnet_estudiante
            // 
            this.rbx_carnet_estudiante.AutoSize = true;
            this.rbx_carnet_estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbx_carnet_estudiante.Location = new System.Drawing.Point(303, 12);
            this.rbx_carnet_estudiante.Name = "rbx_carnet_estudiante";
            this.rbx_carnet_estudiante.Size = new System.Drawing.Size(156, 24);
            this.rbx_carnet_estudiante.TabIndex = 21;
            this.rbx_carnet_estudiante.Text = "Carnet Estudiante";
            this.rbx_carnet_estudiante.UseVisualStyleBackColor = true;
            this.rbx_carnet_estudiante.CheckedChanged += new System.EventHandler(this.rbx_carnet_estudiante_CheckedChanged);
            // 
            // rbx_num_semanas
            // 
            this.rbx_num_semanas.AutoSize = true;
            this.rbx_num_semanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbx_num_semanas.Location = new System.Drawing.Point(152, 12);
            this.rbx_num_semanas.Name = "rbx_num_semanas";
            this.rbx_num_semanas.Size = new System.Drawing.Size(129, 24);
            this.rbx_num_semanas.TabIndex = 20;
            this.rbx_num_semanas.Text = "N° de Semana";
            this.rbx_num_semanas.UseVisualStyleBackColor = true;
            this.rbx_num_semanas.CheckedChanged += new System.EventHandler(this.rbx_num_semanas_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filtrar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(361, 149);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(110, 28);
            this.btn_buscar.TabIndex = 22;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Visible = false;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_num_semana
            // 
            this.cbx_num_semana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_num_semana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbx_num_semana.FormattingEnabled = true;
            this.cbx_num_semana.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.cbx_num_semana.Location = new System.Drawing.Point(18, 150);
            this.cbx_num_semana.Name = "cbx_num_semana";
            this.cbx_num_semana.Size = new System.Drawing.Size(331, 28);
            this.cbx_num_semana.TabIndex = 23;
            this.cbx_num_semana.Visible = false;
            this.cbx_num_semana.SelectedIndexChanged += new System.EventHandler(this.cbx_num_semana_SelectedIndexChanged);
            // 
            // txt_carnet_estudiante
            // 
            this.txt_carnet_estudiante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_carnet_estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_carnet_estudiante.Location = new System.Drawing.Point(18, 151);
            this.txt_carnet_estudiante.Name = "txt_carnet_estudiante";
            this.txt_carnet_estudiante.Size = new System.Drawing.Size(331, 26);
            this.txt_carnet_estudiante.TabIndex = 24;
            this.txt_carnet_estudiante.Visible = false;
            this.txt_carnet_estudiante.TextChanged += new System.EventHandler(this.txt_carnet_estudiante_TextChanged);
            // 
            // Hoja_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 690);
            this.Controls.Add(this.txt_carnet_estudiante);
            this.Controls.Add(this.cbx_num_semana);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_asignaturas);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hoja_Consulta";
            this.Text = "Hoja_Consulta";
            this.Load += new System.EventHandler(this.Hoja_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Semanas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_estudA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemaConsult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn VistBueno;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.ComboBox cbx_asignaturas;
        private System.Windows.Forms.RadioButton rbx_Asginaturas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbx_carnet_estudiante;
        private System.Windows.Forms.RadioButton rbx_num_semanas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox cbx_num_semana;
        private System.Windows.Forms.TextBox txt_carnet_estudiante;
    }
}