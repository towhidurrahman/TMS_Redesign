//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using HRMS.MODEL;

//using System.Reflection;
//using System.IO;


//namespace HRMS
//{
//    public partial class frmMain : Form
//    {
//        TreeNode _selectedNode = null;
//        DataTable _acountsTb = null;
//        SqlConnection _connection;
//        SqlCommand _command;
//        SqlDataAdapter _adapter;

//        string sql;
//        string firstUId;
//        string fullName, CheckActive, passday;
//        public string txtMainUserName { get; set; }
//        public frmMain()
//        {
//            InitializeComponent();
//            //_newNode = _thisLevel = _update = false;
//            _acountsTb = new DataTable();
//            _connection = new SqlConnection("Data Source=(local);Initial Catalog=HRMSDB;Integrated Security=True");
//            _command = new SqlCommand();
//            _command.Connection = _connection;
//        }

//        private void frmMain_Load(object sender, EventArgs e)
//        {
//            String sql = "SELECT *  FROM [UAUTH] where type='Parent Account' AND [UID]='" + txtMainUserName + "'";
//            try
//            {
//                _connection.Open();
//                _adapter = new SqlDataAdapter(sql, _connection);

//                _adapter.Fill(_acountsTb);
//            }
//            catch (SqlException ex)
//            {
//                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            finally
//            {
//                _connection.Close();
//            }

//            PopulateTreeView(0, null);
//            //----------
//            listView1.View = View.LargeIcon;
//            //listView1.View = View.Details;
//            listView1.Columns.Add("", 150);
//            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
//        }
//        private void PopulateTreeView(int parentId, TreeNode parentNode)
//        {

//            TreeNode childNode;
//            foreach (DataRow dr in _acountsTb.Select("[parent]=" + parentId))
//            {
//                TreeNode t = new TreeNode();
//                // t.Text = dr["code"].ToString() + " - " + dr["ac_name"].ToString();
//                t.Text = dr["ac_name"].ToString();
//                t.Name = dr["code"].ToString();
//                t.Tag = _acountsTb.Rows.IndexOf(dr);
//                if (parentNode == null)
//                {
//                    treeView1.Nodes.Add(t);
//                    childNode = t;
//                }
//                else
//                {
//                    parentNode.Nodes.Add(t);
//                    childNode = t;
//                }
//                PopulateTreeView(Convert.ToInt32(dr["code"].ToString()), childNode);
//            }
//        }

//        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
//        {
//            //listView1.Items.Clear();          
//            //listView1.SmallImageList = imgs;

//            _selectedNode = treeView1.SelectedNode;
//            ShowNodeData(_selectedNode);
//        }
//        private void ShowNodeData(TreeNode nod)
//        {
//            DataRow r = _acountsTb.Rows[int.Parse(nod.Tag.ToString())];
//            string id = r["code"].ToString();
//            string name = r["ac_name"].ToString();

//            sql = "select * from UAUTH where [UID]='" + txtMainUserName + "' and parent='" + id + "'";
//            dataLoadList(sql, "UAUTH");

//            autoResizeColumns(listView1);
//            //listView1.Items.Add("User", 0);
//        }
//        public void dataLoadList(string sql, string myString)
//        {//populate List view

//            ImageList imgs = new ImageList();
//            imgs.ImageSize = new Size(25, 25);

//            string[] paths = { };
//            //paths = Directory.GetFiles(@"F:\HRMS\Repository_HRMS\Images\ico");
//            paths = Directory.GetFiles(@"F:\Repository_HRMS\Images\ico");

//            //var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
//            //paths = (outPutDirectory, "Images\\logo.png)";
//            //var logoimage = Path.Combine(outPutDirectory, "Images\\logo.png");
//            //string relLogo = new Uri(logoimage).LocalPath;
//            //var logoImage = new LinkedResource(relLogo)

//            try
//            {
//                foreach (string path in paths)
//                {
//                    imgs.Images.Add(Image.FromFile(path));
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//            // End Populating Listview
//            DataTable dtable = new DataTable();
//            dataProvider lstData = new dataProvider();

//            dtable = lstData.getDataTable(sql, myString);

//            listView1.Items.Clear();

//            //string activeStatus;

//            for (int i = 0; i < dtable.Rows.Count; i++)
//            {
//                DataRow drow = dtable.Rows[i];

//                if (drow.RowState != DataRowState.Deleted)
//                {
//                    ListView lv = this.listView1;
//                    lv.View = View.LargeIcon;

//                    // Set the reference to your same member variable:
//                    // lv.SmallImageList = imgs;
//                    // lv.Items.Clear();

//                    listView1.LargeImageList = imgs;
//                    int imgno = Convert.ToInt32(drow["IMGNMBR"].ToString().Trim());
//                    ListViewItem lvi = new ListViewItem(drow["ac_name"].ToString().Trim(), imgno);
//                    lvi.SubItems.Add(drow["ac_name"].ToString().Trim());
//                    //listView1.Items.Add("User", 0);
//                    listView1.Items.Add(lvi);

//                }
//            }

//        }
//        public static void autoResizeColumns(ListView lv)
//        {
//            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
//            ListView.ColumnHeaderCollection cc = lv.Columns;
//            for (int i = 0; i < cc.Count; i++)
//            {
//                int colWidth = TextRenderer.MeasureText(cc[i].Text, lv.Font).Width + 10;
//                if (colWidth > cc[i].Width)
//                {
//                    cc[i].Width = colWidth;
//                }
//            }
//        }

//        private void listView1_DoubleClick(object sender, EventArgs e)
//        {
//            //string selected = listView1.SelectedItems[0].SubItems[0].Text;        
//            ////**** Child UM**************************
//            //if (selected == "User")
//            //{

//            //    frmUserCreation UserCreation = new frmUserCreation();
//            //    UserCreation.Owner = this;
//            //    UserCreation.txtMainUserName = txtMainUserName;
//            //    UserCreation.ShowDialog();
//            //}
//            //if (selected == "User Role Authorization")
//            //{
//            //    frmAdminUserAuthorization AdminUserAuthorization = new frmAdminUserAuthorization();
//            //    AdminUserAuthorization.Owner = this;
//            //    AdminUserAuthorization.txtMainUserName = txtMainUserName;
//            //    AdminUserAuthorization.ShowDialog();
//            //}                

//            ////frmAdminUserAuthorization
//            //if (selected == "Leave Setup") // Parent Leave Setup
//            //{
//            //    listView1.Items.Clear();
//            //    listView1.Items.Add("Leave Year", 6);
//            //    listView1.Items.Add("Leave Types", 4);
//            //    listView1.Items.Add("Leave Parameters", 4);
//            //    listView1.Items.Add("Work Flow", 4);
//            //}
//            ////******Child Leave Setup***************
//            //if (selected == "Leave Year")
//            //{
//            //    frmLeaveYearMaster leaveYearMaster = new frmLeaveYearMaster();
//            //    leaveYearMaster.Owner = this;
//            //    leaveYearMaster.txtMainUserName = txtMainUserName;
//            //    leaveYearMaster.ShowDialog();
//            //}
//            //if (selected == "Leave Types")
//            //{
//            //    frmLeaveTypesMaster leaveTypesMaster = new frmLeaveTypesMaster();
//            //    leaveTypesMaster.Owner = this;
//            //    leaveTypesMaster.txtMainUserName = txtMainUserName;
//            //    leaveTypesMaster.ShowDialog();
//            //}
//            //if (selected == "Leave Parameters")
//            //{
//            //    frmLeaveParameterMaster leaveParameterMaster = new frmLeaveParameterMaster();
//            //    leaveParameterMaster.Owner = this;
//            //    leaveParameterMaster.txtMainUserName = txtMainUserName;
//            //    leaveParameterMaster.ShowDialog();
//            //}
//            //if (selected == "Work Flow")
//            //{
//            //    frmLeaveWorkflowMaster leaveWorkflow = new frmLeaveWorkflowMaster();
//            //    leaveWorkflow.Owner = this;
//            //    leaveWorkflow.txtMainUserName = txtMainUserName;
//            //    leaveWorkflow.ShowDialog();
//            //}
//            ////*******************End Leave Setup****************************
//            //if (selected == "Year End")
//            //{
//            //    MessageBox.Show("Year End Don't Create yet!");
//            //    return;

//            //}
//            //if (selected == "Leave Entitlement")
//            //{
//            //    frmLeaveEntitlementMaster leaveEntitlementMaster = new frmLeaveEntitlementMaster();
//            //    leaveEntitlementMaster.Owner = this;
//            //    leaveEntitlementMaster.txtMainUserName = txtMainUserName;
//            //    leaveEntitlementMaster.ShowDialog();
//            //}
//            //// *****************End PP*******************

//            //if (selected == "Leave Transactions") // Parent Leave Trans.
//            //{
//            //    listView1.Items.Clear();
//            //    listView1.Items.Add("Leave Entries", 5);
//            //    listView1.Items.Add("Leave Adjustment", 5);
//            //}

