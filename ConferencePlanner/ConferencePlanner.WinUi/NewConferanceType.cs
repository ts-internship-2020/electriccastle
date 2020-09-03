using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Repository.Ef.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ConferencePlanner.WinUi.Program;

namespace ConferencePlanner.WinUi
{
    public partial class NewConferanceType : Form
    {

       
        public int ? ConferanceTypeId { get; set; }
        private readonly IConferenceTypeRepository conferanceTypeRepository;
       
        


        public NewConferanceType(IConferenceTypeRepository conferanceTypeRepository)
        {
            this.conferanceTypeRepository = conferanceTypeRepository;
            InitializeComponent();
        }





        private void btSaveType_Click(object sender, EventArgs e)
        {
            if (txtNameType.Text == string.Empty)
            {
                txtNameType.Focus();
                errorProviderName.SetError(txtNameType, "Can't be empty");
          
            }
            else if(txtCodeType.Text == string.Empty)
            {
                txtCodeType.Focus();
                errorProviderCode.SetError(txtCodeType, "Can't be empty");
            }
            if(txtNameType.Text != string.Empty && txtCodeType.Text != string.Empty)
          
            {
                int countType;
                List<ConferenceTypeModel> listConferanceType = conferanceTypeRepository.getAllTypes();
                countType = listConferanceType.Count;
                ConferenceTypeModel type;
                for (int i = 0; i < countType; i++)
                {
                    type = listConferanceType.ElementAt(i);


                    if (ConferanceTypeId != null && ConferanceTypeId == i + 1)
                    {
                        type.ConferenceTypeName = txtNameType.Text;
                        type.ConferenceTypeCode = txtCodeType.Text;
                        
                        conferanceTypeRepository.getType(type);
                    }
                    else
                    {
                        ConferenceTypeModel typeNew = new ConferenceTypeModel();
                        if (ConferanceTypeId == null)
                        {
                            typeNew.ConferenceTypeCode = " ";
                            typeNew.ConferenceTypeName = " ";
                            ConferanceTypeId = 0;
                            typeNew.ConferenceTypeName = txtNameType.Text;
                            typeNew.ConferenceTypeCode = txtCodeType.Text;
                        
                            conferanceTypeRepository.insertType(typeNew);
                        }
                    }
                }
                this.Close();
            }


        }

        private void NewConferanceType_Load(object sender, EventArgs e)
        {
            int countType;
            List<ConferenceTypeModel> listConferanceType = conferanceTypeRepository.getAllTypes();
            countType = listConferanceType.Count;
            ConferenceTypeModel type;
            for(int i=0;i<countType;i++)
            {
                type = listConferanceType.ElementAt(i);
                if (ConferanceTypeId != null && ConferanceTypeId==i+1)
                {
                    txtNameType.Text = type.ConferenceTypeName.ToString();
                    txtCodeType.Text = type.ConferenceTypeCode.ToString();
                    
                }
                if(ConferanceTypeId==null)
                {
                    txtNameType.Text = "";
                   txtCodeType.Text = "";
                }
              
            }

        }

        private void txtCodeType_Validating(object sender, CancelEventArgs e)
        {
                e.Cancel = false;
                errorProviderCode.SetError(txtCodeType, "");

        }

        private void txtNameType_Validating(object sender, CancelEventArgs e)
        {
                e.Cancel = false;
                errorProviderName.SetError(txtNameType, "");
        }

        private void NewConferanceType_Activated(object sender, EventArgs e)
        {
            errorProviderCode.SetError(txtNameType, "");
            errorProviderCode.SetError(txtCodeType, "");
        }
    }
}
