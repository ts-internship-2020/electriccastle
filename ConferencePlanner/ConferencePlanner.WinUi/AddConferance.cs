using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.Helpers;
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

        private readonly IConferenceCategoryRepository conferenceCategoryRepository;

        private List<ConferenceCategoryModel> conferenceCategories;

        private PaginationHelper<ConferenceCategoryModel> categoryTabPaginationHelper;

        private int categoryTabPageSize = 5;

        public int? ConferenceId { get; set; }

        public AddConferance(IConferanceCategory getConferanceCategory,
                             IConferenceCategoryRepository conferenceCategoryRepository)
        {
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
            ////Check to ensure that the row CheckBox is clicked.
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
            // mai trebuie ManageOrganizerPaginationButtonsState()
            GenerateCategoryTabEditDeleteButtons();
            // List<ConferanceCategory> conferenceCategory = _getConferanceCategory.GetConferencesCategory();

            //foreach (List<ConferanceCategory> conferance in conferenceCategory)
            //{
            //    CategoryName.Items.Add(conferance);
            //}
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
    }
}

