namespace WaterSystem_v1
{
    partial class FrmUserDetail
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
            this.pnlUserContainer = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.pnlButtonLeftContainer = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pnlButtonRight = new System.Windows.Forms.Panel();
            this.pnlClear = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlListContainer = new System.Windows.Forms.Panel();
            this.ovlUser = new BrightIdeasSoftware.ObjectListView();
            this.pnlUserContainer.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.pnlButtonLeftContainer.SuspendLayout();
            this.pnlButtonRight.SuspendLayout();
            this.pnlListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovlUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserContainer
            // 
            this.pnlUserContainer.Controls.Add(this.pnlListContainer);
            this.pnlUserContainer.Controls.Add(this.pnlTop);
            this.pnlUserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlUserContainer.Name = "pnlUserContainer";
            this.pnlUserContainer.Size = new System.Drawing.Size(596, 405);
            this.pnlUserContainer.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlButtonContainer);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(596, 179);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlButtonContainer
            // 
            this.pnlButtonContainer.Controls.Add(this.pnlButtonLeftContainer);
            this.pnlButtonContainer.Controls.Add(this.pnlButtonRight);
            this.pnlButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonContainer.Location = new System.Drawing.Point(0, 134);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(596, 45);
            this.pnlButtonContainer.TabIndex = 0;
            // 
            // pnlButtonLeftContainer
            // 
            this.pnlButtonLeftContainer.Controls.Add(this.btnPreview);
            this.pnlButtonLeftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonLeftContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonLeftContainer.Name = "pnlButtonLeftContainer";
            this.pnlButtonLeftContainer.Size = new System.Drawing.Size(172, 45);
            this.pnlButtonLeftContainer.TabIndex = 10;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreview.Location = new System.Drawing.Point(29, 6);
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
            this.pnlButtonRight.Location = new System.Drawing.Point(172, 0);
            this.pnlButtonRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtonRight.Name = "pnlButtonRight";
            this.pnlButtonRight.Size = new System.Drawing.Size(424, 45);
            this.pnlButtonRight.TabIndex = 9;
            // 
            // pnlClear
            // 
            this.pnlClear.BackgroundImage = global::WaterSystem_v1.Properties.Resources.clear1;
            this.pnlClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlClear.Location = new System.Drawing.Point(253, 14);
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
            this.btnAdd.Location = new System.Drawing.Point(300, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(123, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(129, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlListContainer
            // 
            this.pnlListContainer.Controls.Add(this.ovlUser);
            this.pnlListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListContainer.Location = new System.Drawing.Point(0, 179);
            this.pnlListContainer.Name = "pnlListContainer";
            this.pnlListContainer.Size = new System.Drawing.Size(596, 226);
            this.pnlListContainer.TabIndex = 11;
            // 
            // ovlUser
            // 
            this.ovlUser.CellEditUseWholeCell = false;
            this.ovlUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ovlUser.HasCollapsibleGroups = false;
            this.ovlUser.Location = new System.Drawing.Point(0, 0);
            this.ovlUser.MenuLabelGroupBy = "";
            this.ovlUser.MenuLabelLockGroupingOn = "";
            this.ovlUser.MenuLabelSortAscending = "";
            this.ovlUser.MenuLabelUnlockGroupingOn = "";
            this.ovlUser.Name = "ovlUser";
            this.ovlUser.Size = new System.Drawing.Size(596, 226);
            this.ovlUser.TabIndex = 6;
            this.ovlUser.UseCompatibleStateImageBehavior = false;
            this.ovlUser.View = System.Windows.Forms.View.Details;
            // 
            // FrmUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(596, 405);
            this.Controls.Add(this.pnlUserContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserDetail";
            this.Text = "FrmUserDetail";
            this.pnlUserContainer.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlButtonContainer.ResumeLayout(false);
            this.pnlButtonLeftContainer.ResumeLayout(false);
            this.pnlButtonRight.ResumeLayout(false);
            this.pnlButtonRight.PerformLayout();
            this.pnlListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovlUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserContainer;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.Panel pnlButtonLeftContainer;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel pnlButtonRight;
        private System.Windows.Forms.Panel pnlClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlListContainer;
        private BrightIdeasSoftware.ObjectListView ovlUser;
    }
}