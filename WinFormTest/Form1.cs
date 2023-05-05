using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class FrmEmp : Form
    {
        public FrmEmp()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();
            

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

       
        private void Save_Click(object sender, EventArgs e, int id)
        {
             id=int.Parse(txtId.Text.ToString());
            string name = txtName.Text.ToString();
            string designation = txtdesig.ToString();

           string address = txtAddr.ToString();
            DataSet ds = new DataSet("Data Set");
            DataTable dataTable = new DataTable("Data");
            // dataTable.Columns.Add(eid);
            dataTable.Columns.Add("EmpId",typeof(int));
            dataTable.Columns.Add("EmpName", typeof(string));
            dataTable.Columns.Add("Designation", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));

            //dataTable.Rows.Add(new object[]
            //{
            //   "txtempid" ,txtid.text
            //})
                 //id = int.Parse(txtId.Text.ToString);
            
           // DataGrid dataGrid = new DataGrid();
            




        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("Data Set");
            DataTable dt = new DataTable("Data");

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            txtId.Text = String.Empty;
            txtName.Text = String.Empty;
            txtdesig.Text = String.Empty;
            txtAddr.Text = String.Empty;

            //sqlconnection con = new sqlconnection();
            con.Open();
            string query = "Delete from Employee";
        }
    }
}
