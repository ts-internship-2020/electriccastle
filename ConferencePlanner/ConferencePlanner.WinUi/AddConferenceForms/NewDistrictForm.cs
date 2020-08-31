using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Windows.UI.Xaml.Controls;

namespace ConferencePlanner.WinUi
{
    public partial class NewDistrictForm : Form
    {
        private readonly IAddConferenceDistrictRepository conferenceDistrictRepository;

        private readonly IAddConferenceCountryRepository conferenceCountryRepository;

        private List<AddConferenceCountryModel> countries;

        private Regex onlyLettersRegex = new Regex(@"^[a-zA-Z]+$");

        public int? DistrictId { get; set; }

        public NewDistrictForm(IAddConferenceDistrictRepository conferenceDistrictRepository,
                               IAddConferenceCountryRepository conferenceCountryRepository)
        {
            InitializeComponent();
            this.conferenceDistrictRepository = conferenceDistrictRepository;
            this.conferenceCountryRepository = conferenceCountryRepository;
        }

        private void NewDistrictForm_Load(object sender, EventArgs e)
        {
            countries = conferenceCountryRepository.GetConferencesCountry();
            CountryComboBox.DataSource = countries;
            CountryComboBox.DisplayMember = "DictionaryCountryName";
            CountryComboBox.ValueMember = "DictionaryCountryId";
            if (DistrictId == null)
            {
                DistrictId = conferenceDistrictRepository.GetNextId();
                DistrictNameTextBox.Text = "";
                DistrictCodeTextBox.Text = "";
                SaveButton.Click += new EventHandler(AddDistrict);
                CountryComboBox.SelectedIndex = 0;
            }
            else
            {
                AddConferenceDistrictModel district = conferenceDistrictRepository.GetDistrict((int)DistrictId);
                DistrictNameTextBox.Text = district.DictionaryDistrictName;
                DistrictCodeTextBox.Text = district.DistrictCode;
                SaveButton.Click += new EventHandler(EditDistrict);
                CountryComboBox.SelectedValue = district.DictionaryCountryId;
            }
        }

        private void AddDistrict(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                conferenceDistrictRepository.InsertConferenceDistrict(new AddConferenceDistrictModel
                {
                    DictionaryDistrictId = (int)DistrictId,
                    DictionaryDistrictName = DistrictNameTextBox.Text,
                    DistrictCode = DistrictCodeTextBox.Text,
                    DictionaryCountryId = (int)CountryComboBox.SelectedValue
                });
                Close();
            }
        }

        private void EditDistrict(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                conferenceDistrictRepository.UpdateConferenceDistrict(new AddConferenceDistrictModel
                {
                    DictionaryDistrictId = (int)DistrictId,
                    DictionaryDistrictName = DistrictNameTextBox.Text,
                    DistrictCode = DistrictCodeTextBox.Text,
                    DictionaryCountryId = (int)CountryComboBox.SelectedValue
                });
                Close();
            }
        }

        private void DistrictNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!onlyLettersRegex.IsMatch(DistrictNameTextBox.Text))
            {
                e.Cancel = true;
                DistrictNameTextBox.Focus();
                errorProviderDistrictName.SetError(DistrictNameTextBox, "The name should only contain letters");
            }
            else if (DistrictNameTextBox.TextLength == 0)
            {
                e.Cancel = true;
                DistrictNameTextBox.Focus();
                errorProviderDistrictName.SetError(DistrictNameTextBox, "You have to introduce the name");
            }
            else if (DistrictNameTextBox.TextLength <= 3)
            {
                e.Cancel = true;
                DistrictNameTextBox.Focus();
                errorProviderDistrictName.SetError(DistrictNameTextBox, "Such country does not exist");
            }
            else
            {
                e.Cancel = false;
                errorProviderDistrictName.SetError(DistrictNameTextBox, "");
            }

        }

        private void DistrictCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!onlyLettersRegex.IsMatch(DistrictCodeTextBox.Text))
            {
                e.Cancel = true;
                DistrictCodeTextBox.Focus();
                errorProviderDistrictCode.SetError(DistrictCodeTextBox, "The code should contain only letters");
            }
            else if (DistrictCodeTextBox.TextLength == 0)
            {
                e.Cancel = true;
                DistrictCodeTextBox.Focus();
                errorProviderDistrictCode.SetError(DistrictCodeTextBox, "You have to introduce the code");
            }
            else if (DistrictCodeTextBox.TextLength == 1)
            {
                e.Cancel = true;
                DistrictCodeTextBox.Focus();
                errorProviderDistrictCode.SetError(DistrictCodeTextBox, "This code is not explicit");
            }
            else
            {
                e.Cancel = false;
                errorProviderDistrictCode.SetError(DistrictCodeTextBox, "");
            }
        }

        private void NewDistrictForm_Activated(object sender, EventArgs e)
        {
            errorProviderDistrictName.SetError(DistrictNameTextBox, "");
            errorProviderDistrictCode.SetError(DistrictCodeTextBox, "");
        }
    }
}
