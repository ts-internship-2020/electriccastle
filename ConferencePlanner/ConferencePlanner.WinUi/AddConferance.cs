using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.Helpers;
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

        private readonly IAddConferenceCityRepository _getCity;

        private readonly IAddConferenceCountyRepository _getCountry;

        private readonly IAddConferenceDistrictRepository _getDistrict;

        private List<ConferenceCategoryModel> conferenceCategories;

        private List<AddConferenceCityModel> cityModel;

        private List<AddConferenceCountryModel> countryModel;

        private List<AddConferenceDistrictModel> districtModel;

        private PaginationHelper<ConferenceCategoryModel> categoryTabPaginationHelper;

        private int categoryTabPageSize = 5;

        private int scrollVal;
        public int? ConferenceId { get; set; }

        public AddConferance(IConferanceCategory getConferanceCategory,
                             IConferenceCategoryRepository conferenceCategoryRepository,
                             IAddConferenceCityRepository getCity,
                             IAddConferenceCountyRepository getCountry,
                             IAddConferenceDistrictRepository getDistrict)
        {
            this._getCity = getCity;
            this._getDistrict = getDistrict;
            this._getCountry = getCountry;
            scrollVal = 0;
            InitializeComponent();
            _getConferanceCategory=getConferanceCategory;
            this.conferenceCategoryRepository = conferenceCategoryRepository;
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

        private void GenerateCategoryTabEditDeleteButtons()
        {
            //DataGridViewButtonColumn buttonEdit = new DataGridViewButtonColumn();
            //CategoryTabGrid.Columns.Add(buttonEdit);
            //buttonEdit.HeaderText = "Edit";
            //buttonEdit.Name = "Edit";
            //buttonEdit.Text = "Edit";
            //buttonEdit.UseColumnTextForButtonValue = true;

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
            //DataGridViewButtonColumn buttonDelete = new DataGridViewButtonColumn();
            //CategoryTabGrid.Columns.Add(buttonDelete);
            //buttonDelete.HeaderText = "Delete";
            //buttonDelete.Name = "Delete";
            //buttonDelete.Text = "Delete";
            //buttonDelete.UseColumnTextForButtonValue = true;
        }

        private void CategoryTabGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //this.CategoryTabGrid.Columns["ConferenceCategoryId"].Visible = false;
        }

        private void CategoryTabGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 || e.ColumnIndex != CategoryTabGrid.Columns["Edit"].Index 
            //                   || e.ColumnIndex != CategoryTabGrid.Columns["Delete"].Index) return;

            //Int32 categoryId = (Int32)CategoryTabGrid[CategoryTabGrid.Columns["ConferenceCategoryId"].Index, e.RowIndex].Value;

            //if (e.ColumnIndex == CategoryTabGrid.Columns["Edit"].Index)
            //{
            //    //AddConferance addConferance = Program.ServiceProvider.GetService<AddConferance>();
            //    //addConferance.ConferenceId = categoryId;
            //    //addConferance.ShowDialog();
            //}

            //if (e.ColumnIndex == CategoryTabGrid.Columns["Delete"].Index)
            //{
            //    //conferenceCategoryRepository.deleteCategory(categoryId);
            //}
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

