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
            bt_ofd = new Button();
            lb_ofdPath = new Label();
            folderBrowser = new FolderBrowserDialog();
            chkb_recursive = new CheckBox();
            comboBox1 = new ComboBox();
            lb_extFilter = new Label();
            lstView_files = new ListView();
            FileName = new ColumnHeader();
            FilePath = new ColumnHeader();
            SuspendLayout();
            // 
            // bt_ofd
            // 
            bt_ofd.Location = new Point(12, 12);
            bt_ofd.Name = "bt_ofd";
            bt_ofd.Size = new Size(148, 29);
            bt_ofd.TabIndex = 0;
            bt_ofd.Text = "Open Location";
            bt_ofd.UseVisualStyleBackColor = true;
            bt_ofd.Click += bt_ofd_Click;
            // 
            // lb_ofdPath
            // 
            lb_ofdPath.AutoSize = true;
            lb_ofdPath.Location = new Point(175, 16);
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
            comboBox1.Location = new Point(175, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // lb_extFilter
            // 
            lb_extFilter.AutoSize = true;
            lb_extFilter.Location = new Point(332, 48);
            lb_extFilter.Name = "lb_extFilter";
            lb_extFilter.Size = new Size(109, 20);
            lb_extFilter.TabIndex = 5;
            lb_extFilter.Text = "Extension Filter";
            // 
            // lstView_files
            // 
            lstView_files.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstView_files.Columns.AddRange(new ColumnHeader[] { FileName, FilePath });
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
            // qDocOrganizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 773);
            Controls.Add(lstView_files);
            Controls.Add(lb_extFilter);
            Controls.Add(comboBox1);
            Controls.Add(chkb_recursive);
            Controls.Add(lb_ofdPath);
            Controls.Add(bt_ofd);
            Name = "qDocOrganizer";
            Text = "qDocOrganizer";
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
    }
}
