using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orologioDesktop
{
    public partial class Form1 : Form
    {
        SQLiteDataAdapter adapter;
        BindingSource bindingSource1 = new BindingSource();
        DataTable dt;
       
        
        public Form1()
        {
            InitializeComponent();
           

        
        
        }

        public void refreshDataGridView()
{
    dataGridView1.DataSource = bindingSource1;
}
        
         
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daskaloiDataSet.Tmimata' table. You can move, or remove it, as needed.
            this.tmimataTableAdapter.Fill(this.daskaloiDataSet.Tmimata);
            // TODO: This line of code loads data into the 'daskaloiDataSet.Taksi' table. You can move, or remove it, as needed.
            this.taksiTableAdapter.Fill(this.daskaloiDataSet.Taksi);
            // TODO: This line of code loads data into the 'daskaloiDataSet.Mathimata' table. You can move, or remove it, as needed.
            this.mathimataTableAdapter.Fill(this.daskaloiDataSet.Mathimata);
            // TODO: This line of code loads data into the 'daskaloiDataSet.Imeres' table. You can move, or remove it, as needed.
            this.imeresTableAdapter.Fill(this.daskaloiDataSet.Imeres);
            // TODO: This line of code loads data into the 'daskaloiDataSet.Daskaloi' table. You can move, or remove it, as needed.
            this.daskaloiTableAdapter.Fill(this.daskaloiDataSet.Daskaloi);
            // TODO: This line of code loads data into the 'daskaloiDataSet.Daskaloi' table. You can move, or remove it, as needed.
            dataGridView1.Update();


            var connectionString = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";
            string select =@"select Tmimata.onoma , Daskaloi.onoma , Daskaloi.epitheto ,Imeres.onoma , Programma.ora , Mathimata.onoma , Taksi.onoma as Tαξη 
From Programma , Tmimata , Daskaloi , Mathimata , Taksi , Imeres
Where Daskaloi.id = Programma.id_daskaloi and Imeres.id_imeres = Programma.id_imeres
and Tmimata.id_tmimata = Programma.id_tmimata and Mathimata.id_mathimata = Programma.id_mathimata 
and Programma.id_taksi = Taksi.id_taksi";


            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();
            SQLiteCommand command = new SQLiteCommand(select, connection);


            dt = new DataTable();
             adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);

            // Automatically generate the DataGridView columns.
           
            dataGridView1.AutoGenerateColumns = true;
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoSizeRowsMode =
               DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            // Set the DataGridView control's border.
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.Columns[0].HeaderText = "Τμήμα";
            dataGridView1.Columns[1].HeaderText = "Όνομα";
            dataGridView1.Columns[2].HeaderText = "Επίθετο";
            dataGridView1.Columns[3].HeaderText = "Ημέρα";
            dataGridView1.Columns[4].HeaderText = "Ώρα";
            dataGridView1.Columns[5].HeaderText = "Μάθημα";
            dataGridView1.Columns[6].HeaderText = "Τάξη";
       
             connection.Close();

             string curItem = listBox4.SelectedValue.ToString();

             listBox3.DataSource = null;
             var connectionString2 = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";
             string select2 = "SELECT * FROM Mathimata Where id_taksi=" + listBox4.SelectedValue.ToString();


             SQLiteConnection connection2 = new SQLiteConnection(connectionString2);

             connection2.Open();
             SQLiteCommand command2 = new SQLiteCommand(select2, connection2);


             DataTable dt2 = new DataTable();

             SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(command2);
             adapter2.Fill(dt2);
             listBox3.DisplayMember = "onoma";
             listBox3.ValueMember = "id_mathimata";
             listBox3.DataSource = dt2;
            
             connection.Close();

             DataView dv = (this.daskaloiDataSet.Tmimata.DefaultView);
             DataRowView drv = (DataRowView)listBox4.SelectedItem;
             String item = drv["id_taksi"].ToString();
             

            //filter on load class a

             dv.RowFilter = "id_taksi =" + item;

             DataTable newTable = dv.ToTable();
             listBox5.DataSource = newTable;
             listBox5.DisplayMember = "onoma";
             listBox5.ValueMember = "id_tmimata";

        }

        private void lb4Click(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb != null)
            {
                


                DataView dv = (this.daskaloiDataSet.Tmimata.DefaultView);
                DataRowView drv = (DataRowView)lb.SelectedItem;
                String item = drv["id_taksi"].ToString();
                
                dv.RowFilter = "id_taksi =" + item;
                DataTable newTable = dv.ToTable();
                listBox5.DataSource = newTable;
                listBox5.DisplayMember = "onoma";
                listBox5.ValueMember = "id_tmimata";
            }
        }





        private void ListBox1Format(object sender, ListControlConvertEventArgs e)
        {

            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value= r["onoma"] +" "+ r["epitheto"];
            listBox6.SetSelected(0, true);


        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox4.SelectedValue == null)
            {
                return;
            }
            
            string curItem = listBox4.SelectedValue.ToString();
         
            listBox3.DataSource = null;
            var connectionString = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";
            string select = "SELECT * FROM Mathimata Where id_taksi=" + listBox4.SelectedValue.ToString();
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(select, connection);
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);
           listBox3.DisplayMember = "onoma";
           listBox3.ValueMember = "id_mathimata";
           listBox3.DataSource = dt;
          connection.Close();
 
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            var form3 = (Form3)Tag;
            form3.Show();
            this.Close();
        
        
        }

 

        private void button1_Click(object sender, EventArgs e)
        {


            var connectionString = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteTransaction trans;
            string SQL = "INSERT INTO Programma (id_tmimata, id_daskaloi, id_imeres, ora , id_mathimata , id_taksi) VALUES";
            SQL += "(@id_tmimata, @id_daskaloi, @id_imeres, @ora, @id_mathimata , @id_taksi)";
            string curItem = listBox6.SelectedItem.ToString();
            SQLiteCommand cmd = new SQLiteCommand(SQL);
            cmd.Parameters.AddWithValue("@id_tmimata", Int32.Parse(listBox5.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@id_daskaloi", Int32.Parse(listBox1.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@id_imeres", Int32.Parse(listBox2.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@ora", Int32.Parse(curItem));
           
            cmd.Parameters.AddWithValue("@id_mathimata", Int32.Parse(listBox3.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@id_taksi", Int32.Parse(listBox4.SelectedValue.ToString()));
            cmd.Connection = connection;
            connection.Open();
            trans = connection.BeginTransaction();
            int retval = 0;
            try
            {
                retval = cmd.ExecuteNonQuery();
                if (retval == 1)
                    MessageBox.Show("H εισαγωγή ήταν επιτυχής");
                else
                    MessageBox.Show("H εισαγωγή απέτυχε.");
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
            finally
            {
                trans.Commit();
                cmd.Dispose();
                string select = @"select Tmimata.onoma , Daskaloi.onoma , Daskaloi.epitheto ,Imeres.onoma , Programma.ora , Mathimata.onoma , Taksi.onoma as Tαξη 
From Programma , Tmimata , Daskaloi , Mathimata , Taksi , Imeres
Where Daskaloi.id = Programma.id_daskaloi and Imeres.id_imeres = Programma.id_imeres
and Tmimata.id_tmimata = Programma.id_tmimata and Mathimata.id_mathimata = Programma.id_mathimata 
and Programma.id_taksi = Taksi.id_taksi";
                         
                SQLiteCommand command = new SQLiteCommand(select, connection);
                dt.Clear();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                connection.Close();
               }

        }





     
       

      



    }
}
