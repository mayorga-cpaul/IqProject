﻿namespace EconomicMF.Forms.Forms.Users
{
    partial class FrmValidateForgotPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidateForgotPass));
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtCode = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSuccess = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(390, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtCode.BorderColor = System.Drawing.Color.White;
            this.txtCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCode.BorderRadius = 0;
            this.txtCode.BorderSize = 2;
            this.txtCode.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(78, 117);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCode.PasswordChar = false;
            this.txtCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCode.PlaceholderText = "Código";
            this.txtCode.Size = new System.Drawing.Size(261, 44);
            this.txtCode.TabIndex = 15;
            this.txtCode.Texts = "";
            this.txtCode.UnderlinedStyle = true;
            // 
            // btnSuccess
            // 
            this.btnSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(206)))), ((int)(((byte)(171)))));
            this.btnSuccess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(206)))), ((int)(((byte)(171)))));
            this.btnSuccess.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSuccess.BorderRadius = 5;
            this.btnSuccess.BorderSize = 0;
            this.btnSuccess.FlatAppearance.BorderSize = 0;
            this.btnSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccess.ForeColor = System.Drawing.Color.Black;
            this.btnSuccess.Location = new System.Drawing.Point(78, 183);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(261, 34);
            this.btnSuccess.TabIndex = 14;
            this.btnSuccess.Text = "Aceptar";
            this.btnSuccess.TextColor = System.Drawing.Color.Black;
            this.btnSuccess.UseVisualStyleBackColor = false;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Confirmar código (revisar email)";
            // 
            // FrmValidateForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(428, 267);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmValidateForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmValidateForgotPass";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private RJCodeAdvance.RJControls.RJTextBox txtCode;
        private RJCodeAdvance.RJControls.RJButton btnSuccess;
        private System.Windows.Forms.Label label1;
    }
}