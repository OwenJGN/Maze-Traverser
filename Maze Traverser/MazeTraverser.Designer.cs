namespace NEA_Prototype
{
    partial class frmMazeTraverser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMazeTraverser));
            this.cbxAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblCustomMaze = new System.Windows.Forms.Label();
            this.btnMazeGen = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAlgorithmText = new System.Windows.Forms.Label();
            this.lblCurrentAlgorithm = new System.Windows.Forms.Label();
            this.btnSelectStart = new System.Windows.Forms.Button();
            this.btnSelectEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxSpeedOfSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.pnlCurrentSearch = new System.Windows.Forms.Panel();
            this.lblPathPossible = new System.Windows.Forms.Label();
            this.btnResetSandE = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.lblCurrentAL = new System.Windows.Forms.Label();
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.lblCurrentID = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnMultipleEnds = new System.Windows.Forms.Button();
            this.lblFileAccess = new System.Windows.Forms.Label();
            this.pnlSelectedPanel = new System.Windows.Forms.Panel();
            this.lblNodeID = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtNewWeight = new System.Windows.Forms.TextBox();
            this.btnChangeWeight = new System.Windows.Forms.Button();
            this.lblSelectSorE = new System.Windows.Forms.Label();
            this.lblCurrentNodeID = new System.Windows.Forms.Label();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.lblCurrentWeight = new System.Windows.Forms.Label();
            this.lblInvalidWeight = new System.Windows.Forms.Label();
            this.cbxUsersFiles = new System.Windows.Forms.ComboBox();
            this.pnlCurrentSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxAlgorithm
            // 
            this.cbxAlgorithm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlgorithm.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlgorithm.FormattingEnabled = true;
            this.cbxAlgorithm.Items.AddRange(new object[] {
            "Dijkstras",
            "A*",
            "Breadth",
            "Depth"});
            this.cbxAlgorithm.Location = new System.Drawing.Point(866, 272);
            this.cbxAlgorithm.Name = "cbxAlgorithm";
            this.cbxAlgorithm.Size = new System.Drawing.Size(120, 21);
            this.cbxAlgorithm.TabIndex = 7;
            this.cbxAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cbxAlgorithm_SelectedIndexChanged);
            // 
            // lblCustomMaze
            // 
            this.lblCustomMaze.BackColor = System.Drawing.Color.White;
            this.lblCustomMaze.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomMaze.ForeColor = System.Drawing.Color.DimGray;
            this.lblCustomMaze.Location = new System.Drawing.Point(882, 97);
            this.lblCustomMaze.Name = "lblCustomMaze";
            this.lblCustomMaze.Size = new System.Drawing.Size(259, 23);
            this.lblCustomMaze.TabIndex = 2;
            this.lblCustomMaze.Text = "Click on a square to change colour";
            // 
            // btnMazeGen
            // 
            this.btnMazeGen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMazeGen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMazeGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMazeGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMazeGen.FlatAppearance.BorderSize = 5;
            this.btnMazeGen.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMazeGen.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMazeGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMazeGen.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMazeGen.ForeColor = System.Drawing.Color.Transparent;
            this.btnMazeGen.Location = new System.Drawing.Point(854, 32);
            this.btnMazeGen.Name = "btnMazeGen";
            this.btnMazeGen.Size = new System.Drawing.Size(155, 40);
            this.btnMazeGen.TabIndex = 1;
            this.btnMazeGen.Text = "Generate New";
            this.btnMazeGen.UseVisualStyleBackColor = false;
            this.btnMazeGen.Click += new System.EventHandler(this.btnMazeGen_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 5;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(895, 314);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(246, 39);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblAlgorithmText
            // 
            this.lblAlgorithmText.BackColor = System.Drawing.Color.LightGray;
            this.lblAlgorithmText.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithmText.ForeColor = System.Drawing.Color.Gray;
            this.lblAlgorithmText.Location = new System.Drawing.Point(7, 7);
            this.lblAlgorithmText.Name = "lblAlgorithmText";
            this.lblAlgorithmText.Size = new System.Drawing.Size(155, 27);
            this.lblAlgorithmText.TabIndex = 14;
            this.lblAlgorithmText.Text = "Current Algorithm:";
            // 
            // lblCurrentAlgorithm
            // 
            this.lblCurrentAlgorithm.BackColor = System.Drawing.Color.LightGray;
            this.lblCurrentAlgorithm.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAlgorithm.ForeColor = System.Drawing.Color.Blue;
            this.lblCurrentAlgorithm.Location = new System.Drawing.Point(159, 7);
            this.lblCurrentAlgorithm.Name = "lblCurrentAlgorithm";
            this.lblCurrentAlgorithm.Size = new System.Drawing.Size(109, 26);
            this.lblCurrentAlgorithm.TabIndex = 16;
            // 
            // btnSelectStart
            // 
            this.btnSelectStart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSelectStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelectStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectStart.FlatAppearance.BorderSize = 5;
            this.btnSelectStart.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelectStart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelectStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectStart.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectStart.ForeColor = System.Drawing.Color.White;
            this.btnSelectStart.Location = new System.Drawing.Point(886, 156);
            this.btnSelectStart.Name = "btnSelectStart";
            this.btnSelectStart.Size = new System.Drawing.Size(80, 39);
            this.btnSelectStart.TabIndex = 3;
            this.btnSelectStart.Text = "START";
            this.btnSelectStart.UseVisualStyleBackColor = false;
            this.btnSelectStart.Click += new System.EventHandler(this.btnSelectStart_Click);
            // 
            // btnSelectEnd
            // 
            this.btnSelectEnd.BackColor = System.Drawing.Color.Red;
            this.btnSelectEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelectEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectEnd.FlatAppearance.BorderSize = 5;
            this.btnSelectEnd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelectEnd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelectEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectEnd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectEnd.ForeColor = System.Drawing.Color.White;
            this.btnSelectEnd.Location = new System.Drawing.Point(982, 157);
            this.btnSelectEnd.Name = "btnSelectEnd";
            this.btnSelectEnd.Size = new System.Drawing.Size(79, 39);
            this.btnSelectEnd.TabIndex = 4;
            this.btnSelectEnd.Text = "END";
            this.btnSelectEnd.UseVisualStyleBackColor = false;
            this.btnSelectEnd.Click += new System.EventHandler(this.btnSelectEnd_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(862, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 5;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(912, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderSize = 5;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(992, 374);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(77, 39);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.LightGray;
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(854, 448);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(322, 21);
            this.txtFileName.TabIndex = 11;
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.Transparent;
            this.lblFileName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.Gray;
            this.lblFileName.Location = new System.Drawing.Point(850, 422);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(95, 18);
            this.lblFileName.TabIndex = 24;
            this.lblFileName.Text = "File Name:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 5;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1022, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxSpeedOfSearch
            // 
            this.cbxSpeedOfSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSpeedOfSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpeedOfSearch.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSpeedOfSearch.FormattingEnabled = true;
            this.cbxSpeedOfSearch.Items.AddRange(new object[] {
            "Fast ",
            "Normal",
            "Slow"});
            this.cbxSpeedOfSearch.Location = new System.Drawing.Point(1044, 272);
            this.cbxSpeedOfSearch.Name = "cbxSpeedOfSearch";
            this.cbxSpeedOfSearch.Size = new System.Drawing.Size(148, 21);
            this.cbxSpeedOfSearch.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(1040, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Speed of search:";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.LightGray;
            this.lblTime.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gray;
            this.lblTime.Location = new System.Drawing.Point(7, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(102, 27);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "Time Taken:";
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.BackColor = System.Drawing.Color.LightGray;
            this.lblTimeTaken.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTaken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTimeTaken.Location = new System.Drawing.Point(107, 50);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(72, 26);
            this.lblTimeTaken.TabIndex = 29;
            // 
            // pnlCurrentSearch
            // 
            this.pnlCurrentSearch.BackColor = System.Drawing.Color.LightGray;
            this.pnlCurrentSearch.Controls.Add(this.lblPathPossible);
            this.pnlCurrentSearch.Controls.Add(this.lblTime);
            this.pnlCurrentSearch.Controls.Add(this.lblTimeTaken);
            this.pnlCurrentSearch.Controls.Add(this.lblAlgorithmText);
            this.pnlCurrentSearch.Controls.Add(this.lblCurrentAlgorithm);
            this.pnlCurrentSearch.Location = new System.Drawing.Point(843, 640);
            this.pnlCurrentSearch.Name = "pnlCurrentSearch";
            this.pnlCurrentSearch.Size = new System.Drawing.Size(357, 95);
            this.pnlCurrentSearch.TabIndex = 30;
            // 
            // lblPathPossible
            // 
            this.lblPathPossible.BackColor = System.Drawing.Color.LightGray;
            this.lblPathPossible.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathPossible.ForeColor = System.Drawing.Color.Red;
            this.lblPathPossible.Location = new System.Drawing.Point(11, 31);
            this.lblPathPossible.Name = "lblPathPossible";
            this.lblPathPossible.Size = new System.Drawing.Size(143, 19);
            this.lblPathPossible.TabIndex = 40;
            // 
            // btnResetSandE
            // 
            this.btnResetSandE.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnResetSandE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResetSandE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetSandE.FlatAppearance.BorderSize = 5;
            this.btnResetSandE.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnResetSandE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnResetSandE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSandE.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSandE.ForeColor = System.Drawing.Color.White;
            this.btnResetSandE.Location = new System.Drawing.Point(936, 191);
            this.btnResetSandE.Name = "btnResetSandE";
            this.btnResetSandE.Size = new System.Drawing.Size(69, 37);
            this.btnResetSandE.TabIndex = 5;
            this.btnResetSandE.Text = "Reset ";
            this.btnResetSandE.UseVisualStyleBackColor = false;
            this.btnResetSandE.Click += new System.EventHandler(this.btnResetSandE_Click);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Gray;
            this.lblID.Location = new System.Drawing.Point(854, 492);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 19);
            this.lblID.TabIndex = 31;
            this.lblID.Text = "ID:";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Gray;
            this.lblUsername.Location = new System.Drawing.Point(854, 511);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 19);
            this.lblUsername.TabIndex = 32;
            this.lblUsername.Text = "Username:";
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.BackColor = System.Drawing.Color.White;
            this.lblAccessLevel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessLevel.ForeColor = System.Drawing.Color.Gray;
            this.lblAccessLevel.Location = new System.Drawing.Point(854, 530);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(89, 19);
            this.lblAccessLevel.TabIndex = 33;
            this.lblAccessLevel.Text = "Access Level:";
            // 
            // lblCurrentAL
            // 
            this.lblCurrentAL.BackColor = System.Drawing.Color.White;
            this.lblCurrentAL.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAL.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentAL.Location = new System.Drawing.Point(943, 530);
            this.lblCurrentAL.Name = "lblCurrentAL";
            this.lblCurrentAL.Size = new System.Drawing.Size(248, 19);
            this.lblCurrentAL.TabIndex = 34;
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.BackColor = System.Drawing.Color.White;
            this.lblCurrentUsername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUsername.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentUsername.Location = new System.Drawing.Point(925, 511);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(258, 19);
            this.lblCurrentUsername.TabIndex = 35;
            // 
            // lblCurrentID
            // 
            this.lblCurrentID.BackColor = System.Drawing.Color.White;
            this.lblCurrentID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentID.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentID.Location = new System.Drawing.Point(879, 492);
            this.lblCurrentID.Name = "lblCurrentID";
            this.lblCurrentID.Size = new System.Drawing.Size(171, 19);
            this.lblCurrentID.TabIndex = 36;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.White;
            this.btnCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.FlatAppearance.BorderSize = 5;
            this.btnCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateAccount.Location = new System.Drawing.Point(943, 571);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(143, 41);
            this.btnCreateAccount.TabIndex = 37;
            this.btnCreateAccount.Text = "Edit Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnMultipleEnds
            // 
            this.btnMultipleEnds.BackColor = System.Drawing.Color.Red;
            this.btnMultipleEnds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMultipleEnds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultipleEnds.FlatAppearance.BorderSize = 5;
            this.btnMultipleEnds.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMultipleEnds.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMultipleEnds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipleEnds.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleEnds.ForeColor = System.Drawing.Color.White;
            this.btnMultipleEnds.Location = new System.Drawing.Point(1071, 148);
            this.btnMultipleEnds.Name = "btnMultipleEnds";
            this.btnMultipleEnds.Size = new System.Drawing.Size(105, 56);
            this.btnMultipleEnds.TabIndex = 38;
            this.btnMultipleEnds.Text = "Multiple ends (AStar)";
            this.btnMultipleEnds.UseVisualStyleBackColor = false;
            this.btnMultipleEnds.Click += new System.EventHandler(this.btnMultipleEnds_Click);
            // 
            // lblFileAccess
            // 
            this.lblFileAccess.BackColor = System.Drawing.Color.White;
            this.lblFileAccess.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileAccess.ForeColor = System.Drawing.Color.Maroon;
            this.lblFileAccess.Location = new System.Drawing.Point(963, 481);
            this.lblFileAccess.Name = "lblFileAccess";
            this.lblFileAccess.Size = new System.Drawing.Size(213, 19);
            this.lblFileAccess.TabIndex = 39;
            // 
            // pnlSelectedPanel
            // 
            this.pnlSelectedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectedPanel.Location = new System.Drawing.Point(32, 627);
            this.pnlSelectedPanel.Name = "pnlSelectedPanel";
            this.pnlSelectedPanel.Size = new System.Drawing.Size(142, 100);
            this.pnlSelectedPanel.TabIndex = 40;
            // 
            // lblNodeID
            // 
            this.lblNodeID.BackColor = System.Drawing.Color.White;
            this.lblNodeID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNodeID.ForeColor = System.Drawing.Color.Gray;
            this.lblNodeID.Location = new System.Drawing.Point(213, 640);
            this.lblNodeID.Name = "lblNodeID";
            this.lblNodeID.Size = new System.Drawing.Size(80, 25);
            this.lblNodeID.TabIndex = 41;
            this.lblNodeID.Text = "NodeID:";
            // 
            // lblLocation
            // 
            this.lblLocation.BackColor = System.Drawing.Color.White;
            this.lblLocation.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Gray;
            this.lblLocation.Location = new System.Drawing.Point(213, 688);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(80, 25);
            this.lblLocation.TabIndex = 42;
            this.lblLocation.Text = "Location:";
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.White;
            this.lblWeight.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.Gray;
            this.lblWeight.Location = new System.Drawing.Point(460, 640);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 25);
            this.lblWeight.TabIndex = 43;
            this.lblWeight.Text = "Weight:";
            // 
            // txtNewWeight
            // 
            this.txtNewWeight.BackColor = System.Drawing.Color.LightGray;
            this.txtNewWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewWeight.Location = new System.Drawing.Point(465, 668);
            this.txtNewWeight.Multiline = true;
            this.txtNewWeight.Name = "txtNewWeight";
            this.txtNewWeight.Size = new System.Drawing.Size(271, 19);
            this.txtNewWeight.TabIndex = 44;
            // 
            // btnChangeWeight
            // 
            this.btnChangeWeight.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChangeWeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangeWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeWeight.FlatAppearance.BorderSize = 5;
            this.btnChangeWeight.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChangeWeight.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChangeWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeWeight.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeWeight.ForeColor = System.Drawing.Color.White;
            this.btnChangeWeight.Location = new System.Drawing.Point(462, 688);
            this.btnChangeWeight.Name = "btnChangeWeight";
            this.btnChangeWeight.Size = new System.Drawing.Size(74, 39);
            this.btnChangeWeight.TabIndex = 45;
            this.btnChangeWeight.Text = "Change";
            this.btnChangeWeight.UseVisualStyleBackColor = false;
            this.btnChangeWeight.Click += new System.EventHandler(this.btnChangeWeight_Click);
            // 
            // lblSelectSorE
            // 
            this.lblSelectSorE.BackColor = System.Drawing.Color.White;
            this.lblSelectSorE.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSorE.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectSorE.Location = new System.Drawing.Point(950, 135);
            this.lblSelectSorE.Name = "lblSelectSorE";
            this.lblSelectSorE.Size = new System.Drawing.Size(67, 25);
            this.lblSelectSorE.TabIndex = 46;
            this.lblSelectSorE.Text = "Select:";
            // 
            // lblCurrentNodeID
            // 
            this.lblCurrentNodeID.BackColor = System.Drawing.Color.White;
            this.lblCurrentNodeID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentNodeID.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentNodeID.Location = new System.Drawing.Point(288, 640);
            this.lblCurrentNodeID.Name = "lblCurrentNodeID";
            this.lblCurrentNodeID.Size = new System.Drawing.Size(80, 25);
            this.lblCurrentNodeID.TabIndex = 47;
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.BackColor = System.Drawing.Color.White;
            this.lblCurrentLocation.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLocation.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentLocation.Location = new System.Drawing.Point(292, 688);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(130, 25);
            this.lblCurrentLocation.TabIndex = 48;
            // 
            // lblCurrentWeight
            // 
            this.lblCurrentWeight.BackColor = System.Drawing.Color.White;
            this.lblCurrentWeight.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeight.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentWeight.Location = new System.Drawing.Point(528, 640);
            this.lblCurrentWeight.Name = "lblCurrentWeight";
            this.lblCurrentWeight.Size = new System.Drawing.Size(80, 25);
            this.lblCurrentWeight.TabIndex = 49;
            // 
            // lblInvalidWeight
            // 
            this.lblInvalidWeight.BackColor = System.Drawing.Color.White;
            this.lblInvalidWeight.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidWeight.ForeColor = System.Drawing.Color.Maroon;
            this.lblInvalidWeight.Location = new System.Drawing.Point(548, 697);
            this.lblInvalidWeight.Name = "lblInvalidWeight";
            this.lblInvalidWeight.Size = new System.Drawing.Size(174, 19);
            this.lblInvalidWeight.TabIndex = 50;
            // 
            // cbxUsersFiles
            // 
            this.cbxUsersFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxUsersFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsersFiles.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsersFiles.FormattingEnabled = true;
            this.cbxUsersFiles.Location = new System.Drawing.Point(1075, 385);
            this.cbxUsersFiles.Name = "cbxUsersFiles";
            this.cbxUsersFiles.Size = new System.Drawing.Size(117, 21);
            this.cbxUsersFiles.TabIndex = 51;
            this.cbxUsersFiles.SelectedIndexChanged += new System.EventHandler(this.cbxUsersFiles_SelectedIndexChanged);
            // 
            // frmMazeTraverser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 735);
            this.Controls.Add(this.cbxUsersFiles);
            this.Controls.Add(this.lblInvalidWeight);
            this.Controls.Add(this.lblCurrentWeight);
            this.Controls.Add(this.lblCurrentLocation);
            this.Controls.Add(this.lblCurrentNodeID);
            this.Controls.Add(this.lblSelectSorE);
            this.Controls.Add(this.btnChangeWeight);
            this.Controls.Add(this.txtNewWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblNodeID);
            this.Controls.Add(this.pnlSelectedPanel);
            this.Controls.Add(this.lblFileAccess);
            this.Controls.Add(this.btnMultipleEnds);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblCurrentID);
            this.Controls.Add(this.lblCurrentUsername);
            this.Controls.Add(this.lblCurrentAL);
            this.Controls.Add(this.lblAccessLevel);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnResetSandE);
            this.Controls.Add(this.pnlCurrentSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSpeedOfSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectEnd);
            this.Controls.Add(this.btnSelectStart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnMazeGen);
            this.Controls.Add(this.cbxAlgorithm);
            this.Controls.Add(this.lblCustomMaze);
            this.Enabled = false;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMazeTraverser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze Visual & Traverser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCurrentSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxAlgorithm;
        private System.Windows.Forms.Label lblCustomMaze;
        private System.Windows.Forms.Button btnMazeGen;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAlgorithmText;
        private System.Windows.Forms.Label lblCurrentAlgorithm;
        private System.Windows.Forms.Button btnSelectStart;
        private System.Windows.Forms.Button btnSelectEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbxSpeedOfSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Panel pnlCurrentSearch;
        private System.Windows.Forms.Button btnResetSandE;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAccessLevel;
        private System.Windows.Forms.Label lblCurrentAL;
        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.Label lblCurrentID;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnMultipleEnds;
        private System.Windows.Forms.Label lblPathPossible;
        private System.Windows.Forms.Label lblFileAccess;
        private System.Windows.Forms.Panel pnlSelectedPanel;
        private System.Windows.Forms.Label lblNodeID;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtNewWeight;
        private System.Windows.Forms.Button btnChangeWeight;
        private System.Windows.Forms.Label lblSelectSorE;
        private System.Windows.Forms.Label lblCurrentNodeID;
        private System.Windows.Forms.Label lblCurrentLocation;
        private System.Windows.Forms.Label lblCurrentWeight;
        private System.Windows.Forms.Label lblInvalidWeight;
        private System.Windows.Forms.ComboBox cbxUsersFiles;
    }
}

