using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using System.Net;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Linq;

namespace ConferencePlanner.WinUi
{
    public partial class SpeakerForm : Form
    {

        private readonly ISpeakerDetailRepository _getSpeakerDetailRepository;

        //private List<SpeakerDetailModel> speakerDetail;

        public SpeakerForm(ISpeakerDetailRepository _getSpeakerDetailRepository)
        {
            this._getSpeakerDetailRepository = _getSpeakerDetailRepository;
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SpeakerForm_Load(object sender, EventArgs e)
        {
            int i;
            int nrElements;
            SpeakerDetailModel listElement;

            List<SpeakerDetailModel> speakerDetail = _getSpeakerDetailRepository.GetSpeakerDetail();
            nrElements = speakerDetail.Count;
            
            for (i = 0; i < nrElements; i++)
            {
                listElement = speakerDetail.ElementAt(i);
                if (MainScreen.SetValueIdSpeker.ToString() == listElement.Id.ToString())
                {
                    speakerNameText.Text = listElement.Name.ToString();
                    speakerRatingText.Text = listElement.Rating.ToString();
                    speakerNationalityText.Text = listElement.Nationality.ToString(); 
                    pictureSpeaker.LoadAsync(listElement.Picture.ToString());

                }
            }

        }

        private void SpeakerRating_Click(object sender, EventArgs e)
        {

        }
    }
}
