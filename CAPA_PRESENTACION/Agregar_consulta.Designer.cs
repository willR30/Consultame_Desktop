
namespace CAPA_PRESENTACION
{
    partial class Agregar_consulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTipoConsult = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbn_SinAprobar = new System.Windows.Forms.RadioButton();
            this.rbn_Aprobado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txt_FirmaEst = new System.Windows.Forms.TextBox();
            this.txt_NumCarnet = new System.Windows.Forms.TextBox();
            this.txt_CanEst = new System.Windows.Forms.TextBox();
            this.dt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_NumSemanas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_TemaConsult = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbx_asignaturas = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(490, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nueva Consulta";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 60);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(419, 59);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(208, 79);
            this.label7.TabIndex = 29;
            this.label7.Text = "Firma del estudiante\r\natendido:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(419, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(208, 59);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nº de carnet del\r\nestudiante:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(219, 59);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nº de semana:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(3, 59);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(219, 79);
            this.label10.TabIndex = 31;
            this.label10.Text = "Cant de\r\nestudiantes \r\natendidos:\r\n";
            // 
            // cbTipoConsult
            // 
            this.cbTipoConsult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoConsult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTipoConsult.FormattingEnabled = true;
            this.cbTipoConsult.Items.AddRange(new object[] {
            "Virtual",
            "Presencial",
            "Fuera de Horas"});
            this.cbTipoConsult.Location = new System.Drawing.Point(927, 66);
            this.cbTipoConsult.Name = "cbTipoConsult";
            this.cbTipoConsult.Size = new System.Drawing.Size(289, 33);
            this.cbTipoConsult.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.rbn_SinAprobar);
            this.panel3.Controls.Add(this.rbn_Aprobado);
            this.panel3.Location = new System.Drawing.Point(945, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 128);
            this.panel3.TabIndex = 31;
            // 
            // rbn_SinAprobar
            // 
            this.rbn_SinAprobar.AutoSize = true;
            this.rbn_SinAprobar.Checked = true;
            this.rbn_SinAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbn_SinAprobar.Location = new System.Drawing.Point(46, 83);
            this.rbn_SinAprobar.Name = "rbn_SinAprobar";
            this.rbn_SinAprobar.Size = new System.Drawing.Size(143, 29);
            this.rbn_SinAprobar.TabIndex = 1;
            this.rbn_SinAprobar.TabStop = true;
            this.rbn_SinAprobar.Text = "Sin aprobar ";
            this.rbn_SinAprobar.UseVisualStyleBackColor = true;
            // 
            // rbn_Aprobado
            // 
            this.rbn_Aprobado.AutoSize = true;
            this.rbn_Aprobado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbn_Aprobado.Location = new System.Drawing.Point(46, 38);
            this.rbn_Aprobado.Name = "rbn_Aprobado";
            this.rbn_Aprobado.Size = new System.Drawing.Size(123, 29);
            this.rbn_Aprobado.TabIndex = 0;
            this.rbn_Aprobado.Text = "Aprobado";
            this.rbn_Aprobado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(911, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(84, 59);
            this.label2.TabIndex = 36;
            this.label2.Text = "Hora:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(911, 59);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(84, 79);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.171F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.34063F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.93981F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.54856F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Controls.Add(this.txtHora, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_FirmaEst, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_NumCarnet, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_CanEst, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.dt_Fecha, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_NumSemanas, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 78);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.52174F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1296, 138);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHora.Location = new System.Drawing.Point(1001, 3);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(169, 30);
            this.txtHora.TabIndex = 42;
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged);
            // 
            // txt_FirmaEst
            // 
            this.txt_FirmaEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_FirmaEst.Location = new System.Drawing.Point(633, 62);
            this.txt_FirmaEst.Name = "txt_FirmaEst";
            this.txt_FirmaEst.Size = new System.Drawing.Size(210, 30);
            this.txt_FirmaEst.TabIndex = 42;
            this.txt_FirmaEst.TextChanged += new System.EventHandler(this.txt_FirmaEst_TextChanged);
            // 
            // txt_NumCarnet
            // 
            this.txt_NumCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_NumCarnet.Location = new System.Drawing.Point(633, 3);
            this.txt_NumCarnet.Name = "txt_NumCarnet";
            this.txt_NumCarnet.Size = new System.Drawing.Size(210, 30);
            this.txt_NumCarnet.TabIndex = 43;
            this.txt_NumCarnet.TextChanged += new System.EventHandler(this.txt_NumCarnet_TextChanged);
            // 
            // txt_CanEst
            // 
            this.txt_CanEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_CanEst.Location = new System.Drawing.Point(228, 62);
            this.txt_CanEst.Name = "txt_CanEst";
            this.txt_CanEst.Size = new System.Drawing.Size(150, 30);
            this.txt_CanEst.TabIndex = 42;
            this.txt_CanEst.TextChanged += new System.EventHandler(this.txt_CanEst_TextChanged);
            // 
            // dt_Fecha
            // 
            this.dt_Fecha.Enabled = false;
            this.dt_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dt_Fecha.Location = new System.Drawing.Point(1001, 62);
            this.dt_Fecha.Name = "dt_Fecha";
            this.dt_Fecha.Size = new System.Drawing.Size(252, 30);
            this.dt_Fecha.TabIndex = 37;
            // 
            // txt_NumSemanas
            // 
            this.txt_NumSemanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_NumSemanas.Location = new System.Drawing.Point(228, 3);
            this.txt_NumSemanas.Name = "txt_NumSemanas";
            this.txt_NumSemanas.Size = new System.Drawing.Size(150, 30);
            this.txt_NumSemanas.TabIndex = 38;
            this.txt_NumSemanas.TextChanged += new System.EventHandler(this.txt_NumSemanas_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tema de consulta:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(986, 29);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tipo de consulta:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(10, 128);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Observaciones";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cbTipoConsult);
            this.panel1.Location = new System.Drawing.Point(12, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 326);
            this.panel1.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_TemaConsult);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(8, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 225);
            this.panel4.TabIndex = 41;
            // 
            // txt_TemaConsult
            // 
            this.txt_TemaConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_TemaConsult.Location = new System.Drawing.Point(8, 51);
            this.txt_TemaConsult.Multiline = true;
            this.txt_TemaConsult.Name = "txt_TemaConsult";
            this.txt_TemaConsult.Size = new System.Drawing.Size(210, 150);
            this.txt_TemaConsult.TabIndex = 39;
            this.txt_TemaConsult.TextChanged += new System.EventHandler(this.txt_TemaConsult_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbx_asignaturas);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_Observaciones);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(246, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 305);
            this.panel2.TabIndex = 42;
            // 
            // cbx_asignaturas
            // 
            this.cbx_asignaturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_asignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_asignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbx_asignaturas.FormattingEnabled = true;
            this.cbx_asignaturas.Location = new System.Drawing.Point(15, 51);
            this.cbx_asignaturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_asignaturas.Name = "cbx_asignaturas";
            this.cbx_asignaturas.Size = new System.Drawing.Size(625, 37);
            this.cbx_asignaturas.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(10, 14);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(122, 25);
            this.label12.TabIndex = 41;
            this.label12.Text = "Asignaturas:";
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Observaciones.Location = new System.Drawing.Point(15, 160);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(625, 118);
            this.txt_Observaciones.TabIndex = 40;
            this.txt_Observaciones.TextChanged += new System.EventHandler(this.txt_Observaciones_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(968, 143);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(171, 25);
            this.label11.TabIndex = 41;
            this.label11.Text = "VoBo. Jefe Depto.";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(904, 578);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(362, 122);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar Consulta";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Agregar_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 717);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Agregar_consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_consulta";
            this.Load += new System.EventHandler(this.Agregar_consulta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.ComboBox cbTipoConsult;
        public System.Windows.Forms.RadioButton rbn_SinAprobar;
        public System.Windows.Forms.RadioButton rbn_Aprobado;
        public System.Windows.Forms.DateTimePicker dt_Fecha;
        private System.Windows.Forms.TextBox txt_NumSemanas;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txt_FirmaEst;
        private System.Windows.Forms.TextBox txt_NumCarnet;
        private System.Windows.Forms.TextBox txt_CanEst;
        private System.Windows.Forms.TextBox txt_TemaConsult;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx_asignaturas;
    }
}