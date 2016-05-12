namespace orologioDesktop
{
    partial class addvariousForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.new_db = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(290, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Διαχείριση Στοιχείων Εφαρμογής";
            // 
            // new_db
            // 
            this.new_db.BackColor = System.Drawing.Color.Red;
            this.new_db.Location = new System.Drawing.Point(311, 166);
            this.new_db.Name = "new_db";
            this.new_db.Size = new System.Drawing.Size(502, 231);
            this.new_db.TabIndex = 1;
            this.new_db.Text = "Δημιουργία Βάσης Δεδομένων";
            this.new_db.UseVisualStyleBackColor = false;
            this.new_db.Click += new System.EventHandler(this.new_db_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(399, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 137);
            this.button1.TabIndex = 4;
            this.button1.Text = "Επιστροφή (Μενού)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addvariousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.new_db);
            this.Controls.Add(this.label1);
            this.Name = "addvariousForm";
            this.Text = "Διαχείριση Στοιχείων Εφαρμογής";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button new_db;
        private System.Windows.Forms.Button button1;
    }
}