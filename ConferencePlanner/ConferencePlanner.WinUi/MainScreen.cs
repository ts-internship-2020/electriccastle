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
using static ConferencePlanner.WinUi.Program;


namespace ConferencePlanner.WinUi
{
    public partial class MainScreen : Form
    {
        private readonly IParticipantsConferencesRepository _getParticipantRepository;

        private readonly IOrganizerConferencesRepository organizerConferencesRepository;

        public List<OrganizerConferencesModel> organizerConferences { get; set; }

        int scrollVal;

        public MainScreen(IParticipantsConferencesRepository _getParticipantRepository, IOrganizerConferencesRepository organizerConferencesRepository)
        {
            this._getParticipantRepository = _getParticipantRepository;
            this.organizerConferencesRepository = organizerConferencesRepository;
            scrollVal = 0;
            InitializeComponent();
            organizerConferences = organizerConferencesRepository.GetConferencesForOrganizer(EmailParticipants);
        }

        private void BackButtonParticipant_Click(object sender, EventArgs e)
        {
            List<ParticipantsConferencesModel> conferenceParticipants = _getParticipantRepository.GetParticipantsConferences();
            scrollVal = scrollVal - 5;
            if(scrollVal < 0)
            {
                scrollVal = 0;
            }
            populateGridParticipants(conferenceParticipants, scrollVal);


        }

        void populateGridParticipants(List<ParticipantsConferencesModel> conferenceParticipants, int scrollVal)
        {
            ConferencesParticipant.Rows.Clear();
            int nr = conferenceParticipants.Count;
            int i;
            int numberRowsPage = 5;
            if(nr - scrollVal < numberRowsPage)
            {
                numberRowsPage = nr - scrollVal;
            }
            for (i = 0; i < numberRowsPage; i++)
            {
                int n = ConferencesParticipant.Rows.Add();
                ParticipantsConferencesModel listElement = conferenceParticipants.ElementAt(scrollVal+i);

                ConferencesParticipant.Rows[n].Cells[0].Value = listElement.Name.ToString();
                ConferencesParticipant.Rows[n].Cells[1].Value = listElement.StartDate.ToString();
                ConferencesParticipant.Rows[n].Cells[2].Value = listElement.EndDate.ToString();
                ConferencesParticipant.Rows[n].Cells[3].Value = listElement.ConferenceType.ToString();
                ConferencesParticipant.Rows[n].Cells[4].Value = listElement.ConferenceCategory.ToString();
                ConferencesParticipant.Rows[n].Cells[5].Value = listElement.Address.ToString();
                ConferencesParticipant.Rows[n].Cells[6].Value = listElement.Speaker.ToString();
                ConferencesParticipant.Rows[n].Cells[7].Value = "Attend";
                ConferencesParticipant.Rows[n].Cells[8].Value = "Join";
                ConferencesParticipant.Rows[n].Cells[9].Value = "Withdraw";
                ConferencesParticipant.Rows[n].Cells[10].Value = listElement.StateName.ToString();


            }

        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            List<ParticipantsConferencesModel> conferenceParticipants = _getParticipantRepository.GetParticipantsConferences();

            populateGridParticipants(conferenceParticipants,scrollVal);
 


            OrganizerGrid.DataSource = organizerConferences;
            OrganizerGrid.AutoGenerateColumns = true;
        }

        private void NextButtonParticipant_Click(object sender, EventArgs e)
        {
            List<ParticipantsConferencesModel> conferenceParticipants = _getParticipantRepository.GetParticipantsConferences();
            int nr = conferenceParticipants.Count;
            scrollVal = scrollVal + 5;
            if(scrollVal >= nr)
            {
                scrollVal = scrollVal - 5;
            }
            populateGridParticipants(conferenceParticipants, scrollVal);
        }

        private void DatePickerParticipantStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FilterParticipants_Click(object sender, EventArgs e)
        {

        }

        private void ConferencesParticipant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7 )
            {
                    ConferencesParticipant.Rows[e.RowIndex].Cells[7].Style.BackColor = System.Drawing.Color.GreenYellow;
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Attended";
            }
            else if(e.ColumnIndex == 8)
            {
                
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Joined";
                DateTime oDate = Convert.ToDateTime(ConferencesParticipant.Rows[e.RowIndex].Cells[1].Value);
                TimeSpan ts = oDate - DateTime.Now;
                if (ts.TotalMinutes <= 5)
                    ConferencesParticipant.Rows[e.RowIndex].Cells[8].Style.BackColor = System.Drawing.Color.Green;

                //if (ts.TotalMinutes > 5)
                //    ConferencesParticipant.Rows[e.RowIndex].Cells[8].Visible = false;
                Form f = new WebViewConnection();
                f.Show();

            }
            else if (e.ColumnIndex == 9)
            {
                DateTime oDate = Convert.ToDateTime(ConferencesParticipant.Rows[e.RowIndex].Cells[1].Value);
                TimeSpan ts = oDate - DateTime.Now;
                if (ts.TotalMinutes >= 6)
                    ConferencesParticipant.Rows[e.RowIndex].Cells[9].Style.BackColor = System.Drawing.Color.Red;
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Withdraw";
            }

            if (e.ColumnIndex == 6)
            {
                Form formSpeaker = new SpeakerForm();
                formSpeaker.Show();
 
            }
        }

        private void AddConferenceButton_Click(object sender, EventArgs e)
        {
            //_getParticipantRepository.test();

        }

        private void OrganizerStartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            OrganizerGrid.DataSource = organizerConferences.Where(conference => conference.StartDate >= OrganizerStartDatePicker.Value).ToList();
        }

        private void OrganizerEndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            OrganizerGrid.DataSource = organizerConferences.Where(conference => conference.EndDate <= OrganizerEndDatePicker.Value).ToList();
        }

        private void OrganizerFilterButton_Click(object sender, EventArgs e)
        {
            OrganizerGrid.DataSource = organizerConferences.Where(conference => conference.StartDate >= OrganizerStartDatePicker.Value
                                                                             && conference.EndDate <= OrganizerEndDatePicker.Value).ToList();
        }
    }
}