namespace qDocOrganizer
{
    partial class qDocOrganizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bt_ofd = new Button();
            lb_ofdPath = new Label();
            folderBrowser = new FolderBrowserDialog();
            chkb_recursive = new CheckBox();
            comboBox1 = new ComboBox();
            lb_extFilter = new Label();
            lstView_files = new ListView();
            FileName = new ColumnHeader();
            FilePath = new ColumnHeader();
            contextMenuListViewItem = new ContextMenuStrip(components);
            MoveTo = new ToolStripMenuItem();
            copyToToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            renameToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            toolStripMoveTo = new ToolStripMenuItem();
            toolStripCopyTo = new ToolStripMenuItem();
            toolStripDelete = new ToolStripMenuItem();
            toolStripOpenFiles = new ToolStripMenuItem();
            toolStripMenuOptions = new ToolStripMenuItem();
            toolStripMenuTheme = new ToolStripMenuItem();
            toolStripThemeDark = new ToolStripMenuItem();
            toolStripDefaultTheme = new ToolStripMenuItem();
            toolStripAbout = new ToolStripMenuItem();
            contextMenuListViewItem.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bt_ofd
            // 
            bt_ofd.BackColor = SystemColors.ButtonFace;
            bt_ofd.Location = new Point(9, 34);
            bt_ofd.Margin = new Padding(3, 2, 3, 2);
            bt_ofd.Name = "bt_ofd";
            bt_ofd.Size = new Size(130, 22);
            bt_ofd.TabIndex = 0;
            bt_ofd.Text = "Open Location";
            bt_ofd.UseVisualStyleBackColor = false;
            bt_ofd.Click += bt_ofd_Click;
            // 
            // lb_ofdPath
            // 
            lb_ofdPath.AutoSize = true;
            lb_ofdPath.Location = new Point(269, 12);
            lb_ofdPath.Name = "lb_ofdPath";
            lb_ofdPath.Size = new Size(16, 15);
            lb_ofdPath.TabIndex = 1;
            lb_ofdPath.Text = "...";
            // 
            // chkb_recursive
            // 
            chkb_recursive.AutoSize = true;
            chkb_recursive.Checked = true;
            chkb_recursive.CheckState = CheckState.Checked;
            chkb_recursive.ForeColor = SystemColors.ControlText;
            chkb_recursive.Location = new Point(10, 60);
            chkb_recursive.Margin = new Padding(3, 2, 3, 2);
            chkb_recursive.Name = "chkb_recursive";
            chkb_recursive.Size = new Size(124, 19);
            chkb_recursive.TabIndex = 2;
            chkb_recursive.Text = "Include Subfolders";
            chkb_recursive.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(145, 34);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // lb_extFilter
            // 
            lb_extFilter.AutoSize = true;
            lb_extFilter.Location = new Point(283, 36);
            lb_extFilter.Name = "lb_extFilter";
            lb_extFilter.Size = new Size(86, 15);
            lb_extFilter.TabIndex = 5;
            lb_extFilter.Text = "Extension Filter";
            // 
            // lstView_files
            // 
            lstView_files.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstView_files.Columns.AddRange(new ColumnHeader[] { FileName, FilePath });
            lstView_files.ContextMenuStrip = contextMenuListViewItem;
            lstView_files.Location = new Point(10, 118);
            lstView_files.Margin = new Padding(3, 2, 3, 2);
            lstView_files.Name = "lstView_files";
            lstView_files.Size = new Size(682, 530);
            lstView_files.TabIndex = 6;
            lstView_files.UseCompatibleStateImageBehavior = false;
            lstView_files.View = View.Details;
            lstView_files.DoubleClick += lstView_files_DoubleClick;
            // 
            // FileName
            // 
            FileName.Text = "File Name";
            FileName.Width = 200;
            // 
            // FilePath
            // 
            FilePath.Text = "File Path";
            FilePath.Width = 600;
            // 
            // contextMenuListViewItem
            // 
            contextMenuListViewItem.ImageScalingSize = new Size(20, 20);
            contextMenuListViewItem.Items.AddRange(new ToolStripItem[] { MoveTo, copyToToolStripMenuItem, deleteToolStripMenuItem, renameToolStripMenuItem });
            contextMenuListViewItem.Name = "contextMenuListViewItem";
            contextMenuListViewItem.Size = new Size(135, 92);
            // 
            // MoveTo
            // 
            MoveTo.Name = "MoveTo";
            MoveTo.Size = new Size(134, 22);
            MoveTo.Text = "Move to...";
            MoveTo.Click += MoveTo_Click;
            // 
            // copyToToolStripMenuItem
            // 
            copyToToolStripMenuItem.Name = "copyToToolStripMenuItem";
            copyToToolStripMenuItem.Size = new Size(134, 22);
            copyToToolStripMenuItem.Text = "Copy to...";
            copyToToolStripMenuItem.Click += copyToToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(134, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new Size(134, 22);
            renameToolStripMenuItem.Text = "Open File/s";
            renameToolStripMenuItem.Click += renameToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 12);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 7;
            label1.Text = "Selected Location:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, toolStripMenuOptions, toolStripAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(695, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMoveTo, toolStripCopyTo, toolStripDelete, toolStripOpenFiles });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMoveTo
            // 
            toolStripMoveTo.Name = "toolStripMoveTo";
            toolStripMoveTo.Size = new Size(180, 22);
            toolStripMoveTo.Text = "Move to...";
            toolStripMoveTo.Click += toolStripMoveTo_Click;
            // 
            // toolStripCopyTo
            // 
            toolStripCopyTo.Name = "toolStripCopyTo";
            toolStripCopyTo.Size = new Size(180, 22);
            toolStripCopyTo.Text = "Copy to...";
            toolStripCopyTo.Click += toolStripCopyTo_Click;
            // 
            // toolStripDelete
            // 
            toolStripDelete.Name = "toolStripDelete";
            toolStripDelete.Size = new Size(180, 22);
            toolStripDelete.Text = "Delete";
            toolStripDelete.Click += toolStripDelete_Click;
            // 
            // toolStripOpenFiles
            // 
            toolStripOpenFiles.Name = "toolStripOpenFiles";
            toolStripOpenFiles.Size = new Size(180, 22);
            toolStripOpenFiles.Text = "Open File/s";
            toolStripOpenFiles.Click += toolStripOpenFiles_Click;
            // 
            // toolStripMenuOptions
            // 
            toolStripMenuOptions.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuTheme });
            toolStripMenuOptions.Name = "toolStripMenuOptions";
            toolStripMenuOptions.Size = new Size(61, 20);
            toolStripMenuOptions.Text = "Options";
            // 
            // toolStripMenuTheme
            // 
            toolStripMenuTheme.DropDownItems.AddRange(new ToolStripItem[] { toolStripThemeDark, toolStripDefaultTheme });
            toolStripMenuTheme.Name = "toolStripMenuTheme";
            toolStripMenuTheme.Size = new Size(162, 22);
            toolStripMenuTheme.Text = "Theme Selection";
            // 
            // toolStripThemeDark
            // 
            toolStripThemeDark.Name = "toolStripThemeDark";
            toolStripThemeDark.Size = new Size(171, 22);
            toolStripThemeDark.Text = "Set DarkTheme";
            toolStripThemeDark.Click += toolStripThemeDark_Click;
            // 
            // toolStripDefaultTheme
            // 
            toolStripDefaultTheme.Name = "toolStripDefaultTheme";
            toolStripDefaultTheme.Size = new Size(171, 22);
            toolStripDefaultTheme.Text = "Set Default Theme";
            toolStripDefaultTheme.Click += toolStripDefaultTheme_Click;
            // 
            // toolStripAbout
            // 
            toolStripAbout.Name = "toolStripAbout";
            toolStripAbout.Size = new Size(52, 20);
            toolStripAbout.Text = "About";
            toolStripAbout.Click += toolStripAbout_Click;
            // 
            // qDocOrganizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(695, 656);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(lstView_files);
            Controls.Add(lb_extFilter);
            Controls.Add(comboBox1);
            Controls.Add(chkb_recursive);
            Controls.Add(lb_ofdPath);
            Controls.Add(bt_ofd);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "qDocOrganizer";
            Text = "qDocOrganizer";
            contextMenuListViewItem.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_ofd;
        private Label lb_ofdPath;
        private FolderBrowserDialog folderBrowser;
        private CheckBox chkb_recursive;
        private ComboBox comboBox1;
        private Label lb_extFilter;
        private ListView lstView_files;
        private ColumnHeader FileName;
        private ColumnHeader FilePath;
        private Label label1;
        private ContextMenuStrip contextMenuListViewItem;
        private ToolStripMenuItem MoveTo;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem copyToToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem toolStripMoveTo;
        private ToolStripMenuItem toolStripCopyTo;
        private ToolStripMenuItem toolStripDelete;
        private ToolStripMenuItem toolStripMenuOptions;
        private ToolStripMenuItem toolStripMenuTheme;
        private ToolStripMenuItem toolStripThemeDark;
        private ToolStripMenuItem toolStripDefaultTheme;
        private ToolStripMenuItem toolStripAbout;
        private ToolStripMenuItem toolStripOpenFiles;
    }
}
