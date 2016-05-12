using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace orologioDesktop
{
    public partial class Form3 : Form
    {
        public Form3()
        {

            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(2000);
            
            
            InitializeComponent();

            t.Abort();
        }



        public void splash()
        {
            Application.Run(new splashform());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Tag = this;
            frm.Show(this);
            this.Hide();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Tag = this;
            frm.Show(this);
            this.Hide();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addtaksisForm frm = new addtaksisForm();
            frm.Tag = this;
            frm.Show(this);
            this.Hide();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addtmimaForm frm = new addtmimaForm();
            frm.Tag = this;
            frm.Show(this);
            this.Hide();   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addekpaideytikoiForm frm = new addekpaideytikoiForm();
            frm.Tag = this;
            frm.Show(this);
            this.Hide();   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addmathimataForm frm = new addmathimataForm();
            frm.Tag = this;
            frm.Show(this);
            this.Hide();   
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addvariousForm frm = new addvariousForm();
            frm.Tag = this;
            frm.Show(this);
            this.Hide();   
        }
    }
}
