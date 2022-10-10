﻿namespace EconomicMF.UserControls
{
    partial class UCReports
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImage = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnDowloadReport = new RJCodeAdvance.RJControls.RJButton();
            this.lblAportación = new System.Windows.Forms.Label();
            this.lblNameInversor = new System.Windows.Forms.Label();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.lblIdProject = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.pbImage.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbImage.BorderSize = 2;
            this.pbImage.GradientAngle = 50F;
            this.pbImage.Location = new System.Drawing.Point(15, 5);
            this.pbImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(48, 48);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnDowloadReport
            // 
            this.btnDowloadReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnDowloadReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnDowloadReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDowloadReport.BorderRadius = 10;
            this.btnDowloadReport.BorderSize = 0;
            this.btnDowloadReport.FlatAppearance.BorderSize = 0;
            this.btnDowloadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDowloadReport.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDowloadReport.ForeColor = System.Drawing.Color.White;
            this.btnDowloadReport.Location = new System.Drawing.Point(744, 13);
            this.btnDowloadReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDowloadReport.Name = "btnDowloadReport";
            this.btnDowloadReport.Size = new System.Drawing.Size(185, 29);
            this.btnDowloadReport.TabIndex = 2;
            this.btnDowloadReport.Text = "Dowload report";
            this.btnDowloadReport.TextColor = System.Drawing.Color.White;
            this.btnDowloadReport.UseVisualStyleBackColor = false;
            this.btnDowloadReport.Click += new System.EventHandler(this.btnDowloadReport_Click_1);
            // 
            // lblAportación
            // 
            this.lblAportación.AutoSize = true;
            this.lblAportación.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAportación.ForeColor = System.Drawing.Color.White;
            this.lblAportación.Location = new System.Drawing.Point(110, 33);
            this.lblAportación.Name = "lblAportación";
            this.lblAportación.Size = new System.Drawing.Size(22, 17);
            this.lblAportación.TabIndex = 57;
            this.lblAportación.Text = "Id:";
            // 
            // lblNameInversor
            // 
            this.lblNameInversor.AutoSize = true;
            this.lblNameInversor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameInversor.ForeColor = System.Drawing.Color.White;
            this.lblNameInversor.Location = new System.Drawing.Point(109, 7);
            this.lblNameInversor.Name = "lblNameInversor";
            this.lblNameInversor.Size = new System.Drawing.Size(91, 17);
            this.lblNameInversor.TabIndex = 56;
            this.lblNameInversor.Text = "Name project:";
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameProject.ForeColor = System.Drawing.Color.White;
            this.lblNameProject.Location = new System.Drawing.Point(219, 7);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(103, 17);
            this.lblNameProject.TabIndex = 58;
            this.lblNameProject.Text = "<name project>";
            // 
            // lblIdProject
            // 
            this.lblIdProject.AutoSize = true;
            this.lblIdProject.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdProject.ForeColor = System.Drawing.Color.White;
            this.lblIdProject.Location = new System.Drawing.Point(219, 37);
            this.lblIdProject.Name = "lblIdProject";
            this.lblIdProject.Size = new System.Drawing.Size(82, 17);
            this.lblIdProject.TabIndex = 59;
            this.lblIdProject.Text = "<Id project>";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(454, 20);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(91, 17);
            this.lblData.TabIndex = 60;
            this.lblData.Text = "Name project:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 3);
            this.panel1.TabIndex = 62;
            // 
            // UCReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblIdProject);
            this.Controls.Add(this.lblNameProject);
            this.Controls.Add(this.lblAportación);
            this.Controls.Add(this.lblNameInversor);
            this.Controls.Add(this.btnDowloadReport);
            this.Controls.Add(this.pbImage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCReports";
            this.Size = new System.Drawing.Size(947, 64);
            this.Load += new System.EventHandler(this.UCReports_Load);
            this.MouseEnter += new System.EventHandler(this.UCReports_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCReports_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJCircularPictureBox pbImage;
        private RJCodeAdvance.RJControls.RJButton btnDowloadReport;
        private System.Windows.Forms.Label lblAportación;
        private System.Windows.Forms.Label lblNameInversor;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.Label lblIdProject;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel1;
    }
}
