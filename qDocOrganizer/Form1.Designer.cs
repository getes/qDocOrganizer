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
            renameToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            copyToToolStripMenuItem = new ToolStripMenuItem();
            contextMenuListViewItem.SuspendLayout();
            SuspendLayout();
            // 
            // bt_ofd
            // 
            bt_ofd.BackColor = SystemColors.GradientActiveCaption;
            bt_ofd.Location = new Point(12, 12);
            bt_ofd.Name = "bt_ofd";
            bt_ofd.Size = new Size(148, 29);
            bt_ofd.TabIndex = 0;
            bt_ofd.Text = "Open Location";
            bt_ofd.UseVisualStyleBackColor = false;
            bt_ofd.Click += bt_ofd_Click;
            // 
            // lb_ofdPath
            // 
            lb_ofdPath.AutoSize = true;
            lb_ofdPath.Location = new Point(307, 16);
            lb_ofdPath.Name = "lb_ofdPath";
            lb_ofdPath.Size = new Size(18, 20);
            lb_ofdPath.TabIndex = 1;
            lb_ofdPath.Text = "...";
            // 
            // chkb_recursive
            // 
            chkb_recursive.AutoSize = true;
            chkb_recursive.Checked = true;
            chkb_recursive.CheckState = CheckState.Checked;
            chkb_recursive.Location = new Point(14, 48);
            chkb_recursive.Name = "chkb_recursive";
            chkb_recursive.Size = new Size(100, 24);
            chkb_recursive.TabIndex = 2;
            chkb_recursive.Text = "Recursive?";
            chkb_recursive.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // lb_extFilter
            // 
            lb_extFilter.AutoSize = true;
            lb_extFilter.Location = new Point(323, 48);
            lb_extFilter.Name = "lb_extFilter";
            lb_extFilter.Size = new Size(109, 20);
            lb_extFilter.TabIndex = 5;
            lb_extFilter.Text = "Extension Filter";
            // 
            // lstView_files
            // 
            lstView_files.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstView_files.Columns.AddRange(new ColumnHeader[] { FileName, FilePath });
            lstView_files.ContextMenuStrip = contextMenuListViewItem;
            lstView_files.Location = new Point(12, 78);
            lstView_files.Name = "lstView_files";
            lstView_files.Size = new Size(779, 684);
            lstView_files.TabIndex = 6;
            lstView_files.UseCompatibleStateImageBehavior = false;
            lstView_files.View = View.Details;
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
            contextMenuListViewItem.Items.AddRange(new ToolStripItem[] { MoveTo, copyToToolStripMenuItem, renameToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuListViewItem.Name = "contextMenuListViewItem";
            contextMenuListViewItem.Size = new Size(211, 128);
            // 
            // MoveTo
            // 
            MoveTo.Name = "MoveTo";
            MoveTo.Size = new Size(140, 24);
            MoveTo.Text = "MoveTo...";
            MoveTo.Click += MoveTo_Click;
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new Size(140, 24);
            renameToolStripMenuItem.Text = "Rename";
            renameToolStripMenuItem.Click += renameToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(140, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 16);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 7;
            label1.Text = "Selected Location:";
            // 
            // copyToToolStripMenuItem
            // 
            copyToToolStripMenuItem.Name = "copyToToolStripMenuItem";
            copyToToolStripMenuItem.Size = new Size(210, 24);
            copyToToolStripMenuItem.Text = "CopyTo...";
            copyToToolStripMenuItem.Click += copyToToolStripMenuItem_Click;
            // 
            // qDocOrganizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(794, 773);
            Controls.Add(label1);
            Controls.Add(lstView_files);
            Controls.Add(lb_extFilter);
            Controls.Add(comboBox1);
            Controls.Add(chkb_recursive);
            Controls.Add(lb_ofdPath);
            Controls.Add(bt_ofd);
            Name = "qDocOrganizer";
            Text = "qDocOrganizer";
            contextMenuListViewItem.ResumeLayout(false);
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
    }
}
