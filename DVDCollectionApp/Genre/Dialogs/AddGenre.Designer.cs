namespace Gnr.Dialogs
{
    partial class AddGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGenre));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddbtnSave = new System.Windows.Forms.Button();
            this.AddbtnClose = new System.Windows.Forms.Button();
            this.AddbtnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.AddtxtName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.AddbtnSave, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.AddbtnClose, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(57, 221);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(112, 70);
            this.tableLayoutPanel2.TabIndex = 13;
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
            // AddbtnClear
            // 
            this.AddbtnClear.Location = new System.Drawing.Point(624, 84);
            this.AddbtnClear.Name = "AddbtnClear";
            this.AddbtnClear.Size = new System.Drawing.Size(75, 23);
            this.AddbtnClear.TabIndex = 14;
            this.AddbtnClear.Text = "Clear";
            this.AddbtnClear.UseVisualStyleBackColor = true;
            this.AddbtnClear.Click += new System.EventHandler(this.AddbtnClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddtxtName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(139, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 36);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddtxtName
            // 
            this.AddtxtName.Location = new System.Drawing.Point(61, 3);
            this.AddtxtName.Name = "AddtxtName";
            this.AddtxtName.Size = new System.Drawing.Size(394, 24);
            this.AddtxtName.TabIndex = 1;
            // 
            // AddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(795, 504);
            this.Controls.Add(this.AddbtnClear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Genre";
            this.Load += new System.EventHandler(this.AddGenre_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddbtnSave;
        private System.Windows.Forms.Button AddbtnClose;
        private System.Windows.Forms.Button AddbtnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddtxtName;
    }
}