//            ////********Child Leave Trans.********************
//            //if (selected == "Leave Entries")
//            //{
//            //    frmLeaveEntriesMaster leaveEntriesMaster = new frmLeaveEntriesMaster();
//            //    leaveEntriesMaster.Owner = this;
//            //    leaveEntriesMaster.txtMainUserName = txtMainUserName;
//            //    leaveEntriesMaster.ShowDialog();
//            //}
//            //if (selected == "Leave Adjustment")
//            //{
//            //    frmLeaveAdjustmentMaster leaveAdjustmentMaster = new frmLeaveAdjustmentMaster();
//            //    leaveAdjustmentMaster.Owner = this;
//            //    leaveAdjustmentMaster.txtMainUserName = txtMainUserName;
//            //    leaveAdjustmentMaster.ShowDialog();
//            //}
//            ////****************End Leave Trans.************************
//            //if (selected == "District")
//            //{
//            //    frmDistrictMaster districtMaster = new frmDistrictMaster();
//            //    districtMaster.Owner = this;
//            //    districtMaster.txtMainUserName = txtMainUserName;
//            //    districtMaster.ShowDialog();
//            //}
//            //if (selected == "Thana")
//            //{
//            //    frmThanaMaster thanaMaster = new frmThanaMaster();
//            //    thanaMaster.Owner = this;
//            //    thanaMaster.txtMainUserName = txtMainUserName;
//            //    thanaMaster.ShowDialog();
//            //}
//            //if (selected == "District-Thana")
//            //{
//            //    frmThanaDistrictMaster thanaMaster = new frmThanaDistrictMaster();
//            //    thanaMaster.Owner = this;
//            //    thanaMaster.txtMainUserName = txtMainUserName;
//            //    thanaMaster.ShowDialog();
//            //}
//            //if (selected == "Post Code")
//            //{
//            //    frmPostCodeMaster postCodeMaster = new frmPostCodeMaster();
//            //    postCodeMaster.Owner = this;
//            //    postCodeMaster.txtMainUserName = txtMainUserName;
//            //    postCodeMaster.ShowDialog();
//            //}
//            //if (selected == "Nationality")
//            //{
//            //    frmNationalityMaster NationalityMaster = new frmNationalityMaster();
//            //    NationalityMaster.Owner = this;
//            //    NationalityMaster.txtMainUserName = txtMainUserName;
//            //    NationalityMaster.ShowDialog();
//            //}
//            //if (selected == "Relation")
//            //{
//            //    frmRelationMaster RelationMaster = new frmRelationMaster();
//            //    RelationMaster.Owner = this;
//            //    RelationMaster.txtMainUserName = txtMainUserName;
//            //    RelationMaster.ShowDialog();
//            //}
//            //if (selected == "Religions")
//            //{
//            //    frmReligionMaster ReligionMaster = new frmReligionMaster();
//            //    ReligionMaster.Owner = this;
//            //    ReligionMaster.txtMainUserName = txtMainUserName;
//            //    ReligionMaster.ShowDialog();
//            //}
//            //if (selected == "Occupations")
//            //{
//            //    frmOccupationsMaster OccupationMaster = new frmOccupationsMaster();
//            //    OccupationMaster.Owner = this;
//            //    OccupationMaster.txtMainUserName = txtMainUserName;
//            //    OccupationMaster.ShowDialog();
//            //}
//            //if (selected == "Nomination Purpose")
//            //{
//            //    frmNominationMaster NominationMaster = new frmNominationMaster();
//            //    NominationMaster.Owner = this;
//            //    NominationMaster.txtMainUserName = txtMainUserName;
//            //    NominationMaster.ShowDialog();
//            //}
//            //if (selected == "Employee Type")
//            //{
//            //    frmEmployeeTypeMaster employeeType = new frmEmployeeTypeMaster();
//            //    employeeType.Owner = this;
//            //    employeeType.txtMainUserName = txtMainUserName;
//            //    employeeType.ShowDialog();
//            //}
//            //if (selected == "Employee Designation")
//            //{
//            //    frmDesignationMaster designationMaster = new frmDesignationMaster();
//            //    designationMaster.Owner = this;
//            //    designationMaster.txtMainUserName = txtMainUserName;
//            //    designationMaster.ShowDialog();
//            //}
//            //if (selected == "Employee Grade")
//            //{
//            //    frmGradeGroupMaster employeeGrade = new frmGradeGroupMaster();
//            //    employeeGrade.Owner = this;
//            //    employeeGrade.txtMainUserName = txtMainUserName;
//            //    employeeGrade.ShowDialog();
//            //}
//            //if (selected == "Grade Category")
//            //{
//            //    frmEmployeeGradesMaster employeeGrades = new frmEmployeeGradesMaster();
//            //    employeeGrades.Owner = this;
//            //    employeeGrades.txtMainUserName = txtMainUserName;
//            //    employeeGrades.ShowDialog();
//            //}
//            //if (selected == "Education Type")
//            //{
//            //    frmEducationTypeMaster educationType = new frmEducationTypeMaster();
//            //    educationType.Owner = this;
//            //    educationType.txtMainUserName = txtMainUserName;
//            //    educationType.ShowDialog();
//            //}
//            //if (selected == "Degree Title")
//            //{
//            //    frmDegreeTitleMaster degreeTitle = new frmDegreeTitleMaster();
//            //    degreeTitle.Owner = this;
//            //    degreeTitle.txtMainUserName = txtMainUserName;
//            //    degreeTitle.ShowDialog();
//            //}
//            //if (selected == "Institute")
//            //{
//            //    frmInstituteMaster instituteMaster = new frmInstituteMaster();
//            //    instituteMaster.Owner = this;
//            //    instituteMaster.txtMainUserName = txtMainUserName;
//            //    instituteMaster.ShowDialog();
//            //}
//            //if (selected == "Complain")
//            //{
//            //    frmDisciplinaryComplainMaster complainMaster = new frmDisciplinaryComplainMaster();
//            //    complainMaster.Owner = this;
//            //    complainMaster.txtMainUserName = txtMainUserName;
//            //    complainMaster.ShowDialog();
//            //}
//            //if (selected == "Punishment")
//            //{
//            //    frmDisciplinaryPunishmentMaster punishmentMaster = new frmDisciplinaryPunishmentMaster();
//            //    punishmentMaster.Owner = this;
//            //    punishmentMaster.txtMainUserName = txtMainUserName;
//            //    punishmentMaster.ShowDialog();
//            //}
//            ////***************End Child Basic setup******************************
//            //if (selected == "Employees")
//            //{
//            //    frmEmployeeInformationMasterSetup employeeInformationMaster =
//            //        new frmEmployeeInformationMasterSetup();
//            //    employeeInformationMaster.Owner = this;
//            //    employeeInformationMaster.txtMainUserName = txtMainUserName;
//            //    employeeInformationMaster.ShowDialog();
//            //}
//            ////************End Emp info **********************

//            //if (selected == "Disciplinary Management") // Parent Dis. Management
//            //{
//            //    listView1.Items.Clear();
//            //    listView1.Items.Add("Disciplinary Transaction", 5);
//            //}
//            ////****Child Dis. Management************
//            //if (selected == "Disciplinary Transaction")
//            //{
//            //    frmDisciplinaryActionTaken ActionTaken = new frmDisciplinaryActionTaken();
//            //    ActionTaken.Owner = this;
//            //    ActionTaken.ShowDialog();
//            //}
//            ////************End Dis. Management **********************
//            //if (selected == "Organization Detail")
//            //{
//            //    frmCompanyProfile CompanyProfile = new frmCompanyProfile();
//            //    CompanyProfile.Owner = this;
//            //    CompanyProfile.txtMainUserName = txtMainUserName;
//            //    CompanyProfile.ShowDialog();
//            //}
//            //if (selected == "Organization Hierarchy") // Parent Org. Hierarchy
//            //{
//            //    listView1.Items.Clear();
//            //    listView1.Items.Add("Division", 4);
//            //    listView1.Items.Add("Department", 4);
//            //    listView1.Items.Add("Sub-Department", 4);
//            //    listView1.Items.Add("Section", 4);
//            //}
//            ////*******Child Org. Hierarchy **********
//            //if (selected == "Division")
//            //{
//            //    frmDivisionMaster DivisionMaster = new frmDivisionMaster();
//            //    DivisionMaster.Owner = this;
//            //    DivisionMaster.txtMainUserName = txtMainUserName;
//            //    DivisionMaster.ShowDialog();
//            //}
//            //if (selected == "Department")
//            //{
//            //    frmDepartmentMaster DepartmentMaster = new frmDepartmentMaster();
//            //    DepartmentMaster.Owner = this;
//            //    DepartmentMaster.txtMainUserName = txtMainUserName;
//            //    DepartmentMaster.ShowDialog();
//            //}
//            //if (selected == "Sub-Department")
//            //{
//            //    frmSubDepartmentMaster SubDepartmentMaster = new frmSubDepartmentMaster();
//            //    SubDepartmentMaster.Owner = this;
//            //    SubDepartmentMaster.txtMainUserName = txtMainUserName;
//            //    SubDepartmentMaster.ShowDialog();
//            //}
//            //if (selected == "Section")
//            //{
//            //    frmSectionMaster SectionMaster = new frmSectionMaster();
//            //    SectionMaster.Owner = this;
//            //    SectionMaster.txtMainUserName = txtMainUserName;
//            //    SectionMaster.ShowDialog();
//            //}
//            ////***********End Org. Hierarchy setup******************
//            //if (selected == "Location")
//            //{
//            //    frmLocationMaster locationMaster = new frmLocationMaster();
//            //    locationMaster.Owner = this;
//            //    locationMaster.txtMainUserName = txtMainUserName;
//            //    locationMaster.ShowDialog();
//            //}
//            ////*******End Child Location******************

