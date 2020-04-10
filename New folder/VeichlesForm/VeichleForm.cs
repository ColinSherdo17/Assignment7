using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace VeichlesForm
{
  
    public partial class VeichleDataForm : Form
    {

        String connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Owner\Desktop\Assignmentone\Common7\COLLEGE\.NET\Veichles.accdb";

        public VeichleDataForm()
        {
            InitializeComponent();
        }

        private void DisplayDataButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select Student_ID from Veichles", conn);
            OleDbDataReader rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(rd);
            
            dataGridView1.DataSource = dt;

        }

        private void VeichleDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veichlesDataSet.Veichles' table. You can move, or remove it, as needed.
            this.veichlesTableAdapter.Fill(veichlesDataSet.Veichles);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void veichlesBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
