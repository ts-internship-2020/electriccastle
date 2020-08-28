
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
using static ConferencePlanner.WinUi.Program;
using Windows.UI.Xaml.Controls;
using Microsoft.Extensions.DependencyInjection;
using Windows.ApplicationModel.Activation;
using System.Linq;

namespace ConferencePlanner.WinUi
{
    public partial class AddConferance : Form
    {
        private readonly IConferanceCategory _getConferanceCategory;

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
        private readonly IAddConferenceCountyRepository _getCountry;
        private List<AddConferenceCountryModel> countryModel;

        //District Tab
        private readonly IAddConferenceDistrictRepository _getDistrict;
        private List<AddConferenceDistrictModel> districtModel;

        //City Tab
        private List<AddConferenceCityModel> cityModel;
        private readonly IAddConferenceCityRepository _getCity;

        public int scrollVal;

        public int? ConferenceId { get; set; }

        public AddConferance(IConferanceCategory getConferanceCategory,
                             IConferenceCategoryRepository conferenceCategoryRepository,
                             IAddConferenceCityRepository getCity,
                             IAddConferenceCountyRepository getCountry,
                             IAddConferenceDistrictRepository getDistrict,
                             IConferenceTypeRepository conferanceTypeRepository)
        {
            this._getCity = getCity;
            this._getDistrict = getDistrict;
            this._getCountry = getCountry;
            scrollVal = 0;
            InitializeComponent();
            _getConferanceCategory = getConferanceCategory;
            this.conferenceCategoryRepository = conferenceCategoryRepository;
            this.conferanceTypeRepository = conferanceTypeRepository;


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


            tabConferance.SelectedIndex = (tabConferance.SelectedIndex + 1 < tabConferance.TabCount) ?
                             tabConferance.SelectedIndex + 1 : tabConferance.SelectedIndex;

            if (tabConferance.SelectedTab == tabConferance.TabPages["tabPage3"])
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

            if (tabConferance.SelectedTab == tabConferance.TabPages["tabPage2"])
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
            countryModel = _getCountry.GetConferencesCountry();
            populateGridCountry(countryModel, scrollVal);

            districtModel = _getDistrict.GetConferencesDistrict();
            populateGridDistrict(districtModel, scrollVal);

            cityModel = _getCity.GetConferencesCity();
            populateGridCity(cityModel, scrollVal);


            GenerateEditButtonCountry();
            GenerateEditButtonDistrict();
            GenerateEditButtonCity();
            GenerateDeleteButtonCountry();
            GenerateDeleteButtonDistrict();
            GenerateDeleteButtonCity();


        }

        void populateGridCountry(List<AddConferenceCountryModel> country, int scrollVal)
        {
            DGVCountry.Rows.Clear();

            int nr = country.Count;

            int numberRowsPage = 2;
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

            }
        }

        void populateGridDistrict(List<AddConferenceDistrictModel> district, int scrollVal)
        {
            DGVDistrict.Rows.Clear();


            int nr = district.Count;

            int numberRowsPage = 3;
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

            }
        }

        void populateGridCity(List<AddConferenceCityModel> city, int scrollVal)
        {
            DGVCity.Rows.Clear();
            int nr = city.Count;

            int numberRowsPage = 3;
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

            }

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
            buttonDeleteCity.HeaderText = "Edit";
            buttonDeleteCity.Name = "Edit";
            buttonDeleteCity.Text = "Edit";
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
                    conferenceCategoryRepository.deleteCategory(categoryId);
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
            conferanceTypeModels = conferanceTypeRepository.getAllTypes();
            conferanceTypePaginationHelper = new PaginationHelper<ConferenceTypeModel>(conferanceTypeModels, typeTabPageSize);
            dataGridViewType.DataSource = conferanceTypePaginationHelper.GetPage();
            dataGridViewType.AutoGenerateColumns = true;
            ManageTypeTabPaginationButtonsState();
            GenerateTypeTabEditAndDeleteButtons();

            CategoryTabReloadData();
        }

        private void CategoryTabReloadData()
        {
            conferenceCategories = conferenceCategoryRepository.getAllCategories();
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
                    conferanceTypeRepository.deleteType(typeId);
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
            scrollVal = scrollVal + 2;
            if (scrollVal >= nr)
            {
                scrollVal = scrollVal - 2;
            }
            populateGridCountry(countryModel, scrollVal);
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            //country
            scrollVal = scrollVal - 2;
            if (scrollVal < 0)
            {
                scrollVal = 0;
            }
            populateGridCountry(countryModel, scrollVal);
        }

        private void PreviousPageDistrict_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal - 3;
            if (scrollVal < 0)
            {
                scrollVal = 0;
            }
            populateGridDistrict(districtModel, scrollVal);
        }

        private void NextDistrict_Click(object sender, EventArgs e)
        {
            int nr = countryModel.Count;
            scrollVal = scrollVal + 3;
            if (scrollVal >= nr)
            {
                scrollVal = scrollVal - 3;
            }
            populateGridDistrict(districtModel, scrollVal);
        }

        private void PrevoiusCity_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal - 3;
            if (scrollVal < 0)
            {
                scrollVal = 0;
            }
            populateGridCity(cityModel, scrollVal);
        }

        private void NextCity_Click(object sender, EventArgs e)
        {
            int nr = countryModel.Count;
            scrollVal = scrollVal + 3;
            if (scrollVal >= nr)
            {
                scrollVal = scrollVal - 3;
            }
            populateGridCity(cityModel, scrollVal);
        }

        private void textNameCountry_TextChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            List<AddConferenceCountryModel> countryModelTxt = _getCountry.GetConferencesCountry();
            // if(countryModel.DictionaryCountryName.Equ)
            countryModel = countryModelTxt.Where(countryModel => (countryModel.DictionaryCountryName.Contains(textNameCountry.Text)) ||
            (countryModel.CountryCode.Contains(textNameCountry.Text))).ToList();
            populateGridCountry(countryModel, scrollVal);
        }

        private void DistrictFilter_TextChanged(object sender, EventArgs e)
        {
            //filter district
            scrollVal = 0;
            List<AddConferenceDistrictModel> districtModelTxt = _getDistrict.GetConferencesDistrict();

            districtModel = districtModelTxt.Where(districtModel => (districtModel.DictionaryDistrictName.Contains(DistrictFilter.Text)) ||
            (districtModel.DistrictCode.Contains(DistrictFilter.Text))).ToList();
            populateGridDistrict(districtModel, scrollVal);
        }

        private void filterCity_TextChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            List<AddConferenceCityModel> cityModelTxt = _getCity.GetConferencesCity();

            cityModel = cityModelTxt.Where(cityModel => (cityModel.DictionaryCityName.Contains(filterCity.Text)) ||
            (cityModel.CityCode.Contains(filterCity.Text))).ToList();
            populateGridCity(cityModel, scrollVal);
        }
    }
}



