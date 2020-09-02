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
using ConferencePlanner.Abstraction.Helpers;
using static ConferencePlanner.WinUi.Program;
using Microsoft.Extensions.DependencyInjection;
using static ConferencePlanner.WinUi.Program;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConferencePlanner.WinUi
{
   
   

    public partial class MainScreen : Form
    {
        //private string emailParticipantLogare;

        private readonly IParticipantsConferencesRepository _getParticipantRepository;

        private readonly IOrganizerConferencesRepository organizerConferencesRepository;

        private List<OrganizerConferencesModel> organizerConferences;

        private PaginationHelper<OrganizerConferencesModel> paginationHelper;

        private readonly IEmailParticipant _email;

        private List<ParticipantsConferencesModel> conferences;

        private int pageSize = 2;

        private int scrollVal;

        private int numberEntry;

        public static int SetValueIdSpeker = 0;

        public object QRCodeGenerator { get; private set; }

        public MainScreen(IParticipantsConferencesRepository _getParticipantRepository,
            IOrganizerConferencesRepository organizerConferencesRepository,
            IEmailParticipant _emailPart
            )
        {
            this._getParticipantRepository = _getParticipantRepository;
            this.organizerConferencesRepository = organizerConferencesRepository;
            this._email = _emailPart;
            scrollVal = 0;
            InitializeComponent();
            
        }

       
        void populateGridParticipants(List<ParticipantsConferencesModel> conferenceParticipants, int scrollVal, int entries)
        {
           
            ConferencesParticipant.Rows.Clear();
            int nr = conferenceParticipants.Count;
            int i;
            int numberRowsPage = entries;
            if (numberRowsPage > nr)
            {
                numberRowsPage = nr;
            }
            if (nr - scrollVal < numberRowsPage)
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

        private async Task GetResponseParticipantsConference()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage msg = await client.GetAsync("http://localhost:2794/ConferenceParticipants/ParticipantsConference");
            if (msg.IsSuccessStatusCode)
            {
                string response = await msg.Content.ReadAsStringAsync();
            }

        }

        private async Task PostParticipantsConferenceState()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage msg = await client.GetAsync("http://localhost:2794/ConferenceParticipants/ParticipantState");
            if (msg.IsSuccessStatusCode)
            {
                string response = await msg.Content.ReadAsStringAsync();
            }

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            GetResponseParticipantsConference();
            conferences = _getParticipantRepository.GetParticipantsConferences();
            numberEntry = Convert.ToInt32(entryPageTextBox.Text);
            populateGridParticipants(conferences, scrollVal, numberEntry);

            organizerConferences = this.organizerConferencesRepository.GetConferencesForOrganizer(EmailParticipants);
            paginationHelper = new PaginationHelper<OrganizerConferencesModel>(organizerConferences, pageSize);
            OrganizerGrid.DataSource = paginationHelper.GetPage();
            OrganizerGrid.AutoGenerateColumns = true;
            GenerateOrganizerEditButtons();
            ManageOrganizerPaginationButtonsState();
        }
        
        private void GenerateOrganizerEditButtons()
        {
            DataGridViewButtonColumn buttonEdit = new DataGridViewButtonColumn();
            OrganizerGrid.Columns.Add(buttonEdit);
            buttonEdit.HeaderText = "Edit";
            buttonEdit.Name = "Edit";
            buttonEdit.Text = "Edit";
            buttonEdit.UseColumnTextForButtonValue = true;
        }
      
        private void DatePickerParticipantStart_ValueChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            List<ParticipantsConferencesModel> conferenceParticipants = _getParticipantRepository.GetParticipantsConferences();
            conferences = conferenceParticipants.Where(conference => conference.StartDate >= DatePickerParticipantStart.Value).ToList();
            populateGridParticipants(conferences, scrollVal, numberEntry);

        }

        private void DatePickerParticipantEnd_ValueChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            List<ParticipantsConferencesModel> conferenceParticipants = _getParticipantRepository.GetParticipantsConferences();
            conferences = conferenceParticipants.Where(conference => conference.EndDate <= DatePickerParticipantEnd.Value).ToList();
            populateGridParticipants(conferences, scrollVal, numberEntry);
        }

        private void FilterParticipants_Click(object sender, EventArgs e)
        {
          
            scrollVal = 0;
            List<ParticipantsConferencesModel> conferenceParticipants = _getParticipantRepository.GetParticipantsConferences();
            conferences = conferenceParticipants.Where(conference => (conference.StartDate >= DatePickerParticipantStart.Value) && 
                                                        (conference.EndDate <= DatePickerParticipantEnd.Value) ).ToList();
            populateGridParticipants(conferences, scrollVal, numberEntry);
        }


        private void BackButtonParticipant_Click(object sender, EventArgs e)
        {

            
            scrollVal = scrollVal - numberEntry;
            if (scrollVal < 0)
            {
                scrollVal = 0;
            }
            populateGridParticipants(conferences, scrollVal, numberEntry);
        }

        private void NextButtonParticipant_Click(object sender, EventArgs e)
        {
            

            int nr = conferences.Count;
            scrollVal = scrollVal + numberEntry;
            if (scrollVal >= nr)
            {
                scrollVal = scrollVal - numberEntry;
            }
            populateGridParticipants(conferences, scrollVal, numberEntry);
        }

        private void OrganizerPreviousButton_Click(object sender, EventArgs e)
        {
            paginationHelper.PreviousPage();
            OrganizerGrid.DataSource = paginationHelper.GetPage();
            ManageOrganizerPaginationButtonsState();
        }

        private void OrganizerNextButton_Click(object sender, EventArgs e)
        {
            paginationHelper.NextPage();
            OrganizerGrid.DataSource = paginationHelper.GetPage();
            ManageOrganizerPaginationButtonsState();
        }

        private void OrganizerFilterButton_Click(object sender, EventArgs e)
        {
            List<OrganizerConferencesModel> filteredData = organizerConferences.Where(conference => conference.StartDate >= OrganizerStartDatePicker.Value
                                                                                                 && conference.EndDate <= OrganizerEndDatePicker.Value).ToList();
            paginationHelper = new PaginationHelper<OrganizerConferencesModel>(filteredData, pageSize);
            OrganizerGrid.DataSource = paginationHelper.GetPage();
            ManageOrganizerPaginationButtonsState();
        }
        private void ConferencesParticipant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _email.InsertEmailParticipantBD(e.RowIndex+1, EmailParticipants);

            if (e.ColumnIndex == 7)
            {
                PostParticipantsConferenceState();
                _getParticipantRepository.UpdateParticipantsConferencesState(e.ColumnIndex, EmailParticipants);
                ConferencesParticipant.Rows[e.RowIndex].Cells[7].Style.BackColor = System.Drawing.Color.GreenYellow;
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Attended";


            }

            else if (e.ColumnIndex == 8)
            {
                PostParticipantsConferenceState();
                _getParticipantRepository.UpdateParticipantsConferencesState(e.ColumnIndex, EmailParticipants);
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Joined";
                DateTime oDate = Convert.ToDateTime(ConferencesParticipant.Rows[e.RowIndex].Cells[1].Value);
                TimeSpan ts = oDate - DateTime.Now;
                if (ts.TotalMinutes <= 5)
                    ConferencesParticipant.Rows[e.RowIndex].Cells[8].Style.BackColor = System.Drawing.Color.Green;

                //if (ts.TotalMinutes > 5)
                //    ConferencesParticipant.Rows[e.RowIndex].Cells[8].di = false;
                Form f = new WebViewConnection();
                f.Show();

            }
            else if (e.ColumnIndex == 9)
            {
                PostParticipantsConferenceState();
                _getParticipantRepository.UpdateParticipantsConferencesState(e.ColumnIndex, EmailParticipants);
                DateTime oDate = Convert.ToDateTime(ConferencesParticipant.Rows[e.RowIndex].Cells[1].Value);
                TimeSpan ts = oDate - DateTime.Now;
                if (ts.TotalMinutes >= 6)
                    ConferencesParticipant.Rows[e.RowIndex].Cells[9].Style.BackColor = System.Drawing.Color.Red;
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Withdraw";

            }

            if (e.ColumnIndex == 6)
            {
                SetValueIdSpeker = conferences.ElementAt(e.RowIndex).Id;
                SpeakerForm sf = Program.ServiceProvider.GetService<SpeakerForm>();
                sf.ShowDialog();
            }

           
           
        }

     

        private void OrganizerStartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            List<OrganizerConferencesModel> filteredData = organizerConferences.Where(conference => conference.StartDate >= OrganizerStartDatePicker.Value).ToList();
            paginationHelper = new PaginationHelper<OrganizerConferencesModel>(filteredData, pageSize);
            OrganizerGrid.DataSource = paginationHelper.GetPage();
            ManageOrganizerPaginationButtonsState();
        }

        private void OrganizerEndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            List<OrganizerConferencesModel> filteredData = organizerConferences.Where(conference => conference.EndDate <= OrganizerEndDatePicker.Value).ToList();
            paginationHelper = new PaginationHelper<OrganizerConferencesModel>(filteredData, pageSize);
            OrganizerGrid.DataSource = paginationHelper.GetPage();
            ManageOrganizerPaginationButtonsState();
        }

        private void ManageOrganizerPaginationButtonsState()
        {
            OrganizerPreviousButton.Enabled = paginationHelper.HasPreviousPage();
            OrganizerNextButton.Enabled = paginationHelper.HasNextPage();
        }


        private void AddConferenceButton_Click_1(object sender, EventArgs e)
        {

            AddConferance addConferance = Program.ServiceProvider.GetService<AddConferance>();
            addConferance.ConferenceId = null;
            addConferance.ShowDialog();

        }

        private void OrganizerGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.OrganizerGrid.Columns["ConferenceId"].Visible = false;
        }

        private void OrganizerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            OrganizerGrid.Columns["Edit"].Index) return;

            Int32 conferenceId = (Int32)OrganizerGrid[OrganizerGrid.Columns["ConferenceId"].Index, e.RowIndex].Value;

            AddConferance addConferance = Program.ServiceProvider.GetService<AddConferance>();
            addConferance.ConferenceId = conferenceId;
            addConferance.ShowDialog();
        }

        private void OrganizerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void entryPageTextBox_TextChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            if (entryPageTextBox.Text == string.Empty)
            {
                numberEntry = 0;
            }
            else
            {
                numberEntry = Convert.ToInt32(entryPageTextBox.Text);
            }

            populateGridParticipants(conferences, scrollVal, numberEntry);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.BackColor = Color.Transparent;
            //label1.BackColor = System.Drawing.Color.Transparent;
        }
    }
}