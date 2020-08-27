using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Windows.ApplicationModel.Activation;

namespace ConferencePlanner.WinUi
{
    public partial class AddConferance : Form
    {
        private readonly IConferanceCategory _getConferanceCategory;

        public int? ConferenceId { get; set; }

        public AddConferance(IConferanceCategory getConferanceCategory)
        {
            InitializeComponent();
            _getConferanceCategory=getConferanceCategory;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

          
            tabConferance.SelectedIndex = (tabConferance.SelectedIndex + 1 < tabConferance.TabCount) ?
                             tabConferance.SelectedIndex + 1 : tabConferance.SelectedIndex;

            if (tabConferance.SelectedTab == tabConferance.TabPages["tabType"])
            {
                button1.Text = "Save";
                btSaveAndNew.Visible = true;
            }


        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if (tabConferance.SelectedIndex != 0)
            {
                tabConferance.SelectedIndex = (tabConferance.SelectedIndex - 1 < tabConferance.TabCount) ?
                                 tabConferance.SelectedIndex - 1 : tabConferance.SelectedIndex;
            }
            
            if (tabConferance.SelectedTab == tabConferance.TabPages["tabCategory"])
            {
                button1.Text = "Next";
                btSaveAndNew.Visible = false;
            }

        }



        private void tabConferance_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabConferance_Validating(object sender, CancelEventArgs e)
        {
            
        }


       //  public static int currentSelectedTab;
        private void tabConferance_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //int selectedTab = tabConferance.SelectedIndex;
            //Disable the tab selection
            //if (currentSelectedTab != selectedTab)
            //{

            //    tabConferance.SelectTab(currentSelectedTab);
            //}
           


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1_CellClick////Check to ensure that the row CheckBox is clicked.
            //if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            //{
            //    //Loop and uncheck all other CheckBoxes.
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        if (row.Index == e.RowIndex)
            //        {
            //            row.Cells["Main"].Value = !Convert.ToBoolean(row.Cells["Main"].EditedFormattedValue);
            //        }
            //        else
            //        {
            //            row.Cells["Main"].Value = false;
            //        }
            //    }
            //}
        }

        private void AddConferance_Load(object sender, EventArgs e)
        {
            label1.Text = ConferenceId.ToString();
            // List<ConferanceCategory> conferenceCategory = _getConferanceCategory.GetConferencesCategory();

            //foreach (List<ConferanceCategory> conferance in conferenceCategory)
            //{
            //    CategoryName.Items.Add(conferance);
            //}

            DataGridViewButtonColumn buttonEditCountry = new DataGridViewButtonColumn();
            DGVCountry.Columns.Add(buttonEditCountry);
            buttonEditCountry.HeaderText = "Edit";
            buttonEditCountry.Name = "Edit";
            buttonEditCountry.Text = "Edit";
            buttonEditCountry.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttonEditDistrict = new DataGridViewButtonColumn();
            DGVDistrict.Columns.Add(buttonEditDistrict);
            buttonEditDistrict.HeaderText = "Edit";
            buttonEditDistrict.Name = "Edit";
            buttonEditDistrict.Text = "Edit";
            buttonEditDistrict.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttonEditCity = new DataGridViewButtonColumn();
            DGVCity.Columns.Add(buttonEditCity);
            buttonEditCity.HeaderText = "Edit";
            buttonEditCity.Name = "Edit";
            buttonEditCity.Text = "Edit";
            buttonEditCity.UseColumnTextForButtonValue = true;

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void NewCountry_Click(object sender, EventArgs e)
        {
            NewCountryForm fc = new NewCountryForm();
            fc.Show();
        }

        private void NewDistrict_Click(object sender, EventArgs e)
        {
            NewDistrictForm fd = new NewDistrictForm();
            fd.Show();
        }

        private void NewCity_Click(object sender, EventArgs e)
        {
            NewCityForm fcity = new NewCityForm();
            fcity.Show();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabSpeakerNextButton_Click(object sender, EventArgs e)
        {

        }

        private void tabSpeakerAddButton_Click(object sender, EventArgs e)
        {
            AddSpeakerForm fAddSpeaker = new AddSpeakerForm();
            fAddSpeaker.ShowDialog();
        }

        private void tabSpeakerPreviousButton_Click(object sender, EventArgs e)
        {

        }

        private void tabSpeakerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabSpeakerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

