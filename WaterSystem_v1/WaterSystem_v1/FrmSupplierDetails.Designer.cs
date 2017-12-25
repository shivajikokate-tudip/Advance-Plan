namespace WaterSystem_v1
{
    partial class FrmSupplierDetails
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
            this.pnlTopContainer = new System.Windows.Forms.Panel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.pnlButtonRight = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlClear = new System.Windows.Forms.Panel();
            this.pnlButtonLeftContainer = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.ovlSupplier = new BrightIdeasSoftware.ObjectListView();
            this.pnlContainer.SuspendLayout();
            this.pnlTopContainer.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.pnlButtonRight.SuspendLayout();
            this.pnlButtonLeftContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovlSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.ovlSupplier);
            this.pnlContainer.Controls.Add(this.pnlTopContainer);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(634, 381);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlTopContainer
            // 
            this.pnlTopContainer.Controls.Add(this.pnlButtonContainer);
            this.pnlTopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlTopContainer.Name = "pnlTopContainer";
            this.pnlTopContainer.Size = new System.Drawing.Size(634, 157);
            this.pnlTopContainer.TabIndex = 0;
            // 
            // pnlButtonContainer
            // 
            this.pnlButtonContainer.Controls.Add(this.pnlButtonLeftContainer);
            this.pnlButtonContainer.Controls.Add(this.pnlButtonRight);
            this.pnlButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonContainer.Location = new System.Drawing.Point(0, 113);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(634, 44);
            this.pnlButtonContainer.TabIndex = 0;
            // 
            // pnlButtonRight
            // 
            this.pnlButtonRight.Controls.Add(this.pnlClear);
            this.pnlButtonRight.Controls.Add(this.btnAdd);
            this.pnlButtonRight.Controls.Add(this.txtSearch);
            this.pnlButtonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonRight.Location = new System.Drawing.Point(210, 0);
            this.pnlButtonRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtonRight.Name = "pnlButtonRight";
            this.pnlButtonRight.Size = new System.Drawing.Size(424, 44);
            this.pnlButtonRight.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(301, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(124, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(129, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlClear
            // 
            this.pnlClear.BackgroundImage = global::WaterSystem_v1.Properties.Resources.clear1;
            this.pnlClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlClear.Location = new System.Drawing.Point(254, 14);
            this.pnlClear.Name = "pnlClear";
            this.pnlClear.Size = new System.Drawing.Size(20, 20);
            this.pnlClear.TabIndex = 3;
            // 
            // pnlButtonLeftContainer
            // 
            this.pnlButtonLeftContainer.Controls.Add(this.btnPreview);
            this.pnlButtonLeftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonLeftContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonLeftContainer.Name = "pnlButtonLeftContainer";
            this.pnlButtonLeftContainer.Size = new System.Drawing.Size(210, 44);
            this.pnlButtonLeftContainer.TabIndex = 9;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreview.Location = new System.Drawing.Point(29, 10);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(103, 35);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // ovlSupplier
            // 
            this.ovlSupplier.CellEditUseWholeCell = false;
            this.ovlSupplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovlSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ovlSupplier.HasCollapsibleGroups = false;
            this.ovlSupplier.Location = new System.Drawing.Point(0, 157);
            this.ovlSupplier.MenuLabelGroupBy = "";
            this.ovlSupplier.MenuLabelLockGroupingOn = "";
            this.ovlSupplier.MenuLabelSortAscending = "";
            this.ovlSupplier.MenuLabelUnlockGroupingOn = "";
            this.ovlSupplier.Name = "ovlSupplier";
            this.ovlSupplier.Size = new System.Drawing.Size(634, 224);
            this.ovlSupplier.TabIndex = 7;
            this.ovlSupplier.UseCompatibleStateImageBehavior = false;
            this.ovlSupplier.View = System.Windows.Forms.View.Details;
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSupplier";
            this.Text = "FrmSupplier";
            this.pnlContainer.ResumeLayout(false);
            this.pnlTopContainer.ResumeLayout(false);
            this.pnlButtonContainer.ResumeLayout(false);
            this.pnlButtonRight.ResumeLayout(false);
            this.pnlButtonRight.PerformLayout();
            this.pnlButtonLeftContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovlSupplier)).EndInit();
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
        private BrightIdeasSoftware.ObjectListView ovlSupplier;
    }
}