//            //if (selected == "Holiday Master") // Parent  Holiday setup
//            //{
//            //    listView1.Items.Clear();
//            //    listView1.Items.Add("Weekend", 9);
//            //    listView1.Items.Add("Holiday", 9);
//            //}
//            //// *****Child Holiday Setup**************
//            //if (selected == "Weekend")
//            //{
//            //    frmWeeklyHolidayMaster weeklyHolidayMaster = new frmWeeklyHolidayMaster();
//            //    weeklyHolidayMaster.Owner = this;

//            //    weeklyHolidayMaster.ShowDialog();
//            //}
//            //if (selected == "Holiday")
//            //{
//            //    frmYearlyHolidayMaster yearlyHolidayMaster = new frmYearlyHolidayMaster();
//            //    yearlyHolidayMaster.Owner = this;
//            //    yearlyHolidayMaster.txtMainUserName = txtMainUserName;
//            //    yearlyHolidayMaster.ShowDialog();
//            //}
//            ////******End Child Holiday******************

//            //if (selected == "Bank Service") // Parent Bank Service
//            //{
//            //    listView1.Items.Clear();
//            //    listView1.Items.Add("Bank Setup", 3);
//            //    listView1.Items.Add("Bank Transaction", 3);
//            //}
//            //if (selected == "Bank Setup") // Parent Bank Setup
//            //{
//            //    listView1.Items.Clear();
//            //    listView1.Items.Add("Banks", 4);
//            //    listView1.Items.Add("Branches", 4);
//            //}
//            ////*****child Bank Setup*******************
//            //if (selected == "Banks")
//            //{
//            //    frmBankMaster bankMaster = new frmBankMaster();
//            //    bankMaster.Owner = this;
//            //    bankMaster.txtMainUserName = txtMainUserName;
//            //    bankMaster.ShowDialog();
//            //}
//            //if (selected == "Branches")
//            //{
//            //    frmBankBranchMaster bankBranch = new frmBankBranchMaster();
//            //    bankBranch.Owner = this;
//            //    bankBranch.txtMainUserName = txtMainUserName;
//            //    bankBranch.ShowDialog();
//            //}
//            ////***********End Child Bank Setup********************
//            //if (selected == "Assign Salary Bank Account")
//            //{
//            //    frmBankAccountAssignSalary BankAssignSalary = new frmBankAccountAssignSalary();
//            //    BankAssignSalary.Owner = this;
//            //    BankAssignSalary.txtMainUserName = txtMainUserName;
//            //    BankAssignSalary.ShowDialog();
//            //}
//            //if (selected == "Assign OPI Bank Account")
//            //{
//            //    frmBankAccountAssignOPI BankAssignOPI = new frmBankAccountAssignOPI();
//            //    BankAssignOPI.Owner = this;
//            //    BankAssignOPI.txtMainUserName = txtMainUserName;
//            //    BankAssignOPI.ShowDialog();
//            //}
//            ////*************End Bank Trans.*****************************
//            //if (selected == "Loans & Advances") // Parent Loans & Advances
//            //{
//            //    listView1.Items.Clear();
//            //    listView1.Items.Add("Loan Setup", 3);
//            //    listView1.Items.Add("Loan Transaction", 3);
//            //}
//            //if (selected == "Loan Setup") // Parent Loan Setup
//            //{
//            //    listView1.Items.Clear();
//            //    listView1.Items.Add("Loan Type", 4);
//            //    listView1.Items.Add("Loan Category", 4);
//            //}
//            ////*********child Loan type******************8
//            //if (selected == "Loan Type")
//            //{
//            //    frmLoanTypeMaster loanTypeMaster = new frmLoanTypeMaster();
//            //    loanTypeMaster.Owner = this;
//            //    loanTypeMaster.txtMainUserName = txtMainUserName;
//            //    loanTypeMaster.ShowDialog();
//            //}
//            //if (selected == "Loan Category")
//            //{
//            //    frmLoanCategoryMaster loanCategoryMaster = new frmLoanCategoryMaster();
//            //    loanCategoryMaster.Owner = this;
//            //    loanCategoryMaster.txtMainUserName = txtMainUserName;
//            //    loanCategoryMaster.ShowDialog();
//            //}
//            ////****End Child loan setup************
//            //if (selected == "Loan Entry Batch List")
//            //{
//            //    frmLoanScheduleMaster loanScheduleMaster = new frmLoanScheduleMaster();
//            //    loanScheduleMaster.Owner = this;
//            //    loanScheduleMaster.txtMainUserName = txtMainUserName;
//            //    loanScheduleMaster.ShowDialog();
//            //}
//            //if (selected == "Loan Adjustment Batch List")
//            //{
//            //    frmLoanScheduleAdjustmentBatchList loanScheduleAdjustment = new frmLoanScheduleAdjustmentBatchList();
//            //    loanScheduleAdjustment.Owner = this;
//            //    loanScheduleAdjustment.txtMainUserName = txtMainUserName;
//            //    loanScheduleAdjustment.ShowDialog();
//            //}
//            ////***********End Child loan trans.**************

//            //if (selected == "Monthly Salary Process") //Parent Monthly Salary Process
//            //{
//            //    listView1.Items.Clear();
//            //    listView1.Items.Add("Salary Setup", 3);
//            //    listView1.Items.Add("Salary Periodic Process", 3);
//            //    listView1.Items.Add("Salary Transaction", 3);
//            //}
//            //if (selected == "Earning Deduction")
//            //{
//            //    frmEarningDeductionMaster EarningDeductionMaster = new frmEarningDeductionMaster();
//            //    EarningDeductionMaster.Owner = this;
//            //    EarningDeductionMaster.txtMainUserName = txtMainUserName;
//            //    EarningDeductionMaster.ShowDialog();
//            //}
//            //if (selected == "Grade")
//            //{
//            //    frmEarningDeductionGradeSetupMaster gradeSetupMaster = new frmEarningDeductionGradeSetupMaster();
//            //    gradeSetupMaster.Owner = this;
//            //    gradeSetupMaster.txtMainUserName = txtMainUserName;
//            //    gradeSetupMaster.ShowDialog();
//            //}
//            //if (selected == "Slab")
//            //{
//            //    frmSlabSetupManually slabSetupManually = new frmSlabSetupManually();
//            //    slabSetupManually.Owner = this;
//            //    slabSetupManually.txtMainUserName = txtMainUserName;
//            //    slabSetupManually.ShowDialog();
//            //}
//            ////******End Salary Setup*************************
//            //if (selected == "Assign Individual Salary")
//            //{
//            //    frmEarningDeductionBatchUploadIndividualAllowanceInfomation
//            //        EDbatchUploadIndividualAllowanceInfomation =
//            //            new frmEarningDeductionBatchUploadIndividualAllowanceInfomation();
//            //    EDbatchUploadIndividualAllowanceInfomation.Owner = this;
//            //    EDbatchUploadIndividualAllowanceInfomation.txtMainUserName = txtMainUserName;
//            //    EDbatchUploadIndividualAllowanceInfomation.ShowDialog();
//            //}
//            //if (selected == "Component Wise Salary Approval")
//            //{
//            //    frmEarningDeductionHeadWiseSalaryApproval approvalBatchUpload =
//            //        new frmEarningDeductionHeadWiseSalaryApproval();
//            //    approvalBatchUpload.Owner = this;
//            //    approvalBatchUpload.txtMainUserName = txtMainUserName;
//            //    approvalBatchUpload.ShowDialog();
//            //}
//            //if (selected == "View Individual Salary")
//            //{
//            //    frmEarningDeductionAppliedForView earningDeductionAppliedForView =
//            //        new frmEarningDeductionAppliedForView();
//            //    earningDeductionAppliedForView.Owner = this;
//            //    earningDeductionAppliedForView.txtMainUserName = txtMainUserName;
//            //    earningDeductionAppliedForView.ShowDialog();
//            //}
//            //if (selected == "Salary Month End")
//            //{
//            //    frmSalaryMonthEnd SalaryMonthEnd = new frmSalaryMonthEnd();
//            //    SalaryMonthEnd.Owner = this;
//            //    SalaryMonthEnd.txtMainUserName = txtMainUserName;
//            //    SalaryMonthEnd.ShowDialog();
//            //}
//            ////******* End Salary Periodic Process********************
//            //if (selected == "Monthly Salary Calculation")
//            //{
//            //    frmSalaryCalculationBatchListMaster salaryCalculationBatchListMaster =
//            //        new frmSalaryCalculationBatchListMaster();
//            //    salaryCalculationBatchListMaster.Owner = this;
//            //    salaryCalculationBatchListMaster.txtMainUserName = txtMainUserName;
//            //    salaryCalculationBatchListMaster.ShowDialog();
//            //}
//            //if (selected == "Edit Individual Employee")
//            //{
//            //    frmEditIndividualEmployee editIndividualEmployee = new frmEditIndividualEmployee();
//            //    editIndividualEmployee.Owner = this;
//            //    editIndividualEmployee.ShowDialog();
//            //}
//            ////***********End Child Salary Transaction********************
//            //if (selected == "OP Item")
//            //{
//            //    frmOPIItemMaster opiItemMaster = new frmOPIItemMaster();
//            //    opiItemMaster.Owner = this;
//            //    opiItemMaster.txtMainUserName = txtMainUserName;
//            //    opiItemMaster.ShowDialog();
//            //}
//            //if (selected == "OP Grade")
//            //{
//            //    frmOPIGradeMaster OPIGradeMaster = new frmOPIGradeMaster();
//            //    OPIGradeMaster.Owner = this;
//            //    OPIGradeMaster.txtMainUserName = txtMainUserName;
//            //    OPIGradeMaster.ShowDialog();
//            //}

