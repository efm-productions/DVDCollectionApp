namespace MyDVDsMain.Views
{
    partial class DisplayMain
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalBoxsets = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalBoxes = new System.Windows.Forms.TextBox();
            this.txtTotalCases = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalContents = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalDiscs = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectBoxNum = new System.Windows.Forms.Button();
            this.btnStartBox = new System.Windows.Forms.Button();
            this.cboBoxNums = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRatings = new System.Windows.Forms.Button();
            this.btnGenres = new System.Windows.Forms.Button();
            this.btnIcons = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dVDIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startANewBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.castToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdAllContents = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllContents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(655, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.txtTotalBoxsets, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalBoxes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalCases, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalContents, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalDiscs, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.54099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.45901F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTotalBoxsets
            // 
            this.txtTotalBoxsets.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalBoxsets.Location = new System.Drawing.Point(145, 70);
            this.txtTotalBoxsets.Name = "txtTotalBoxsets";
            this.txtTotalBoxsets.ReadOnly = true;
            this.txtTotalBoxsets.Size = new System.Drawing.Size(71, 24);
            this.txtTotalBoxsets.TabIndex = 0;
            this.txtTotalBoxsets.TabStop = false;
            this.txtTotalBoxsets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Boxsets";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Boxes";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Cases";
            // 
            // txtTotalBoxes
            // 
            this.txtTotalBoxes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalBoxes.Location = new System.Drawing.Point(145, 3);
            this.txtTotalBoxes.Name = "txtTotalBoxes";
            this.txtTotalBoxes.ReadOnly = true;
            this.txtTotalBoxes.Size = new System.Drawing.Size(71, 24);
            this.txtTotalBoxes.TabIndex = 0;
            this.txtTotalBoxes.TabStop = false;
            this.txtTotalBoxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCases
            // 
            this.txtTotalCases.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalCases.Location = new System.Drawing.Point(145, 36);
            this.txtTotalCases.Name = "txtTotalCases";
            this.txtTotalCases.ReadOnly = true;
            this.txtTotalCases.Size = new System.Drawing.Size(71, 24);
            this.txtTotalCases.TabIndex = 0;
            this.txtTotalCases.TabStop = false;
            this.txtTotalCases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Selections";
            // 
            // txtTotalContents
            // 
            this.txtTotalContents.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalContents.Location = new System.Drawing.Point(145, 137);
            this.txtTotalContents.Name = "txtTotalContents";
            this.txtTotalContents.ReadOnly = true;
            this.txtTotalContents.Size = new System.Drawing.Size(71, 24);
            this.txtTotalContents.TabIndex = 0;
            this.txtTotalContents.TabStop = false;
            this.txtTotalContents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Discs";
            // 
            // txtTotalDiscs
            // 
            this.txtTotalDiscs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalDiscs.Location = new System.Drawing.Point(145, 105);
            this.txtTotalDiscs.Name = "txtTotalDiscs";
            this.txtTotalDiscs.ReadOnly = true;
            this.txtTotalDiscs.Size = new System.Drawing.Size(71, 24);
            this.txtTotalDiscs.TabIndex = 0;
            this.txtTotalDiscs.TabStop = false;
            this.txtTotalDiscs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectBoxNum);
            this.groupBox2.Controls.Add(this.btnStartBox);
            this.groupBox2.Controls.Add(this.cboBoxNums);
            this.groupBox2.Location = new System.Drawing.Point(294, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 114);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DVD\'s";
            // 
            // btnSelectBoxNum
            // 
            this.btnSelectBoxNum.Location = new System.Drawing.Point(19, 29);
            this.btnSelectBoxNum.Name = "btnSelectBoxNum";
            this.btnSelectBoxNum.Size = new System.Drawing.Size(206, 26);
            this.btnSelectBoxNum.TabIndex = 2;
            this.btnSelectBoxNum.Text = "Select a Box to View/Edit";
            this.btnSelectBoxNum.UseVisualStyleBackColor = true;
            this.btnSelectBoxNum.Click += new System.EventHandler(this.btnSelectBoxNum_Click);
            // 
            // btnStartBox
            // 
            this.btnStartBox.Location = new System.Drawing.Point(19, 69);
            this.btnStartBox.Name = "btnStartBox";
            this.btnStartBox.Size = new System.Drawing.Size(206, 26);
            this.btnStartBox.TabIndex = 3;
            this.btnStartBox.Text = "Start a New Box";
            this.btnStartBox.UseVisualStyleBackColor = true;
            this.btnStartBox.Click += new System.EventHandler(this.btnStartBox_Click);
            // 
            // cboBoxNums
            // 
            this.cboBoxNums.FormattingEnabled = true;
            this.cboBoxNums.Location = new System.Drawing.Point(238, 29);
            this.cboBoxNums.Name = "cboBoxNums";
            this.cboBoxNums.Size = new System.Drawing.Size(68, 24);
            this.cboBoxNums.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.tableLayoutPanel2.Controls.Add(this.txtSearchTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(61, 499);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(797, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearchTitle.Location = new System.Drawing.Point(218, 15);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(576, 24);
            this.txtSearchTitle.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Location = new System.Drawing.Point(55, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 26);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search for a Title...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(299, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 71);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administrator";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnRatings, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGenres, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnIcons, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(302, 33);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnRatings
            // 
            this.btnRatings.Location = new System.Drawing.Point(209, 3);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.Size = new System.Drawing.Size(90, 26);
            this.btnRatings.TabIndex = 6;
            this.btnRatings.Text = "Ratings";
            this.btnRatings.UseVisualStyleBackColor = true;
            this.btnRatings.Click += new System.EventHandler(this.btnRatings_Click);
            // 
            // btnGenres
            // 
            this.btnGenres.Location = new System.Drawing.Point(106, 3);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Size = new System.Drawing.Size(97, 26);
            this.btnGenres.TabIndex = 5;
            this.btnGenres.Text = "Genres";
            this.btnGenres.UseVisualStyleBackColor = true;
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
            // 
            // btnIcons
            // 
            this.btnIcons.Location = new System.Drawing.Point(3, 3);
            this.btnIcons.Name = "btnIcons";
            this.btnIcons.Size = new System.Drawing.Size(97, 26);
            this.btnIcons.TabIndex = 4;
            this.btnIcons.Text = "Icons";
            this.btnIcons.UseVisualStyleBackColor = true;
            this.btnIcons.Click += new System.EventHandler(this.btnIcons_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.administratorToolStripMenuItem,
            this.collectionToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(934, 24);
            this.mainMenu.TabIndex = 6;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dVDIconsToolStripMenuItem,
            this.genresToolStripMenuItem,
            this.ratingsToolStripMenuItem});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "&Administrator";
            // 
            // dVDIconsToolStripMenuItem
            // 
            this.dVDIconsToolStripMenuItem.Name = "dVDIconsToolStripMenuItem";
            this.dVDIconsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dVDIconsToolStripMenuItem.Text = "&Icons";
            this.dVDIconsToolStripMenuItem.Click += new System.EventHandler(this.dVDIconsToolStripMenuItem_Click);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.genresToolStripMenuItem.Text = "&Genres";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.genresToolStripMenuItem_Click);
            // 
            // ratingsToolStripMenuItem
            // 
            this.ratingsToolStripMenuItem.Name = "ratingsToolStripMenuItem";
            this.ratingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ratingsToolStripMenuItem.Text = "&Ratings";
            this.ratingsToolStripMenuItem.Click += new System.EventHandler(this.ratingsToolStripMenuItem_Click);
            // 
            // collectionToolStripMenuItem
            // 
            this.collectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startANewBoxToolStripMenuItem,
            this.viewCollectionToolStripMenuItem});
            this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
            this.collectionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.collectionToolStripMenuItem.Text = "&Collection";
            // 
            // startANewBoxToolStripMenuItem
            // 
            this.startANewBoxToolStripMenuItem.Name = "startANewBoxToolStripMenuItem";
            this.startANewBoxToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.startANewBoxToolStripMenuItem.Text = "&Start A New Box";
            // 
            // viewCollectionToolStripMenuItem
            // 
            this.viewCollectionToolStripMenuItem.Name = "viewCollectionToolStripMenuItem";
            this.viewCollectionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.viewCollectionToolStripMenuItem.Text = "&View Collection";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byTitleToolStripMenuItem,
            this.castToolStripMenuItem,
            this.directorToolStripMenuItem,
            this.yearToolStripMenuItem,
            this.byGenreToolStripMenuItem,
            this.byRatingToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.searchToolStripMenuItem.Text = "&DVD Search";
            // 
            // byTitleToolStripMenuItem
            // 
            this.byTitleToolStripMenuItem.Name = "byTitleToolStripMenuItem";
            this.byTitleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.byTitleToolStripMenuItem.Text = "By T&itle";
            // 
            // castToolStripMenuItem
            // 
            this.castToolStripMenuItem.Name = "castToolStripMenuItem";
            this.castToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.castToolStripMenuItem.Text = "By Ca&st";
            // 
            // directorToolStripMenuItem
            // 
            this.directorToolStripMenuItem.Name = "directorToolStripMenuItem";
            this.directorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.directorToolStripMenuItem.Text = "By &Director";
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.yearToolStripMenuItem.Text = "By &Year";
            // 
            // byGenreToolStripMenuItem
            // 
            this.byGenreToolStripMenuItem.Name = "byGenreToolStripMenuItem";
            this.byGenreToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.byGenreToolStripMenuItem.Text = "By &Genre";
            // 
            // byRatingToolStripMenuItem
            // 
            this.byRatingToolStripMenuItem.Name = "byRatingToolStripMenuItem";
            this.byRatingToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.byRatingToolStripMenuItem.Text = "By &Rating";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(23, 246);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(187, 26);
            this.btnViewDetails.TabIndex = 7;
            this.btnViewDetails.Text = "View Selections Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyDVDsMain.Properties.Resources.DVDCase6;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 152);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grdAllContents
            // 
            this.grdAllContents.AllowUserToAddRows = false;
            this.grdAllContents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grdAllContents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAllContents.BackgroundColor = System.Drawing.Color.OldLace;
            this.grdAllContents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllContents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAllContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllContents.EnableHeadersVisualStyles = false;
            this.grdAllContents.Location = new System.Drawing.Point(21, 282);
            this.grdAllContents.MultiSelect = false;
            this.grdAllContents.Name = "grdAllContents";
            this.grdAllContents.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllContents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan;
            this.grdAllContents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAllContents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAllContents.Size = new System.Drawing.Size(892, 214);
            this.grdAllContents.TabIndex = 0;
            this.grdAllContents.TabStop = false;
            this.grdAllContents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllContents_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(858, 513);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 26);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DisplayMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(934, 567);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grdAllContents);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DisplayMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My DVD Collection";
            this.Load += new System.EventHandler(this.DisplayMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllContents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalBoxes;
        private System.Windows.Forms.TextBox txtTotalCases;
        private System.Windows.Forms.TextBox txtTotalDiscs;
        private System.Windows.Forms.TextBox txtTotalContents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartBox;
        private System.Windows.Forms.ComboBox cboBoxNums;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnGenres;
        private System.Windows.Forms.Button btnRatings;
        private System.Windows.Forms.Button btnIcons;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSelectBoxNum;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dVDIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startANewBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCollectionToolStripMenuItem;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem castToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTotalBoxsets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem byGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byRatingToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdAllContents;
        private System.Windows.Forms.Button btnClear;
    }
}