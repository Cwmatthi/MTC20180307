using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        String connstring = @"Server=PL7\MTCDB;Database=AdventureWorks2012;Trusted_Connection=True;";


        public Form1()
        {
            InitializeComponent();
        }

        private void VendorGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        
        
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(connstring);
            SqlDataAdapter sqlDA = new SqlDataAdapter("sp_Vendorinfo", sqlconn);
            DataTable dtVendors = new DataTable();
            sqlDA.Fill(dtVendors);
            VendorGrid.DataSource = dtVendors;

        }
    }
}
