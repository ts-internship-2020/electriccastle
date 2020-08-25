﻿using System;
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

        public MainScreen(IParticipantsConferencesRepository _getParticipantRepository, IOrganizerConferencesRepository organizerConferencesRepository)
        {
            this._getParticipantRepository = _getParticipantRepository;
            this.organizerConferencesRepository = organizerConferencesRepository;
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
                ConferencesParticipant.Rows[n].Cells[7].Value = "Attend";
                ConferencesParticipant.Rows[n].Cells[8].Value = "Join";
                ConferencesParticipant.Rows[n].Cells[9].Value = "Withdraw";
                conferenceParticipants.RemoveAt(0);
            }

            List<OrganizerConferencesModel> organizerConferences = organizerConferencesRepository.GetConferencesForOrganizer(EmailParticipants);
            OrganizerGrid.DataSource = organizerConferences;
            OrganizerGrid.AutoGenerateColumns = true;
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
        }

        private void AddConferenceButton_Click(object sender, EventArgs e)
        {
            //_getParticipantRepository.test();

        }
    }
}