//            ////RND purpose dynamically form load


//            ////******End child Other Payment Setup**************

//            try
//            {
//                string selected = listView1.SelectedItems[0].SubItems[0].Text;

//                //if (selected == "Transcom Distribution Company Limited")   //Parent Company Name
//                //{
//                //    listView1.Items.Clear();
//                //    listView1.Items.Add("Administrative Service", 3);
//                //    listView1.Items.Add("Organization", 3);
//                //    listView1.Items.Add("HR Management", 3);
//                //    listView1.Items.Add("Payroll Management", 3);
//                //    listView1.Items.Add("Final Settlement", 3);
//                //}

//                if (selected == "User Management") // Parent UM
//                {
//                    listView1.Items.Clear();

//                    listView1.Items.Add("User", 0); //Here 0 is Image Id  
//                    listView1.Items.Add("Role", 1);
//                    listView1.Items.Add("User role authorization", 2);
//                }

//                //**** Child UM**************************
//                if (selected == "User")
//                {
//                    frmUserCreation UserCreation = new frmUserCreation();
//                    UserCreation.Owner = this;
//                    UserCreation.txtMainUserName = txtMainUserName;
//                    UserCreation.ShowDialog();
//                }
//                //if (selected == "Role")
//                //{
//                //    frmUserCreation UserCreation = new frmUserCreation();
//                //    UserCreation.Owner = this;
//                //    UserCreation.txtMainUserName = txtMainUserName;
//                //    UserCreation.ShowDialog();
//                //}
//                if (selected == "User Role Authorization")
//                {
//                    frmAdminUserAuthorization AdminUserAuthorization = new frmAdminUserAuthorization();
//                    AdminUserAuthorization.Owner = this;
//                    AdminUserAuthorization.txtMainUserName = txtMainUserName;
//                    AdminUserAuthorization.ShowDialog();
//                }
//                if (selected == "UI Profile Maintenance")
//                {
//                    frmUIProfileMaintenance UIProfileMaintenance = new frmUIProfileMaintenance();
//                    UIProfileMaintenance.Owner = this;
//                    UIProfileMaintenance.txtMainUserName = txtMainUserName;
//                    UIProfileMaintenance.ShowDialog();
//                }
//                //**** End Child UM**************************

//                if (selected == "Leave & Attendance Management") // Parent Leave Management
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Leave Setup", 3); // Folder id=3
//                    listView1.Items.Add("Leave Year", 3);
//                    listView1.Items.Add("Leave Types", 3);
//                }
//                if (selected == "Leave")
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Leave Setup", 6);
//                    listView1.Items.Add("Leave Periodic Processing", 6);
//                    listView1.Items.Add("Leave Transactions", 6);
//                }

//                if (selected == "Leave Setup") // Parent Leave Setup
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Leave Year", 6);
//                    listView1.Items.Add("Leave Types", 4);
//                    listView1.Items.Add("Leave Parameters", 4);
//                    listView1.Items.Add("Work Flow", 4);
//                }
//                //******Child Leave Setup***************
//                if (selected == "Leave Year")
//                {
//                    frmLeaveYearSetup leaveYearMaster = new frmLeaveYearSetup();
//                    leaveYearMaster.Owner = this;
//                    leaveYearMaster.txtMainUserName = txtMainUserName;
//                    leaveYearMaster.ShowDialog();
//                }
//                if (selected == "Leave Types")
//                {
//                    frmLeaveTypesMaster leaveTypesMaster = new frmLeaveTypesMaster();
//                    leaveTypesMaster.Owner = this;
//                    leaveTypesMaster.txtMainUserName = txtMainUserName;
//                    leaveTypesMaster.ShowDialog();
//                }
//                if (selected == "Leave Parameters")
//                {
//                    frmLeaveParameterMaster leaveParameterMaster = new frmLeaveParameterMaster();
//                    leaveParameterMaster.Owner = this;
//                    leaveParameterMaster.txtMainUserName = txtMainUserName;
//                    leaveParameterMaster.ShowDialog();
//                }
//                if (selected == "Work Flow")
//                {
//                    frmLeaveWorkflowMaster leaveWorkflow = new frmLeaveWorkflowMaster();
//                    leaveWorkflow.Owner = this;
//                    leaveWorkflow.txtMainUserName = txtMainUserName;
//                    leaveWorkflow.ShowDialog();
//                }
//                //*******************End Leave Setup****************************

//                if (selected == "Leave Periodic Processing") // Parent Leave PP
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Year End", 6);
//                    listView1.Items.Add("Leave Entitlement", 5);
//                }

//                //*****Child Leave PP*********************************
//                if (selected == "Year End")
//                {
//                    MessageBox.Show("Year End Don't Create yet!");
//                    return;

//                }
//                if (selected == "Leave Entitlement")
//                {
//                    frmLeaveEntitlementMaster leaveEntitlementMaster = new frmLeaveEntitlementMaster();
//                    leaveEntitlementMaster.Owner = this;
//                    leaveEntitlementMaster.txtMainUserName = txtMainUserName;
//                    leaveEntitlementMaster.ShowDialog();
//                }
//                // *****************End PP*******************

//                if (selected == "Leave Transactions") // Parent Leave Trans.
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Leave Entries", 5);
//                    listView1.Items.Add("Leave Adjustment", 5);
//                }

//                //********Child Leave Trans.********************
//                if (selected == "Leave Entries")
//                {
//                    frmLeaveEntriesMaster leaveEntriesMaster = new frmLeaveEntriesMaster();
//                    leaveEntriesMaster.Owner = this;
//                    leaveEntriesMaster.txtMainUserName = txtMainUserName;
//                    leaveEntriesMaster.ShowDialog();
//                }
//                if (selected == "Leave Adjustment")
//                {
//                    frmLeaveAdjustmentMaster leaveAdjustmentMaster = new frmLeaveAdjustmentMaster();
//                    leaveAdjustmentMaster.Owner = this;
//                    leaveAdjustmentMaster.txtMainUserName = txtMainUserName;
//                    leaveAdjustmentMaster.ShowDialog();
//                }
//                //****************End Leave Trans.************************

//                if (selected == "Attendance")
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Shift Setup", 6);
//                    listView1.Items.Add("Manual Attendance", 6);
//                    listView1.Items.Add("Shift Assign Process", 6);
//                    listView1.Items.Add("Attendance Transactions", 6);
//                }
//                if (selected == "Shift Setup")
//                {
//                    frmShiftSetup shiftSetup = new frmShiftSetup();
//                    shiftSetup.Owner = this;
//                    shiftSetup.txtMainUserName = txtMainUserName;
//                    shiftSetup.ShowDialog();
//                }
//                if (selected == "Manual Attendance")
//                {
//                    frmManualAttendanceEntry manualAttendanceEntry = new frmManualAttendanceEntry();
//                    manualAttendanceEntry.Owner = this;
//                    manualAttendanceEntry.txtMainUserName = txtMainUserName;
//                    manualAttendanceEntry.ShowDialog();
//                }
//                if (selected == "Shift Assign Process")
//                {
//                    frmShiftAssignProcess shiftAssignProcess = new frmShiftAssignProcess();
//                    shiftAssignProcess.Owner = this;
//                    shiftAssignProcess.txtMainUserName = txtMainUserName;
//                    shiftAssignProcess.ShowDialog();
//                }

