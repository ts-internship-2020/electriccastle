
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

namespace ConferencePlanner.WinUi
{
    public partial class AddConferance : Form
    {
        private readonly IConferanceCategory _getConferanceCategory;

        // Category Tab

        private readonly IConferenceCategoryRepository conferenceCategoryRepository;
        private readonly IConferenceTypeRepository conferanceTypeRepository;

        private List<ConferenceCategoryModel> conferenceCategories;
        private List<ConferenceTypeModel> conferanceTypeModels;

        private PaginationHelper<ConferenceCategoryModel> categoryTabPaginationHelper;
        private PaginationHelper<ConferenceTypeModel> conferanceTypePaginationHelper;
       

        private int categoryTabPageSize = 3;
        private int typeTabPageSize = 1;
     

        //

        public int? ConferenceId { get; set; }

        public AddConferance(IConferanceCategory getConferanceCategory,
                             IConferenceCategoryRepository conferenceCategoryRepository, IConferenceTypeRepository conferanceTypeRepository)
        {
            InitializeComponent();
            _getConferanceCategory=getConferanceCategory;
            this.conferenceCategoryRepository = conferenceCategoryRepository;
            this.conferanceTypeRepository = conferanceTypeRepository;
          
            conferenceCategories = conferenceCategoryRepository.getAllCategories();
            categoryTabPaginationHelper = new PaginationHelper<ConferenceCategoryModel>(conferenceCategories, categoryTabPageSize);
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
            CategoryTabGrid.DataSource = categoryTabPaginationHelper.GetPage();
            CategoryTabGrid.AutoGenerateColumns = true;
            ManageCategoryTabPaginationButtonsState();
            GenerateCategoryTabEditDeleteButtons();
            //// List<ConferanceCategory> conferenceCategory = _getConferanceCategory.GetConferencesCategory();

            //foreach (List<ConferanceCategory> conferance in conferenceCategory)
            //{
            //    CategoryName.Items.Add(conferance);
            //}
          
          //  addConferanceType(conferanceTypeModels);

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
        private void GenerateCategoryTabEditDeleteButtons()
        {
            DataGridViewButtonColumn buttonEdit = new DataGridViewButtonColumn();
            CategoryTabGrid.Columns.Add(buttonEdit);
            buttonEdit.HeaderText = "Edit";
            buttonEdit.Name = "Edit";
            buttonEdit.Text = "Edit";
            buttonEdit.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttonDelete = new DataGridViewButtonColumn();
            CategoryTabGrid.Columns.Add(buttonDelete);
            buttonDelete.HeaderText = "Delete";
            buttonDelete.Name = "Delete";
            buttonDelete.Text = "Delete";
            buttonDelete.UseColumnTextForButtonValue = true;
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

        private void CategoryTabGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.CategoryTabGrid.Columns["ConferenceCategoryId"].Visible = false;
        }

        private void CategoryTabGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != CategoryTabGrid.Columns["Edit"].Index
                               || e.ColumnIndex != CategoryTabGrid.Columns["Delete"].Index) return;

            Int32 categoryId = (Int32)CategoryTabGrid[CategoryTabGrid.Columns["ConferenceCategoryId"].Index, e.RowIndex].Value;

            if (e.ColumnIndex == CategoryTabGrid.Columns["Edit"].Index)
            {
                //AddConferance addConferance = Program.ServiceProvider.GetService<AddConferance>();
                //addConferance.ConferenceId = categoryId;
                //addConferance.ShowDialog();
            }

            if (e.ColumnIndex == CategoryTabGrid.Columns["Delete"].Index)
            {
                //conferenceCategoryRepository.deleteCategory(categoryId);
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
            if (e.RowIndex < 0 ||( e.ColumnIndex != dataGridViewType.Columns["Edit"].Index && e.ColumnIndex != dataGridViewType.Columns["Delete"].Index)) return;


            Int32 typeId = (Int32)dataGridViewType[dataGridViewType.Columns["ConferenceTypeId"].Index, e.RowIndex].Value;


            if (e.ColumnIndex == dataGridViewType.Columns["Edit"].Index)
               
            {
                NewConferanceType newConferanceType = Program.ServiceProvider.GetService<NewConferanceType>();
                newConferanceType.ConferanceTypeId = typeId;
                newConferanceType.ShowDialog();
            }
            else
            {
                if(e.ColumnIndex == dataGridViewType.Columns["Delete"].Index)
                {
                    conferanceTypeRepository.deleteType(typeId);
                }
            }
           

        }

        private void AddConferance_Activated(object sender, EventArgs e)
        {
            conferanceTypeModels = conferanceTypeRepository.getAllTypes();
            conferanceTypePaginationHelper = new PaginationHelper<ConferenceTypeModel>(conferanceTypeModels, typeTabPageSize);

            dataGridViewType.DataSource = conferanceTypePaginationHelper.GetPage();
            dataGridViewType.AutoGenerateColumns = true;

            ManageTypeTabPaginationButtonsState();
            GenerateTypeTabEditAndDeleteButtons();

        }
    }
}

