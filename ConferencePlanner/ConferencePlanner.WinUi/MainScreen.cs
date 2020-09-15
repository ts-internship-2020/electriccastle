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
using ConferencePlanner.Abstraction.Helpers;
using static ConferencePlanner.WinUi.Program;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Mail;
using Windows.ApplicationModel.VoiceCommands;
using System.Net;
using BarcodeLib;
using System.IO;
using System.Drawing.Imaging;
using Tulpep.NotificationWindow;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ConferencePlanner.WinUi
{


    

    public  partial class MainScreen : Form
    {
        private HttpClient httpClient;

        //private string emailParticipantLogare;

        private List<OrganizerConferencesModel> organizerConferences;

        private PaginationHelper<OrganizerConferencesModel> paginationHelper;

        private readonly IEmailParticipant _email;

        private List<ParticipantsConferencesModel> conferences;

        private int pageSize = 2;

        private int scrollVal;

        private int numberEntry;

        public static string SetValueIdSpeker;

        private List<ParticipantsConferencesModel> currentPageConferences;

        public object QRCodeGenerator { get; private set; }

      
        public MainScreen(IEmailParticipant _emailPart)
        {
            this._email = _emailPart;
            httpClient = new HttpClient();

            //currentPageConferences = new List<ParticipantsConferencesModel>();
            scrollVal = 0;
            InitializeComponent();
            
        }

       
        void populateGridParticipants(List<ParticipantsConferencesModel> conferenceParticipants, int scrollVal, int entries)
        {
            List<ParticipantsConferencesModel> conf = new List<ParticipantsConferencesModel>();
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
                conf.Add(listElement);
                
            }
            currentPageConferences = conf;



        }

        private async Task<List<ParticipantsConferencesModel>> GetResponseParticipantsConference()
        {
            HttpResponseMessage msg = await httpClient.GetAsync("http://localhost:2794/api/ConferenceParticipants/ParticipantsConference");
            List<ParticipantsConferencesModel> participants = new List<ParticipantsConferencesModel>();
            if (msg.IsSuccessStatusCode)
            {
                string response = await msg.Content.ReadAsStringAsync();
                participants = JsonConvert.DeserializeObject<List<ParticipantsConferencesModel>>(response);
            }
            return participants;
        }

        private async Task PostParticipantsConferenceState(int index)
        {
            string url = "http://localhost:2794/api/ConferenceParticipants/ParticipantState?index=" + index + "&email=" + EmailParticipants;
            HttpContent content = new StringContent("", Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Data not loaded properly from API");
            }
        }

        private async void MainScreen_Load(object sender, EventArgs e)
        {
            
              
            conferences = await GetResponseParticipantsConference();

            numberEntry = Convert.ToInt32(entryPageTextBox.Text);
            populateGridParticipants(conferences, scrollVal, numberEntry);

            await GetOrganizerConferencesViaAPI();

            paginationHelper = new PaginationHelper<OrganizerConferencesModel>(organizerConferences, pageSize);
            OrganizerTabEntriesTextBox.Text = pageSize.ToString();
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
      
        private async void DatePickerParticipantStart_ValueChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            List<ParticipantsConferencesModel> conferenceParticipants = await GetResponseParticipantsConference();
            conferences = conferenceParticipants.Where(conference => conference.StartDate >= DatePickerParticipantStart.Value).ToList();
            populateGridParticipants(conferences, scrollVal, numberEntry);

        }

        private async void DatePickerParticipantEnd_ValueChanged(object sender, EventArgs e)
        {
            scrollVal = 0;
            List<ParticipantsConferencesModel> conferenceParticipants = await GetResponseParticipantsConference();
            conferences = conferenceParticipants.Where(conference => conference.EndDate <= DatePickerParticipantEnd.Value).ToList();
            populateGridParticipants(conferences, scrollVal, numberEntry);
        }

        private async void FilterParticipants_Click(object sender, EventArgs e)
        {
          
            scrollVal = 0;
            List<ParticipantsConferencesModel> conferenceParticipants = await GetResponseParticipantsConference();
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

        public  Stream ToStream( Image image, ImageFormat formaw)
        {
            var stream = new System.IO.MemoryStream();
            image.Save(stream, formaw);
            stream.Position = 0;
            return stream;
        }

        private void sendMail(String email)
        {

            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("totalevents12@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Authentication code ";
                Random random = new Random();

                String code = random.Next().ToString();
                while (code.Length != 10)
                {
                    code = random.Next().ToString();
                }
                code = code + "12";
                Barcode barcode = new Barcode();
                Color foreColor = Color.Black;
                Color backColor = Color.Transparent;
                Image imageBarCode = barcode.Encode(TYPE.UPCA, code, foreColor, backColor);
          
                mail.Body = "Your code is: " +code;
                var stream = ToStream(imageBarCode, ImageFormat.Png);
                
                mail.Attachments.Add(new Attachment(stream, "imageBarCode.png", "imageBarCode/png"));



                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("totalevents12@gmail.com", "12parola34");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                PopupNotifier popup = new PopupNotifier();
               // popup.Image = Properties.Resources.info;
                popup.TitleText = "Mail";
                popup.ContentText = "Verify you email";
                popup.Popup();
                _email.UpdateEmail(email, code);
              


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

        private async void ConferencesParticipant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //_email.InsertEmailParticipantBD(e.RowIndex+1, EmailParticipants);

            if (e.ColumnIndex == 7)
            {
                await PostParticipantsConferenceState(e.ColumnIndex);
                //_getParticipantRepository.UpdateParticipantsConferencesState(e.ColumnIndex, EmailParticipants);
                ConferencesParticipant.Rows[e.RowIndex].Cells[7].Style.BackColor = System.Drawing.Color.GreenYellow;
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Attended";
               sendMail(EmailParticipants);


            }

            else if (e.ColumnIndex == 8)
            {
                await PostParticipantsConferenceState(e.ColumnIndex);
                //_getParticipantRepository.UpdateParticipantsConferencesState(e.ColumnIndex, EmailParticipants);
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Joined";
                DateTime oDate = Convert.ToDateTime(ConferencesParticipant.Rows[e.RowIndex].Cells[1].Value);
                TimeSpan ts = oDate - DateTime.Now;
                if (ts.TotalMinutes <= 5)
                    ConferencesParticipant.Rows[e.RowIndex].Cells[8].Style.BackColor = System.Drawing.Color.Green;

                Form f = new WebViewConnection();
                f.Show();

            }
            else if (e.ColumnIndex == 9)
            {
                await PostParticipantsConferenceState(e.ColumnIndex);
                //_getParticipantRepository.UpdateParticipantsConferencesState(e.ColumnIndex, EmailParticipants);
                DateTime oDate = Convert.ToDateTime(ConferencesParticipant.Rows[e.RowIndex].Cells[1].Value);
                TimeSpan ts = oDate - DateTime.Now;
                if (ts.TotalMinutes >= 6)
                    ConferencesParticipant.Rows[e.RowIndex].Cells[9].Style.BackColor = System.Drawing.Color.Red;
                ConferencesParticipant.Rows[e.RowIndex].Cells[10].Value = "Withdraw";

            }

            if (e.ColumnIndex == 6)
            {
                SetValueIdSpeker = currentPageConferences.ElementAt(e.RowIndex).Speaker.ToString(); ;
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

        private void OrganizerTabTextBox_TextChanged(object sender, EventArgs e)
        {
            if (OrganizerTabEntriesTextBox.Text != string.Empty)
            {
                paginationHelper.pageSize = Convert.ToInt32(OrganizerTabEntriesTextBox.Text);
                paginationHelper.pageNumber = 1;
                // Nu stergeti
                //categoryTabPaginationHelper.pageNumber = categoryTabPaginationHelper.GetPageForIndex(conferenceCategories.FindIndex(cat => cat.ConferenceCategoryId == (int)CategoryTabGrid.SelectedRows[0].Cells["ConferenceCategoryId"].Value) + 1);
                OrganizerGrid.DataSource = paginationHelper.GetPage();
                ManageOrganizerPaginationButtonsState();
            }
        }


        private async Task GetOrganizerConferencesViaAPI()
        {
            HttpResponseMessage message = await httpClient.GetAsync("http://localhost:2794/api/OrganizerConferences/" + EmailParticipants);
            //List<OrganizerConferencesModel> conferences = new List<OrganizerConferencesModel>();
            if (message.IsSuccessStatusCode)
            {
                string resp = await message.Content.ReadAsStringAsync();
                organizerConferences = JsonConvert.DeserializeObject<List<OrganizerConferencesModel>>(resp);
            }
            //return conferences;
        }
    }
}