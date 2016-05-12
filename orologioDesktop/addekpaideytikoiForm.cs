using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
namespace orologioDesktop
{
    public partial class addekpaideytikoiForm : Form
    {

        DataTable dt;
        SQLiteDataAdapter adapter;
        public addekpaideytikoiForm()
        {
            InitializeComponent();

            save_btn.Enabled = false;
            delete_btn.Enabled = false;
            new_btn.Enabled = false;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";
            string select = @"select *  from Daskaloi";

            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();
            SQLiteCommand command = new SQLiteCommand(select, connection);


             dt = new DataTable();
             adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);
          
            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
            SQLiteCommand command_taksi = new SQLiteCommand(select, connection);

            connection.Close();



           
       




            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Όνομα";
            dataGridView1.Columns[1].HeaderText = "Επίθετο";
            dataGridView1.Columns[2].HeaderText = "Email";
            dataGridView1.Columns[3].HeaderText = "Ειδικότητα";
            dataGridView1.Columns[4].HeaderText = "Βιογραφικό";


            save_btn.Enabled = true;
            delete_btn.Enabled = true;
            new_btn.Enabled = true;


        }

        private void menu_Click(object sender, EventArgs e)
        {
            var form3 = (Form3)Tag;
            form3.Show();
            this.Close();//Hide();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            save_btn.Enabled = true;
            new_btn.Enabled = false;
            delete_btn.Enabled = false;
            dataGridView1.AllowUserToAddRows = true;
       
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            if (MessageBox.Show("Θέλετε σίγουρα τη διαγραφή ?", "Διαγραφή", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    adapter.Update(dt);
                }

                catch
                {

                    MessageBox.Show("Δεν έγινε καμία διαγραφή. Πιθανών επιλέξατε κενή γραμμή");
                    return;
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            dataGridView1.EndEdit();

            try
            {

                adapter.Update(dt);


            }
            catch
            {

                MessageBox.Show("Δεν έγινε καμία προσθήκη. Πιθανών πατήσατε Αποθήκευση χωρίς να εισάγετε στοιχεία");
                return;
            }

            dt.AcceptChanges();



            dataGridView1.ReadOnly = true;
            save_btn.Enabled = false;
            new_btn.Enabled = true;
            delete_btn.Enabled = true;

            button1_Click(button1, new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, 1, 1, 1, 1)); //Ανανέωση GridView
      
        }
    }
}
