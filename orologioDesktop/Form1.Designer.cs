namespace orologioDesktop
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.daskaloiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daskaloiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daskaloiDataSet = new orologioDesktop.daskaloiDataSet();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.imeresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daskaloiTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.DaskaloiTableAdapter();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.mathimataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mathimataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.taksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathimataTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.MathimataTableAdapter();
            this.taksiTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.TaksiTableAdapter();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.tmimataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tmimataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tmimataTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.TmimataTableAdapter();
            this.tmimataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.imeresTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.ImeresTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imeresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathimataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathimataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmimataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmimataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmimataBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.daskaloiBindingSource;
            this.listBox1.DisplayMember = "epitheto";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(285, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 144);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "id";
            this.listBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ListBox1Format);
            // 
            // daskaloiBindingSource
            // 
            this.daskaloiBindingSource.DataMember = "Daskaloi";
            this.daskaloiBindingSource.DataSource = this.daskaloiDataSetBindingSource;
            // 
            // daskaloiDataSetBindingSource
            // 
            this.daskaloiDataSetBindingSource.DataSource = this.daskaloiDataSet;
            this.daskaloiDataSetBindingSource.Position = 0;
            // 
            // daskaloiDataSet
            // 
            this.daskaloiDataSet.DataSetName = "daskaloiDataSet";
            this.daskaloiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.imeresBindingSource;
            this.listBox2.DisplayMember = "onoma";
            this.listBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(285, 178);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(354, 84);
            this.listBox2.TabIndex = 1;
            this.listBox2.ValueMember = "id_imeres";
            // 
            // imeresBindingSource
            // 
            this.imeresBindingSource.DataMember = "Imeres";
            this.imeresBindingSource.DataSource = this.daskaloiDataSetBindingSource;
            // 
            // daskaloiTableAdapter
            // 
            this.daskaloiTableAdapter.ClearBeforeFill = true;
            // 
            // listBox3
            // 
            this.listBox3.DataSource = this.mathimataBindingSource1;
            this.listBox3.DisplayMember = "onoma";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(938, 23);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(474, 224);
            this.listBox3.TabIndex = 2;
            this.listBox3.ValueMember = "id_mathimata";
            // 
            // mathimataBindingSource1
            // 
            this.mathimataBindingSource1.DataMember = "Mathimata";
            this.mathimataBindingSource1.DataSource = this.daskaloiDataSetBindingSource;
            // 
            // mathimataBindingSource
            // 
            this.mathimataBindingSource.DataMember = "Mathimata";
            this.mathimataBindingSource.DataSource = this.daskaloiDataSetBindingSource;
            // 
            // listBox4
            // 
            this.listBox4.DataSource = this.taksiBindingSource;
            this.listBox4.DisplayMember = "onoma";
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(285, 370);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(354, 104);
            this.listBox4.TabIndex = 3;
            this.listBox4.ValueMember = "id_taksi";
            this.listBox4.Click += new System.EventHandler(this.lb4Click);
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // taksiBindingSource
            // 
            this.taksiBindingSource.DataMember = "Taksi";
            this.taksiBindingSource.DataSource = this.daskaloiDataSetBindingSource;
            // 
            // mathimataTableAdapter
            // 
            this.mathimataTableAdapter.ClearBeforeFill = true;
            // 
            // taksiTableAdapter
            // 
            this.taksiTableAdapter.ClearBeforeFill = true;
            // 
            // listBox5
            // 
            this.listBox5.DataSource = this.tmimataBindingSource1;
            this.listBox5.DisplayMember = "onoma";
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 20;
            this.listBox5.Location = new System.Drawing.Point(285, 497);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(354, 64);
            this.listBox5.TabIndex = 4;
            this.listBox5.ValueMember = "id_tmimata";
            // 
            // tmimataBindingSource1
            // 
            this.tmimataBindingSource1.DataMember = "Tmimata";
            this.tmimataBindingSource1.DataSource = this.daskaloiDataSetBindingSource;
            // 
            // tmimataBindingSource
            // 
            this.tmimataBindingSource.DataMember = "Tmimata";
            this.tmimataBindingSource.DataSource = this.daskaloiDataSetBindingSource;
            // 
            // tmimataTableAdapter
            // 
            this.tmimataTableAdapter.ClearBeforeFill = true;
            // 
            // tmimataBindingSource2
            // 
            this.tmimataBindingSource2.DataMember = "Tmimata";
            this.tmimataBindingSource2.DataSource = this.daskaloiDataSetBindingSource;
            // 
            // imeresTableAdapter
            // 
            this.imeresTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Επιλέξτε Εκπαιδευτικό";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Επιλέξτε Ημέρα";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(16, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Επιλέξτε Τμήμα";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(13, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Επιλέξτε Τάξη";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(721, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Επιλέξτε Μάθημα";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(938, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(474, 156);
            this.button1.TabIndex = 10;
            this.button1.Text = "Αποθήκευση";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(1105, 852);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 100);
            this.button2.TabIndex = 11;
            this.button2.Text = "Επιστροφή";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(21, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Επιλέξτε Ώρα";
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 20;
            this.listBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.listBox6.Location = new System.Drawing.Point(285, 277);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(354, 84);
            this.listBox6.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 600);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 231);
            this.dataGridView1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(15, 586);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Υπάρχον Πρόγραμμα";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(17, 617);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Μόνο προβολή";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1624, 1098);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Δημιουργία Προγράμματος";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imeresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathimataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathimataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmimataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmimataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmimataBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource daskaloiDataSetBindingSource;
        private daskaloiDataSet daskaloiDataSet;
        private System.Windows.Forms.BindingSource daskaloiBindingSource;
        private daskaloiDataSetTableAdapters.DaskaloiTableAdapter daskaloiTableAdapter;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.BindingSource mathimataBindingSource;
        private daskaloiDataSetTableAdapters.MathimataTableAdapter mathimataTableAdapter;
        private System.Windows.Forms.BindingSource taksiBindingSource;
        private daskaloiDataSetTableAdapters.TaksiTableAdapter taksiTableAdapter;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.BindingSource tmimataBindingSource;
        private daskaloiDataSetTableAdapters.TmimataTableAdapter tmimataTableAdapter;
        private System.Windows.Forms.BindingSource tmimataBindingSource1;
        private System.Windows.Forms.BindingSource tmimataBindingSource2;
        private System.Windows.Forms.BindingSource imeresBindingSource;
        private daskaloiDataSetTableAdapters.ImeresTableAdapter imeresTableAdapter;
        private System.Windows.Forms.BindingSource mathimataBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
       
    }
}

