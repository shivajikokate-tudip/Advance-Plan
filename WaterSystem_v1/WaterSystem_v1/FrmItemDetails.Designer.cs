﻿namespace WaterSystem_v1
{
    partial class FrmItemDetails
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlListContainer = new System.Windows.Forms.Panel();
            this.ovlItem = new BrightIdeasSoftware.ObjectListView();
            this.pnlTopContainer = new System.Windows.Forms.Panel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.pnlButtonLeftContainer = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pnlButtonRight = new System.Windows.Forms.Panel();
            this.pnlClear = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlContainer.SuspendLayout();
            this.pnlListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovlItem)).BeginInit();
            this.pnlTopContainer.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.pnlButtonLeftContainer.SuspendLayout();
            this.pnlButtonRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlListContainer);
            this.pnlContainer.Controls.Add(this.pnlTopContainer);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(679, 391);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlListContainer
            // 
            this.pnlListContainer.Controls.Add(this.ovlItem);
            this.pnlListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListContainer.Location = new System.Drawing.Point(0, 177);
            this.pnlListContainer.Name = "pnlListContainer";
            this.pnlListContainer.Size = new System.Drawing.Size(679, 214);
            this.pnlListContainer.TabIndex = 11;
            // 
            // ovlItem
            // 
            this.ovlItem.CellEditUseWholeCell = false;
            this.ovlItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ovlItem.HasCollapsibleGroups = false;
            this.ovlItem.Location = new System.Drawing.Point(0, 0);
            this.ovlItem.MenuLabelGroupBy = "";
            this.ovlItem.MenuLabelLockGroupingOn = "";
            this.ovlItem.MenuLabelSortAscending = "";
            this.ovlItem.MenuLabelUnlockGroupingOn = "";
            this.ovlItem.Name = "ovlItem";
            this.ovlItem.Size = new System.Drawing.Size(679, 214);
            this.ovlItem.TabIndex = 6;
            this.ovlItem.UseCompatibleStateImageBehavior = false;
            this.ovlItem.View = System.Windows.Forms.View.Details;
            // 
            // pnlTopContainer
            // 
            this.pnlTopContainer.Controls.Add(this.pnlButtonContainer);
            this.pnlTopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlTopContainer.Name = "pnlTopContainer";
            this.pnlTopContainer.Size = new System.Drawing.Size(679, 177);
            this.pnlTopContainer.TabIndex = 1;
            // 
            // pnlButtonContainer
            // 
            this.pnlButtonContainer.Controls.Add(this.pnlButtonLeftContainer);
            this.pnlButtonContainer.Controls.Add(this.pnlButtonRight);
            this.pnlButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonContainer.Location = new System.Drawing.Point(0, 129);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(679, 48);
            this.pnlButtonContainer.TabIndex = 0;
            // 
            // pnlButtonLeftContainer
            // 
            this.pnlButtonLeftContainer.Controls.Add(this.btnPreview);
            this.pnlButtonLeftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonLeftContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonLeftContainer.Name = "pnlButtonLeftContainer";
            this.pnlButtonLeftContainer.Size = new System.Drawing.Size(255, 48);
            this.pnlButtonLeftContainer.TabIndex = 9;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreview.Location = new System.Drawing.Point(29, 7);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(103, 35);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // pnlButtonRight
            // 
            this.pnlButtonRight.Controls.Add(this.pnlClear);
            this.pnlButtonRight.Controls.Add(this.btnAdd);
            this.pnlButtonRight.Controls.Add(this.txtSearch);
            this.pnlButtonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonRight.Location = new System.Drawing.Point(255, 0);
            this.pnlButtonRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtonRight.Name = "pnlButtonRight";
            this.pnlButtonRight.Size = new System.Drawing.Size(424, 48);
            this.pnlButtonRight.TabIndex = 8;
            // 
            // pnlClear
            // 
            this.pnlClear.BackgroundImage = global::WaterSystem_v1.Properties.Resources.clear1;
            this.pnlClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlClear.Location = new System.Drawing.Point(252, 15);
            this.pnlClear.Name = "pnlClear";
            this.pnlClear.Size = new System.Drawing.Size(20, 20);
            this.pnlClear.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(299, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(122, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(129, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // FrmItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(679, 391);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItemDetails";
            this.Text = "FrmItemDetails";
            this.Load += new System.EventHandler(this.FrmItemDetails_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovlItem)).EndInit();
            this.pnlTopContainer.ResumeLayout(false);
            this.pnlButtonContainer.ResumeLayout(false);
            this.pnlButtonLeftContainer.ResumeLayout(false);
            this.pnlButtonRight.ResumeLayout(false);
            this.pnlButtonRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlTopContainer;
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.Panel pnlButtonRight;
        private System.Windows.Forms.Panel pnlClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlButtonLeftContainer;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel pnlListContainer;
        private BrightIdeasSoftware.ObjectListView ovlItem;
    }
}