//                if (selected == "Attendance Transactions")
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Device Data Process", 5);
//                    listView1.Items.Add("Attendance Final Process", 5);
//                }
//                if (selected == "Device Data Process")
//                {
//                    frmAttendanceDeviceDataProcess attendanceDeviceDataProcess = new frmAttendanceDeviceDataProcess();
//                    attendanceDeviceDataProcess.Owner = this;
//                    attendanceDeviceDataProcess.txtMainUserName = txtMainUserName;
//                    attendanceDeviceDataProcess.ShowDialog();
//                }
//                if (selected == "Attendance Final Process")
//                {
//                    frmAttendanceFinalProcess attendanceFinalProcess = new frmAttendanceFinalProcess();
//                    attendanceFinalProcess.Owner = this;
//                    attendanceFinalProcess.txtMainUserName = txtMainUserName;
//                    attendanceFinalProcess.ShowDialog();
//                }
//                if (selected == "Basic Setup") // Parent Basic Setutp
//                {
//                    listView1.Items.Clear();
//                    //listView1.Items.Add("Division", 4);
//                    listView1.Items.Add("District", 4);
//                    listView1.Items.Add("Thana", 4);
//                    listView1.Items.Add("District-Thana", 4);
//                    listView1.Items.Add("Post Code", 4);
//                    listView1.Items.Add("Nationality", 4);
//                    listView1.Items.Add("Relation", 4);
//                    listView1.Items.Add("Religions", 4);
//                    listView1.Items.Add("Occupations", 4);
//                    listView1.Items.Add("Nomination Purpose", 4);
//                    listView1.Items.Add("Employee Type", 4);
//                    listView1.Items.Add("Employee Designation", 4);
//                    listView1.Items.Add("Employee Grade", 4);
//                    listView1.Items.Add("Grade Category", 4);
//                    listView1.Items.Add("Education Type", 4);
//                    listView1.Items.Add("Degree Title", 4);
//                    listView1.Items.Add("Institute", 4);
//                    listView1.Items.Add("Complain", 4);
//                    listView1.Items.Add("Punishment", 4);
//                }
//                //****** Child Basic Setutp************************
//                //if (selected == "Division")
//                //{
//                //    frmDivisionMaster DivisionMaster = new frmDivisionMaster();
//                //    DivisionMaster.Owner = this;
//                //    DivisionMaster.txtMainUserName = txtMainUserName;
//                //    DivisionMaster.ShowDialog();
//                //}      
//                if (selected == "District")
//                {
//                    frmDistrict district = new frmDistrict();
//                    district.Owner = this;
//                    district.txtMainUserName = txtMainUserName;
//                    district.ShowDialog();
//                }
//                if (selected == "Thana")
//                {
//                    frmThana thana = new frmThana();
//                    thana.Owner = this;
//                    thana.txtMainUserName = txtMainUserName;
//                    thana.ShowDialog();
//                }
//                if (selected == "District-Thana")
//                {
//                    frmThanaDistrictMaster thanaMaster = new frmThanaDistrictMaster();
//                    thanaMaster.Owner = this;
//                    thanaMaster.txtMainUserName = txtMainUserName;
//                    thanaMaster.ShowDialog();
//                }
//                if (selected == "Post Code")
//                {
//                    frmPostCodeSetup postCode = new frmPostCodeSetup();
//                    postCode.Owner = this;
//                    postCode.txtMainUserName = txtMainUserName;
//                    postCode.ShowDialog();
//                }
//                if (selected == "Nationality")
//                {
//                    frmNationality nationality = new frmNationality();
//                    nationality.Owner = this;
//                    nationality.txtMainUserName = txtMainUserName;
//                    nationality.ShowDialog();
//                }
//                if (selected == "Relation")
//                {
//                    frmRelation relation = new frmRelation();
//                    relation.Owner = this;
//                    relation.txtMainUserName = txtMainUserName;
//                    relation.ShowDialog();
//                }
//                if (selected == "Religions")
//                {
//                    frmReligion religion = new frmReligion();
//                    religion.Owner = this;
//                    religion.txtMainUserName = txtMainUserName;
//                    religion.ShowDialog();
//                }
//                if (selected == "Occupations")
//                {
//                    frmOccupations occupations = new frmOccupations();
//                    occupations.Owner = this;
//                    occupations.txtMainUserName = txtMainUserName;
//                    occupations.ShowDialog();
//                }
//                if (selected == "Nomination Purpose")
//                {
//                    frmNomination nomination = new frmNomination();
//                    nomination.Owner = this;
//                    nomination.txtMainUserName = txtMainUserName;
//                    nomination.ShowDialog();
//                }
//                if (selected == "Employee Type")
//                {
//                    frmEmployeeType employeeType = new frmEmployeeType();
//                    employeeType.Owner = this;
//                    employeeType.txtMainUserName = txtMainUserName;
//                    employeeType.ShowDialog();
//                }
//                if (selected == "Employee Designation")
//                {
//                    frmDesignation designationMaster = new frmDesignation();
//                    designationMaster.Owner = this;
//                    designationMaster.txtMainUserName = txtMainUserName;
//                    designationMaster.ShowDialog();
//                }
//                if (selected == "Employee Grade")
//                {
//                    frmEmployeeGradeGroup employeeGrade = new frmEmployeeGradeGroup();
//                    employeeGrade.Owner = this;
//                    employeeGrade.txtMainUserName = txtMainUserName;
//                    employeeGrade.ShowDialog();
//                }
//                if (selected == "Grade Category")
//                {
//                    frmEmployeeGradeCategory employeeGrades = new frmEmployeeGradeCategory();
//                    employeeGrades.Owner = this;
//                    employeeGrades.txtMainUserName = txtMainUserName;
//                    employeeGrades.ShowDialog();
//                }
//                if (selected == "Education Type")
//                {
//                    frmEducationType educationType = new frmEducationType();
//                    educationType.Owner = this;
//                    educationType.txtMainUserName = txtMainUserName;
//                    educationType.ShowDialog();
//                }
//                if (selected == "Degree Title")
//                {
//                    frmDegreeTitle degreeTitle = new frmDegreeTitle();
//                    degreeTitle.Owner = this;
//                    degreeTitle.txtMainUserName = txtMainUserName;
//                    degreeTitle.ShowDialog();
//                }
//                if (selected == "Institute")
//                {
//                    frmInstitute instituteMaster = new frmInstitute();
//                    instituteMaster.Owner = this;
//                    instituteMaster.txtMainUserName = txtMainUserName;
//                    instituteMaster.ShowDialog();
//                }
//                if (selected == "Complain")
//                {
//                    frmDisciplinaryComplain complainMaster = new frmDisciplinaryComplain();
//                    complainMaster.Owner = this;
//                    complainMaster.txtMainUserName = txtMainUserName;
//                    complainMaster.ShowDialog();
//                }
//                if (selected == "Punishment")
//                {
//                    frmDisciplinaryPunishment punishmentMaster = new frmDisciplinaryPunishment();
//                    punishmentMaster.Owner = this;
//                    punishmentMaster.txtMainUserName = txtMainUserName;
//                    punishmentMaster.ShowDialog();
//                }
//                //***************End Child Basic setup******************************

//                if (selected == "Employee Information") //Parent Emp info
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Employees", 7);
//                }
//                //***********Child Emp Info**********************
//                if (selected == "Employees")
//                {
//                    frmEmployeeInformationMasterSetup employeeInformationMaster =
//                        new frmEmployeeInformationMasterSetup();
//                    employeeInformationMaster.Owner = this;
//                    employeeInformationMaster.txtMainUserName = txtMainUserName;
//                    employeeInformationMaster.ShowDialog();
//                }
//                //************End Emp info **********************

//                if (selected == "Disciplinary Management") // Parent Dis. Management
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Disciplinary Transaction", 5);
//                }
//                //****Child Dis. Management************
//                if (selected == "Disciplinary Transaction")
//                {
//                    frmDisciplinaryActionTaken ActionTaken = new frmDisciplinaryActionTaken();
//                    ActionTaken.Owner = this;
//                    ActionTaken.ShowDialog();
//                }
//                //************End Dis. Management **********************

//                if (selected == "Organization Details") // Parent Org. Details
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Organization Detail", 8);
//                }

//                //********* Child Org. details
//                if (selected == "Organization Detail")
//                {
//                    frmCompanyProfile CompanyProfile = new frmCompanyProfile();
//                    CompanyProfile.Owner = this;
//                    CompanyProfile.txtMainUserName = txtMainUserName;
//                    CompanyProfile.ShowDialog();
//                }
//                if (selected == "Organization Hierarchy") // Parent Org. Hierarchy
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Division", 4);
//                    listView1.Items.Add("Department", 4);
//                    listView1.Items.Add("Sub-Department", 4);
//                    listView1.Items.Add("Section", 4);
//                }
//                //*******Child Org. Hierarchy **********
//                if (selected == "Division")
//                {
//                    frmDivision DivisionMaster = new frmDivision();
//                    DivisionMaster.Owner = this;
//                    DivisionMaster.txtMainUserName = txtMainUserName;
//                    DivisionMaster.ShowDialog();
//                }
//                if (selected == "Department")
//                {
//                    frmDepartment DepartmentMaster = new frmDepartment();
//                    DepartmentMaster.Owner = this;
//                    DepartmentMaster.txtMainUserName = txtMainUserName;
//                    DepartmentMaster.ShowDialog();
//                }
//                if (selected == "Sub-Department")
//                {
//                    frmSubDepartment SubDepartmentMaster = new frmSubDepartment();
//                    SubDepartmentMaster.Owner = this;
//                    SubDepartmentMaster.txtMainUserName = txtMainUserName;
//                    SubDepartmentMaster.ShowDialog();
//                }
//                if (selected == "Section")
//                {
//                    frmBrand SectionMaster = new frmBrand();
//                    SectionMaster.Owner = this;
//                    SectionMaster.txtMainUserName = txtMainUserName;
//                    SectionMaster.ShowDialog();
//                }
//                //***********End Org. Hierarchy setup******************

//                if (selected == "Locations") // parent Locations
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Location", 4);
//                }
//                //**********Child Location Setup*************
//                if (selected == "Location")
//                {
//                    frmLocation locationMaster = new frmLocation();
//                    locationMaster.Owner = this;
//                    locationMaster.txtMainUserName = txtMainUserName;
//                    locationMaster.ShowDialog();
//                }
//                //*******End Child Location******************

//                if (selected == "Holiday Master") // Parent  Holiday setup
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Weekend", 9);
//                    listView1.Items.Add("Holiday", 9);
//                }
//                // *****Child Holiday Setup**************
//                if (selected == "Weekend")
//                {
//                    frmWeeklyHolidayMaster weeklyHolidayMaster = new frmWeeklyHolidayMaster();
//                    weeklyHolidayMaster.Owner = this;

