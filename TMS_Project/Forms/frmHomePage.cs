using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Speech.Recognition;
using System.Speech.Synthesis;



namespace TMS_Project
{
    public partial class frmHomepage : Form
    {
        SQL sq = new SQL();
        string nodeText;
        string treelevel;
        
        public frmHomepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode tNode;
            tNode = treeView1.Nodes.Add("Saif Tea Estate");  // Adding Item to First Node
           // imageList1.ImageSize = new Size(50, 50);
            treeView1.ImageList = TreeNodeImages;



            DataTable dtroottree = sq.get_rs("Select distinct ModuleName as RootItem  FROM [SAIF].[dbo].[ASPROGRAM]", "SAIF", "10.168.2.244");

            for(int i=0; i<= dtroottree.Rows.Count-1; i++)     // Loop for Assigning Parent Node
            {

                treeView1.Nodes[0].Nodes.Add(dtroottree.Rows[i]["RootItem"].ToString());   //Adding Item to Second Node


                //treeView1.SelectedNode.ImageIndex = 0;
                


                DataTable dtchildtree = sq.get_rs("Select distinct [SubModuleName] as Childitem  FROM [SAIF].[dbo].[ASPROGRAM] where modulename = '"+ dtroottree.Rows[i]["RootItem"].ToString() + "'", "SAIF", "10.168.2.244");   // Query to find out Child item inside the parent

                        for(int j = 0; j<= dtchildtree.Rows.Count-1;j++)       // Loop for Assignig child item to parent item
                        {
                            treeView1.Nodes[0].Nodes[i].Nodes.Add(dtchildtree.Rows[j]["Childitem"].ToString());   // Adding Item to Third Node
                        }

            }         
                       
        }

     
       

        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

           
            SpeechSynthesizer JARVIS = new SpeechSynthesizer();

            nodeText = treeView1.SelectedNode.ToString();

            nodeText = nodeText.Replace("TreeNode:", "");

            

            //switch (nodeText.Trim())
            //{
            //    case "Administrative Services":
            //        JARVIS.Speak(nodeText);
            //        break;
            //    default:
            //        JARVIS.Speak(nodeText);
            //        break;
                    
            //}


         //   MessageBox.Show(treeView1.SelectedNode.Nodes.Count.ToString());

            if(treeView1.SelectedNode.Nodes.Count!=0 && treeView1.SelectedNode.Parent != null)
            {
                
                treelevel = "Modules";

            }
            else if(treeView1.SelectedNode.Nodes.Count == 0 && treeView1.SelectedNode.Parent != null)
            {
                
                treelevel = "Submodules";
            }
            else if (treeView1.SelectedNode.Nodes.Count != 0 && treeView1.SelectedNode.Parent == null)
            {
             
                treelevel = "Root";
            }




