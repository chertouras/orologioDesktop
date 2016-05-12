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
    public partial class addtmimaForm : Form
    {
        SQLiteDataAdapter adapter;
        BindingSource bindingSource1 = new BindingSource();
        DataTable dt, dt_taksi;
        
        int created = 0;
        DataSet sDs;
        DataGridViewComboBoxColumn col1, col1daskalos; 
        DataTable dt_daskalos;


        public addtmimaForm()
        {
            InitializeComponent();
            save_btn.Enabled = false;
            delete_btn.Enabled = false;
            new_btn.Enabled = false;


        }

       


    

        private void button3_Click(object sender, EventArgs e)
        {
            var connectionString = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";
            string select = @"select *  from Tmimata";

            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();
            SQLiteCommand command = new SQLiteCommand(select, connection);

            sDs = new DataSet();
            dt = new DataTable();
            adapter = new SQLiteDataAdapter(command);
            adapter.Fill(sDs, "Tmimata");
            dt = sDs.Tables["Tmimata"];
            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
         
            connection.Close();
                        

            
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            save_btn.Enabled = false;
        
            dataGridView1.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false; 
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
           
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.Columns[1].HeaderText = "Τμήμα";

            connectionString = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";
             select = "SELECT * FROM Taksi";
             string select_daskalos = "SELECT * FROM Daskaloi";
            SQLiteConnection connection_taksi = new SQLiteConnection(connectionString);
            connection_taksi.Open();
            SQLiteCommand command_taksi = new SQLiteCommand(select, connection_taksi);
            SQLiteCommand command_daskalos = new SQLiteCommand(select_daskalos, connection_taksi);
            dt_taksi = new DataTable();
             dt_daskalos = new DataTable();
            SQLiteDataAdapter adapter_taksi = new SQLiteDataAdapter(command_taksi);
            SQLiteDataAdapter adapter_daskalos = new SQLiteDataAdapter(command_daskalos);
            adapter_taksi.Fill(dt_taksi);
            adapter_daskalos.Fill(dt_daskalos);

            if (created == 0)
            {
                 col1 = new DataGridViewComboBoxColumn();
                 col1daskalos = new DataGridViewComboBoxColumn();
                 created = 1; 
                dataGridView1.Columns.Add(col1); 
                dataGridView1.Columns.Add(col1daskalos);
            } 


            
            col1.Name = "col1";
            col1.HeaderText = "Επιλέξτε Τάξη";
            col1.DataSource = dt_taksi; // datasource for combo
            col1.DataPropertyName = "id_taksi";
           
            col1.ValueMember = "id_taksi";
            col1.DisplayMember = "onoma";


            col1daskalos.Name = "col1daskalos";
            col1daskalos.HeaderText = "Επιλέξτε Διδάσκοντα";
            col1daskalos.DataSource = dt_daskalos; // datasource for combo
            col1daskalos.DataPropertyName = "id_daskalos";
           
            col1daskalos.ValueMember = "id";
            col1daskalos.DisplayMember = "epitheto";
            dataGridView1.AllowUserToAddRows = false;
            new_btn.Enabled = true;
            delete_btn.Enabled = true;

            connection.Close();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            save_btn.Enabled = true;
            new_btn.Enabled = false;
            delete_btn.Enabled = false;
            dataGridView1.AllowUserToAddRows = true;
       
        
        
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

            button3_Click(button3, new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, 1, 1, 1, 1)); //Ανανέωση GridView
      
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            var form3 = (Form3)Tag;
            form3.Show();
            this.Close();
        }


    }
}
