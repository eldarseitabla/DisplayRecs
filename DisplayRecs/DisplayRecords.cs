using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DisplayRecs
{
    public partial class DisplayRecords : Form
    {
        public DisplayRecords()
        {
            InitializeComponent();
        }

        private void DisplayRecords_Load(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Directory.GetParent(baseDirectory).Parent.Parent.Parent.FullName;
            string directory = projectRoot;
            ///string directory = @"C:\Users\User\source\repos\DisplayRecs";
            string fileName = @"\ManagementRecs.txt";
            string managementRecs = directory + fileName;
            string[] managementRecsRecordsFromFile;
            try
            {
                managementRecsRecordsFromFile = Helper.ReadFileIntoArray(managementRecs);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error #1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            List<string> listOfRecords = Helper.ConvertArrayToList(managementRecsRecordsFromFile);

            dataGridViewAllRecords.Columns.Add("Manager_Number", "Manager Number");
            dataGridViewAllRecords.Columns.Add("Manager_Forename", "Manager Forename");
            dataGridViewAllRecords.Columns.Add("Manager_Surname", "Manager Surname");
            dataGridViewAllRecords.Columns.Add("Dept_Number", "Dept Number");

            foreach (string aRowInList in listOfRecords)
            {
                string[] individualFields = aRowInList.Split(';');
                dataGridViewAllRecords.Rows.Add(individualFields);
            }

            labelFeedback.Text = listOfRecords[0].ToString();
        }
    }
}