             listviewloaditems(nodeText, treelevel);


        }

        public void listviewloaditems(string nodeText, string treelevel)
        {
            listView1.Clear();
            listView1.LargeImageList = TreeNodeImages;
            



            DataTable dtlistviewitem = new DataTable();

            if (treelevel == "Modules")
            {
                dtlistviewitem = sq.get_rs("Select distinct [SubModuleName] as Childitem  FROM [SAIF].[dbo].[ASPROGRAM] where modulename = '" + nodeText.Trim() + "' ", "SAIF", "10.168.2.244");
            }
            else if(treelevel == "Submodules")
            {
                dtlistviewitem = sq.get_rs("Select [Programname] as Childitem  FROM [SAIF].[dbo].[ASPROGRAM] where submodulename = '" + nodeText.Trim() + "' order by vieworder", "SAIF", "10.168.2.244");
            }
                        
        
            for(int i=0;i<=dtlistviewitem.Rows.Count-1;i++)
            {

                ListViewItem LVI = new ListViewItem(dtlistviewitem.Rows[i]["Childitem"].ToString(),2);

                      
                listView1.Items.Add(LVI);


            }
            
        }

     

        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

  
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                string Itemselected = listView1.SelectedItems[0].SubItems[0].Text;

                callform(Itemselected);



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void callform(string Itemselected)
        {

            switch (Itemselected.Trim())
            {

                case "Database Backup":
                    frmDatabaseBackup frmDatabaseBackup = new frmDatabaseBackup() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDatabaseBackup.ShowDialog();
                    break;

                case "Users":
                    frmUser frmUser = new frmUser() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmUser.ShowDialog();
                    break;

                case "Security Group":
                    frmSecurityGroup frmSecurityGroup = new frmSecurityGroup() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmSecurityGroup.ShowDialog();
                    break;

                case "User Authorization":
                    frmUserAuthorization frmUserAuthorization = new frmUserAuthorization() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmUserAuthorization.ShowDialog();
                    break;

                case "Checking Transaction Status":
                    frmcheckingstatus frmcheckingstatus = new frmcheckingstatus() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmcheckingstatus.ShowDialog();
                    break;

                case "Company Profile":
                    frmCompanyInformation frmCompanyInformation = new frmCompanyInformation() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmCompanyInformation.ShowDialog();
                    break;

                case "Fiscal Calender":
                    frmFiscalCalendar frmFiscalCalendar = new frmFiscalCalendar() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmFiscalCalendar.ShowDialog();
                    break;

                case "Add Inns Manager":
                    frmAddInnManager frmAddInnManager = new frmAddInnManager() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmAddInnManager.ShowDialog();
                    break;

                case "Employees":
                    frmWorkerDetails frmWorkerDetails = new frmWorkerDetails() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWorkerDetails.ShowDialog();
                    break;

                case "Employees Information":
                     frmWorkerInformation frmWorkerInformation = new frmWorkerInformation() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWorkerInformation.ShowDialog();
                    break;

                case "Holiday Calender":
                    frmHolidayCalender frmHolidayCalender = new frmHolidayCalender() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmHolidayCalender.ShowDialog();
                    break;

                case "Pay Accounts":
                     frmPaymentSetup frmPaymentSetup = new frmPaymentSetup() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmPaymentSetup.ShowDialog();
                    break;

                case "Leave Process":
                    frmLeave frmLeave = new frmLeave() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmLeave.ShowDialog();
                    break;

                case "Leave Statement":
                    frmDailyLeaveStatement frmDailyLeaveStatement = new frmDailyLeaveStatement() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyLeaveStatement.ShowDialog();
                    break;

                case "Leave Analysis Report":
                    frmDailyLeaveAnalysis frmDailyLeaveAnalysis = new frmDailyLeaveAnalysis() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyLeaveAnalysis.ShowDialog();
                    break;

                case "Worker Leave Status":
                    frmWorkerLeaveStatus frmWorkerLeaveStatus = new frmWorkerLeaveStatus() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWorkerLeaveStatus.ShowDialog();
                    break;

                case "Absence List":
                    frmAbsentList frmAbsentList = new frmAbsentList() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmAbsentList.ShowDialog();
                    break;

                case "Daily Absent List":
                    frmDailyAbsentList frmDailyAbsentList = new frmDailyAbsentList() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyAbsentList.ShowDialog();
                    break;


                case "Weekly Holiday Pay Generator":
                    frmWeeklyHolidayPayGenerator frmWeeklyHolidayPayGenerator = new frmWeeklyHolidayPayGenerator() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyHolidayPayGenerator.ShowDialog();
                    break;

                case "Utility Deduction":
                    frmWeeklyUtilityDeduction frmWeeklyUtilityDeduction = new frmWeeklyUtilityDeduction() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyUtilityDeduction.ShowDialog();
                    break;

                case "Holiday Pay Generator":
                    frmHolidayPayGenerator frmHolidayPayGenerator = new frmHolidayPayGenerator() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmHolidayPayGenerator.ShowDialog();
                    break;

                case "Weekly Pay Manager":
                    frmWeeklyPayManager frmWeeklyPayManager = new frmWeeklyPayManager() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyPayManager.ShowDialog();
                    break;

                case "Weekly Pay Statement":
                    frmWeeklyPayment frmWeeklyPayment = new frmWeeklyPayment() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyPayment.ShowDialog();
                    break;

                case "Trusty Deduction":
                    frmTrustyDeduction frmTrustyDeduction = new frmTrustyDeduction() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmTrustyDeduction.ShowDialog();
                    break;

                case "Special Puja Calculation":
                    frmSpecialPujaCalculation frmSpecialPujaCalculation = new frmSpecialPujaCalculation() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmSpecialPujaCalculation.ShowDialog();
                    break;                    

                case "Monthly PF Report":
                    frmMonthlyPF frmMonthlyPF = new frmMonthlyPF() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmMonthlyPF.ShowDialog();
                    break;

                case "Day End Processing":
                    frmDayEndProcess frmDayEndProcess = new frmDayEndProcess() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDayEndProcess.ShowDialog();
                    break;

                case "MIS Processing":
                    frmMisProcess frmMisProcess = new frmMisProcess() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmMisProcess.ShowDialog();
                    break;

                case "Regular Ration Calculation":
                    frmWeeklyRationProcess frmWeeklyRationProcess = new frmWeeklyRationProcess() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyRationProcess.ShowDialog();
                    break;

                case "Special Ration Calculation":
                    frmSpecialRationCalculation frmSpecialRationCalculation = new frmSpecialRationCalculation() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmSpecialRationCalculation.ShowDialog();
                    break;

                case "Ration Statement":
                    frmWeeklyRation frmWeeklyRation = new frmWeeklyRation() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyRation.ShowDialog();
                    break;

               


                case "Section":
                    frmSection frmSection = new frmSection() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmSection.ShowDialog();
                    break;

                case "Sirder":
                    frmSirder frmSirder = new frmSirder() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmSirder.ShowDialog();
                    break;

                case "Field Work Category":
                    frmFieldWorkCategory frmFieldWorkCategory = new frmFieldWorkCategory() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmFieldWorkCategory.ShowDialog();

                    break;

                case "Group Category":
                    frmGroupCategory frmGroupCategory = new frmGroupCategory() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmGroupCategory.ShowDialog(); 
               
                    break;

                  
                case "Babu":
                    frmbabu frmbabu = new frmbabu() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmbabu.ShowDialog();
                    break;

                case "Field Jakor":
                    frmFieldJakor frmFieldJakor = new frmFieldJakor() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmFieldJakor.ShowDialog();
                    break;

                case "Plucking Jakor":
                    frmPluckingJakor frmPluckingJakor = new frmPluckingJakor() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmPluckingJakor.ShowDialog();
                    break;
                case "Weather":
                    frmWeather frmWeather = new frmWeather() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeather.ShowDialog();
                    break;

                case "Category":
                    Category Category = new Category() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    Category.ShowDialog();
                    break;

                case "Daily Field Report":
                    frmDailyFieldReport frmDailyFieldReport = new frmDailyFieldReport() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyFieldReport.ShowDialog();
                    break;

                case "Weekly Field Report":
                    frmWeeklyFieldReport frmWeeklyFieldReport = new frmWeeklyFieldReport() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyFieldReport.ShowDialog();
                    break;

                case "Field Analysis Report":
                    frmDailyFieldAnalysis frmDailyFieldAnalysis = new frmDailyFieldAnalysis() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyFieldAnalysis.ShowDialog();
                    break;

                case "Field Analysis Report Cash":
                    frmDailyFieldAnalysisCash frmDailyFieldAnalysisCash = new frmDailyFieldAnalysisCash() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyFieldAnalysisCash.ShowDialog();
                    break;

                case "Katcha Report":
                    frmKatchaReport frmKatchaReport = new frmKatchaReport() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmKatchaReport.ShowDialog();
                    break;



                case "Factory Work Category":
                    frmFactoryyWorkCategory frmFactoryyWorkCategory = new frmFactoryyWorkCategory() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmFactoryyWorkCategory.ShowDialog();
                    break;

                case "Factory Jakor":
                    frmFactoryJakor frmFactoryJakor = new frmFactoryJakor() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmFactoryJakor.ShowDialog();
                    break;


                case "Factory Processing Register":
                    frmFactoryProcessing frmFactoryProcessing = new frmFactoryProcessing() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmFactoryProcessing.ShowDialog();
                    break;
                          

                case "Factory Utility Register":
                    frmFactoryUtilityRegister frmFactoryUtilityRegister = new frmFactoryUtilityRegister() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmFactoryUtilityRegister.ShowDialog();
                    break;

                case "Factory Running Register":
                    frmFactoryRunningRegister frmFactoryRunningRegister = new frmFactoryRunningRegister() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmFactoryRunningRegister.ShowDialog();
                    break;

                case "Weekly Factory Report":
                    frmWeeklyFactoryReport frmWeeklyFactoryReport = new frmWeeklyFactoryReport() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyFactoryReport.ShowDialog();
                    break;

                case "Daily Factory Report":
                    frmDailyFactoryReport frmDailyFactoryReport = new frmDailyFactoryReport() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyFactoryReport.ShowDialog();
                    break;

                case "Factory Analysis Report":
                    frmDailyfactoryAnalysis frmDailyfactoryAnalysis = new frmDailyfactoryAnalysis() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyfactoryAnalysis.ShowDialog();
                    break;

                case "Factory Analysis Report Cash":
                    frmDailyFactoryAnalysisCash frmDailyFactoryAnalysisCash = new frmDailyFactoryAnalysisCash() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyFactoryAnalysisCash.ShowDialog();
                    break;





                case "Rubber Work Category":
                    frmRubberWorkCategory frmRubberWorkCategory = new frmRubberWorkCategory() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmRubberWorkCategory.ShowDialog();
                    break;

                case "Rubber Jakor":
                    frmRubberJakor frmRubberJakor = new frmRubberJakor() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmRubberJakor.ShowDialog();
                    break;

                case "Latex To RSS":
                    frmLatexToRss frmLatexToRss = new frmLatexToRss() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmLatexToRss.ShowDialog();
                    break;

                case "Daily Rubber Report":
                    frmDailyRubberReport frmDailyRubberReport = new frmDailyRubberReport() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyRubberReport.ShowDialog();
                    break;

                case "Weekly Rubber Report":
                    frmWeeklyRubberReport frmWeeklyRubberReport = new frmWeeklyRubberReport() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyRubberReport.ShowDialog();
                    break;

                case "Rubber Analysis Report Cash":
                    frmRubberDailyAnalysisCashReport frmRubberDailyAnalysisCashReport = new frmRubberDailyAnalysisCashReport() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmRubberDailyAnalysisCashReport.ShowDialog();
                    break;
                case "Rubber Analysis Report":
                    frmDailyLeaveAnalysisReport frmRubberDailyAnalysisReport1 = new frmDailyLeaveAnalysisReport() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmRubberDailyAnalysisReport1.ShowDialog();
                    break;

                case "Item":
                    frmNurseryItem frmNurseryItem = new frmNurseryItem() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmNurseryItem.ShowDialog();
                    break;

                case "Location":
                    frmNurseryLocation frmNurseryLocation = new frmNurseryLocation() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmNurseryLocation.ShowDialog();
                    break;

                case "Planting Type":
                    frmPlantingType frmPlantingType = new frmPlantingType() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmPlantingType.ShowDialog();
                    break;

                case "Inventory Activities":
                    frmDailyInventoryTransaction frmDailyInventoryTransaction = new frmDailyInventoryTransaction() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmDailyInventoryTransaction.ShowDialog();
                    break;

                case "Weekly Planting History":
                    frmWeeklyPlantationHistory frmWeeklyPlantationHistory = new frmWeeklyPlantationHistory() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyPlantationHistory.ShowDialog();
                    break;

                

                case "Nursery Information":
                    frmWeeklyNurseryInformation frmWeeklyNurseryInformation = new frmWeeklyNurseryInformation() { Owner = this, StartPosition = FormStartPosition.CenterScreen, MaximizeBox = false };
                    frmWeeklyNurseryInformation.ShowDialog();
                    break;
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
