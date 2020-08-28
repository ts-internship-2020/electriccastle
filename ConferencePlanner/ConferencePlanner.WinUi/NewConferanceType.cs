using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
           
            if (txtCodeType.Text==string.Empty || txtNameType.Text==string.Empty)
            {
                txtCodeType.Focus();
                errorProviderCode.SetError(txtCodeType, "Can't be empty");
                errorProviderCode.SetError(txtNameType, "Can't be empty");

            }
            else
            {
                int countType;
                List<ConferenceTypeModel> listConferanceType = conferanceTypeRepository.getAllTypes();
                countType = listConferanceType.Count;
                ConferenceTypeModel type;
                for(int i=0;i<countType;i++)
                {
                    type = listConferanceType.ElementAt(i);
                    
                    if (ConferanceTypeId != null && ConferanceTypeId == i + 1)
                    {
                        type.ConferenceTypeName = txtNameType.Text;
                        type.ConferenceTypeCode = txtCodeType.Text;
                        conferanceTypeRepository.getType(type) ;
                    }
                    else
                    {
                        ConferenceTypeModel typeNew = new ConferenceTypeModel();
                        if (ConferanceTypeId==null && typeNew==null)
                        {
                           
                            typeNew.ConferenceTypeName = txtNameType.Text;
                            typeNew.ConferenceTypeCode = txtCodeType.Text;

                            conferanceTypeRepository.insertType(typeNew);
                        }
                    }
                }
              
            }
            this.Close();


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
            }

        }
    }
}
