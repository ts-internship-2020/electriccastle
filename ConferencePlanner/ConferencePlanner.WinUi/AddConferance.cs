using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows.ApplicationModel.Activation;
using Microsoft.Extensions.DependencyInjection;

namespace ConferencePlanner.WinUi
{
    public partial class AddConferance : Form
    {
        private readonly IConferanceCategory _getConferanceCategory;

        private readonly IConferenceCategoryRepository conferenceCategoryRepository;

        private List<ConferenceCategoryModel> conferenceCategories;

        private PaginationHelper<ConferenceCategoryModel> categoryTabPaginationHelper;

        private int categoryTabPageSize = 5;

        //tab Speaker
        private readonly ISpeakerRepository getSpeakerRepository;

        private List<SpeakerModel> getSpeakerList;

        private List<SpeakerModel> currentSpeakerGridPage;

        private int elementMainSpeakerId;

        public static SpeakerModel editedSpeaker;

        public static int maxIdSpeaker = 0;

        private int scrollValSpeaker;

        List<int> getSpeakerInConference;

        //

        public int? ConferenceId { get; set; }

        public AddConferance(IConferanceCategory getConferanceCategory,
                             IConferenceCategoryRepository conferenceCategoryRepository,
                             ISpeakerRepository getSpeakerRepository
                             )
        {
            InitializeComponent();
            _getConferanceCategory=getConferanceCategory;
            this.conferenceCategoryRepository = conferenceCategoryRepository;
            this.getSpeakerRepository = getSpeakerRepository;
            scrollValSpeaker = 0;
            elementMainSpeakerId = 0;
            getSpeakerInConference = new List<int>();
            conferenceCategories = conferenceCategoryRepository.getAllCategories();
            categoryTabPaginationHelper = new PaginationHelper<ConferenceCategoryModel>(conferenceCategories, categoryTabPageSize);
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
            getSpeakerList = getSpeakerRepository.GetSpeaker();
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker);
            getMaxId(getSpeakerList);
            List<SpeakerModel> getSpeakerInConference = new List<SpeakerModel>();

        }

        private void GenerateCategoryTabEditDeleteButtons()
        {
            //DataGridViewButtonColumn buttonEdit = new DataGridViewButtonColumn();
            //CategoryTabGrid.Columns.Add(buttonEdit);
            //buttonEdit.HeaderText = "Edit";
            //buttonEdit.Name = "Edit";
            //buttonEdit.Text = "Edit";
            //buttonEdit.UseColumnTextForButtonValue = true;

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

        // Start Tab Speaker functions
        void getMaxId(List<SpeakerModel> speakerList)
        {
            int i;
            int numberElements = speakerList.Count;
            for (i = 0; i < numberElements; i++)
            {
                SpeakerModel listElement = speakerList.ElementAt(i);
                if (listElement.Id > 0)
                {
                    maxIdSpeaker = listElement.Id;
                }

            }
        }
        void populateTabSpeakersGrid(List<SpeakerModel> speakerList, int scrollValue)
        {
            List<SpeakerModel> speakers = new List<SpeakerModel>();
           // currentSpeakerGridPage.Clear();
            tabSpeakerGrid.Rows.Clear();
            int numberElements = speakerList.Count;
            int i;
            int rows;
            int numberRowsPage = 5;
            if (numberElements - scrollValue < numberRowsPage)
            {
                numberRowsPage = numberElements - scrollValue;
            }

            for (i = 0; i < numberRowsPage; i++)
            {
                rows = tabSpeakerGrid.Rows.Add();
                SpeakerModel listElement = speakerList.ElementAt(i + scrollValSpeaker);
                speakers.Add(listElement);

                tabSpeakerGrid.Rows[rows].Cells[0].Value = listElement.Name.ToString();
                tabSpeakerGrid.Rows[rows].Cells[1].Value = listElement.Rating.ToString();
                tabSpeakerGrid.Rows[rows].Cells[2].Value = listElement.Nationality.ToString();

                tabSpeakerGrid.Rows[rows].Cells[5].Value = "Edit";
                tabSpeakerGrid.Rows[rows].Cells[6].Value = "Delete";
            }
            currentSpeakerGridPage = speakers;

        }

        List<SpeakerModel> getListSpeakerInConference()
        {
            List<SpeakerModel> speakers = null;

            int numberElements = currentSpeakerGridPage.Count;
            int i;
            int rows;

            for (i = 0; i < numberElements; i++)
            {

                //SpeakerModel listElement = speakerList.ElementAt(i);
                if(Convert.ToBoolean(tabSpeakerGrid.Rows[i].Cells[4].Value) == true)
                {
                    speakers.Add(currentSpeakerGridPage.ElementAt(i));
                }

            }           
                return speakers;
        }


        private void tabSpeakerAdd_Click(object sender, EventArgs e)
        {
            AddSpeakerForm fAddSpeaker = Program.ServiceProvider.GetService<AddSpeakerForm>();
            fAddSpeaker.ShowDialog();
        }

        private void tabSpeakerNextButton_Click(object sender, EventArgs e)
        {
            int nr = getSpeakerList.Count;
            scrollValSpeaker = scrollValSpeaker + 5;
            if (scrollValSpeaker >= nr)
            {
                scrollValSpeaker = scrollValSpeaker - 5;
            }
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker);
        }


