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


namespace ConferencePlanner.WinUi
{
    public partial class MainScreen : Form
    {
        private readonly IParticipantsConferencesRepository _getParticipantRepository;

        public MainScreen(IParticipantsConferencesRepository _getParticipantRepository)
        {
            this._getParticipantRepository = _getParticipantRepository;
            InitializeComponent();
        }

        private void BackButtonParticipant_Click(object sender, EventArgs e)
        {

        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            List<ParticipantsConferencesModel> conferenceParticipants = _getParticipantRepository.GetParticipantsConferences();
            int nr = conferenceParticipants.Count;
            int i;
            for (i = 0; i <nr; i++)
            {
                int n = ConferencesParticipant.Rows.Add();
                ConferencesParticipant.Rows[n].Cells[0].Value = conferenceParticipants.FirstOrDefault().Name.ToString();
                ConferencesParticipant.Rows[n].Cells[1].Value = conferenceParticipants.FirstOrDefault().StartDate.ToString();
                ConferencesParticipant.Rows[n].Cells[2].Value = conferenceParticipants.FirstOrDefault().EndDate.ToString();
                ConferencesParticipant.Rows[n].Cells[3].Value = conferenceParticipants.FirstOrDefault().ConferenceType.ToString();
                ConferencesParticipant.Rows[n].Cells[4].Value = conferenceParticipants.FirstOrDefault().ConferenceCategory.ToString();
                ConferencesParticipant.Rows[n].Cells[5].Value = conferenceParticipants.FirstOrDefault().Address.ToString();
                ConferencesParticipant.Rows[n].Cells[6].Value = conferenceParticipants.FirstOrDefault().Speaker.ToString();
                conferenceParticipants.RemoveAt(0);
            }



        }

        

        private void NextButtonParticipant_Click(object sender, EventArgs e)
        {

        }

        private void DatePickerParticipantStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FilterParticipants_Click(object sender, EventArgs e)
        {

        }

        private void ConferencesParticipant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddConferenceButton_Click(object sender, EventArgs e)
        {
            //_getParticipantRepository.test();
        }
    }
}