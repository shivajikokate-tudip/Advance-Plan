﻿namespace WaterSystem_v1
{
    partial class FrmAddEditCustomer
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pnlActiveContainer = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.toggleActive = new JCS.ToggleSwitch();
            this.lblActive = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtMob = new System.Windows.Forms.TextBox();
            this.lblGstNo = new System.Windows.Forms.Label();
            this.txtGstNo = new System.Windows.Forms.TextBox();
            this.pnlTitle.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlActiveContainer.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.MediumBlue;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(539, 35);
            this.pnlTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(224, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ADD";
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButton.Controls.Add(this.pnlActiveContainer);
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSubmit);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 297);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(539, 46);
            this.pnlButton.TabIndex = 5;
            // 
            // pnlActiveContainer
            // 
            this.pnlActiveContainer.Controls.Add(this.pnlActive);
            this.pnlActiveContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlActiveContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlActiveContainer.Name = "pnlActiveContainer";
            this.pnlActiveContainer.Size = new System.Drawing.Size(167, 46);
            this.pnlActiveContainer.TabIndex = 2;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.pnlActive.Controls.Add(this.toggleActive);
            this.pnlActive.Controls.Add(this.lblActive);
            this.pnlActive.Location = new System.Drawing.Point(12, 6);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(144, 33);
            this.pnlActive.TabIndex = 0;
            // 
            // toggleActive
            // 
            this.toggleActive.Location = new System.Drawing.Point(65, 6);
            this.toggleActive.Name = "toggleActive";
            this.toggleActive.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleActive.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleActive.Size = new System.Drawing.Size(50, 19);
            this.toggleActive.TabIndex = 5;
            // 
            // lblActive
            // 
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.Color.White;
            this.lblActive.Location = new System.Drawing.Point(9, 7);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(53, 20);
            this.lblActive.TabIndex = 5;
            this.lblActive.Text = "Active";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(325, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(420, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 25);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(43, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Customer/ Firm Name :";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(42, 45);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(122, 16);
            this.lblNo.TabIndex = 7;
            this.lblNo.Text = "Customer Number :";
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Location = new System.Drawing.Point(46, 64);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(142, 20);
            this.txtNumber.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(46, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(42, 205);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 16);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(46, 224);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(451, 46);
            this.txtAddress.TabIndex = 11;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(313, 151);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(55, 16);
            this.lblMobile.TabIndex = 12;
            this.lblMobile.Text = "Mobile :";
            // 
            // txtMob
            // 
            this.txtMob.Location = new System.Drawing.Point(316, 170);
            this.txtMob.Name = "txtMob";
            this.txtMob.Size = new System.Drawing.Size(181, 20);
            this.txtMob.TabIndex = 13;
            // 
            // lblGstNo
            // 
            this.lblGstNo.AutoSize = true;
            this.lblGstNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGstNo.Location = new System.Drawing.Point(43, 151);
            this.lblGstNo.Name = "lblGstNo";
            this.lblGstNo.Size = new System.Drawing.Size(106, 16);
            this.lblGstNo.TabIndex = 14;
            this.lblGstNo.Text = "GSTIN Number :";
            // 
            // txtGstNo
            // 
            this.txtGstNo.Location = new System.Drawing.Point(45, 170);
            this.txtGstNo.Name = "txtGstNo";
            this.txtGstNo.Size = new System.Drawing.Size(184, 20);
            this.txtGstNo.TabIndex = 15;
            // 
            // FrmAddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(539, 343);
            this.Controls.Add(this.txtGstNo);
            this.Controls.Add(this.lblGstNo);
            this.Controls.Add(this.txtMob);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddEditCustomer";
            this.Load += new System.EventHandler(this.FrmAddEditCustomer_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlActiveContainer.ResumeLayout(false);
            this.pnlActive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlActiveContainer;
        private System.Windows.Forms.Panel pnlActive;
        private JCS.ToggleSwitch toggleActive;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtMob;
        private System.Windows.Forms.Label lblGstNo;
        private System.Windows.Forms.TextBox txtGstNo;
    }
}