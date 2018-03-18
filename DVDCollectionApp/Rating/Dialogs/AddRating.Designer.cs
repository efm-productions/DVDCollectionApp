namespace Rt.Dialogs
{
    partial class AddRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRating));
            this.label2 = new System.Windows.Forms.Label();
            this.txtMPAACode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnClrMPAACode = new System.Windows.Forms.Button();
            this.btnClrDescription = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AddbtnSave = new System.Windows.Forms.Button();
            this.AddbtnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "MPAA Code";
            // 
            // txtMPAACode
            // 
            this.txtMPAACode.Location = new System.Drawing.Point(105, 4);
            this.txtMPAACode.Margin = new System.Windows.Forms.Padding(4);
            this.txtMPAACode.Name = "txtMPAACode";
            this.txtMPAACode.Size = new System.Drawing.Size(153, 24);
            this.txtMPAACode.TabIndex = 1;
            this.txtMPAACode.TextChanged += new System.EventHandler(this.txtMPAACode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(106, 4);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(576, 24);
            this.txtDescription.TabIndex = 2;
            // 
            // btnClrMPAACode
            // 
            this.btnClrMPAACode.Location = new System.Drawing.Point(266, 4);
            this.btnClrMPAACode.Margin = new System.Windows.Forms.Padding(4);
            this.btnClrMPAACode.Name = "btnClrMPAACode";
            this.btnClrMPAACode.Size = new System.Drawing.Size(73, 23);
            this.btnClrMPAACode.TabIndex = 10;
            this.btnClrMPAACode.TabStop = false;
            this.btnClrMPAACode.Text = "Clear";
            this.btnClrMPAACode.UseVisualStyleBackColor = true;
            this.btnClrMPAACode.Click += new System.EventHandler(this.btnClrMPAACode_Click);
            // 
            // btnClrDescription
            // 
            this.btnClrDescription.Location = new System.Drawing.Point(690, 4);
            this.btnClrDescription.Margin = new System.Windows.Forms.Padding(4);
            this.btnClrDescription.Name = "btnClrDescription";
            this.btnClrDescription.Size = new System.Drawing.Size(75, 23);
            this.btnClrDescription.TabIndex = 11;
            this.btnClrDescription.TabStop = false;
            this.btnClrDescription.Text = "Clear";
            this.btnClrDescription.UseVisualStyleBackColor = true;
            this.btnClrDescription.Click += new System.EventHandler(this.btnClrDescription_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMPAACode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClrMPAACode, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 33);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.9766F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0234F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClrDescription, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 125);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(775, 35);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.AddbtnSave, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.AddbtnClose, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 211);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(112, 70);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // AddbtnSave
            // 
            this.AddbtnSave.Location = new System.Drawing.Point(4, 4);
            this.AddbtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.AddbtnSave.Name = "AddbtnSave";
            this.AddbtnSave.Size = new System.Drawing.Size(100, 26);
            this.AddbtnSave.TabIndex = 4;
            this.AddbtnSave.Text = "Save";
            this.AddbtnSave.UseVisualStyleBackColor = true;
            this.AddbtnSave.Click += new System.EventHandler(this.AddbtnSave_Click);
            // 
            // AddbtnClose
            // 
            this.AddbtnClose.Location = new System.Drawing.Point(4, 38);
            this.AddbtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.AddbtnClose.Name = "AddbtnClose";
            this.AddbtnClose.Size = new System.Drawing.Size(100, 26);
            this.AddbtnClose.TabIndex = 8;
            this.AddbtnClose.Text = "Cancel";
            this.AddbtnClose.UseVisualStyleBackColor = true;
            this.AddbtnClose.Click += new System.EventHandler(this.AddbtnClose_Click);
            // 
            // AddRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(795, 504);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Rating";
            this.Load += new System.EventHandler(this.AddRating_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMPAACode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnClrMPAACode;
        private System.Windows.Forms.Button btnClrDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button AddbtnSave;
        private System.Windows.Forms.Button AddbtnClose;
    }
}