//                    weeklyHolidayMaster.ShowDialog();
//                }
//                if (selected == "Holiday")
//                {
//                    frmYearlyHolidaySetup yearlyHolidayMaster = new frmYearlyHolidaySetup();
//                    yearlyHolidayMaster.Owner = this;
//                    yearlyHolidayMaster.txtMainUserName = txtMainUserName;
//                    yearlyHolidayMaster.ShowDialog();
//                }
//                //******End Child Holiday******************

//                if (selected == "Bank Service") // Parent Bank Service
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Bank Setup", 3);
//                    listView1.Items.Add("Bank Transactions", 3);
//                }
//                if (selected == "Bank Setup") // Parent Bank Setup
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Banks", 4);
//                    listView1.Items.Add("Branches", 4);
//                }
//                //*****child Bank Setup*******************
//                if (selected == "Banks")
//                {
//                    frmBankSetup bankMaster = new frmBankSetup();
//                    bankMaster.Owner = this;
//                    bankMaster.txtMainUserName = txtMainUserName;
//                    bankMaster.ShowDialog();
//                }
//                if (selected == "Branches")
//                {
//                    frmBankBranch bankBranch = new frmBankBranch();
//                    bankBranch.Owner = this;
//                    bankBranch.txtMainUserName = txtMainUserName;
//                    bankBranch.ShowDialog();
//                }
//                //***********End Child Bank Setup********************

//                if (selected == "Bank Transactions") //Parent bank trans.
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Assign Salary Bank Account", 5);
//                    listView1.Items.Add("Salary Bank Account", 5);
//                    listView1.Items.Add("Assign OPI Bank Account", 5);
//                }
//                //****************Child Bank Trans. *******************
//                if (selected == "Assign Salary Bank Account")
//                {
//                    frmBankAccountAssignSalary BankAssignSalary = new frmBankAccountAssignSalary();
//                    BankAssignSalary.Owner = this;
//                    BankAssignSalary.txtMainUserName = txtMainUserName;
//                    BankAssignSalary.ShowDialog();
//                }
//                if (selected == "Salary Bank Account")
//                {
//                    frmSalaryBankAccount salaryBankAccount = new frmSalaryBankAccount();
//                    salaryBankAccount.Owner = this;
//                    salaryBankAccount.txtMainUserName = txtMainUserName;
//                    salaryBankAccount.ShowDialog();
//                }
//                if (selected == "Assign OPI Bank Account")
//                {
//                    frmBankAccountAssignOPI BankAssignOPI = new frmBankAccountAssignOPI();
//                    BankAssignOPI.Owner = this;
//                    BankAssignOPI.txtMainUserName = txtMainUserName;
//                    BankAssignOPI.ShowDialog();
//                }
//                //*************End Bank Trans.*****************************
//                if (selected == "Loans & Advances") // Parent Loans & Advances
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Loan Setup", 3);
//                    listView1.Items.Add("Loan Transaction", 3);
//                }
//                if (selected == "Loan Setup") // Parent Loan Setup
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Loan Type", 4);
//                    listView1.Items.Add("Loan Category", 4);
//                }
//                //*********child Loan type******************8
//                if (selected == "Loan Type")
//                {
//                    frmLoanTypeSetup loanTypeMaster = new frmLoanTypeSetup();
//                    loanTypeMaster.Owner = this;
//                    loanTypeMaster.txtMainUserName = txtMainUserName;
//                    loanTypeMaster.ShowDialog();
//                }
//                if (selected == "Loan Category")
//                {
//                    frmLoanCategorySetup loanCategoryMaster = new frmLoanCategorySetup();
//                    loanCategoryMaster.Owner = this;
//                    loanCategoryMaster.txtMainUserName = txtMainUserName;
//                    loanCategoryMaster.ShowDialog();
//                }
//                //****End Child loan setup************
//                if (selected == "Loan Transaction") // Parent Loan trans.
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Loan Entry Batch List", 5);
//                    listView1.Items.Add("Loan Adjustment Batch List", 5);
//                }
//                //**********child Loan trans.************************
//                if (selected == "Loan Entry Batch List")
//                {
//                    frmLoanScheduleMaster loanScheduleMaster = new frmLoanScheduleMaster();
//                    loanScheduleMaster.Owner = this;
//                    loanScheduleMaster.txtMainUserName = txtMainUserName;
//                    loanScheduleMaster.ShowDialog();
//                }
//                if (selected == "Loan Adjustment Batch List")
//                {
//                    frmLoanScheduleAdjustmentBatchList loanScheduleAdjustment = new frmLoanScheduleAdjustmentBatchList();
//                    loanScheduleAdjustment.Owner = this;
//                    loanScheduleAdjustment.txtMainUserName = txtMainUserName;
//                    loanScheduleAdjustment.ShowDialog();
//                }
//                //***********End Child loan trans.**************

//                if (selected == "Monthly Salary Process") //Parent Monthly Salary Process
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Salary Setup", 3);
//                    listView1.Items.Add("Salary Periodic Process", 3);
//                    listView1.Items.Add("Salary Transaction", 3);
//                }
//                if (selected == "Salary Setup") //Parent salary setup
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Earning Deduction", 4);
//                    listView1.Items.Add("Grade", 4);
//                    listView1.Items.Add("Slab", 4);
//                }
//                //*******Child Salary Setup********************
//                if (selected == "Earning Deduction")
//                {
//                    frmEarningDeductionMaster EarningDeductionMaster = new frmEarningDeductionMaster();
//                    EarningDeductionMaster.Owner = this;
//                    EarningDeductionMaster.txtMainUserName = txtMainUserName;
//                    EarningDeductionMaster.ShowDialog();
//                }
//                if (selected == "Grade")
//                {
//                    frmEarningDeductionGradeSetupMaster gradeSetupMaster = new frmEarningDeductionGradeSetupMaster();
//                    gradeSetupMaster.Owner = this;
//                    gradeSetupMaster.txtMainUserName = txtMainUserName;
//                    gradeSetupMaster.ShowDialog();
//                }
//                if (selected == "Slab")
//                {
//                    frmSlabSetupManually slabSetupManually = new frmSlabSetupManually();
//                    slabSetupManually.Owner = this;
//                    slabSetupManually.txtMainUserName = txtMainUserName;
//                    slabSetupManually.ShowDialog();
//                }
//                //******End Salary Setup*************************

//                if (selected == "Salary Periodic Process") //Parent Salary Periodic Process
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Assign Individual Salary", 5);
//                    listView1.Items.Add("Component Wise Salary Approval", 5);
//                    listView1.Items.Add("View Individual Salary", 5);
//                    listView1.Items.Add("Salary Month End", 11);
//                }
//                //****Child Salary Periodic Process*******************
//                if (selected == "Assign Individual Salary")
//                {
//                    frmEarningDeductionAssignIndividual
//                        EDbatchUploadIndividualAllowanceInfomation =
//                            new frmEarningDeductionAssignIndividual();
//                    EDbatchUploadIndividualAllowanceInfomation.Owner = this;
//                    EDbatchUploadIndividualAllowanceInfomation.txtMainUserName = txtMainUserName;
//                    EDbatchUploadIndividualAllowanceInfomation.ShowDialog();
//                }
//                if (selected == "Component Wise Salary Approval")
//                {
//                    frmEarningDeductionHeadWiseSalaryApproval approvalBatchUpload =
//                        new frmEarningDeductionHeadWiseSalaryApproval();
//                    approvalBatchUpload.Owner = this;
//                    approvalBatchUpload.txtMainUserName = txtMainUserName;
//                    approvalBatchUpload.ShowDialog();
//                }
//                if (selected == "View Individual Salary")
//                {
//                    frmEarningDeductionAppliedForView earningDeductionAppliedForView =
//                        new frmEarningDeductionAppliedForView();
//                    earningDeductionAppliedForView.Owner = this;
//                    earningDeductionAppliedForView.txtMainUserName = txtMainUserName;
//                    earningDeductionAppliedForView.ShowDialog();
//                }
//                if (selected == "Salary Month End")
//                {
//                    frmSalaryMonthEnd SalaryMonthEnd = new frmSalaryMonthEnd();
//                    SalaryMonthEnd.Owner = this;
//                    SalaryMonthEnd.txtMainUserName = txtMainUserName;
//                    SalaryMonthEnd.ShowDialog();
//                }
//                //******* End Salary Periodic Process********************
//                if (selected == "Salary Transaction") //Parent salary Transaction
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Deduction Entry", 5);
//                    listView1.Items.Add("Monthly Salary Calculation", 5);
//                    listView1.Items.Add("Edit Individual Employee", 5);
//                }
//                //***********Child Salary Transaction********************
//                if (selected == "Deduction Entry")
//                {
//                    frmDeductionEntryMaster deductionEntryMaster = new frmDeductionEntryMaster();
//                    deductionEntryMaster.Owner = this;
//                    deductionEntryMaster.txtMainUserName = txtMainUserName;
//                    deductionEntryMaster.ShowDialog();
//                }
//                if (selected == "Monthly Salary Calculation")
//                {
//                    frmSalaryCalculationBatchListMaster salaryCalculationBatchListMaster = new frmSalaryCalculationBatchListMaster();
//                    salaryCalculationBatchListMaster.Owner = this;
//                    salaryCalculationBatchListMaster.txtMainUserName = txtMainUserName;
//                    salaryCalculationBatchListMaster.ShowDialog();
//                }
//                if (selected == "Edit Individual Employee")
//                {
//                    frmEditIndividualEmployee editIndividualEmployee = new frmEditIndividualEmployee();
//                    editIndividualEmployee.Owner = this;
//                    editIndividualEmployee.ShowDialog();
//                }
//                //***********End Child Salary Transaction********************

