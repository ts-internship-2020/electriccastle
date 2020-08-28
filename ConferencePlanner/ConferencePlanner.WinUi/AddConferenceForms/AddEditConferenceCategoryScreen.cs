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
                CategoryId = conferenceCategoryRepository.getNextId();
                SaveButton.Click += new EventHandler(AddConferenceCategory);
            }
            else
            {
                ConferenceCategoryModel category = conferenceCategoryRepository.getCategory((int)CategoryId);
                CategoryNameTextBox.Text = category.ConferenceCategoryName;
                CategoryCodeTextBox.Text = category.ConferenceCategoryCode;
                SaveButton.Click += new EventHandler(EditConferenceCategory);
            }
        }

        private void AddConferenceCategory(object sender, EventArgs e)
        {
            conferenceCategoryRepository.addCategory(new ConferenceCategoryModel
            {
                ConferenceCategoryId = (int)CategoryId,
                ConferenceCategoryName = CategoryNameTextBox.Text,
                ConferenceCategoryCode = CategoryCodeTextBox.Text
            });
            this.Close();
        }

        private void EditConferenceCategory(object sender, EventArgs e)
        {
            conferenceCategoryRepository.editCategory(new ConferenceCategoryModel
            {
                ConferenceCategoryId = (int)CategoryId,
                ConferenceCategoryName = CategoryNameTextBox.Text,
                ConferenceCategoryCode = CategoryCodeTextBox.Text
            });
            this.Close();
        }
    }
}
