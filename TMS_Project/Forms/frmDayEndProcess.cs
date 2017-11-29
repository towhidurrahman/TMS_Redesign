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
    public partial class frmDayEndProcess : Form
    {
        public frmDayEndProcess()
        {
            InitializeComponent();
        }

        private void btnbtndayendPcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
