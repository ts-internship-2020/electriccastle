using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System.Globalization;

//using System.Text.RegularExpression;

namespace ConferencePlanner.WinUi
{
    public partial class EditSpeakerForm : Form
    {
        public static SpeakerModel modifiedSpeaker;
        private readonly ISpeakerRepository _getSpeakerRepository;

        public EditSpeakerForm(ISpeakerRepository _getSpeakerRepository)
        {
            this._getSpeakerRepository = _getSpeakerRepository;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EditSpeakerForm_Load(object sender, EventArgs e)
        {
            editSpeakerCodeTextBox.Text = AddConferance.editedSpeaker.Code.ToString();
            editSpeakerNameTextBox.Text = AddConferance.editedSpeaker.Name.ToString();
            editSpeakerRatingTextBox.Text = AddConferance.editedSpeaker.Rating.ToString();
            editSpeakerNationalityTextBox.Text = AddConferance.editedSpeaker.Nationality.ToString();
            editSpeakerPictureTextBox.Text = AddConferance.editedSpeaker.Picture.ToString();



        }

        private void editSpeakerCodeTextBox_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void editSpeakerCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(editSpeakerCodeTextBox.Text == string.Empty)
            {
                errorProviderEditSpeakerCode.SetError(editSpeakerCodeTextBox,"Please Enter Code");
            }
            else
            {
                errorProviderEditSpeakerCode.SetError(editSpeakerCodeTextBox, "");
            }
        }

        private void editSpeakerNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            
            if (editSpeakerNameTextBox.Text == string.Empty)
            {
                errorProviderEditSpeakerName.SetError(editSpeakerNameTextBox, "Please Enter Name");
            }
            else
            {
                errorProviderEditSpeakerName.SetError(editSpeakerNameTextBox, "");
            }

        }

        private void editSpeakerRatingTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal nr;
            if (editSpeakerRatingTextBox.Text == string.Empty)
            {
                errorProviderEditSpeakerRating.SetError(editSpeakerRatingTextBox, "Please Enter Rating");
            }
            else if (!( decimal.TryParse(editSpeakerRatingTextBox.Text, out nr)))
            {
                errorProviderEditSpeakerRating.SetError(editSpeakerRatingTextBox, "Please Enter Decimal");
            }
            else
            {
                errorProviderEditSpeakerRating.SetError(editSpeakerRatingTextBox, "");
            }


        }

        private void editSpeakerNationalityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (editSpeakerNationalityTextBox.Text == string.Empty)
            {
                errorProviderEditSpeakerNationality.SetError(editSpeakerNationalityTextBox, "Please Enter Nationality");
            }
            else
            {
                errorProviderEditSpeakerNationality.SetError(editSpeakerNationalityTextBox, "");
            }
        }

        private void editSpeakerPictureTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (editSpeakerPictureTextBox.Text == string.Empty)
            {
                errorProviderEditSpeakerPicture.SetError(editSpeakerPictureTextBox, "Please Enter Picture Link");
            }
            else
            {
                errorProviderEditSpeakerPicture.SetError(editSpeakerPictureTextBox, "");
            }
        }

        private void saveEditSpeaker_Click(object sender, EventArgs e)
        {
            //dcvff
            
        }

        private void butonCircular1_Click(object sender, EventArgs e)
        {
            decimal number;
            number = decimal.Parse(editSpeakerRatingTextBox.Text);

            if (errorProviderEditSpeakerName.GetError(editSpeakerNameTextBox) == "" &&
               errorProviderEditSpeakerPicture.GetError(editSpeakerPictureTextBox) == "" &&
               errorProviderEditSpeakerNationality.GetError(editSpeakerNationalityTextBox) == "" &&
               errorProviderEditSpeakerCode.GetError(editSpeakerCodeTextBox) == "" &&
               errorProviderEditSpeakerRating.GetError(editSpeakerRatingTextBox) == ""
               )
            {
                //modifiedSpeaker.Id = AddConferance.editedSpeaker.Id;
                //modifiedSpeaker.Code = editSpeakerCodeTextBox.Text;
                //modifiedSpeaker.Name = editSpeakerNameTextBox.Text;
                //modifiedSpeaker.Rating = number;
                //modifiedSpeaker.Nationality = editSpeakerNationalityTextBox.Text;
                //modifiedSpeaker.Picture = editSpeakerPictureTextBox.Text;

                _getSpeakerRepository.editSpeaker(AddConferance.editedSpeaker.Id, editSpeakerCodeTextBox.Text, editSpeakerNameTextBox.Text, number, editSpeakerNationalityTextBox.Text, editSpeakerPictureTextBox.Text);
                this.Close();

            }
        }
    }
}
