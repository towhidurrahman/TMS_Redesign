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
    public partial class frmDatabaseBackup : Form
    {
        public frmDatabaseBackup()
        {
            InitializeComponent();
        }

        private void textBox2_Resize(object sender, EventArgs e)
        {

        }

        private void Database_Backup_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
