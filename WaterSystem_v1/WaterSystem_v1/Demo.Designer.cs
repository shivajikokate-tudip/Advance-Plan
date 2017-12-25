namespace WaterSystem_v1
{
    partial class Demo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ovlMeasurement = new BrightIdeasSoftware.ObjectListView();
            this.pnlTopContainer = new System.Windows.Forms.Panel();
            this.pnlTopChildContainer = new System.Windows.Forms.Panel();
            this.pnlButtonLeft = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pnlButtonRight = new System.Windows.Forms.Panel();
            this.pnlClear = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovlMeasurement)).BeginInit();
            this.pnlTopContainer.SuspendLayout();
            this.pnlTopChildContainer.SuspendLayout();
            this.pnlButtonLeft.SuspendLayout();
            this.pnlButtonRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(159, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.pnlTopContainer);
            this.panel2.Controls.Add(this.ovlMeasurement);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 397);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ovlMeasurement
            // 
            this.ovlMeasurement.CellEditUseWholeCell = false;
            this.ovlMeasurement.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovlMeasurement.HasCollapsibleGroups = false;
            this.ovlMeasurement.Location = new System.Drawing.Point(177, 33);
            this.ovlMeasurement.MenuLabelGroupBy = "";
            this.ovlMeasurement.MenuLabelLockGroupingOn = "";
            this.ovlMeasurement.MenuLabelSortAscending = "";
            this.ovlMeasurement.MenuLabelUnlockGroupingOn = "";
            this.ovlMeasurement.Name = "ovlMeasurement";
            this.ovlMeasurement.Size = new System.Drawing.Size(372, 136);
            this.ovlMeasurement.TabIndex = 3;
            this.ovlMeasurement.UseCompatibleStateImageBehavior = false;
            this.ovlMeasurement.View = System.Windows.Forms.View.Details;
            this.ovlMeasurement.SelectedIndexChanged += new System.EventHandler(this.ovlMeasurement_SelectedIndexChanged);
            // 
            // pnlTopContainer
            // 
            this.pnlTopContainer.Controls.Add(this.pnlTopChildContainer);
            this.pnlTopContainer.Location = new System.Drawing.Point(81, 198);
            this.pnlTopContainer.Name = "pnlTopContainer";
            this.pnlTopContainer.Size = new System.Drawing.Size(548, 106);
            this.pnlTopContainer.TabIndex = 4;
            // 
            // pnlTopChildContainer
            // 
            this.pnlTopChildContainer.Controls.Add(this.pnlButtonLeft);
            this.pnlTopChildContainer.Controls.Add(this.pnlButtonRight);
            this.pnlTopChildContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopChildContainer.Location = new System.Drawing.Point(0, 37);
            this.pnlTopChildContainer.Name = "pnlTopChildContainer";
            this.pnlTopChildContainer.Size = new System.Drawing.Size(548, 69);
            this.pnlTopChildContainer.TabIndex = 0;
            // 
            // pnlButtonLeft
            // 
            this.pnlButtonLeft.Controls.Add(this.btnPreview);
            this.pnlButtonLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonLeft.Name = "pnlButtonLeft";
            this.pnlButtonLeft.Size = new System.Drawing.Size(210, 69);
            this.pnlButtonLeft.TabIndex = 3;
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
            // pnlButtonRight
            // 
            this.pnlButtonRight.Controls.Add(this.pnlClear);
            this.pnlButtonRight.Controls.Add(this.btnAdd);
            this.pnlButtonRight.Controls.Add(this.textBox1);
            this.pnlButtonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonRight.Location = new System.Drawing.Point(210, 0);
            this.pnlButtonRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtonRight.Name = "pnlButtonRight";
            this.pnlButtonRight.Size = new System.Drawing.Size(338, 69);
            this.pnlButtonRight.TabIndex = 2;
            // 
            // pnlClear
            // 
            this.pnlClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlClear.Location = new System.Drawing.Point(202, 22);
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
            this.btnAdd.Location = new System.Drawing.Point(234, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Demo";
            this.Text = "Demo";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovlMeasurement)).EndInit();
            this.pnlTopContainer.ResumeLayout(false);
            this.pnlTopChildContainer.ResumeLayout(false);
            this.pnlButtonLeft.ResumeLayout(false);
            this.pnlButtonRight.ResumeLayout(false);
            this.pnlButtonRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private BrightIdeasSoftware.ObjectListView ovlMeasurement;
        private System.Windows.Forms.Panel pnlTopContainer;
        private System.Windows.Forms.Panel pnlTopChildContainer;
        private System.Windows.Forms.Panel pnlButtonLeft;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel pnlButtonRight;
        private System.Windows.Forms.Panel pnlClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
    }
}