namespace orologioDesktop
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.tmimataComboBox1 = new System.Windows.Forms.ComboBox();
            this.tmimataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daskaloiDataSet = new orologioDesktop.daskaloiDataSet();
            this.tmimataTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.TmimataTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.epithetoComboBox1 = new System.Windows.Forms.ComboBox();
            this.daskaloiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onomaComboBox1 = new System.Windows.Forms.ComboBox();
            this.imeresComboBox1 = new System.Windows.Forms.ComboBox();
            this.imeresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oraComboBox1 = new System.Windows.Forms.ComboBox();
            this.mathimaComboBox1 = new System.Windows.Forms.ComboBox();
            this.mathimataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taksiComboBox1 = new System.Windows.Forms.ComboBox();
            this.taksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.daskaloiTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.DaskaloiTableAdapter();
            this.daskaloiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imeresTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.ImeresTableAdapter();
            this.daskaloiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathimataTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.MathimataTableAdapter();
            this.taksiTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.TaksiTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.id_daskalos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fillByFilterToolStrip = new System.Windows.Forms.ToolStrip();
            this.idmathimatextBox1 = new System.Windows.Forms.TextBox();
            this.fKProgramma30BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programmaTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.ProgrammaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmimataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imeresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathimataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProgramma30BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(932, 403);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ωρολόγιο Πρόγραμμα";
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.LightGreen;
            this.load.Location = new System.Drawing.Point(22, 100);
            this.load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(192, 94);
            this.load.TabIndex = 3;
            this.load.Text = "Φόρτωση Δεδομένων (Πατήστε για refresh)";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Location = new System.Drawing.Point(22, 224);
            this.back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(192, 89);
            this.back.TabIndex = 4;
            this.back.Text = "Επιστροφή";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tmimataComboBox1
            // 
            this.tmimataComboBox1.DataSource = this.tmimataBindingSource;
            this.tmimataComboBox1.DisplayMember = "onoma";
            this.tmimataComboBox1.FormattingEnabled = true;
            this.tmimataComboBox1.Location = new System.Drawing.Point(254, 521);
            this.tmimataComboBox1.Name = "tmimataComboBox1";
            this.tmimataComboBox1.Size = new System.Drawing.Size(308, 28);
            this.tmimataComboBox1.TabIndex = 5;
            this.tmimataComboBox1.ValueMember = "id_tmimata";
            // 
            // tmimataBindingSource
            // 
            this.tmimataBindingSource.DataMember = "Tmimata";
            this.tmimataBindingSource.DataSource = this.daskaloiDataSet;
            // 
            // daskaloiDataSet
            // 
            this.daskaloiDataSet.DataSetName = "daskaloiDataSet";
            this.daskaloiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tmimataTableAdapter
            // 
            this.tmimataTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Τμήμα";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Επώνυμο";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Όνομα";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Μάθημα";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ώρα";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Μέρα";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 645);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Τάξη";
            // 
            // epithetoComboBox1
            // 
            this.epithetoComboBox1.DataSource = this.daskaloiBindingSource;
            this.epithetoComboBox1.DisplayMember = "onoma";
            this.epithetoComboBox1.FormattingEnabled = true;
            this.epithetoComboBox1.Location = new System.Drawing.Point(254, 559);
            this.epithetoComboBox1.Name = "epithetoComboBox1";
            this.epithetoComboBox1.Size = new System.Drawing.Size(308, 28);
            this.epithetoComboBox1.TabIndex = 13;
            this.epithetoComboBox1.ValueMember = "id";
            this.epithetoComboBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.epithetoComboBox1_Format);
            // 
            // daskaloiBindingSource
            // 
            this.daskaloiBindingSource.DataMember = "Daskaloi";
            this.daskaloiBindingSource.DataSource = this.daskaloiDataSet;
            // 
            // onomaComboBox1
            // 
            this.onomaComboBox1.DataSource = this.daskaloiBindingSource;
            this.onomaComboBox1.DisplayMember = "onoma";
            this.onomaComboBox1.FormattingEnabled = true;
            this.onomaComboBox1.Location = new System.Drawing.Point(254, 593);
            this.onomaComboBox1.Name = "onomaComboBox1";
            this.onomaComboBox1.Size = new System.Drawing.Size(308, 28);
            this.onomaComboBox1.TabIndex = 14;
            this.onomaComboBox1.ValueMember = "id";
            this.onomaComboBox1.Visible = false;
            // 
            // imeresComboBox1
            // 
            this.imeresComboBox1.DataSource = this.imeresBindingSource;
            this.imeresComboBox1.DisplayMember = "onoma";
            this.imeresComboBox1.FormattingEnabled = true;
            this.imeresComboBox1.Location = new System.Drawing.Point(669, 521);
            this.imeresComboBox1.Name = "imeresComboBox1";
            this.imeresComboBox1.Size = new System.Drawing.Size(377, 28);
            this.imeresComboBox1.TabIndex = 15;
            this.imeresComboBox1.ValueMember = "id_imeres";
            // 
            // imeresBindingSource
            // 
            this.imeresBindingSource.DataMember = "Imeres";
            this.imeresBindingSource.DataSource = this.daskaloiDataSet;
            // 
            // oraComboBox1
            // 
            this.oraComboBox1.FormattingEnabled = true;
            this.oraComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.oraComboBox1.Location = new System.Drawing.Point(669, 566);
            this.oraComboBox1.Name = "oraComboBox1";
            this.oraComboBox1.Size = new System.Drawing.Size(377, 28);
            this.oraComboBox1.TabIndex = 16;
            // 
            // mathimaComboBox1
            // 
            this.mathimaComboBox1.DisplayMember = "onoma";
            this.mathimaComboBox1.FormattingEnabled = true;
            this.mathimaComboBox1.Location = new System.Drawing.Point(670, 604);
            this.mathimaComboBox1.Name = "mathimaComboBox1";
            this.mathimaComboBox1.Size = new System.Drawing.Size(377, 28);
            this.mathimaComboBox1.TabIndex = 17;
            this.mathimaComboBox1.ValueMember = "id_mathimata";
            // 
            // mathimataBindingSource
            // 
            this.mathimataBindingSource.DataMember = "Mathimata";
            this.mathimataBindingSource.DataSource = this.daskaloiDataSet;
            // 
            // taksiComboBox1
            // 
            this.taksiComboBox1.DataSource = this.taksiBindingSource;
            this.taksiComboBox1.DisplayMember = "onoma";
            this.taksiComboBox1.FormattingEnabled = true;
            this.taksiComboBox1.Location = new System.Drawing.Point(669, 645);
            this.taksiComboBox1.Name = "taksiComboBox1";
            this.taksiComboBox1.Size = new System.Drawing.Size(377, 28);
            this.taksiComboBox1.TabIndex = 18;
            this.taksiComboBox1.ValueMember = "id_taksi";
            this.taksiComboBox1.SelectedIndexChanged += new System.EventHandler(this.updateMathimata);
            // 
            // taksiBindingSource
            // 
            this.taksiBindingSource.DataMember = "Taksi";
            this.taksiBindingSource.DataSource = this.daskaloiDataSet;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(254, 643);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(184, 26);
            this.idBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 643);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Πρόγραμμα ID";
            // 
            // daskaloiTableAdapter
            // 
            this.daskaloiTableAdapter.ClearBeforeFill = true;
            // 
            // daskaloiBindingSource1
            // 
            this.daskaloiBindingSource1.DataMember = "Daskaloi";
            this.daskaloiBindingSource1.DataSource = this.daskaloiDataSet;
            // 
            // imeresTableAdapter
            // 
            this.imeresTableAdapter.ClearBeforeFill = true;
            // 
            // daskaloiDataSetBindingSource
            // 
            this.daskaloiDataSetBindingSource.DataSource = this.daskaloiDataSet;
            this.daskaloiDataSetBindingSource.Position = 0;
            // 
            // mathimataTableAdapter
            // 
            this.mathimataTableAdapter.ClearBeforeFill = true;
            // 
            // taksiTableAdapter
            // 
            this.taksiTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 686);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Δάσκαλος ID";
            // 
            // id_daskalos
            // 
            this.id_daskalos.Location = new System.Drawing.Point(254, 686);
            this.id_daskalos.Name = "id_daskalos";
            this.id_daskalos.ReadOnly = true;
            this.id_daskalos.Size = new System.Drawing.Size(184, 26);
            this.id_daskalos.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(910, 708);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 72);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ενημέρωση / Αποθήκευση";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fillByFilterToolStrip
            // 
            this.fillByFilterToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByFilterToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByFilterToolStrip.Name = "fillByFilterToolStrip";
            this.fillByFilterToolStrip.Size = new System.Drawing.Size(1246, 25);
            this.fillByFilterToolStrip.TabIndex = 24;
            this.fillByFilterToolStrip.Text = "fillByFilterToolStrip";
            // 
            // idmathimatextBox1
            // 
            this.idmathimatextBox1.Location = new System.Drawing.Point(1067, 606);
            this.idmathimatextBox1.Name = "idmathimatextBox1";
            this.idmathimatextBox1.ReadOnly = true;
            this.idmathimatextBox1.Size = new System.Drawing.Size(100, 26);
            this.idmathimatextBox1.TabIndex = 25;
            this.idmathimatextBox1.Visible = false;
            // 
            // fKProgramma30BindingSource
            // 
            this.fKProgramma30BindingSource.DataMember = "FK_Programma_3_0";
            this.fKProgramma30BindingSource.DataSource = this.daskaloiBindingSource;
            // 
            // programmaTableAdapter
            // 
            this.programmaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(669, 708);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 72);
            this.button2.TabIndex = 26;
            this.button2.Text = "Διαγραφή";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 832);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idmathimatextBox1);
            this.Controls.Add(this.fillByFilterToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_daskalos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.taksiComboBox1);
            this.Controls.Add(this.mathimaComboBox1);
            this.Controls.Add(this.oraComboBox1);
            this.Controls.Add(this.imeresComboBox1);
            this.Controls.Add(this.onomaComboBox1);
            this.Controls.Add(this.epithetoComboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tmimataComboBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.load);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Επεξεργασία Προγράμματος";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmimataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imeresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathimataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProgramma30BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox tmimataComboBox1;
        private daskaloiDataSet daskaloiDataSet;
        private System.Windows.Forms.BindingSource tmimataBindingSource;
        private daskaloiDataSetTableAdapters.TmimataTableAdapter tmimataTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox epithetoComboBox1;
        private System.Windows.Forms.ComboBox onomaComboBox1;
        private System.Windows.Forms.ComboBox imeresComboBox1;
        private System.Windows.Forms.ComboBox oraComboBox1;
        private System.Windows.Forms.ComboBox mathimaComboBox1;
        private System.Windows.Forms.ComboBox taksiComboBox1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource daskaloiBindingSource;
        private daskaloiDataSetTableAdapters.DaskaloiTableAdapter daskaloiTableAdapter;
        private System.Windows.Forms.BindingSource daskaloiBindingSource1;
        private System.Windows.Forms.BindingSource imeresBindingSource;
        private daskaloiDataSetTableAdapters.ImeresTableAdapter imeresTableAdapter;
        private System.Windows.Forms.BindingSource daskaloiDataSetBindingSource;
        private System.Windows.Forms.BindingSource mathimataBindingSource;
        private daskaloiDataSetTableAdapters.MathimataTableAdapter mathimataTableAdapter;
        private System.Windows.Forms.BindingSource taksiBindingSource;
        private daskaloiDataSetTableAdapters.TaksiTableAdapter taksiTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox id_daskalos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip fillByFilterToolStrip;
        private System.Windows.Forms.TextBox idmathimatextBox1;
        private System.Windows.Forms.BindingSource fKProgramma30BindingSource;
        private daskaloiDataSetTableAdapters.ProgrammaTableAdapter programmaTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}