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
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConferencePlanner.WinUi
{
    public partial class SpeakerForm : Form
    {

        private readonly ISpeakerDetailRepository _getSpeakerDetailRepository;


        public SpeakerForm(ISpeakerDetailRepository _getSpeakerDetailRepository)
        {
            this._getSpeakerDetailRepository = _getSpeakerDetailRepository;
            InitializeComponent();
        }

        private async Task<List<SpeakerDetailModel>> GetResponseSpeakerDetail()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage msg = await client.GetAsync("http://localhost:2794/api/SpeakerDetail");
            List<SpeakerDetailModel> speakers = new List<SpeakerDetailModel>();
            if (msg.IsSuccessStatusCode)
            {
                string response = await msg.Content.ReadAsStringAsync();
                speakers = JsonConvert.DeserializeObject<List<SpeakerDetailModel>>(response);
            }
            return speakers;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void SpeakerForm_Load(object sender, EventArgs e)
        {
            int i;
            int nrElements;
            SpeakerDetailModel listElement;

            List<SpeakerDetailModel> speakerDetail = await GetResponseSpeakerDetail();
            nrElements = speakerDetail.Count;
            
            for (i = 0; i < nrElements; i++)
            {
                listElement = speakerDetail.ElementAt(i);
                if (MainScreen.SetValueIdSpeker == listElement.Name)
                {
                    speakerNameText.Text = listElement.Name.ToString();
                    speakerRatingText.Text = listElement.Rating.ToString();
                    speakerNationalityText.Text = listElement.Nationality.ToString(); 
                    pictureSpeaker.LoadAsync(listElement.Picture.ToString());
                    break;
                }
            }

        }
    }
}
