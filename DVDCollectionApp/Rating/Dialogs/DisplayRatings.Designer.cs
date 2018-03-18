namespace Rt.Dialogs
{
    partial class DisplayRatings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayRatings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdAllRatings = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.btnEditRating = new System.Windows.Forms.Button();
            this.btnCloseRating = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllRatings)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdAllRatings);
            this.groupBox1.Location = new System.Drawing.Point(143, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 374);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ratings";
            // 
            // grdAllRatings
            // 
            this.grdAllRatings.AllowUserToAddRows = false;
            this.grdAllRatings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grdAllRatings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAllRatings.BackgroundColor = System.Drawing.Color.OldLace;
            this.grdAllRatings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllRatings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAllRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllRatings.EnableHeadersVisualStyles = false;
            this.grdAllRatings.Location = new System.Drawing.Point(24, 36);
            this.grdAllRatings.MultiSelect = false;
            this.grdAllRatings.Name = "grdAllRatings";
            this.grdAllRatings.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllRatings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan;
            this.grdAllRatings.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAllRatings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAllRatings.Size = new System.Drawing.Size(588, 321);
            this.grdAllRatings.TabIndex = 1;
            this.grdAllRatings.TabStop = false;
            this.grdAllRatings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllRatings_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnAddRating, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnEditRating, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnCloseRating, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 226);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(112, 108);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnAddRating
            // 
            this.btnAddRating.Location = new System.Drawing.Point(4, 4);
            this.btnAddRating.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(100, 26);
            this.btnAddRating.TabIndex = 4;
            this.btnAddRating.Text = "Add";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // btnEditRating
            // 
            this.btnEditRating.Location = new System.Drawing.Point(4, 38);
            this.btnEditRating.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditRating.Name = "btnEditRating";
            this.btnEditRating.Size = new System.Drawing.Size(100, 26);
            this.btnEditRating.TabIndex = 6;
            this.btnEditRating.Text = "Edit";
            this.btnEditRating.UseVisualStyleBackColor = true;
            this.btnEditRating.Click += new System.EventHandler(this.btnEditRating_Click);
            // 
            // btnCloseRating
            // 
            this.btnCloseRating.Location = new System.Drawing.Point(4, 73);
            this.btnCloseRating.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseRating.Name = "btnCloseRating";
            this.btnCloseRating.Size = new System.Drawing.Size(100, 26);
            this.btnCloseRating.TabIndex = 8;
            this.btnCloseRating.Text = "Close";
            this.btnCloseRating.UseVisualStyleBackColor = true;
            this.btnCloseRating.Click += new System.EventHandler(this.btnCloseRating_Click);
            // 
            // DisplayRatings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(795, 504);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayRatings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Ratings";
            this.Load += new System.EventHandler(this.DisplayRatings_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllRatings)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdAllRatings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.Button btnEditRating;
        private System.Windows.Forms.Button btnCloseRating;
    }
}