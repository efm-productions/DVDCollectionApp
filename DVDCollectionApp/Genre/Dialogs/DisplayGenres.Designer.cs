namespace Gnr.Dialogs
{
    partial class DisplayGenres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayGenres));
            this.btnEditGenre = new System.Windows.Forms.Button();
            this.btnCloseGenres = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdAllGenres = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllGenres)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditGenre
            // 
            this.btnEditGenre.Location = new System.Drawing.Point(4, 38);
            this.btnEditGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditGenre.Name = "btnEditGenre";
            this.btnEditGenre.Size = new System.Drawing.Size(100, 26);
            this.btnEditGenre.TabIndex = 6;
            this.btnEditGenre.Text = "Edit";
            this.btnEditGenre.UseVisualStyleBackColor = true;
            this.btnEditGenre.Click += new System.EventHandler(this.btnEditGenre_Click);
            // 
            // btnCloseGenres
            // 
            this.btnCloseGenres.Location = new System.Drawing.Point(4, 73);
            this.btnCloseGenres.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseGenres.Name = "btnCloseGenres";
            this.btnCloseGenres.Size = new System.Drawing.Size(100, 26);
            this.btnCloseGenres.TabIndex = 8;
            this.btnCloseGenres.Text = "Close";
            this.btnCloseGenres.UseVisualStyleBackColor = true;
            this.btnCloseGenres.Click += new System.EventHandler(this.btnCloseGenres_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(4, 4);
            this.btnAddGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(100, 26);
            this.btnAddGenre.TabIndex = 4;
            this.btnAddGenre.Text = "Add";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdAllGenres);
            this.groupBox1.Location = new System.Drawing.Point(175, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 374);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genres";
            // 
            // grdAllGenres
            // 
            this.grdAllGenres.AllowUserToAddRows = false;
            this.grdAllGenres.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grdAllGenres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAllGenres.BackgroundColor = System.Drawing.Color.OldLace;
            this.grdAllGenres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAllGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllGenres.EnableHeadersVisualStyles = false;
            this.grdAllGenres.Location = new System.Drawing.Point(24, 36);
            this.grdAllGenres.MultiSelect = false;
            this.grdAllGenres.Name = "grdAllGenres";
            this.grdAllGenres.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllGenres.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan;
            this.grdAllGenres.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAllGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAllGenres.Size = new System.Drawing.Size(522, 321);
            this.grdAllGenres.TabIndex = 1;
            this.grdAllGenres.TabStop = false;
            this.grdAllGenres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllGenres_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnAddGenre, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnEditGenre, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnCloseGenres, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(31, 226);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(112, 108);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // DisplayGenres
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayGenres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Genres";
            this.Load += new System.EventHandler(this.DisplayGenres_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllGenres)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditGenre;
        private System.Windows.Forms.Button btnCloseGenres;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView grdAllGenres;
    }
}