//                if (selected == "Monthly Other Payment") // Parent Monthly Other Payment
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Other Payment Setup", 3);
//                    listView1.Items.Add("OP Periodic Processing", 3);
//                    listView1.Items.Add("OP Transaction", 3);
//                }
//                if (selected == "Other Payment Setup") // Parent Other Payment Setup
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("OP Item", 4);
//                    listView1.Items.Add("OP Grade", 4);
//                }
//                // ***********child Other Payment Setup**************
//                if (selected == "OP Item")
//                {
//                    frmOPIItemSetup opiItemMaster = new frmOPIItemSetup();
//                    opiItemMaster.Owner = this;
//                    opiItemMaster.txtMainUserName = txtMainUserName;
//                    opiItemMaster.ShowDialog();
//                }
//                if (selected == "OP Grade")
//                {
//                    frmOPIGradeMaster OPIGradeMaster = new frmOPIGradeMaster();
//                    OPIGradeMaster.Owner = this;
//                    OPIGradeMaster.txtMainUserName = txtMainUserName;
//                    OPIGradeMaster.ShowDialog();
//                }
//                //******End child Other Payment Setup**************
//                if (selected == "OP Periodic Processing") // Parent OP Periodic Processing
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Assign OP Item", 5);
//                    listView1.Items.Add("Component Wise OP Approval", 5);
//                    listView1.Items.Add("View Individual OP Item", 5);
//                }
//                //*********Child OP Periodic Processing*********************
//                if (selected == "Assign OP Item")
//                {
//                    frmOPAssignIndividual OPIbatchUploadIndividualAllowanceInfomation =
//                        new frmOPAssignIndividual();
//                    OPIbatchUploadIndividualAllowanceInfomation.Owner = this;
//                    OPIbatchUploadIndividualAllowanceInfomation.txtMainUserName = txtMainUserName;
//                    OPIbatchUploadIndividualAllowanceInfomation.ShowDialog();
//                }
//                if (selected == "Component Wise OP Approval")
//                {
//                    frmOPHeadWiseSalaryApproval opiHeadWiseSalaryApproval = new frmOPHeadWiseSalaryApproval();
//                    opiHeadWiseSalaryApproval.Owner = this;
//                    opiHeadWiseSalaryApproval.txtMainUserName = txtMainUserName;
//                    opiHeadWiseSalaryApproval.ShowDialog();
//                }
//                if (selected == "View Individual OP Item")
//                {
//                    frmOPViewAppliedToIndividual OPIViewIndividual = new frmOPViewAppliedToIndividual();
//                    OPIViewIndividual.Owner = this;
//                    OPIViewIndividual.txtMainUserName = txtMainUserName;
//                    OPIViewIndividual.ShowDialog();
//                }
//                //*********End Child OP Periodic Processing*********************
//                if (selected == "OP Transaction") // Parent OP Transaction
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Monthly OP CalCulation", 5);
//                }
//                if (selected == "Unauthorized Leave") // Parent Unauthorized Leave
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("U/L Setup", 3);
//                    listView1.Items.Add("U/L Transaction", 3);
//                }
//                if (selected == "U/L Setup") // Parent U/L Setup
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Unauthorized L/A Type", 4);
//                    listView1.Items.Add("Unauthorized L/A Setup", 4);
//                }
//                //**********Child U/L Setup********************
//                if (selected == "Unauthorized L/A Type")
//                {
//                    frmUnauthorizedLeaveTypeSetup unauthorizedLeaveTypeMaster = new frmUnauthorizedLeaveTypeSetup();
//                    unauthorizedLeaveTypeMaster.Owner = this;
//                    unauthorizedLeaveTypeMaster.txtMainUserName = txtMainUserName;
//                    unauthorizedLeaveTypeMaster.ShowDialog();
//                }
//                if (selected == "Unauthorized L/A Setup")
//                {
//                    frmUnauthorizedLeaveSetupMaster unauthorizedLeaveSetupMaster = new frmUnauthorizedLeaveSetupMaster();
//                    unauthorizedLeaveSetupMaster.Owner = this;
//                    unauthorizedLeaveSetupMaster.txtMainUserName = txtMainUserName;
//                    unauthorizedLeaveSetupMaster.ShowDialog();
//                }
//                //**********End Child U/L Setup********************
//                if (selected == "U/L Transaction") // Parent U/L Transaction
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("U/L Entry BatchList", 5);
//                }
//                //*********Child  U/L Transaction***************
//                if (selected == "U/L Entry BatchList")
//                {
//                    frmUnauthorizedMonthlyLeaveEntryMaster unauthorizedMonthlyLeaveSetupMaster =
//                        new frmUnauthorizedMonthlyLeaveEntryMaster();
//                    unauthorizedMonthlyLeaveSetupMaster.Owner = this;
//                    unauthorizedMonthlyLeaveSetupMaster.txtMainUserName = txtMainUserName;
//                    unauthorizedMonthlyLeaveSetupMaster.ShowDialog();
//                }
//                //*********End Child  U/L Transaction***************

//                if (selected == "Overtime") // Parent Overtime
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Overtime Setup", 3);
//                    listView1.Items.Add("Overtime Transaction", 3);
//                }
//                if (selected == "Overtime Setup") // Parent Overtime Setup
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Overtime Term", 4);
//                    listView1.Items.Add("Overtime Rate", 4);
//                }
//                //******Child Overtime Setup*****************
//                if (selected == "Overtime Term")
//                {
//                    frmOvertimeSetup overtimeMaster = new frmOvertimeSetup();
//                    overtimeMaster.Owner = this;
//                    overtimeMaster.txtMainUserName = txtMainUserName;
//                    overtimeMaster.ShowDialog();
//                }
//                if (selected == "Overtime Rate")
//                {
//                    frmOvertTimeTermPamameterMaster overtTimeTermPamameter = new frmOvertTimeTermPamameterMaster();
//                    overtTimeTermPamameter.Owner = this;
//                    overtTimeTermPamameter.txtMainUserName = txtMainUserName;
//                    overtTimeTermPamameter.ShowDialog();
//                }
//                //******End Child Overtime Setup*****************
//                if (selected == "Overtime Transaction") //Parent Overtime Transaction
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Overtime Entry BatchList", 5);
//                }
//                if (selected == "Overtime Entry BatchList")
//                {
//                    frmOverTimeMonthEntryMaster overTimeMonthEntry = new frmOverTimeMonthEntryMaster();
//                    overTimeMonthEntry.Owner = this;
//                    overTimeMonthEntry.txtMainUserName = txtMainUserName;
//                    overTimeMonthEntry.ShowDialog();
//                }
//                //********End Overtime Child**************************
//                if (selected == "Bonus") // Parent Bonus
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Bonus Setup", 3);
//                    listView1.Items.Add("Bonus Transaction", 3);
//                }
//                if (selected == "Bonus Setup") // Parent Bonus Setup
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Bonus Type", 4);
//                    listView1.Items.Add("Bonus Parameter", 4);
//                }
//                //************child Bonus Type*****************
//                if (selected == "Bonus Type")
//                {
//                    frmBonusType bonusType = new frmBonusType();
//                    bonusType.Owner = this;
//                    bonusType.txtMainUserName = txtMainUserName;
//                    bonusType.ShowDialog();
//                }
//                if (selected == "Bonus Parameter")
//                {
//                    frmBonusParameterMaster BonusParameterMaster = new frmBonusParameterMaster();
//                    BonusParameterMaster.Owner = this;
//                    BonusParameterMaster.ShowDialog();
//                }
//                //************End child Bonus Type*****************
//                if (selected == "Bonus Transaction") // Parent Bonus Transaction
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Bonus Entry Batch List", 5);
//                }
//                if (selected == "Bonus Entry Batch List")
//                {
//                    frmBonusSetupMaster bonusSetupMaster = new frmBonusSetupMaster();
//                    bonusSetupMaster.Owner = this;
//                    bonusSetupMaster.txtMainUserName = txtMainUserName;
//                    bonusSetupMaster.ShowDialog();
//                }
//                //******End Bonus Transaction********************
//                if (selected == "Long Term Benefit") // Parent Long Term Benefit
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Benefit Setup", 3);
//                    listView1.Items.Add("Benefit Transaction", 3);
//                }
//                if (selected == "Benefit Setup")
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("PF Membership", 4);
//                }
//                if (selected == "PF Membership")
//                {
//                    frmPFMembershipMaster pfMembershipMaster = new frmPFMembershipMaster();
//                    pfMembershipMaster.Owner = this;
//                    pfMembershipMaster.txtMainUserName = txtMainUserName;
//                    pfMembershipMaster.ShowDialog();
//                }
//                if (selected == "Benefit Transaction")
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Provident Fund Payment", 5);
//                    listView1.Items.Add("Gratuity", 5); // Form don't Create yet
//                }
//                if (selected == "Provident Fund Payment")
//                {
//                    frmPfmembershipWizardMaster pfPaymentWizard = new frmPfmembershipWizardMaster();
//                    pfPaymentWizard.Owner = this;
//                    pfPaymentWizard.txtMainUserName = txtMainUserName;
//                    pfPaymentWizard.ShowDialog();
//                }
//                if (selected == "Gratuity")
//                {
//                    MessageBox.Show("Gratuity don't Create yet");
//                    return;
//                }
//                //***************Income Tax*****************
//                if (selected == "Income Tax") //Parent Income tax
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("I/T Setup", 3);
//                    listView1.Items.Add("I/T Periodic Processing", 3);
//                    listView1.Items.Add("I/T Transaction", 3);
//                }
//                if (selected == "I/T Setup") //Parent Income Setup
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Tax Slab", 4);
//                    listView1.Items.Add("Tax Rules", 4);
//                    listView1.Items.Add("Minimum Tax", 4);
//                    listView1.Items.Add("Region Setup", 4);
//                    listView1.Items.Add("Investment Type", 4);
//                    listView1.Items.Add("New Year Setup", 6);
//                }
//                //************Child I/T Setup****************
//                if (selected == "Tax Slab")
//                {
//                    frmIncomeTaxParameterMaster incomeTaxMaster = new frmIncomeTaxParameterMaster();
//                    incomeTaxMaster.Owner = this;
//                    incomeTaxMaster.ShowDialog();
//                }

