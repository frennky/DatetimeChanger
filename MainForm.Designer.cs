
namespace DatetimeChanger
{
    partial class MainForm
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
            this.dtpRecorded = new System.Windows.Forms.DateTimePicker();
            this.lblRecorded = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.dtpReal = new System.Windows.Forms.DateTimePicker();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.gbDatetime = new System.Windows.Forms.GroupBox();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.statusStrip.SuspendLayout();
            this.gbDatetime.SuspendLayout();
            this.gbFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpRecorded
            // 
            this.dtpRecorded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRecorded.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpRecorded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRecorded.Location = new System.Drawing.Point(66, 22);
            this.dtpRecorded.Name = "dtpRecorded";
            this.dtpRecorded.Size = new System.Drawing.Size(394, 23);
            this.dtpRecorded.TabIndex = 0;
            // 
            // lblRecorded
            // 
            this.lblRecorded.AutoSize = true;
            this.lblRecorded.Location = new System.Drawing.Point(6, 28);
            this.lblRecorded.Name = "lblRecorded";
            this.lblRecorded.Size = new System.Drawing.Size(57, 15);
            this.lblRecorded.TabIndex = 1;
            this.lblRecorded.Text = "Recorded";
            // 
            // lblReal
            // 
            this.lblReal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReal.AutoSize = true;
            this.lblReal.Location = new System.Drawing.Point(6, 57);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(29, 15);
            this.lblReal.TabIndex = 2;
            this.lblReal.Text = "Real";
            // 
            // dtpReal
            // 
            this.dtpReal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReal.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpReal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReal.Location = new System.Drawing.Point(66, 51);
            this.dtpReal.Name = "dtpReal";
            this.dtpReal.Size = new System.Drawing.Size(394, 23);
            this.dtpReal.TabIndex = 3;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 25);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(31, 15);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "Path";
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(66, 22);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(244, 23);
            this.tbPath.TabIndex = 6;
            // 
            // btnPath
            // 
            this.btnPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath.Location = new System.Drawing.Point(316, 22);
            this.btnPath.MaximumSize = new System.Drawing.Size(46, 23);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(46, 23);
            this.btnPath.TabIndex = 7;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(368, 22);
            this.btnUpdate.MaximumSize = new System.Drawing.Size(132, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_ClickAsync);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 181);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(494, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(400, 16);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // gbDatetime
            // 
            this.gbDatetime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatetime.Controls.Add(this.dtpReal);
            this.gbDatetime.Controls.Add(this.dtpRecorded);
            this.gbDatetime.Controls.Add(this.lblRecorded);
            this.gbDatetime.Controls.Add(this.lblReal);
            this.gbDatetime.Location = new System.Drawing.Point(12, 12);
            this.gbDatetime.Name = "gbDatetime";
            this.gbDatetime.Size = new System.Drawing.Size(466, 80);
            this.gbDatetime.TabIndex = 11;
            this.gbDatetime.TabStop = false;
            this.gbDatetime.Text = "Datetime";
            // 
            // gbFiles
            // 
            this.gbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiles.Controls.Add(this.btnUpdate);
            this.gbFiles.Controls.Add(this.lblPath);
            this.gbFiles.Controls.Add(this.tbPath);
            this.gbFiles.Controls.Add(this.btnPath);
            this.gbFiles.Location = new System.Drawing.Point(12, 94);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(466, 80);
            this.gbFiles.TabIndex = 12;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 203);
            this.Controls.Add(this.gbFiles);
            this.Controls.Add(this.gbDatetime);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 242);
            this.MinimumSize = new System.Drawing.Size(510, 242);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datetime Changer";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbDatetime.ResumeLayout(false);
            this.gbDatetime.PerformLayout();
            this.gbFiles.ResumeLayout(false);
            this.gbFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpRecorded;
        private System.Windows.Forms.Label lblRecorded;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.DateTimePicker dtpReal;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.GroupBox gbDatetime;
        private System.Windows.Forms.GroupBox gbFiles;
    }
}

