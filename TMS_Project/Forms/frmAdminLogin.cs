using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS_Project
{
    public partial class frmAdminLogin : Form
    {
        SQL sq = new SQL();
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable dtInsertQueryExecute = new DataTable();

             dtInsertQueryExecute = sq.get_rs("insert into USERTABLE values ('" + txtUserID.Text + "','" + txtPassword.Text + "')", "rndDB", ".");

            MessageBox.Show("successfully inserted");

            txtUserID.Text = "";
            txtPassword.Text = "";
        }
        
    }
}
