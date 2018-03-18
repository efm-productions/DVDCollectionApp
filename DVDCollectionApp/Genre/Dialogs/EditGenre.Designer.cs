namespace Gnr.Dialogs
{
    partial class EditGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGenre));
            this.EditbtnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EdittxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EdittxtName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EditbtnSave = new System.Windows.Forms.Button();
            this.EditbtnClose = new System.Windows.Forms.Button();
            this.EditbtnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditbtnClear
            // 
            this.EditbtnClear.Location = new System.Drawing.Point(624, 84);
            this.EditbtnClear.Name = "EditbtnClear";
            this.EditbtnClear.Size = new System.Drawing.Size(75, 23);
            this.EditbtnClear.TabIndex = 17;
            this.EditbtnClear.Text = "Clear";
            this.EditbtnClear.UseVisualStyleBackColor = true;
            this.EditbtnClear.Click += new System.EventHandler(this.EditbtnClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.58065F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.41935F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 398F));
            this.tableLayoutPanel1.Controls.Add(this.EdittxtId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EdittxtName, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(89, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 36);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // EdittxtId
            // 
            this.EdittxtId.Location = new System.Drawing.Point(4, 4);
            this.EdittxtId.Margin = new System.Windows.Forms.Padding(4);
            this.EdittxtId.Name = "EdittxtId";
            this.EdittxtId.ReadOnly = true;
            this.EdittxtId.Size = new System.Drawing.Size(41, 24);
            this.EdittxtId.TabIndex = 19;
            this.EdittxtId.TabStop = false;
            this.EdittxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EdittxtName
            // 
            this.EdittxtName.Location = new System.Drawing.Point(115, 3);
            this.EdittxtName.Name = "EdittxtName";
            this.EdittxtName.Size = new System.Drawing.Size(390, 24);
            this.EdittxtName.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.EditbtnSave, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.EditbtnClose, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.EditbtnDelete, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(57, 221);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(112, 102);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // EditbtnSave
            // 
            this.EditbtnSave.Location = new System.Drawing.Point(4, 4);
            this.EditbtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.EditbtnSave.Name = "EditbtnSave";
            this.EditbtnSave.Size = new System.Drawing.Size(100, 26);
            this.EditbtnSave.TabIndex = 4;
            this.EditbtnSave.Text = "Save";
            this.EditbtnSave.UseVisualStyleBackColor = true;
            this.EditbtnSave.Click += new System.EventHandler(this.EditbtnSave_Click);
            // 
            // EditbtnClose
            // 
            this.EditbtnClose.Location = new System.Drawing.Point(4, 73);
            this.EditbtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.EditbtnClose.Name = "EditbtnClose";
            this.EditbtnClose.Size = new System.Drawing.Size(100, 25);
            this.EditbtnClose.TabIndex = 8;
            this.EditbtnClose.Text = "Cancel";
            this.EditbtnClose.UseVisualStyleBackColor = true;
            this.EditbtnClose.Click += new System.EventHandler(this.EditbtnClose_Click);
            // 
            // EditbtnDelete
            // 
            this.EditbtnDelete.Location = new System.Drawing.Point(4, 38);
            this.EditbtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.EditbtnDelete.Name = "EditbtnDelete";
            this.EditbtnDelete.Size = new System.Drawing.Size(100, 26);
            this.EditbtnDelete.TabIndex = 19;
            this.EditbtnDelete.Text = "Delete";
            this.EditbtnDelete.UseVisualStyleBackColor = true;
            this.EditbtnDelete.Click += new System.EventHandler(this.EditbtnDelete_Click);
            // 
            // EditGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(795, 504);
            this.Controls.Add(this.EditbtnClear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit a Genre";
            this.Load += new System.EventHandler(this.EditGenre_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditbtnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox EdittxtName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button EditbtnSave;
        private System.Windows.Forms.Button EditbtnClose;
        private System.Windows.Forms.TextBox EdittxtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditbtnDelete;
    }
}