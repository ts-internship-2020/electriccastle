using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConferencePlanner.Abstraction.ParticipantRepository;
using ConferencePlanner.Abstraction.ParticipantsModel;

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


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ParticipantsConferencesModel> conferenceParticipants = _getParticipantRepository.GetParticipantsConferences();

            ConferencesParticipant.Rows[0].Cells[0].Value = conferenceParticipants.FirstOrDefault().Name.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ConferencesParticipant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var conferenceParticipants = _getParticipantRepository.GetParticipantsConferences();
            ConferencesParticipant.DataSource = conferenceParticipants;
            //ColumnNameConferenceParticipant.DisplayMember = ;

        }

        private void AddConferenceButton_Click(object sender, EventArgs e)
        {
            _getParticipantRepository.test();
        }
    }
}