        private void tabSpeakerPreviousButton_Click(object sender, EventArgs e)
        {
            scrollValSpeaker = scrollValSpeaker - 5;
            if (scrollValSpeaker < 0)
            {
                scrollValSpeaker = 0;
            }
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker);
        }

        private void tabSpeakerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabSpeakerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewButtonColumn buttonDelete = new DataGridViewButtonColumn();
            //CategoryTabGrid.Columns.Add(buttonDelete);
            //buttonDelete.HeaderText = "Delete";
            //buttonDelete.Name = "Delete";
            //buttonDelete.Text = "Delete";
            //buttonDelete.UseColumnTextForButtonValue = true;
            int i = 0;
            bool isSpeakerSelected = false;

            if(e.ColumnIndex == 5)//Edit
            {
                editedSpeaker = currentSpeakerGridPage.ElementAt(e.RowIndex);
                EditSpeakerForm fEditSpeaker =  Program.ServiceProvider.GetService<EditSpeakerForm>();

                fEditSpeaker.ShowDialog();
            }

            if (e.ColumnIndex == 6)//Delete
            {
                getSpeakerRepository.deleteSpeaker(currentSpeakerGridPage.ElementAt(e.RowIndex).Id);
                scrollValSpeaker = 0;
                getSpeakerList = getSpeakerRepository.GetSpeaker();
                populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker);

            }

            if(e.ColumnIndex == 4)//select speaker
            {
                
                if (Convert.ToBoolean(tabSpeakerGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                {

                    getSpeakerInConference.Remove(currentSpeakerGridPage.ElementAt(e.RowIndex).Id);


                }
                if (Convert.ToBoolean(tabSpeakerGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == false)
                {
                        getSpeakerInConference.Add(currentSpeakerGridPage.ElementAt(e.RowIndex).Id);

                }
            }

            if (e.ColumnIndex == 3)//Main Speaker
            {

                if (Convert.ToBoolean(tabSpeakerGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == false)
                {
                    elementMainSpeakerId = currentSpeakerGridPage.ElementAt(e.RowIndex).Id;

                }
            }
        }

        // End Tab Speaker Functions

        private void CategoryTabGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //this.CategoryTabGrid.Columns["ConferenceCategoryId"].Visible = false;
        }

        private void CategoryTabGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddConferance_Activated(object sender, EventArgs e)
        {
            scrollValSpeaker = 0;
            getSpeakerList = getSpeakerRepository.GetSpeaker();
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker);
            getMaxId(getSpeakerList);
        }

        private void tabSpeakerFilterButton_Click(object sender, EventArgs e)
        {
            scrollValSpeaker = 0;
            List<SpeakerModel> speakerModelTxt = getSpeakerRepository.GetSpeaker();
            getSpeakerList = speakerModelTxt.Where(getSpeakerList => (getSpeakerList.Name.Contains(tabSpeakerFilterText.Text)) ||
            (getSpeakerList.Code.Contains(tabSpeakerFilterText.Text))).ToList();
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker);
        }
    }
}

