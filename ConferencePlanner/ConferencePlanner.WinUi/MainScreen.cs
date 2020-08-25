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

        int scrollVal;

        public MainScreen(IParticipantsConferencesRepository _getParticipantRepository, IOrganizerConferencesRepository organizerConferencesRepository)
        {
            this._getParticipantRepository = _getParticipantRepository;
            this.organizerConferencesRepository = organizerConferencesRepository;
            scrollVal = 0;
            InitializeComponent();
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
            int i;
            int numberRowsPage = 7;
            int numberRowsRemain = scrollVal % numberRowsPage;
            if(numberRowsRemain !=0)
            {
                numberRowsPage = numberRowsRemain;
            }
            for (i = 0; i < numberRowsPage; i++)
            {
                var listElement = conferenceParticipants.ElementAt(scrollVal+i);
                int n = ConferencesParticipant.Rows.Add();
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
            


            List<OrganizerConferencesModel> organizerConferences = organizerConferencesRepository.GetConferencesForOrganizer(EmailParticipants);
            OrganizerGrid.DataSource = organizerConferences;
            OrganizerGrid.AutoGenerateColumns = true;
        }

        

        private void NextButtonParticipant_Click(object sender, EventArgs e)
        {
            List<ParticipantsConferencesModel> conferenceParticipants = _getParticipantRepository.GetParticipantsConferences();
            scrollVal = scrollVal + 5;
            if(scrollVal > 5)
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
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Attended";
            }
            else if(e.ColumnIndex == 8)
            {
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Joined";
                Form f = new WebViewConnection();
                f.Show();

            }
            else if (e.ColumnIndex == 9)
            {
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Withdraw";
            }

            if (e.ColumnIndex == 6)
            {

                //string text = "My text that I want to display";
                //MessageBox.Show(text);
            }
        }

        private void AddConferenceButton_Click(object sender, EventArgs e)
        {
            //_getParticipantRepository.test();

        }
    }
}