//                if (selected == "Tax Rules")
//                {
//                    frmIncomeTaxRulesMaster IncomeTaxRules = new frmIncomeTaxRulesMaster();
//                    IncomeTaxRules.Owner = this;
//                    IncomeTaxRules.ShowDialog();
//                }
//                if (selected == "Minimum Tax")
//                {
//                    frmIncomeTaxMinimumTaxMaster incomeTaxMinimumTaxMaster = new frmIncomeTaxMinimumTaxMaster();
//                    incomeTaxMinimumTaxMaster.Owner = this;
//                    incomeTaxMinimumTaxMaster.ShowDialog();
//                }
//                if (selected == "Region Setup")
//                {
//                    frmRegionSetup regionSetupMaster = new frmRegionSetup();
//                    regionSetupMaster.Owner = this;
//                    regionSetupMaster.ShowDialog();
//                }
//                if (selected == "Investment Type")
//                {
//                    frmIncometaxInvestmentTypeMaster incometaxInvestmentTypeMaster =
//                        new frmIncometaxInvestmentTypeMaster();
//                    incometaxInvestmentTypeMaster.Owner = this;
//                    incometaxInvestmentTypeMaster.ShowDialog();
//                }
//                if (selected == "New Year Setup")
//                {
//                    frmIncomeTaxNewYearSetup incomeTaxNewYearSetup = new frmIncomeTaxNewYearSetup();
//                    incomeTaxNewYearSetup.Owner = this;
//                    incomeTaxNewYearSetup.txtMainUserName = txtMainUserName;
//                    incomeTaxNewYearSetup.ShowDialog();
//                }
//                //************End Child I/T Setup****************
//                if (selected == "I/T Periodic Processing") //Parent I/T Periodic Processing
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Income Tax Year End", 6);
//                    listView1.Items.Add("Tax Reprocess", 5);
//                }
//                //*****Child I/T Periodic Processing*********************
//                if (selected == "Income Tax Year End")
//                {
//                    frmIncomeTaxYearEndMaster incomeTaxYearEnd = new frmIncomeTaxYearEndMaster();
//                    incomeTaxYearEnd.Owner = this;
//                    incomeTaxYearEnd.ShowDialog();
//                }
//                if (selected == "Tax Reprocess")
//                {
//                    frmIncomeTaxReprocess incomeTaxReprocess = new frmIncomeTaxReprocess();
//                    incomeTaxReprocess.Owner = this;
//                    incomeTaxReprocess.ShowDialog();
//                }
//                //*****End Child I/T Periodic Processing*********************

//                if (selected == "I/T Transaction") //Parent I/T Transaction
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Deposit Employee Tax Amount", 5);
//                    listView1.Items.Add("Tax Adjustment", 5);
//                }
//                if (selected == "Deposit Employee Tax Amount")
//                {
//                    frmIncomeTaxDepositMaster IncomeTaxDepositMaster = new frmIncomeTaxDepositMaster();
//                    IncomeTaxDepositMaster.Owner = this;
//                    IncomeTaxDepositMaster.ShowDialog();
//                }
//                if (selected == "Tax Adjustment")
//                {
//                    frmTaxAdjustmentManualMaster taxAdjustmentManualMaster = new frmTaxAdjustmentManualMaster();
//                    taxAdjustmentManualMaster.Owner = this;
//                    taxAdjustmentManualMaster.ShowDialog();
//                }
//                //*****End I/T Transaction*********************
//                //if (selected == "Final Settlement") // Parent final Settlement
//                //{
//                //    listView1.Items.Clear();

//                //    listView1.Items.Add("Define Final Settlement Head", 4);
//                //    listView1.Items.Add("Exit Information", 4);
//                //    listView1.Items.Add("Final Settlement Setup", 4);
//                //    listView1.Items.Add("Exit Hault Information", 4);
//                //}
//                ////********Child Final Settlement***************************
//                //if (selected == "Define Final Settlement Head")
//                //{
//                //    frmFinalSettlementHeadsMaster finalSettlementHeadsMaster = new frmFinalSettlementHeadsMaster();
//                //    finalSettlementHeadsMaster.Owner = this;
//                //    finalSettlementHeadsMaster.ShowDialog();
//                //}
//                //if (selected == "Exit Information")
//                //{
//                //    frmFinalSettlementResignMaster FinalSettlementResignMaster = new frmFinalSettlementResignMaster();
//                //    FinalSettlementResignMaster.Owner = this;
//                //    FinalSettlementResignMaster.txtMainUserName = txtMainUserName;
//                //    FinalSettlementResignMaster.ShowDialog();
//                //}
//                //if (selected == "Final Settlement Setup")
//                //{
//                //    frmFinalSettleMentSettingMaster finalSettleMentSettingMaster = new frmFinalSettleMentSettingMaster();
//                //    finalSettleMentSettingMaster.Owner = this;
//                //    finalSettleMentSettingMaster.ShowDialog();
//                //}
//                //if (selected == "Exit Hault Information")
//                //{
//                //    frmFinalSettlementResignHaultMaster FinalSettlementResignHaultMaster =
//                //        new frmFinalSettlementResignHaultMaster();
//                //    FinalSettlementResignHaultMaster.Owner = this;
//                //    FinalSettlementResignHaultMaster.txtMainUserName = txtMainUserName;
//                //    FinalSettlementResignHaultMaster.ShowDialog();
//                //}
//                ////********End Child Final Settlement***************************
//                if (selected == "Final Settlement")
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("F/S Setup", 3);
//                    listView1.Items.Add("F/S Transaction", 3);
//                }
//                if (selected == "F/S Setup")
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Define Final Settlement Head", 4);
//                    //listView1.Items.Add("Define Final Settlement Head", 4);
//                    //listView1.Items.Add("Exit Information", 4);
//                    //listView1.Items.Add("Final Settlement Setup", 4);
//                    //listView1.Items.Add("Exit Hault Information", 4);
//                }
//                //********Child F/S Setup***************************
//                if (selected == "Define Final Settlement Head")
//                {
//                    frmFinalSettlementHeadsMaster finalSettlementHeadsMaster = new frmFinalSettlementHeadsMaster();
//                    finalSettlementHeadsMaster.Owner = this;
//                    finalSettlementHeadsMaster.ShowDialog();
//                }
//                if (selected == "F/S Transaction")   //Parent F/S Transaction 
//                {
//                    listView1.Items.Clear();
//                    listView1.Items.Add("Exit Entry", 5);
//                    listView1.Items.Add("Exit Hault Entry", 5);
//                    listView1.Items.Add("Exit Transaction Entry", 5);
//                }
//                //*********CHild F/S Transaction***************************
//                if (selected == "Exit Entry")
//                {
//                    frmFinalSettlementResignMaster FinalSettlementResignMaster = new frmFinalSettlementResignMaster();
//                    FinalSettlementResignMaster.Owner = this;
//                    FinalSettlementResignMaster.txtMainUserName = txtMainUserName;
//                    FinalSettlementResignMaster.ShowDialog();
//                }
//                if (selected == "Exit Hault Entry")
//                {
//                    frmFinalSettlementResignHaultMaster FinalSettlementResignHaultMaster = new frmFinalSettlementResignHaultMaster();
//                    FinalSettlementResignHaultMaster.Owner = this;
//                    FinalSettlementResignHaultMaster.txtMainUserName = txtMainUserName;
//                    FinalSettlementResignHaultMaster.ShowDialog();
//                }
//                if (selected == "Exit Transaction Entry")
//                {
//                    frmFinalSettleMentSettingMaster finalSettleMentSettingMaster = new frmFinalSettleMentSettingMaster();
//                    finalSettleMentSettingMaster.Owner = this;
//                    finalSettleMentSettingMaster.ShowDialog();
//                }
//                //********End Child Final Settlement***************************
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }
//    }
//}
