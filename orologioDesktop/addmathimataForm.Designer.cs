﻿namespace orologioDesktop
{
    partial class addmathimataForm
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
            this.save_btn = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.save_btn.Location = new System.Drawing.Point(103, 568);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(172, 83);
            this.save_btn.TabIndex = 13;
            this.save_btn.Text = "Αποθήκευση";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menu.Location = new System.Drawing.Point(290, 568);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(161, 83);
            this.menu.TabIndex = 12;
            this.menu.Text = "Επιστροφή (Μενού)";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Location = new System.Drawing.Point(475, 473);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(206, 83);
            this.delete_btn.TabIndex = 11;
            this.delete_btn.Text = "Διαγραφή";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(290, 473);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(179, 83);
            this.new_btn.TabIndex = 10;
            this.new_btn.Text = "Προσθήκη / Αλλαγή";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(89, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 83);
            this.button1.TabIndex = 9;
            this.button1.Text = "Φόρτωση Δεδομένων";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(592, 343);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Διαχείριση Μαθημάτων";
            // 
            // addmathimataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 663);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "addmathimataForm";
            this.Text = "Διαχείριση Μαθημάτων";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}