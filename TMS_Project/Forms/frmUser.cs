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
    public partial class frmUser : Form
    {
        SQL sq = new SQL();
        public frmUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string AUDTDATE = DateTime.Now.ToString("yyyyMMdd");
                string AUDTTIME = DateTime.Now.ToString("HHmmss");
                string Uid = "";
                

                if (txtUserId.Text == "")
                {
                    MessageBox.Show("Enter User ID");
                    this.ActiveControl = txtPassword;
                    return;
                }
            
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Enter  User Name");
                    this.ActiveControl = txtUserName;
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter  Password");
                    this.ActiveControl = txtPassword;
                    return;
                }
                if (txtVerifyPassword.Text == "")
                {
                    MessageBox.Show("Enter  Verify Password");
                    this.ActiveControl = txtVerifyPassword;
                    return;
                }
                
                if (txtVerifyPassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("Password does not match");
                    this.ActiveControl = txtVerifyPassword;
                    return;
                }
                DataTable dtable = new DataTable();
                dtable = sq.get_rs("Select USERID from USERTBL where USERID='" + txtUserId.Text.Trim().ToUpper() + "'","rndDB",".");
                

                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];

                    if (drow.RowState != DataRowState.Deleted)
                    {
                        Uid = drow["USERID"].ToString().Trim();
                    }
                }

                
                
                if (txtUserId.Text != Uid)
                {
                    string strPassword = txtPassword.Text;
                  

                    var conv = System.Text.Encoding.UTF8.GetBytes(strPassword);
                    var decUserPassword = System.Convert.ToBase64String(conv);







                    MessageBox.Show("Saved Successful....");
                    newentry();

                    
                }
                else if (txtUserId.Text == Uid)
                {
                    string strPassword = txtPassword.Text;
                    //string strEncryptPassword = clsEncryptDecrypt.base64Encode(strPassword);

                    var conv = System.Text.Encoding.UTF8.GetBytes(strPassword);
                    var decUserPassword = System.Convert.ToBase64String(conv);

                    //dtable =sq.get_rs( "update USERTBL set USERFULLNAME = '" + txtUserName.Text + "',USERPASS='" + decUserPassword + "', PASSCREATIONDATE = '"
                    //                            + DateTime.Today + "' ,DATELASTMN = '"
                    //                            + AUDTDATE + "',AUDTTIME='" + AUDTTIME + "',  where USERID = '" + txtUserId.Text.Trim().ToUpper() + "'","rndDB",".");
                    

                    MessageBox.Show("Updated Successful");


                    
                }
                newentry();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newentry();
        }
        private void newentry()
        {
            txtUserId.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtVerifyPassword.Text = "";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmFinder userFinder = new frmFinder();
            userFinder.Owner = this;

            userFinder.ShowDialog();
        }

        private void txtWindowsUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
