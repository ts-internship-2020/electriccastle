﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using Newtonsoft.Json;

namespace ConferencePlanner.WinUi
{

    public partial class NewCityForm : Form
    {
        private readonly IAddConferenceCityRepository getAddConferenceCityRepository;
        private readonly IAddConferenceDistrictRepository getAddConferenceDistrictRepository;

        private AddConferenceCityModel editCity;

        private int maxCityId = 0;

        List<AddConferenceDistrictModel> districts;
        List<AddConferenceCityModel> citiesCityForm;
        List<string> disctictName;

        public NewCityForm(IAddConferenceCityRepository getAddConferenceCityRepository,
            IAddConferenceDistrictRepository getAddConferenceDistrictRepository
            )
        {
            this.getAddConferenceCityRepository = getAddConferenceCityRepository;
            this.getAddConferenceDistrictRepository = getAddConferenceDistrictRepository;
            disctictName = new List<string>();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void butonCircular1_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex name = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z]+$");

            if (CityNameTb.TextLength == 0) errorProviderCityName.SetError(CityNameTb, "You have to introduce the name");
            else
            {
                errorProviderCityName.SetError(CityNameTb, "");
            }

            if (CityCodTb.TextLength == 0) errorProviderCityCod.SetError(CityCodTb, "You have to introduce the code");
            else
            {
                errorProviderCityCod.SetError(CityCodTb, "");
            }

            if (!name.IsMatch(CityNameTb.Text))
            {
                errorProviderCityName.SetError(CityNameTb, "The name should contain only letters");
            }
            else
            {
                errorProviderCityName.SetError(CityNameTb, "");
            }

            if (!name.IsMatch(CityCodTb.Text))
            {
                errorProviderCityCod.SetError(CityCodTb, "The code should contain only letters");
            }
            else
            {
                errorProviderCityCod.SetError(CityCodTb, "");
            }

            if (CityNameTb.TextLength <= 3)
            {
                errorProviderCityName.SetError(CityNameTb, "Such city does not exist");
            }
            else
            {
                errorProviderCityName.SetError(CityNameTb, "");
            }

            if (CityCodTb.TextLength == 1)
            {
                errorProviderCityCod.SetError(CityCodTb, "This code is not explicit");

            }
            else
            {
                errorProviderCityCod.SetError(CityCodTb, "");
            }

            if (editCity == null && errorProviderCityCod.GetError(CityCodTb) == "" &&
                                   errorProviderCityName.GetError(CityNameTb) == "")
            {
               // PostAddCity();
                getAddConferenceCityRepository.insertCity(maxCityId + 1, getDistrictId(), CityCodTb.Text, CityNameTb.Text);
                this.Close();
            }
            else if (editCity != null && errorProviderCityCod.GetError(CityCodTb) == "" &&
                       errorProviderCityName.GetError(CityNameTb) == "")
            {
                //await PostUpdateCity(editCity.DictionaryCityId, CityCodTb.Text, CityNameTb.Text, getDistrictId());
                getAddConferenceCityRepository.updateCity(editCity.DictionaryCityId, CityCodTb.Text, CityNameTb.Text, getDistrictId());
                this.Close();
            }
            else
            {
                // do nothing
            }
        }

        private async Task<List<AddConferenceCityModel>> GetResponseNewCity()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage msg = await client.GetAsync("http://localhost:2794/api/DictionaryCity/City");
            List<AddConferenceCityModel> city = new List<AddConferenceCityModel>();
            if (msg.IsSuccessStatusCode)
            {
                string response = await msg.Content.ReadAsStringAsync();
                city = JsonConvert.DeserializeObject<List<AddConferenceCityModel>>(response);
            }
            return city;
        }

        private async Task<List<AddConferenceDistrictModel>> GetResponseNewDistrict()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage msg = await client.GetAsync("http://localhost:2794/api/District/{District}");
            List<AddConferenceDistrictModel> district = new List<AddConferenceDistrictModel>();
            if (msg.IsSuccessStatusCode)
            {
                string response = await msg.Content.ReadAsStringAsync();
                district = JsonConvert.DeserializeObject<List<AddConferenceDistrictModel>>(response);
            }
            return district;
        }

        private async Task PostAddCity()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage msg = await client.GetAsync("http://localhost:2794/DictionaryCity/AddCity");
            if (msg.IsSuccessStatusCode)
            {
                string response = await msg.Content.ReadAsStringAsync();
            }

        }


        private async Task PostUpdateCity(int id, string code, string name, int disId)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost:2794/api/DictionaryCity/UpdateCity?dictionaryCityId=" + id + "&cityCode=" + code + "&dictionaryCityName=" + name + "&dictionaryDistrictId=" + disId;
            HttpContent content = new StringContent("", Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Data not loaded properly from API");
            }
        }

        private async void NewCityForm_Load(object sender, EventArgs e)
        {
            int i;


            errorProviderCityName.SetError(CityNameTb, "");
            errorProviderCityCod.SetError(CityCodTb, "");
            CityCodTb.Text = string.Empty;
            DistrictNameTb.Text = string.Empty;
            CityNameTb.Text = string.Empty;
            editCity = AddConferance.editedCity;
            districts = await GetResponseNewDistrict();
            citiesCityForm = await GetResponseNewCity();
            MaxCityId();

            if (editCity != null)
            {
                CityCodTb.Text = editCity.CityCode;
                CityNameTb.Text = editCity.DictionaryCityName;
                DistrictNameTb.Text = districts.Find(districtsIds => districtsIds.DictionaryDistrictId == editCity.DictionaryDistrictId).DictionaryDistrictName;

            }
            if(editCity == null)
            {
                CityCodTb.Text = string.Empty;
                CityNameTb.Text = string.Empty;
                DistrictNameTb.Text = string.Empty;
            }

            for (i = 0; i < districts.Count; i++)
            {
                DistrictNameTb.Items.Add(districts.ElementAt(i).DictionaryDistrictName);
            }
        }

        private void MaxCityId()
        {
            int i;
            for(i = 0; i < citiesCityForm.Count; i++)
            {
                if(maxCityId < citiesCityForm.ElementAt(i).DictionaryCityId)
                {
                    maxCityId = citiesCityForm.ElementAt(i).DictionaryCityId;
                }
            }
        }

        private int getDistrictId()
        {
            int number = 0;
            var index = districts.FindIndex(districtsTxt => districtsTxt.DictionaryDistrictName == DistrictNameTb.Text);
            number = districts.ElementAt(index).DictionaryDistrictId;
            return number;
        }

    }
}
