﻿using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums;
using EconomicMF.SettingForms;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations.FormsShowCalculus
{
    public partial class FrmShowCashFlowDetail : Form
    {
        #region move
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        private int flujoId;
        private IUnitOfWork unitOfWork;
        private DataTable dt;
        public decimal VP { get; set; }
        public decimal VF { get; set; }
        private int nper;
        public FrmShowCashFlowDetail(IUnitOfWork unitOfWork, int flujoId, int nper)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.flujoId = flujoId;
            this.nper = nper;
            dt = new DataTable();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            panel1.BackColor = Color.HotPink;
        }

        private void FrmShowCashFlowDetail_Load(object sender, EventArgs e)
        {
            //this.pnlChart.Controls.Add(chartCashFlow);
            this.pnlChart.Controls.Add(chartControl1);
            chartCashFlow.Visible = false;
            LlenarDgv();
        }
        private async void LlenarDgv()
        {
            //TODO: Revisar si esto se devuelve correctamente
            IEnumerable<EconomicDto> cashFlow = await unitOfWork.flujoDetalleClient.GetEconomics(flujoId);
            dgvEconomics.DataSource = cashFlow;
            dt = ConvertDatagridview.ConvertToDataTable(dgvEconomics);
            //LoadChart(cashFlow.ToList());
            FlujoCajaSync(cashFlow.ToList());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    LlenarDgv();
                    return;
                }
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                if (int.TryParse(txtSearch.Text, out int result))
                {
                    bindingSource.Filter = String.Format("Id = {0}", txtSearch.Text);
                }
                dgvEconomics.DataSource = bindingSource;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //TODO: Falta probar
        private void LoadChart(List<EconomicDto> economics)
        {
            chartCashFlow.YAxes.GridLines.Display = false;
            chartCashFlow.Datasets.Clear();
            //TODO: ver si poner legenda si o no
            chartCashFlow.Legend.Display = true;
            foreach(var ec in economics)
            {
                AddFlow(ec);
            }
        }
        //TODO: Falta probar
        private void AddFlow(EconomicDto economic)
        {
            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            int j = 0;
            for (int i = 0; i <= nper; i++)
            {
                int width = chartCashFlow.Width;
                int height = chartCashFlow.Height;
                double valor = 0;
                if (string.Compare(economic.Discriminator, Discriminador.Interes.ToString(), StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    valor = (i == economic.NumPeriodos) ? (double)economic.FutureValue : 0;
                    dataset.DataPoints.Add(i.ToString(), valor);
                }
                else if(string.Compare(economic.Discriminator, Discriminador.Anualidad.ToString(), StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    if (economic.TipoDeCrecimiento.Equals(TipoCrecimiento.Aritmetico))
                    {
                        if(i>=(economic.PeriodoGracia+1) && i <= economic.NumPeriodos)
                        {
                            valor = (double)economic.PagoAnual + (j * (double)economic.Crecimiento);
                        }
                        dataset.DataPoints.Add(i.ToString(), valor);
                        j++;

                    }
                    else if (economic.TipoDeCrecimiento.Equals(TipoCrecimiento.Geometrico))
                    {
                        if (i >= (economic.PeriodoGracia + 1) && i <= economic.NumPeriodos)
                        {
                            valor = (double)economic.PagoAnual * Math.Pow((1 + (double)economic.Crecimiento), j);
                        }
                        dataset.DataPoints.Add(i.ToString(), valor);
                        j++;
                    }
                    else
                    {
                        if (i >= (economic.PeriodoGracia + 1) && i <= economic.NumPeriodos)
                        {
                            valor = (double)economic.PagoAnual;
                        }
                        dataset.DataPoints.Add(i.ToString(), valor);
                    }
                }
                chartCashFlow.Size = new Size(width += 10, height);
            }
            chartCashFlow.Datasets.Add(dataset);
            chartCashFlow.Update();
        }

        private void FrmShowCashFlowDetail_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Flujo de caja clase
        private void FlujoCaja()
        {
            
        }

        //flujo de caja Synfusion
        public void FlujoCajaSync(List<EconomicDto> economics)
        {
            ChartSeries series = chartControl1.Series[0];
            //chartControl1.Spacing = 5;
            //ChartSeries series = new ChartSeries($"Presente", ChartSeriesType.Column);
            chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.AutomaticMode;
            series.Text = series.Name;
            chartControl1.Title.BackColor = Color.White;
            //Random random = new Random();
            
            foreach (var economic in economics)
            {
                int width = chartControl1.Width;
                int height = chartControl1.Height;

                double valor = 0;
                int j = 0;

                if (string.Compare(economic.Discriminator, Discriminador.Interes.ToString(), StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    //valor = (i == economic.NumPeriodos) ? (double)economic.FutureValue : 0;
                    series.Points.Add((double)economic.NumPeriodos, (double)economic.FutureValue);
                }
                else if (string.Compare(economic.Discriminator, Discriminador.Anualidad.ToString(), StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    if (economic.TipoDeCrecimiento.Equals(TipoCrecimiento.Aritmetico))
                    {
                        for(int i = economic.PeriodoGracia + 1; i <= economic.NumPeriodos; i++)
                        {
                            valor = (double)economic.PagoAnual + (j * (double)economic.Crecimiento);
                            series.Points.Add((double)i, (double)valor);
                        }
                        j++;
                    }
                    else if (economic.TipoDeCrecimiento.Equals(TipoCrecimiento.Geometrico))
                    {
                        for (int i = economic.PeriodoGracia + 1; i <= economic.NumPeriodos; i++)
                        {
                            valor = (double)economic.PagoAnual * Math.Pow((1 + (double)economic.Crecimiento), j);
                            series.Points.Add((double)i, (double)valor);
                        }
                        j++;
                    }
                    else
                    {
                        for (int i = economic.PeriodoGracia + 1; i <= economic.NumPeriodos; i++)
                        {
                            //valor = (double)economic.PagoAnual * Math.Pow((1 + (double)economic.Crecimiento), j);
                            series.Points.Add((double)i, (double)economic.PagoAnual);
                        }
                    }
                }

                chartControl1.Size = new Size(width += 10, height);
            }
            series.Style.DisplayText = true;
            series.Style.TextOrientation = ChartTextOrientation.Smart;
            chartControl1.Series.Add(series);
        }
    }
}