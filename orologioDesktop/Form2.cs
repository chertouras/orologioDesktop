using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orologioDesktop
{
   
    public partial class Form2 : Form
    {
        DataTable newTable;
        BindingSource bindingSource1 = new BindingSource();
        private String connectionString;
        private SQLiteConnection connection;
        int empty = 0;
        DataTable dt;
        string select;
        public Form2()
        {


            InitializeComponent();


            connectionString = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";
             select = @"select Programma.id_programma , Tmimata.onoma as Τμήμα, (Daskaloi.onoma || ' ' || Daskaloi.epitheto) AS Ονοματεπώνυμο ,Imeres.onoma as Ημέρα, Programma.ora as Ωρα , Mathimata.onoma as ¨Μάθημα, Taksi.onoma as Tάξη ,Daskaloi.id as Δάσκαλοι_ID
From Programma , Tmimata , Daskaloi , Mathimata , Taksi , Imeres
Where Daskaloi.id = Programma.id_daskaloi and Imeres.id_imeres = Programma.id_imeres
and Tmimata.id_tmimata = Programma.id_tmimata and Mathimata.id_mathimata = Programma.id_mathimata 
and Programma.id_taksi = Taksi.id_taksi ORDER BY Daskaloi.epitheto , CASE Imeres.onoma 
            WHEN 'ΔΕΥΤΕΡΑ' THEN 0 
            WHEN'ΤΡΙΤΗ' THEN 1
            WHEN 'ΤΕΤΑΡΤΗ' THEN 2
            WHEN 'ΠΕΜΠΤΗ' THEN 3
             WHEN 'ΠΑΡΑΣΚΕΥΗ' THEN 4 END ,Tmimata.onoma ,   Programma.ora ASC";
             connection = new SQLiteConnection(connectionString);
         
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SQLiteCommand command = new SQLiteCommand(select, connection);


             dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);
            empty = dt.Rows.Count;
            dataGridView1.AutoGenerateColumns = true;
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            connection.Close();



        }

        private void back_Click(object sender, EventArgs e)
        {

           var form3 = (Form3)Tag;
            form3.Show();
            this.Close();//Hide();
      
        
        
        
        
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'daskaloiDataSet.Programma' table. You can move, or remove it, as needed.
            
    }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
this.programmaTableAdapter.Fill(this.daskaloiDataSet.Programma);
 if (empty != 0) {
            // TODO: This line of code loads data into the 'daskaloiDataSet.Taksi' table. You can move, or remove it, as needed.
            this.taksiTableAdapter.Fill(this.daskaloiDataSet.Taksi);
          
            // TODO: This line of code loads data into the 'daskaloiDataSet.Imeres' table. You can move, or remove it, as needed.
            this.imeresTableAdapter.Fill(this.daskaloiDataSet.Imeres);
            // TODO: This line of code loads data into the 'daskaloiDataSet.Daskaloi' table. You can move, or remove it, as needed.
            this.daskaloiTableAdapter.Fill(this.daskaloiDataSet.Daskaloi);
            // TODO: This line of code loads data into the 'daskaloiDataSet.Tmimata' table. You can move, or remove it, as needed.
            this.tmimataTableAdapter.Fill(this.daskaloiDataSet.Tmimata);  // TODO: This line of code loads data into the 'daskaloiDataSet.Mathimata' table. You can move, or remove it, as needed.

            this.mathimataTableAdapter.Fill(this.daskaloiDataSet.Mathimata);
           
           
                DataView dv = (this.daskaloiDataSet.Mathimata.DefaultView);
                var firstrowcell = (this.daskaloiDataSet.Mathimata)[0][1];
                var firstrowcellid = (this.daskaloiDataSet.Mathimata)[0][0];
                idmathimatextBox1.Text = (string)firstrowcellid.ToString();
                dv.RowFilter = "id_taksi =" + firstrowcell;
                DataTable newTable = dv.ToTable("UniqueLastNames", true, "onoma", "id_mathimata");
                 mathimaComboBox1.DataSource = newTable;
                mathimaComboBox1.DisplayMember = "onoma";
                mathimaComboBox1.ValueMember = "id_mathimata";
           
 
 
 
 }

            DataGridView theGrid = sender as DataGridView;
            if (theGrid != null && theGrid.RowCount!=0)
            {
              
                int id = int.Parse(theGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                string tmima=theGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                
                string epitheto = theGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string mera = theGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
               
               string ora = theGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                string mathima = theGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                string taksi = theGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                int id_daskaloi = int.Parse(theGrid.Rows[e.RowIndex].Cells[7].Value.ToString());

             
                int item = tmimataComboBox1.FindStringExact(tmima);
                tmimataComboBox1.SelectedIndex = item;
                
               item = epithetoComboBox1.FindStringExact(epitheto);
                 epithetoComboBox1.SelectedIndex = item;
                item = imeresComboBox1.FindStringExact(mera);
               
                
                
                imeresComboBox1.SelectedIndex = item;
                item = oraComboBox1.FindStringExact(ora);
                oraComboBox1.SelectedIndex = item;
                item = taksiComboBox1.FindStringExact(taksi);
                taksiComboBox1.SelectedIndex = item;


                 idBox.Text = id.ToString();
                 id_daskalos.Text = id_daskaloi.ToString();

                 DataView dv = (this.daskaloiDataSet.Mathimata.DefaultView);
               
                item++;
                dv.RowFilter = "id_taksi =" + item;

                 newTable = dv.ToTable();
                mathimaComboBox1.DataSource = newTable;
                 mathimaComboBox1.DisplayMember = "onoma";
                 mathimaComboBox1.ValueMember = "id_mathimata";
             
                 item = mathimaComboBox1.FindStringExact(mathima);
                  
                mathimaComboBox1.SelectedIndex = item;
              if (item!=-1)
                idmathimatextBox1.Text = newTable.Rows[item][0].ToString();
  
            }
         
        }

        private void epithetoComboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
         
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["onoma"] + " " + r["epitheto"];
              
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (idBox.Text == "")
                return;

            var connectionString = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteTransaction trans;
            string SQL = "UPDATE Programma SET id_tmimata=@id_tmimata, id_daskaloi=@id_daskaloi, id_imeres=@id_imeres, ora=@ora , id_mathimata= @id_mathimata, id_taksi=@id_taksi WHERE id_programma=@id_programma";
                
            SQLiteCommand cmd = new SQLiteCommand(SQL);
            cmd.Parameters.AddWithValue("@id_tmimata", Int32.Parse(tmimataComboBox1.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@id_daskaloi", Int32.Parse(epithetoComboBox1.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@id_imeres", Int32.Parse(imeresComboBox1.SelectedValue.ToString()));
            string ora = oraComboBox1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@ora", Int32.Parse(ora));

            cmd.Parameters.AddWithValue("@id_mathimata", Int32.Parse(mathimaComboBox1.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@id_taksi", Int32.Parse(taksiComboBox1.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@id_programma", Int32.Parse(idBox.Text));
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
                load_Click(load, new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, 1, 1, 1, 1)); //Ανανέωση GridView
                connection.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (idBox.Text=="")
                return;


            var connectionString = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteTransaction trans;
            string SQL = "Delete From Programma WHERE id_programma=@id_programma";

            SQLiteCommand cmd = new SQLiteCommand(SQL);
            cmd.Parameters.AddWithValue("@id_programma", Int32.Parse(idBox.Text));

            cmd.Connection = connection;
            connection.Open();
            trans = connection.BeginTransaction();
            int retval = 0;
            try
            {
                retval = cmd.ExecuteNonQuery();
                if (retval == 1)
                    MessageBox.Show("H διαγραφή ήταν επιτυχής");
                else
                    MessageBox.Show("H διαγραφή απέτυχε");
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
            finally
            {
                trans.Commit();
                cmd.Dispose();
             load_Click(load, new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, 1, 1, 1, 1)); //Ανανέωση GridView
  
                

   this.daskaloiDataSet.Taksi.Clear();

   
 this.daskaloiDataSet.Imeres.Clear();
  
 this.daskaloiDataSet.Daskaloi.Clear();
   
 this.daskaloiDataSet.Tmimata.Clear();  
 newTable.Clear();
 oraComboBox1.SelectedItem = null;
 connection.Close();

            }

        }

        private void updateMathimata(object sender, EventArgs e)
        {
            if (taksiComboBox1.SelectedValue == null)
            {
                return;
            }

            string curItem = taksiComboBox1.SelectedValue.ToString();

            mathimaComboBox1.DataSource = null;
            var connectionString = @"Data Source=daskaloi.db;Version=3;foreign keys=True;";
            string select = "SELECT * FROM Mathimata Where id_taksi=" + taksiComboBox1.SelectedValue.ToString();
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(select, connection);
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);
            mathimaComboBox1.DisplayMember = "onoma";
            mathimaComboBox1.ValueMember = "id_mathimata";
            mathimaComboBox1.DataSource = dt;
            idmathimatextBox1.Text = mathimaComboBox1.SelectedValue.ToString();
            connection.Close();
        }

      

      
    
    
    
    
    
    }
}
