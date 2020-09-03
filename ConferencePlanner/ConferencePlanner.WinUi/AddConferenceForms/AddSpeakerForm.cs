using ConferencePlanner.Abstraction.ElectricCastleModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConferencePlanner.WinUi
{
    public partial class AddSpeakerForm : Form
    {
        public static SpeakerModel addedSpeaker;
        private readonly ISpeakerRepository _getSpeakerRepository;
        public AddSpeakerForm(ISpeakerRepository _getSpeakerRepository)
        {
            this._getSpeakerRepository = _getSpeakerRepository;
            InitializeComponent();
        }

        private void newSpeakerName_Click(object sender, EventArgs e)
        {

        }

        private void NewSpeaker_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async Task PostAddSpeaker()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage msg = await client.GetAsync("http://localhost:2794/DictionarySpeaker/AddSpeaker");
            if (msg.IsSuccessStatusCode)
            {
                string response = await msg.Content.ReadAsStringAsync();
            }

        }

        private void saveAddSpeaker_Click(object sender, EventArgs e)
        {
            decimal number;
            number = decimal.Parse(newSpeakerRatingTextBox.Text);

            if (errorProviderAddSpeakerName.GetError(newSpeakerNameTextBox) == "" &&
               errorProviderAddSpeakerPicture.GetError(newSpeakerPictureTextBox) == "" &&
               errorProviderAddSpeakerNationality.GetError(newSpeakerNationalityTextBox) == "" &&
               errorProviderAddSpeakerCode.GetError(newSpeakerCodeTextBox) == "" &&
               errorProviderAddSpeakerRating.GetError(newSpeakerRatingTextBox) == ""
               )
            {
                //addedSpeaker.Id = AddConferance.maxIdSpeaker + 1;
                //addedSpeaker.Code = newSpeakerCodeTextBox.Text;
                //addedSpeaker.Name = newSpeakerNameTextBox.Text;
                //addedSpeaker.Rating = number;
                //addedSpeaker.Nationality = newSpeakerNationalityTextBox.Text;
                //addedSpeaker.Picture = newSpeakerPictureTextBox.Text;
                PostAddSpeaker();
       
                    _getSpeakerRepository.addSpeaker(AddConferance.maxIdSpeaker + 1, newSpeakerCodeTextBox.Text, newSpeakerNameTextBox.Text, number, newSpeakerNationalityTextBox.Text, newSpeakerPictureTextBox.Text);
                this.Close();
            }
        }

        private void newSpeakerCodeTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (newSpeakerCodeTextBox.Text == string.Empty)
            {
                errorProviderAddSpeakerCode.SetError(newSpeakerCodeTextBox, "Please Enter Code");
            }
            else
            {
                errorProviderAddSpeakerCode.SetError(newSpeakerCodeTextBox, "");
            }

        }

        private void newSpeakerNameTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (newSpeakerNameTextBox.Text == string.Empty)
            {
                errorProviderAddSpeakerName.SetError(newSpeakerNameTextBox, "Please Enter Name");
            }
            else
            {
                errorProviderAddSpeakerName.SetError(newSpeakerNameTextBox, "");
            }

        }

        private void newSpeakerRatingTextBox_Validating(object sender, CancelEventArgs e)
        {

            decimal nr;
            if (newSpeakerRatingTextBox.Text == string.Empty)
            {
                errorProviderAddSpeakerRating.SetError(newSpeakerRatingTextBox, "Please Enter Rating");
            }
            else if (!(decimal.TryParse(newSpeakerRatingTextBox.Text, out nr)))
            {
                errorProviderAddSpeakerRating.SetError(newSpeakerRatingTextBox, "Please Enter Decimal");
            }
            else
            {
                errorProviderAddSpeakerRating.SetError(newSpeakerRatingTextBox, "");
            }

        }

        private void newSpeakerNationalityTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (newSpeakerNationalityTextBox.Text == string.Empty)
            {
                errorProviderAddSpeakerNationality.SetError(newSpeakerNationalityTextBox, "Please Enter Nationality");
            }
            else
            {
                errorProviderAddSpeakerNationality.SetError(newSpeakerNationalityTextBox, "");
            }

        }

        private void newSpeakerPictureTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (newSpeakerPictureTextBox.Text == string.Empty)
            {
                errorProviderAddSpeakerPicture.SetError(newSpeakerPictureTextBox, "Please Enter Picture");
            }
            else
            {
                errorProviderAddSpeakerPicture.SetError(newSpeakerPictureTextBox, "");
            }

        }
    }
}
