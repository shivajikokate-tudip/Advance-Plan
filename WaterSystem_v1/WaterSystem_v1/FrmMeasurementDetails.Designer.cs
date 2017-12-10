namespace WaterSystem_v1
{
    partial class FrmMeasurementDetails
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
            this.tblLayoutMeasurement = new System.Windows.Forms.TableLayoutPanel();
            this.dgMeasurement = new System.Windows.Forms.DataGridView();
            this.pnlTopContainer = new System.Windows.Forms.Panel();
            this.pnlTopChildContainer = new System.Windows.Forms.Panel();
            this.pnlButtonLeft = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pnlButtonRight = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlClear = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.tblLayoutMeasurement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMeasurement)).BeginInit();
            this.pnlTopContainer.SuspendLayout();
            this.pnlTopChildContainer.SuspendLayout();
            this.pnlButtonLeft.SuspendLayout();
            this.pnlButtonRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutMeasurement
            // 
            this.tblLayoutMeasurement.ColumnCount = 1;
            this.tblLayoutMeasurement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutMeasurement.Controls.Add(this.dgMeasurement, 0, 1);
            this.tblLayoutMeasurement.Controls.Add(this.pnlTopContainer, 0, 0);
            this.tblLayoutMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutMeasurement.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutMeasurement.Name = "tblLayoutMeasurement";
            this.tblLayoutMeasurement.RowCount = 2;
            this.tblLayoutMeasurement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.71866F));
            this.tblLayoutMeasurement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.28134F));
            this.tblLayoutMeasurement.Size = new System.Drawing.Size(620, 359);
            this.tblLayoutMeasurement.TabIndex = 0;
            // 
            // dgMeasurement
            // 
            this.dgMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMeasurement.Location = new System.Drawing.Point(3, 141);
            this.dgMeasurement.Name = "dgMeasurement";
            this.dgMeasurement.Size = new System.Drawing.Size(614, 215);
            this.dgMeasurement.TabIndex = 0;
            // 
            // pnlTopContainer
            // 
            this.pnlTopContainer.Controls.Add(this.pnlTopChildContainer);
            this.pnlTopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopContainer.Location = new System.Drawing.Point(3, 3);
            this.pnlTopContainer.Name = "pnlTopContainer";
            this.pnlTopContainer.Size = new System.Drawing.Size(614, 132);
            this.pnlTopContainer.TabIndex = 1;
            // 
            // pnlTopChildContainer
            // 
            this.pnlTopChildContainer.Controls.Add(this.pnlButtonLeft);
            this.pnlTopChildContainer.Controls.Add(this.pnlButtonRight);
            this.pnlTopChildContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopChildContainer.Location = new System.Drawing.Point(0, 63);
            this.pnlTopChildContainer.Name = "pnlTopChildContainer";
            this.pnlTopChildContainer.Size = new System.Drawing.Size(614, 69);
            this.pnlTopChildContainer.TabIndex = 0;
            // 
            // pnlButtonLeft
            // 
            this.pnlButtonLeft.Controls.Add(this.btnPreview);
            this.pnlButtonLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonLeft.Name = "pnlButtonLeft";
            this.pnlButtonLeft.Size = new System.Drawing.Size(276, 69);
            this.pnlButtonLeft.TabIndex = 3;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreview.Location = new System.Drawing.Point(29, 10);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(103, 35);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            // 
            // pnlButtonRight
            // 
            this.pnlButtonRight.Controls.Add(this.pnlClear);
            this.pnlButtonRight.Controls.Add(this.pnlSearch);
            this.pnlButtonRight.Controls.Add(this.btnAdd);
            this.pnlButtonRight.Controls.Add(this.textBox1);
            this.pnlButtonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonRight.Location = new System.Drawing.Point(276, 0);
            this.pnlButtonRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtonRight.Name = "pnlButtonRight";
            this.pnlButtonRight.Size = new System.Drawing.Size(338, 69);
            this.pnlButtonRight.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(234, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pnlClear
            // 
            this.pnlClear.BackgroundImage = global::WaterSystem_v1.Properties.Resources.clear;
            this.pnlClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClear.Location = new System.Drawing.Point(202, 22);
            this.pnlClear.Name = "pnlClear";
            this.pnlClear.Size = new System.Drawing.Size(20, 20);
            this.pnlClear.TabIndex = 3;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackgroundImage = global::WaterSystem_v1.Properties.Resources.search;
            this.pnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Location = new System.Drawing.Point(51, 22);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(20, 20);
            this.pnlSearch.TabIndex = 2;
            // 
            // FrmMeasurementDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(620, 359);
            this.Controls.Add(this.tblLayoutMeasurement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMeasurementDetails";
            this.Text = "FrmMeasurementDetails";
            this.tblLayoutMeasurement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMeasurement)).EndInit();
            this.pnlTopContainer.ResumeLayout(false);
            this.pnlTopChildContainer.ResumeLayout(false);
            this.pnlButtonLeft.ResumeLayout(false);
            this.pnlButtonRight.ResumeLayout(false);
            this.pnlButtonRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutMeasurement;
        private System.Windows.Forms.DataGridView dgMeasurement;
        private System.Windows.Forms.Panel pnlTopContainer;
        private System.Windows.Forms.Panel pnlTopChildContainer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel pnlButtonRight;
        private System.Windows.Forms.Panel pnlButtonLeft;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlClear;
    }
}