﻿namespace WaterSystem_v1
{
    partial class FrmDashboard
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
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlRightContainer = new System.Windows.Forms.Panel();
            this.pnlRightTopContainer = new System.Windows.Forms.Panel();
            this.pnlRightBottomContainer = new System.Windows.Forms.Panel();
            this.pnlMainContainer.SuspendLayout();
            this.pnlRightContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlMainContainer.Controls.Add(this.pnlRightContainer);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(601, 402);
            this.pnlMainContainer.TabIndex = 0;
            // 
            // pnlRightContainer
            // 
            this.pnlRightContainer.Controls.Add(this.pnlRightBottomContainer);
            this.pnlRightContainer.Controls.Add(this.pnlRightTopContainer);
            this.pnlRightContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightContainer.Location = new System.Drawing.Point(361, 0);
            this.pnlRightContainer.Name = "pnlRightContainer";
            this.pnlRightContainer.Size = new System.Drawing.Size(240, 402);
            this.pnlRightContainer.TabIndex = 0;
            // 
            // pnlRightTopContainer
            // 
            this.pnlRightTopContainer.BackColor = System.Drawing.Color.Linen;
            this.pnlRightTopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTopContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlRightTopContainer.Name = "pnlRightTopContainer";
            this.pnlRightTopContainer.Size = new System.Drawing.Size(240, 203);
            this.pnlRightTopContainer.TabIndex = 0;
            // 
            // pnlRightBottomContainer
            // 
            this.pnlRightBottomContainer.BackColor = System.Drawing.Color.Bisque;
            this.pnlRightBottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRightBottomContainer.Location = new System.Drawing.Point(0, 185);
            this.pnlRightBottomContainer.Name = "pnlRightBottomContainer";
            this.pnlRightBottomContainer.Size = new System.Drawing.Size(240, 217);
            this.pnlRightBottomContainer.TabIndex = 1;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 402);
            this.Controls.Add(this.pnlMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlRightContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Panel pnlRightContainer;
        private System.Windows.Forms.Panel pnlRightBottomContainer;
        private System.Windows.Forms.Panel pnlRightTopContainer;
    }
}

