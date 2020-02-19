using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchScreen
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        private void searchHospBtn_Click(object sender, EventArgs e)
        {
            //Killians code to dump data into list

            List<Info> infos = new List<Info>();

            string userInput = txtSearch.Text;

            List<Info> infoWanted = infos.Where(i => i.Hospital.Contains(userInput));

            if (infoWanted[0] == null)
            {
                MessageBox.Show("Hospital not found", "Hospital not found");
            }
            else
            {
                MessageBox.Show("Hospital Name: " + infoWanted[0].Hospital +
                                "\nHospital Code: " + infoWanted[0].Code +
                                "\nTotal Beds: " + infoWanted[0].Total +
                                "\nGeneral and Acute Beds: " + infoWanted[0].GeneralandAcute +
                                "\nLearning Disabilities Beds: " + infoWanted[0].LearningDisabilities +
                                "\nMaternity Beds: " + infoWanted[0].Maternity +
                                "\nMental Illness Beds: " + infoWanted[0].MentalIllness
                                , "Hospital Info");
            }
        }
    }
}
