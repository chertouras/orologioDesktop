﻿namespace orologioDesktop
{
    partial class addtmimaForm
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
            this.taksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daskaloiDataSet = new orologioDesktop.daskaloiDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.new_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.taksiTableAdapter = new orologioDesktop.daskaloiDataSetTableAdapters.TaksiTableAdapter();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // taksiBindingSource
            // 
            this.taksiBindingSource.DataMember = "Taksi";
            this.taksiBindingSource.DataSource = this.daskaloiDataSet;
            // 
            // daskaloiDataSet
            // 
            this.daskaloiDataSet.DataSetName = "daskaloiDataSet";
            this.daskaloiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(539, 286);
            this.dataGridView1.TabIndex = 1;
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(251, 453);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(199, 76);
            this.new_btn.TabIndex = 2;
            this.new_btn.Text = "Προσθήκη/Ενημέρωση";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Location = new System.Drawing.Point(70, 556);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(175, 76);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Διαγραφή";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(67, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 81);
            this.button3.TabIndex = 4;
            this.button3.Text = "Φόρτωση Δεδομένων";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.save_btn.Location = new System.Drawing.Point(251, 556);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(179, 76);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Αποθήκευση";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // taksiTableAdapter
            // 
            this.taksiTableAdapter.ClearBeforeFill = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancelbtn.Location = new System.Drawing.Point(456, 453);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(164, 76);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "Επιστροφή (Μενού)";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Διαχείριση Τμημάτων";
            // 
            // addtmimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "addtmimaForm";
            this.Text = "Διαχείριση Τμημάτων";
            ((System.ComponentModel.ISupportInitialize)(this.taksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daskaloiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button save_btn;
        private daskaloiDataSet daskaloiDataSet;
        private System.Windows.Forms.BindingSource taksiBindingSource;
        private daskaloiDataSetTableAdapters.TaksiTableAdapter taksiTableAdapter;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label1;
    }
}