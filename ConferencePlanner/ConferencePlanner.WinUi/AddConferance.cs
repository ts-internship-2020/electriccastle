
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.Helpers;
using static ConferencePlanner.WinUi.Program;
using Microsoft.Extensions.DependencyInjection;
using Windows.UI.Xaml.Controls;
using Windows.ApplicationModel.Activation;
using ConferencePlanner.Repository.Ef.Repository;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConferencePlanner.WinUi
{
    public partial class AddConferance : Form
    {
        private readonly IConferanceCategory _getConferanceCategory;

        private readonly IConferenceRepository conferenceRepository;

        // Category Tab
        private readonly IConferenceCategoryRepository conferenceCategoryRepository;
        private List<ConferenceCategoryModel> conferenceCategories;
        private PaginationHelper<ConferenceCategoryModel> categoryTabPaginationHelper;
        private int categoryTabPageSize = 3;

        //Type Tab
        private readonly IConferenceTypeRepository conferanceTypeRepository;
        private List<ConferenceTypeModel> conferanceTypeModels;
        private PaginationHelper<ConferenceTypeModel> conferanceTypePaginationHelper;
        private int typeTabPageSize = 1;


        //Country Tab
        private readonly IAddConferenceCountryRepository _getCountry;
        private List<AddConferenceCountryModel> countryModel;
        public static AddConferenceCountryModel editedCountry;
        private List<AddConferenceCountryModel> currentCountryGridPage;
        public int scrollValCountry;
        private int entryNumberTabCountry;
       //private readonly GetCountryRepositoryEntFr _countryEF;

        //District Tab
        private readonly IAddConferenceDistrictRepository conferenceDistrictRepository;
        private List<AddConferenceDistrictModel> districtModel;
        private int entryNumberTabDistrict;

        //City Tab
        private List<AddConferenceCityModel> cityModel;
        private readonly IAddConferenceCityRepository _getCity;
        public static AddConferenceCityModel editedCity;
        private List<AddConferenceCityModel> currentCityGridPage;
        private AddConferenceCityModel selectedCity;
        private int entryNumberTabCity;

        //tab Speaker
        private readonly ISpeakerRepository getSpeakerRepository;

        private List<SpeakerModel> getSpeakerList;

        private List<SpeakerModel> currentSpeakerGridPage;

        private int elementMainSpeakerId;

        public static SpeakerModel editedSpeaker;

        public static int maxIdSpeaker = 0;

        private int scrollValSpeaker;

        List<int> getSpeakerInConference;

        private int entryNumberTabSpeaker;

        //

        public int scrollVal;

        public int? ConferenceId { get; set; }

        public AddConferance(IConferanceCategory getConferanceCategory,
                             IConferenceCategoryRepository conferenceCategoryRepository,
                             IAddConferenceCityRepository getCity,
                             IAddConferenceCountryRepository getCountry,
                             IAddConferenceDistrictRepository getDistrict,
                             IConferenceTypeRepository conferanceTypeRepository,
                             ISpeakerRepository getSpeakerRepository,
                             IConferenceRepository conferenceRepository
                             )
        {
            this._getCity = getCity;
            this.conferenceDistrictRepository = getDistrict;
            this._getCountry = getCountry;
            scrollVal = 0;
            InitializeComponent();
            _getConferanceCategory = getConferanceCategory;
            this.conferenceCategoryRepository = conferenceCategoryRepository;
            this.conferanceTypeRepository = conferanceTypeRepository;
            this.conferenceRepository = conferenceRepository;


            this.getSpeakerRepository = getSpeakerRepository;
            scrollValSpeaker = 0;
            elementMainSpeakerId = 0;
            getSpeakerInConference = new List<int>(); 
            conferenceCategories = conferenceCategoryRepository.GetAllCategories();
            categoryTabPaginationHelper = new PaginationHelper<ConferenceCategoryModel>(conferenceCategories, categoryTabPageSize);
            conferanceTypeModels = conferanceTypeRepository.getAllTypes();
            conferanceTypePaginationHelper = new PaginationHelper<ConferenceTypeModel>(conferanceTypeModels, typeTabPageSize);
        }


        void addConferanceType(List<ConferenceTypeModel> type)
        {
            //dataGridViewType.Rows.Clear();
            //int countNumber = conferanceTypeModels.Count();

            //ConferanceTypeModel listElement = conferanceTypeModels.ElementAt(0);
            //for (int i=0; i<countNumber;i++)
            //{
            //    int n = dataGridViewType.Rows.Add();
            //    dataGridViewType.Rows[n].Cells[0].Value = listElement.ConferenceTypeCode.ToString();
            //    dataGridViewType.Rows[n].Cells[1].Value = listElement.ConferenceTypeName.ToString();
            //}



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
        private void button1_Click(object sender, EventArgs e)
        {

           checkCancel = false;
            tabConferance.SelectedIndex = (tabConferance.SelectedIndex + 1 < tabConferance.TabCount) ?
                             tabConferance.SelectedIndex + 1 : tabConferance.SelectedIndex;


            if (tabConferance.SelectedTab == tabConferance.TabPages["tabPage3"])
            {
                button1.Text = "Save";
                btSaveAndNew.Visible = true;

                if (ConferenceId == null)
                {
                    button1.Click += new EventHandler(AddConference);
                }
                else
                {
                    button1.Click += new EventHandler(EditConference);
                }
            }


        }

        private void AddConference(object sender, EventArgs e)
        {
            conferenceRepository.AddConference(PopulateConferenceObject());
        }

        private void EditConference(object sender, EventArgs e)
        {
            conferenceRepository.EditConference(PopulateConferenceObject());
        }

        private void btBack_Click(object sender, EventArgs e)
        {

            checkCancel = false;
            if (tabConferance.SelectedIndex != 0)
            {
                tabConferance.SelectedIndex = (tabConferance.SelectedIndex - 1 < tabConferance.TabCount) ?
                                 tabConferance.SelectedIndex - 1 : tabConferance.SelectedIndex;
        

            }
         
            if (tabConferance.SelectedTab == tabConferance.TabPages["tabPage2"])
            {
                button1.Text = "Next";
                btSaveAndNew.Visible = false;
                button1.Click += new EventHandler(button1_Click);
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


        bool checkCancel = true;
        private void tabConferance_Selecting(object sender, TabControlCancelEventArgs e)
        {


            e.Cancel = checkCancel;
            checkCancel = true;

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
            entryNumberTabSpeaker = Convert.ToInt32(tabSpeakerEntryNumberText.Text);
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker, entryNumberTabSpeaker);
            getMaxId(getSpeakerList);
            List<SpeakerModel> getSpeakerInConference = new List<SpeakerModel>();

            entryNumberTabCountry = Convert.ToInt32(tabCountryEntryText.Text);
            countryModel = _getCountry.GetConferencesCountry();
            populateGridCountry(countryModel, scrollVal, entryNumberTabCountry);

            entryNumberTabDistrict = Convert.ToInt32(tabDistrictEntryText.Text);
            districtModel = conferenceDistrictRepository.GetConferencesDistrict();
            populateGridDistrict(districtModel, scrollVal, entryNumberTabDistrict);

            entryNumberTabCity = Convert.ToInt32(tabCityEntryText.Text);
            cityModel = _getCity.GetConferencesCity();
            populateGridCity(cityModel, scrollVal, entryNumberTabCity);
            


            GenerateEditButtonCountry();
            GenerateEditButtonDistrict();
            GenerateEditButtonCity();
            GenerateDeleteButtonCountry();
            GenerateDeleteButtonDistrict();
            GenerateDeleteButtonCity();

            CategoryTabEntriesTextBox.Text = categoryTabPageSize.ToString();
            TypeTabEntriesTextBox.Text = typeTabPageSize.ToString();

            InitializeUIData();
        }

        private void InitializeUIData()
        {
            if (ConferenceId == null)
            {
                txtName.Text = "";
                txtOrganizer.Text = "";
                txtAddress.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;

                CategoryTabReloadData();
                TypeReloadData();
            }
            else
            {
                ConferenceModel conference = conferenceRepository.GetConference((int)ConferenceId);
                txtName.Text = conference.ConferenceName;
                txtOrganizer.Text = conference.OrganizerName;
                txtAddress.Text = conference.AdressDetails;
                dateTimePicker1.Value = conference.StartDate;
                dateTimePicker2.Value = conference.EndDate;

                int categoryIndex = conferenceCategories.FindIndex(cat => cat.ConferenceCategoryId == conference.DictionaryConferenceCategoryId) + 1;
                categoryTabPaginationHelper.pageNumber = categoryTabPaginationHelper.GetPageForIndex(categoryIndex);
                CategoryTabGrid.DataSource = categoryTabPaginationHelper.GetPage();
                CategoryTabGrid.AutoGenerateColumns = true;
                GenerateCategoryTabEditDeleteButtons();
                ManageCategoryTabPaginationButtonsState();
                DataGridViewRow categoryTabRow = CategoryTabGrid.Rows.Cast<DataGridViewRow>()
                                                                     .Where(row => (int)row.Cells["ConferenceCategoryId"].Value == conference.DictionaryConferenceCategoryId)
                                                                     .First();
                CategoryTabGrid.Rows[categoryTabRow.Index].Selected = true;

                int typeIndex = conferanceTypeModels.FindIndex(type => type.ConferenceTypeId == conference.DictionaryConferenceTypeId) + 1;
                conferanceTypePaginationHelper.pageNumber = conferanceTypePaginationHelper.GetPageForIndex(typeIndex);
                dataGridViewType.DataSource = conferanceTypePaginationHelper.GetPage();
                dataGridViewType.AutoGenerateColumns = true;
                GenerateTypeTabEditAndDeleteButtons();
                ManageTypeTabPaginationButtonsState();
                DataGridViewRow typeTabRow = dataGridViewType.Rows.Cast<DataGridViewRow>()
                                                                     .Where(row => (int)row.Cells["ConferenceTypeId"].Value == conference.DictionaryConferenceTypeId)
                                                                     .First();
                dataGridViewType.Rows[typeTabRow.Index].Selected = true;

            }
        }

        void populateGridCountry(List<AddConferenceCountryModel> country, int scrollVal, int countryEntry)
        {
            DGVCountry.Rows.Clear();

            int nr = country.Count;
            List<AddConferenceCountryModel> countries = new List<AddConferenceCountryModel>();
            int numberRowsPage = countryEntry;
            if (numberRowsPage > nr)
            {
                numberRowsPage = nr;
            }
            if (nr - scrollVal < numberRowsPage)
            {
                numberRowsPage = nr - scrollVal;
            }
            for (int i = 0; i < numberRowsPage; i++)
            {

                int n = DGVCountry.Rows.Add();


                AddConferenceCountryModel listCountry = country.ElementAt(scrollVal + i);

                DGVCountry.Rows[n].Cells[0].Value = listCountry.DictionaryCountryName.ToString();
                DGVCountry.Rows[n].Cells[1].Value = listCountry.CountryCode.ToString();
                countries.Add(listCountry);
            }
            currentCountryGridPage = countries;
        }

        void populateGridDistrict(List<AddConferenceDistrictModel> district, int scrollVal, int districtEntry)
        {
            DGVDistrict.Rows.Clear();


            int nr = district.Count;

            int numberRowsPage = districtEntry;
            if (numberRowsPage > nr)
            {
                numberRowsPage = nr;
            }
            if (nr - scrollVal < numberRowsPage)
            {
                numberRowsPage = nr - scrollVal;
            }
            for (int i = 0; i < numberRowsPage; i++)
            {
                int n = DGVDistrict.Rows.Add();


                AddConferenceDistrictModel listDistrict = district.ElementAt(scrollVal + i);

                DGVDistrict.Rows[n].Cells[0].Value = listDistrict.DictionaryDistrictName.ToString();
                DGVDistrict.Rows[n].Cells[1].Value = listDistrict.DistrictCode.ToString();
                DGVDistrict.Rows[n].Cells[2].Value = listDistrict.DictionaryDistrictId;

            }
            DGVDistrict.Columns["DistrictId"].Visible = false;
        }

        void populateGridCity(List<AddConferenceCityModel> city, int scrollVal, int cityEntry)
        {
            List<AddConferenceCityModel> cities = new List<AddConferenceCityModel>();
            DGVCity.Rows.Clear();
            int nr = city.Count;

            int numberRowsPage = cityEntry;
            if (numberRowsPage > nr)
            {
                numberRowsPage = nr;
            }
            if (nr - scrollVal < numberRowsPage)
            {
                numberRowsPage = nr - scrollVal;
            }
            for (int i = 0; i < numberRowsPage; i++)
            {
                int n = DGVCity.Rows.Add();
                AddConferenceCityModel listCity = city.ElementAt(scrollVal + i);


                DGVCity.Rows[n].Cells[0].Value = listCity.DictionaryCityName.ToString();
                DGVCity.Rows[n].Cells[1].Value = listCity.CityCode.ToString();
                cities.Add(listCity);
            }
            currentCityGridPage = cities;
        }

        


        private void GenerateTypeTabEditAndDeleteButtons()
        {
            if (!dataGridViewType.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn buttonEditType = new DataGridViewButtonColumn();
                dataGridViewType.Columns.Add(buttonEditType);
                buttonEditType.HeaderText = "Edit";
                buttonEditType.Name = "Edit";
                buttonEditType.Text = "Edit";
                buttonEditType.UseColumnTextForButtonValue = true;
            }

            if (!dataGridViewType.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn buttonDeleteType = new DataGridViewButtonColumn();
                dataGridViewType.Columns.Add(buttonDeleteType);
                buttonDeleteType.HeaderText = "Delete";
                buttonDeleteType.Name = "Delete";
                buttonDeleteType.Text = "Delete";
                buttonDeleteType.UseColumnTextForButtonValue = true;
            }
        }
        private void GenerateEditButtonCountry()
        {
            DataGridViewButtonColumn buttonEditCountry = new DataGridViewButtonColumn();
            DGVCountry.Columns.Add(buttonEditCountry);
            buttonEditCountry.HeaderText = "Edit";
            buttonEditCountry.Name = "Edit";
            buttonEditCountry.Text = "Edit";
            buttonEditCountry.UseColumnTextForButtonValue = true;
        }

        private void GenerateEditButtonDistrict()
        {
            DataGridViewButtonColumn buttonEditDistrict = new DataGridViewButtonColumn();
            DGVDistrict.Columns.Add(buttonEditDistrict);
            buttonEditDistrict.HeaderText = "Edit";
            buttonEditDistrict.Name = "Edit";
            buttonEditDistrict.Text = "Edit";
            buttonEditDistrict.UseColumnTextForButtonValue = true;
        }

        private void GenerateEditButtonCity()
        {
            DataGridViewButtonColumn buttonEditCity = new DataGridViewButtonColumn();
            DGVCity.Columns.Add(buttonEditCity);
            buttonEditCity.HeaderText = "Edit";
            buttonEditCity.Name = "Edit";
            buttonEditCity.Text = "Edit";
            buttonEditCity.UseColumnTextForButtonValue = true;
        }

        private void GenerateDeleteButtonCountry()
        {
            DataGridViewButtonColumn buttonDeleteCountry = new DataGridViewButtonColumn();
            DGVCountry.Columns.Add(buttonDeleteCountry);
            buttonDeleteCountry.HeaderText = "Delete";
            buttonDeleteCountry.Name = "Delete";
            buttonDeleteCountry.Text = "Delete";
            buttonDeleteCountry.UseColumnTextForButtonValue = true;
        }

        private void GenerateCategoryTabEditDeleteButtons()
        {
            if (!CategoryTabGrid.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn buttonEdit = new DataGridViewButtonColumn();
                CategoryTabGrid.Columns.Add(buttonEdit);
                buttonEdit.HeaderText = "Edit";
                buttonEdit.Name = "Edit";
                buttonEdit.Text = "Edit";
                buttonEdit.UseColumnTextForButtonValue = true;
            }

            if (!CategoryTabGrid.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn buttonDelete = new DataGridViewButtonColumn();
                CategoryTabGrid.Columns.Add(buttonDelete);
                buttonDelete.HeaderText = "Delete";
                buttonDelete.Name = "Delete";
                buttonDelete.Text = "Delete";
                buttonDelete.UseColumnTextForButtonValue = true;
            }
        }
        private void GenerateDeleteButtonDistrict()
        {
            DataGridViewButtonColumn buttonDeleteDistrict = new DataGridViewButtonColumn();
            DGVDistrict.Columns.Add(buttonDeleteDistrict);
            buttonDeleteDistrict.HeaderText = "Delete";
            buttonDeleteDistrict.Name = "Delete";
            buttonDeleteDistrict.Text = "Delete";
            buttonDeleteDistrict.UseColumnTextForButtonValue = true;
        }

        private void GenerateDeleteButtonCity()
        {
            DataGridViewButtonColumn buttonDeleteCity = new DataGridViewButtonColumn();
            DGVCity.Columns.Add(buttonDeleteCity);
            buttonDeleteCity.HeaderText = "Delete";
            buttonDeleteCity.Name = "Delete";
            buttonDeleteCity.Text = "Delete";
            buttonDeleteCity.UseColumnTextForButtonValue = true;
        }

     

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void NewCountry_Click(object sender, EventArgs e)
        {

            NewCountryForm fc = Program.ServiceProvider.GetService<NewCountryForm>();
            fc.ShowDialog();
            //fc.Show();
        }

        private void NewDistrict_Click(object sender, EventArgs e)
        {
            NewDistrictForm newDistrictForm = Program.ServiceProvider.GetService<NewDistrictForm>();
            newDistrictForm.DistrictId = null;
            newDistrictForm.ShowDialog();
        }

        private void NewCity_Click(object sender, EventArgs e)
        {
            editedCity = null;
            NewCityForm fcity = Program.ServiceProvider.GetService<NewCityForm>();
            fcity.ShowDialog();
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
        void populateTabSpeakersGrid(List<SpeakerModel> speakerList, int scrollValue, int speakerEntry)
        {
            List<SpeakerModel> speakers = new List<SpeakerModel>();
           // currentSpeakerGridPage.Clear();
            tabSpeakerGrid.Rows.Clear();
            int numberElements = speakerList.Count;
            int i;
            int rows;
            int numberRowsPage = speakerEntry;
            if (numberRowsPage > numberElements)
            {
                numberRowsPage = numberElements;
            }
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
            tabSpeakerGrid.Columns[0].ReadOnly = true;
            tabSpeakerGrid.Columns[1].ReadOnly = true;
            tabSpeakerGrid.Columns[2].ReadOnly = true;
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
            scrollValSpeaker = scrollValSpeaker + entryNumberTabSpeaker;
            if (scrollValSpeaker >= nr)
            {
                scrollValSpeaker = scrollValSpeaker - entryNumberTabSpeaker;
            }
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker, entryNumberTabSpeaker);
        }


        private void tabSpeakerPreviousButton_Click(object sender, EventArgs e)
        {
            scrollValSpeaker = scrollValSpeaker - entryNumberTabSpeaker;
            if (scrollValSpeaker < 0)
            {
                scrollValSpeaker = 0;
            }
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker, entryNumberTabSpeaker);
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
                populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker, entryNumberTabSpeaker);

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
            this.CategoryTabGrid.Columns["ConferenceCategoryId"].Visible = false;
        }

        private void CategoryTabGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || (e.ColumnIndex != CategoryTabGrid.Columns["Edit"].Index
                               && e.ColumnIndex != CategoryTabGrid.Columns["Delete"].Index)) return;

            Int32 categoryId = (Int32)CategoryTabGrid[CategoryTabGrid.Columns["ConferenceCategoryId"].Index, e.RowIndex].Value;

            if (e.ColumnIndex == CategoryTabGrid.Columns["Edit"].Index)
            {
                AddEditConferenceCategoryScreen addEditCategory = Program.ServiceProvider.GetService<AddEditConferenceCategoryScreen>();
                addEditCategory.CategoryId = categoryId;
                addEditCategory.ShowDialog();
            }

            if (e.ColumnIndex == CategoryTabGrid.Columns["Delete"].Index)
            {
                string categoryName = CategoryTabGrid[CategoryTabGrid.Columns["ConferenceCategoryName"].Index, e.RowIndex].Value.ToString();
                DialogResult dialogResult = DisplayDeleteConfirmation("Are you sure you want to delete " + categoryName + "?", "Delete Category");
                if (dialogResult == DialogResult.Yes)
                {
                    conferenceCategoryRepository.DeleteCategory(categoryId);
                    CategoryTabReloadData();
                }
            }
        }

        private void CategoryTabNextButton_Click(object sender, EventArgs e)
        {
            categoryTabPaginationHelper.NextPage();
            CategoryTabGrid.DataSource = categoryTabPaginationHelper.GetPage();
            ManageCategoryTabPaginationButtonsState();

        }

        private void CategoryTabPreviousButton_Click(object sender, EventArgs e)
        {
            categoryTabPaginationHelper.PreviousPage();
            CategoryTabGrid.DataSource = categoryTabPaginationHelper.GetPage();
            ManageCategoryTabPaginationButtonsState();
        }

        private void ManageCategoryTabPaginationButtonsState()
        {
            CategoryTabPreviousButton.Enabled = categoryTabPaginationHelper.HasPreviousPage();
            CategoryTabNextButton.Enabled = categoryTabPaginationHelper.HasNextPage();
        }

        private void CategoryTabSearchButton_Click(object sender, EventArgs e)
        {
            CategoryTabFilter();
        }

        private void CategoryTabAddButton_Click(object sender, EventArgs e)
        {
            AddEditConferenceCategoryScreen addEditCategory = Program.ServiceProvider.GetService<AddEditConferenceCategoryScreen>();
            addEditCategory.CategoryId = null;
            addEditCategory.ShowDialog();
        }

        private void AddConferance_Activated(object sender, EventArgs e)
        {

            scrollValSpeaker = 0;
            getSpeakerList = getSpeakerRepository.GetSpeaker();
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker, entryNumberTabSpeaker);
            getMaxId(getSpeakerList);
        }
         

        private void TypeReloadData()
        {
            conferanceTypeModels = conferanceTypeRepository.getAllTypes();
            conferanceTypePaginationHelper = new PaginationHelper<ConferenceTypeModel>(conferanceTypeModels, typeTabPageSize);
            dataGridViewType.DataSource = conferanceTypePaginationHelper.GetPage();
            dataGridViewType.AutoGenerateColumns = true;
            ManageTypeTabPaginationButtonsState();
            GenerateTypeTabEditAndDeleteButtons();

            scrollValCountry = 0;
            countryModel = _getCountry.GetConferencesCountry();
            populateGridCountry(countryModel, scrollValCountry, entryNumberTabCountry);

            scrollValSpeaker = 0;
            getSpeakerList = getSpeakerRepository.GetSpeaker();
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker, entryNumberTabSpeaker);
            getMaxId(getSpeakerList);

            scrollVal = 0;
            cityModel = _getCity.GetConferencesCity();
            populateGridCity(cityModel, scrollVal, entryNumberTabCity);

        }
        private void CategoryTabReloadData()
        {
            conferenceCategories = conferenceCategoryRepository.GetAllCategories();
            categoryTabPaginationHelper = new PaginationHelper<ConferenceCategoryModel>(conferenceCategories, categoryTabPageSize);
            CategoryTabGrid.DataSource = categoryTabPaginationHelper.GetPage();
            CategoryTabGrid.AutoGenerateColumns = true;
            GenerateCategoryTabEditDeleteButtons();
            ManageCategoryTabPaginationButtonsState();
        }

        private DialogResult DisplayDeleteConfirmation(string messageBoxText, string messageBoxTitle)
        {
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            return MessageBox.Show(messageBoxText, messageBoxTitle, messageBoxButtons, MessageBoxIcon.Question);
        }

        private void CategoryTabSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            CategoryTabFilter();
        }

        private void CategoryTabFilter()
        {
            string searchString = CategoryTabSearchTextBox.Text;
            List<ConferenceCategoryModel> filteredData = conferenceCategories.Where(category => category.ConferenceCategoryName.ToLower().Contains(searchString.ToLower())
                                                                                                 || category.ConferenceCategoryCode.ToLower().Contains(searchString.ToLower())).ToList();
            categoryTabPaginationHelper = new PaginationHelper<ConferenceCategoryModel>(filteredData, categoryTabPageSize);
            CategoryTabGrid.DataSource = categoryTabPaginationHelper.GetPage();
            ManageCategoryTabPaginationButtonsState();
        }


        private void ManageTypeTabPaginationButtonsState()
        {
            btPreviousType.Enabled = conferanceTypePaginationHelper.HasPreviousPage();
            btNextType.Enabled = conferanceTypePaginationHelper.HasNextPage();

        }
        private void btNewType_Click(object sender, EventArgs e)
        {

            NewConferanceType newConferance = Program.ServiceProvider.GetService<NewConferanceType>();
            newConferance.ConferanceTypeId = null;
            newConferance.ShowDialog();
        }

        private void btNextType_Click(object sender, EventArgs e)
        {

            conferanceTypePaginationHelper.NextPage();
            dataGridViewType.DataSource = conferanceTypePaginationHelper.GetPage();
            ManageTypeTabPaginationButtonsState();

        }

        private void btPreviousType_Click(object sender, EventArgs e)
        {
            conferanceTypePaginationHelper.PreviousPage();
            dataGridViewType.DataSource = conferanceTypePaginationHelper.GetPage();
            ManageTypeTabPaginationButtonsState();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            List<ConferenceTypeModel> searchData = conferanceTypeModels.Where(type => type.ConferenceTypeName.ToLower().Contains(searchValue.ToLower())
                                                                                                 || type.ConferenceTypeCode.ToLower().Contains(searchValue.ToLower())).ToList();

            conferanceTypePaginationHelper = new PaginationHelper<ConferenceTypeModel>(searchData, typeTabPageSize);
            dataGridViewType.DataSource = conferanceTypePaginationHelper.GetPage();
            ManageTypeTabPaginationButtonsState();

        }

        private void dataGridViewType_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridViewType.Columns["ConferenceTypeId"].Visible = false;
        }

        private void dataGridViewType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || (e.ColumnIndex != dataGridViewType.Columns["Edit"].Index && e.ColumnIndex != dataGridViewType.Columns["Delete"].Index)) return;


            Int32 typeId = (Int32)dataGridViewType[dataGridViewType.Columns["ConferenceTypeId"].Index, e.RowIndex].Value;


            if (e.ColumnIndex == dataGridViewType.Columns["Edit"].Index)

            {
                NewConferanceType newConferanceType = Program.ServiceProvider.GetService<NewConferanceType>();
                newConferanceType.ConferanceTypeId = typeId;
                newConferanceType.ShowDialog();
               
            }
            else
            {
                if (e.ColumnIndex == dataGridViewType.Columns["Delete"].Index)
                {
                    string typeName = dataGridViewType[dataGridViewType.Columns["ConferenceTypeName"].Index, e.RowIndex].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want delete " + typeName+ "?", "Delete", MessageBoxButtons.YesNo);
                    if(dialogResult==DialogResult.Yes)
                    {
                        conferanceTypeRepository.deleteType(typeId);
                        TypeReloadData();
                    }
                    

                }
            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            //country
            int nr = countryModel.Count;
            scrollVal = scrollVal + entryNumberTabCountry;
            if (scrollVal >= nr)
            {
                scrollVal = scrollVal - entryNumberTabCountry;
            }
            populateGridCountry(countryModel, scrollVal, entryNumberTabCountry);
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            //country
            scrollVal = scrollVal - entryNumberTabCountry;
            if (scrollVal < 0)
            {
                scrollVal = 0;
            }
            populateGridCountry(countryModel, scrollVal, entryNumberTabCountry);
        }

        private void PreviousPageDistrict_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal - entryNumberTabDistrict;
            if (scrollVal < 0)
            {
                scrollVal = 0;
            }
            populateGridDistrict(districtModel, scrollVal, entryNumberTabDistrict);
        }

        private void NextDistrict_Click(object sender, EventArgs e)
        {
            int nr = districtModel.Count;
            scrollVal = scrollVal + entryNumberTabDistrict;
            if (scrollVal >= nr)
            {
                scrollVal = scrollVal - entryNumberTabDistrict;
            }
            populateGridDistrict(districtModel, scrollVal, entryNumberTabDistrict);
        }

        private void PrevoiusCity_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal - entryNumberTabCity;
            if (scrollVal < 0)
            {
                scrollVal = 0;
            }
            populateGridCity(cityModel, scrollVal, entryNumberTabCity);
        }

        private void NextCity_Click(object sender, EventArgs e)
        {
            int nr = cityModel.Count;
            scrollVal = scrollVal + entryNumberTabCity;
            if (scrollVal >= nr)
            {
                scrollVal = scrollVal - entryNumberTabCity;
            }
            populateGridCity(cityModel, scrollVal, entryNumberTabCity);
        }

        private void textNameCountry_TextChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            List<AddConferenceCountryModel> countryModelTxt = _getCountry.GetConferencesCountry();
            // if(countryModel.DictionaryCountryName.Equ)
            countryModel = countryModelTxt.Where(countryModel => (countryModel.DictionaryCountryName.Contains(textNameCountry.Text)) ||
            (countryModel.CountryCode.Contains(textNameCountry.Text))).ToList();
            populateGridCountry(countryModel, scrollVal, entryNumberTabCountry);
        }

        private void DistrictFilter_TextChanged(object sender, EventArgs e)
        {
            //filter district
            scrollVal = 0;
            List<AddConferenceDistrictModel> districtModelTxt = conferenceDistrictRepository.GetConferencesDistrict();

            districtModel = districtModelTxt.Where(districtModel => (districtModel.DictionaryDistrictName.Contains(DistrictFilter.Text)) ||
            (districtModel.DistrictCode.Contains(DistrictFilter.Text))).ToList();
            populateGridDistrict(districtModel, scrollVal, entryNumberTabDistrict);
        }
        


        private void filterCity_TextChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            List<AddConferenceCityModel> cityModelTxt = _getCity.GetConferencesCity();

            cityModel = cityModelTxt.Where(cityModel => (cityModel.DictionaryCityName.Contains(filterCity.Text)) ||
            (cityModel.CityCode.Contains(filterCity.Text))).ToList();
            populateGridCity(cityModel, scrollVal, entryNumberTabCity);
        }


        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            editedCountry = null;
            int n = countryModel.Count;

            if (e.RowIndex < 0 || (e.ColumnIndex != DGVCountry.Columns["Edit"].Index && e.ColumnIndex != DGVCountry.Columns["Delete"].Index))
                return;
            
            if (e.ColumnIndex == DGVCountry.Columns["Edit"].Index)
            { 
                editedCountry = currentCountryGridPage.ElementAt(e.RowIndex);
                EditCountry();
                NewCountryForm fc = Program.ServiceProvider.GetService<NewCountryForm>();
                fc.ShowDialog();
            }

            else if (e.ColumnIndex == DGVCountry.Columns["Delete"].Index)
            {
                _getCountry.DeleteConferenceCoutry(currentCountryGridPage.ElementAt(e.RowIndex).DictionaryCountryId);
                DeleteCountry();
                scrollValCountry = 0;
                countryModel = _getCountry.GetConferencesCountry();
                populateGridCountry(countryModel, scrollValCountry, entryNumberTabCountry);
                
            }
            else return;
        }

        private async Task EditCountry()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage s = await client.GetAsync("http://localhost:2794/api/Country/{Country}");
            if (s.IsSuccessStatusCode)
            {
                string resp = await s.Content.ReadAsStringAsync();

            }
        }

        private void DGVCity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            editedCity = null;
            //check if only Delete or Edit button is pressed
            if (e.RowIndex < 0 )
            {
                return;
            }
            else
            {
                //button is valid
            }
            // check if Edit Button is pressed
            if (e.ColumnIndex == DGVCity.Columns["Edit"].Index)
            {
                editedCity = currentCityGridPage.ElementAt(e.RowIndex);
                NewCityForm fcity = Program.ServiceProvider.GetService<NewCityForm>();
                fcity.ShowDialog();
            }
            // check if Delete Button is pressed
            else if (e.ColumnIndex == DGVCity.Columns["Delete"].Index)
            {
                _getCity.deleteCity(currentCityGridPage.ElementAt(e.RowIndex).DictionaryCityId);
                scrollVal = 0;
                cityModel = _getCity.GetConferencesCity();
                populateGridCity(cityModel, scrollVal, entryNumberTabCity);
                
            }
            else if (e.RowIndex > 0 && e.ColumnIndex != DGVCity.Columns["Edit"].Index && e.ColumnIndex != DGVCity.Columns["Delete"].Index)
            {

                selectedCity.CityCode = this.DGVCity.Rows[e.RowIndex].Cells["Cod"].Value.ToString();
                selectedCity.DictionaryCityName = this.DGVCity.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                selectedCity.DictionaryCityId = currentCityGridPage.ElementAt(e.RowIndex).DictionaryCityId;
                selectedCity.DictionaryDistrictId = currentCityGridPage.ElementAt(e.RowIndex).DictionaryDistrictId;


            }
            else
            {
                // do nothing
            }
        }

        private async Task DeleteCountry()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage s = await client.GetAsync("http://localhost:2794/api/Country/{Country}");
            if (s.IsSuccessStatusCode)
            {
                string resp = await s.Content.ReadAsStringAsync();

            }
        }

        private void DGVDistrict_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || (e.ColumnIndex != DGVDistrict.Columns["Edit"].Index
                               && e.ColumnIndex != DGVDistrict.Columns["Delete"].Index)) return;

            Int32 districtId = (Int32)DGVDistrict[DGVDistrict.Columns["DistrictId"].Index, e.RowIndex].Value;

            if (e.ColumnIndex == DGVDistrict.Columns["Edit"].Index)
            {
                NewDistrictForm addEditCategory = Program.ServiceProvider.GetService<NewDistrictForm>();
                EditDistrict();
                addEditCategory.DistrictId = districtId;
                addEditCategory.ShowDialog();
            }

            if (e.ColumnIndex == DGVDistrict.Columns["Delete"].Index)
            {
                string districtName = DGVDistrict[DGVDistrict.Columns["DictrictName"].Index, e.RowIndex].Value.ToString();
                DeleteDistrict();
                DialogResult dialogResult = DisplayDeleteConfirmation("Are you sure you want to delete " + districtName + "?", "Delete District");
                if (dialogResult == DialogResult.Yes)
                {
                    conferenceDistrictRepository.DeleteConferenceDistrict(districtId);
                }
            }

        }

        private async Task EditDistrict()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage s = await client.GetAsync("http://localhost:2794/api/District/{District}");
            if (s.IsSuccessStatusCode)
            {
                string resp = await s.Content.ReadAsStringAsync();

            }
        }

        private async Task DeleteDistrict()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage s = await client.GetAsync("http://localhost:2794/api/District/{District}");
            if (s.IsSuccessStatusCode)
            {
                string resp = await s.Content.ReadAsStringAsync();

            }
        }

        private void btSearch_KeyDown(object sender, KeyEventArgs e)
        {
          

        }

        private void tabSpeakerFilterText_TextChanged(object sender, EventArgs e)
        {
            scrollValSpeaker = 0;
            List<SpeakerModel> speakerModelTxt = getSpeakerRepository.GetSpeaker();
            getSpeakerList = speakerModelTxt.Where(getSpeakerList => (getSpeakerList.Name.Contains(tabSpeakerFilterText.Text)) ||
            (getSpeakerList.Code.Contains(tabSpeakerFilterText.Text))).ToList();
            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker, entryNumberTabSpeaker);
        }

        private void tabSpeakerEntryNumberText_TextChanged(object sender, EventArgs e)
        {
            scrollValSpeaker = 0;
            if (tabSpeakerEntryNumberText.Text == string.Empty)
            {
                entryNumberTabSpeaker = 0;
            }
            else
            {
                entryNumberTabSpeaker = Convert.ToInt32(tabSpeakerEntryNumberText.Text);
            }

            populateTabSpeakersGrid(getSpeakerList, scrollValSpeaker, entryNumberTabSpeaker);
        }

        private void tabCityEntryText_TextChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            if (tabCityEntryText.Text == string.Empty)
            {
                entryNumberTabCity = 0;
            }
            else
            {
                entryNumberTabCity = Convert.ToInt32(tabCityEntryText.Text);
            }

            populateGridCity(cityModel, scrollVal, entryNumberTabCity);

        }

        private void btSaveAndNew_Click(object sender, EventArgs e)
        {
            if (ConferenceId == null)
            {
                conferenceRepository.AddConference(PopulateConferenceObject());

                AddConferance addConferance = Program.ServiceProvider.GetService<AddConferance>();
                addConferance.ConferenceId = null;
                addConferance.ShowDialog();
            }
            else
            {
                conferenceRepository.EditConference(PopulateConferenceObject());

                AddConferance addConferance = Program.ServiceProvider.GetService<AddConferance>();
                addConferance.ConferenceId = null;
                addConferance.ShowDialog();
            }
        }

        private ConferenceModel PopulateConferenceObject()
        {
            return new ConferenceModel
            {

            };
        }

        private void tabCountryEntryText_TextChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            if (tabCountryEntryText.Text == string.Empty)
            {
                entryNumberTabCountry = 0;
            }
            else
            {
                entryNumberTabCountry = Convert.ToInt32(tabCountryEntryText.Text);
            }

            populateGridCountry(countryModel, scrollVal, entryNumberTabCountry);
        }

        private void tabDistrictEntryText_TextChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            if (tabDistrictEntryText.Text == string.Empty)
            {
                entryNumberTabDistrict = 0;
            }
            else
            {
                entryNumberTabDistrict = Convert.ToInt32(tabDistrictEntryText.Text);
            }

            populateGridDistrict(districtModel, scrollVal, entryNumberTabDistrict);
        }

        private void CategoryTabEntriesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CategoryTabEntriesTextBox.Text != string.Empty)
            {
                categoryTabPaginationHelper.pageSize = Convert.ToInt32(CategoryTabEntriesTextBox.Text);
                categoryTabPaginationHelper.pageNumber = 1;
                // Nu stergeti
                //categoryTabPaginationHelper.pageNumber = categoryTabPaginationHelper.GetPageForIndex(conferenceCategories.FindIndex(cat => cat.ConferenceCategoryId == (int)CategoryTabGrid.SelectedRows[0].Cells["ConferenceCategoryId"].Value) + 1);
                CategoryTabGrid.DataSource = categoryTabPaginationHelper.GetPage();
                ManageCategoryTabPaginationButtonsState();
            }
        }

        private void TypeTabEntriesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TypeTabEntriesTextBox.Text != string.Empty)
            {
                conferanceTypePaginationHelper.pageSize = Convert.ToInt32(TypeTabEntriesTextBox.Text);
                conferanceTypePaginationHelper.pageNumber = 1;
                // Nu stergeti
                //categoryTabPaginationHelper.pageNumber = categoryTabPaginationHelper.GetPageForIndex(conferenceCategories.FindIndex(cat => cat.ConferenceCategoryId == (int)CategoryTabGrid.SelectedRows[0].Cells["ConferenceCategoryId"].Value) + 1);
                dataGridViewType.DataSource = conferanceTypePaginationHelper.GetPage();
                ManageTypeTabPaginationButtonsState();
            }
        }
    }
}



