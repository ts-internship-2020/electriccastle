using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.Helpers;
using ConferencePlanner.Repository.Ado.ElectricCastleRepository;
using ConferencePlanner.Repository.Ef.Repository;


namespace ConferencePlanner.WinUi
{
    public partial class NewCountryForm : Form
    {

        private readonly IAddConferenceCountryRepository _getCountry;

        //private readonly GetCountryRepositoryEntFr _getCountryEntFr;

        private AddConferenceCountryModel editCountry;

        List<AddConferenceCountryModel> countrys;

        public NewCountryForm(IAddConferenceCountryRepository _getCountry)
        {
            this._getCountry = _getCountry;
            InitializeComponent();
            
        }

        private async Task GetResponse()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage s = await client.GetAsync("http://localhost:2794/api/Country/{Country}");
            if(s.IsSuccessStatusCode)
            {
                string resp = await s.Content.ReadAsStringAsync();

            }

        }

        private async Task InsertData(string codul, string nameul)
        {
            //List<AddConferenceCountryModel> countrys = new List<AddConferenceCountryModel>();
            HttpClient client = new HttpClient();
            HttpResponseMessage s = await client.GetAsync("http://localhost:2794/api/Country/");
            if (s.IsSuccessStatusCode)
            {
                string resp = await s.Content.ReadAsStringAsync();

            }

        }

        private void colorButton1_Click(object sender, EventArgs e)
        {

        }



        private void AddCountryFromButton_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex name = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z]+$");

            if (!name.IsMatch(CoutryNameTb.Text))
            {
                errorProviderCountryName.SetError(CoutryNameTb, "The name should contain only letters");
            }
            else
                errorProviderCountryName.SetError(CoutryNameTb, "");

            if (!name.IsMatch(CountryCodTb.Text))
            {
                errorProviderCountryCod.SetError(CountryCodTb, "The code should contain only letters");
            }
            else errorProviderCountryCod.SetError(CountryCodTb, "");

            if (CoutryNameTb.TextLength == 0) errorProviderCountryName.SetError(CoutryNameTb, "You have to introduce the name");
            else errorProviderCountryName.SetError(CoutryNameTb, "");

            if (CountryCodTb.TextLength == 0) errorProviderCountryCod.SetError(CountryCodTb, "You have to introduce the code");
            else errorProviderCountryCod.SetError(CountryCodTb, "");

            if (CoutryNameTb.TextLength <= 3) errorProviderCountryName.SetError(CoutryNameTb, "Such country does not exist");
            else errorProviderCountryName.SetError(CoutryNameTb, "");

            if (CountryCodTb.TextLength == 1) errorProviderCountryCod.SetError(CountryCodTb, "This code is not explicit");
            else errorProviderCountryCod.SetError(CountryCodTb, "");


            if (editCountry == null)
            {
                _getCountry.InsertConferenceCountry(CountryCodTb.Text, CoutryNameTb.Text);
                //InsertData(CountryCodTb.Text, CoutryNameTb.Text);
                this.Close();
            } 

            if(editCountry!= null)
            {
                _getCountry.UpdateConferenceCountry(CountryCodTb.Text, CoutryNameTb.Text, getCountryId());

                this.Close();
            }
        }


       

        private void NewCountryForm_Load(object sender, EventArgs e)
        {
            int i;
            errorProviderCountryName.SetError(CoutryNameTb, "");
            errorProviderCountryCod.SetError(CountryCodTb, "");
            CountryCodTb.Text = string.Empty;
            CoutryNameTb.Text = string.Empty;
            
            editCountry = AddConferance.editedCountry;

            countrys = _getCountry.GetConferencesCountry();
            //GetResponse();
            if (editCountry != null)
            {
                CountryCodTb.Text = editCountry.CountryCode;
                CoutryNameTb.Text = editCountry.DictionaryCountryName;
               

            }
            if (editCountry == null)
            {
                CountryCodTb.Text = string.Empty;
                CoutryNameTb.Text = string.Empty;
               
            }
           

        }


        public int getCountryId()
        {
            int number = 0;
            var index = countrys.FindIndex(countyName => countyName.CountryCode == CountryCodTb.Text);
            number = countrys.ElementAt(index).DictionaryCountryId;
            return number;
        }
    }
}
