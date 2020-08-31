using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConferencePlanner.WinUi
{
    public partial class AddEditConferenceCategoryScreen : Form
    {
        private readonly IConferenceCategoryRepository conferenceCategoryRepository;

        public int? CategoryId { get; set; }

        public AddEditConferenceCategoryScreen(IConferenceCategoryRepository conferenceCategoryRepository)
        {
            InitializeComponent();
            this.conferenceCategoryRepository = conferenceCategoryRepository;
        }

        private void AddEditConferenceCategory_Load(object sender, EventArgs e)
        {
            if (CategoryId == null)
            {
                CategoryId = conferenceCategoryRepository.GetNextId();
                SaveButton.Click += new EventHandler(AddConferenceCategory);
                CategoryNameTextBox.Text = "";
                CategoryCodeTextBox.Text = "";
            }
            else
            {
                ConferenceCategoryModel category = conferenceCategoryRepository.GetCategory((int)CategoryId);
                CategoryNameTextBox.Text = category.ConferenceCategoryName;
                CategoryCodeTextBox.Text = category.ConferenceCategoryCode;
                SaveButton.Click += new EventHandler(EditConferenceCategory);
            }
        }

        private void AddConferenceCategory(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                conferenceCategoryRepository.AddCategory(new ConferenceCategoryModel
                {
                    ConferenceCategoryId = (int)CategoryId,
                    ConferenceCategoryName = CategoryNameTextBox.Text,
                    ConferenceCategoryCode = CategoryCodeTextBox.Text
                });
                Close();
            }
        }

        private void EditConferenceCategory(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                conferenceCategoryRepository.EditCategory(new ConferenceCategoryModel
                {
                    ConferenceCategoryId = (int)CategoryId,
                    ConferenceCategoryName = CategoryNameTextBox.Text,
                    ConferenceCategoryCode = CategoryCodeTextBox.Text
                });
                Close();
            }
        }

        private void CategoryNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CategoryNameTextBox.Text))
            {
                e.Cancel = true;
                CategoryNameTextBox.Focus();
                CategoryNameTextBoxErrorProvider.SetError(CategoryNameTextBox, "Field is mandatory!");
            }
            else
            {
                e.Cancel = false;
                CategoryNameTextBoxErrorProvider.SetError(CategoryNameTextBox, "");
            }
        }

        private void CategoryCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CategoryCodeTextBox.Text))
            {
                e.Cancel = true;
                CategoryCodeTextBox.Focus();
                CategoryCodeTextBoxErrorProvider.SetError(CategoryCodeTextBox, "Field is mandatory!");
            }
            else if (CategoryCodeTextBox.Text.Length > 10)
            {
                e.Cancel = true;
                CategoryCodeTextBox.Focus();
                CategoryCodeTextBoxErrorProvider.SetError(CategoryCodeTextBox, "Code has a maximum length of 10 characters!");
            }
            else
            {
                e.Cancel = false;
                CategoryCodeTextBoxErrorProvider.SetError(CategoryCodeTextBox, "");
            }
        }

        private void AddEditConferenceCategoryScreen_Activated(object sender, EventArgs e)
        {
            CategoryNameTextBoxErrorProvider.SetError(CategoryNameTextBox, "");
            CategoryCodeTextBoxErrorProvider.SetError(CategoryCodeTextBox, "");
        }
    }
}
