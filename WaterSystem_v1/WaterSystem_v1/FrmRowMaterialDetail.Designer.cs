namespace WaterSystem_v1
{
    partial class FrmRowMaterialDetail
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
            this.pnlRowMaterial = new System.Windows.Forms.Panel();
            this.pnlListContainer = new System.Windows.Forms.Panel();
            this.ovlMeasurement = new BrightIdeasSoftware.ObjectListView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.pnlButtonRight = new System.Windows.Forms.Panel();
            this.pnlClear = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlButtonLeftContainer = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pnlRowMaterial.SuspendLayout();
            this.pnlListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovlMeasurement)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.pnlButtonRight.SuspendLayout();
            this.pnlButtonLeftContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRowMaterial
            // 
            this.pnlRowMaterial.Controls.Add(this.pnlListContainer);
            this.pnlRowMaterial.Controls.Add(this.pnlTop);
            this.pnlRowMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRowMaterial.Location = new System.Drawing.Point(0, 0);
            this.pnlRowMaterial.Name = "pnlRowMaterial";
            this.pnlRowMaterial.Size = new System.Drawing.Size(643, 434);
            this.pnlRowMaterial.TabIndex = 0;
            // 
            // pnlListContainer
            // 
            this.pnlListContainer.Controls.Add(this.ovlMeasurement);
            this.pnlListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListContainer.Location = new System.Drawing.Point(0, 207);
            this.pnlListContainer.Name = "pnlListContainer";
            this.pnlListContainer.Size = new System.Drawing.Size(643, 227);
            this.pnlListContainer.TabIndex = 11;
            // 
            // ovlMeasurement
            // 
            this.ovlMeasurement.CellEditUseWholeCell = false;
            this.ovlMeasurement.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovlMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ovlMeasurement.HasCollapsibleGroups = false;
            this.ovlMeasurement.Location = new System.Drawing.Point(0, 0);
            this.ovlMeasurement.MenuLabelGroupBy = "";
            this.ovlMeasurement.MenuLabelLockGroupingOn = "";
            this.ovlMeasurement.MenuLabelSortAscending = "";
            this.ovlMeasurement.MenuLabelUnlockGroupingOn = "";
            this.ovlMeasurement.Name = "ovlMeasurement";
            this.ovlMeasurement.Size = new System.Drawing.Size(643, 227);
            this.ovlMeasurement.TabIndex = 6;
            this.ovlMeasurement.UseCompatibleStateImageBehavior = false;
            this.ovlMeasurement.View = System.Windows.Forms.View.Details;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlButtonContainer);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(643, 207);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlButtonContainer
            // 
            this.pnlButtonContainer.Controls.Add(this.pnlButtonRight);
            this.pnlButtonContainer.Controls.Add(this.pnlButtonLeftContainer);
            this.pnlButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonContainer.Location = new System.Drawing.Point(0, 154);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(643, 53);
            this.pnlButtonContainer.TabIndex = 0;
            // 
            // pnlButtonRight
            // 
            this.pnlButtonRight.Controls.Add(this.pnlClear);
            this.pnlButtonRight.Controls.Add(this.btnAdd);
            this.pnlButtonRight.Controls.Add(this.txtSearch);
            this.pnlButtonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonRight.Location = new System.Drawing.Point(219, 0);
            this.pnlButtonRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtonRight.Name = "pnlButtonRight";
            this.pnlButtonRight.Size = new System.Drawing.Size(424, 53);
            this.pnlButtonRight.TabIndex = 9;
            // 
            // pnlClear
            // 
            this.pnlClear.BackgroundImage = global::WaterSystem_v1.Properties.Resources.clear1;
            this.pnlClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlClear.Location = new System.Drawing.Point(254, 19);
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
            this.btnAdd.Location = new System.Drawing.Point(301, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(124, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(129, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlButtonLeftContainer
            // 
            this.pnlButtonLeftContainer.Controls.Add(this.btnPreview);
            this.pnlButtonLeftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonLeftContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonLeftContainer.Name = "pnlButtonLeftContainer";
            this.pnlButtonLeftContainer.Size = new System.Drawing.Size(643, 53);
            this.pnlButtonLeftContainer.TabIndex = 10;
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
            // FrmRowMaterialDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(643, 434);
            this.Controls.Add(this.pnlRowMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRowMaterialDetail";
            this.Text = "FrmRowMaterialDetail";
            this.pnlRowMaterial.ResumeLayout(false);
            this.pnlListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovlMeasurement)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlButtonContainer.ResumeLayout(false);
            this.pnlButtonRight.ResumeLayout(false);
            this.pnlButtonRight.PerformLayout();
            this.pnlButtonLeftContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRowMaterial;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.Panel pnlButtonRight;
        private System.Windows.Forms.Panel pnlClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlButtonLeftContainer;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel pnlListContainer;
        private BrightIdeasSoftware.ObjectListView ovlMeasurement;
    }
}