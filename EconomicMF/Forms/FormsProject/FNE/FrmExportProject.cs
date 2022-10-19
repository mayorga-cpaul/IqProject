﻿using EconomicEF.Common.UserCache;
using EconomicMF.Domain.Contracts;
using EconomicMF.UserControls.Export;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsProject.FNE
{
    
    public partial class FrmExportProject : Form
    {
        private IUnitOfWork unitOfWOrk;
        public FrmExportProject(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWOrk = unitOfWork;
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void FrmExportProject_Load(object sender, System.EventArgs e)
        {
            //ChargeAmortizacion();
            //ChargeAsset();
            ChargeProject();
        }

        private async void ChargeAmortizacion()
        {

        }

        private void ChargeAsset()
        {
            throw new NotImplementedException();
        }

        private async void ChargeProject()
        {
            var project = await unitOfWOrk.ProjectClient.GetAsync(DataOnMemory.ProjectId);
            flpProject.Controls.Add(new UCProjectExp(unitOfWOrk, project.Id));
        }
    }
}
