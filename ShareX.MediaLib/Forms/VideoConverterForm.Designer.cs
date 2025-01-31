﻿using ShareNot.HelpersLib.Controls.BlackStyle;

namespace ShareNot.MediaLib.Forms
{
    partial class VideoConverterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoConverterForm));
            this.lblInputFilePath = new System.Windows.Forms.Label();
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.btnInputFilePathBrowse = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.btnOutputFolderBrowse = new System.Windows.Forms.Button();
            this.lblOutputFileName = new System.Windows.Forms.Label();
            this.txtOutputFileName = new System.Windows.Forms.TextBox();
            this.cbVideoEncoder = new System.Windows.Forms.ComboBox();
            this.lblVideoQuality = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.cbAutoOpenFolder = new System.Windows.Forms.CheckBox();
            this.pbProgress = new BlackStyleProgressBar();
            this.cbUseCustomArguments = new System.Windows.Forms.CheckBox();
            this.lblVideoEncoder = new System.Windows.Forms.Label();
            this.tbVideoQuality = new System.Windows.Forms.TrackBar();
            this.lblVideoQualityValue = new System.Windows.Forms.Label();
            this.lblVideoQualityHigher = new System.Windows.Forms.Label();
            this.lblVideoQualityLower = new System.Windows.Forms.Label();
            this.nudVideoQualityBitrate = new System.Windows.Forms.NumericUpDown();
            this.lblVideoQualityBitrateHint = new System.Windows.Forms.Label();
            this.cbVideoQualityUseBitrate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbVideoQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoQualityBitrate)).BeginInit();
            this.SuspendLayout();
            //
            // lblInputFilePath
            //
            resources.ApplyResources(this.lblInputFilePath, "lblInputFilePath");
            this.lblInputFilePath.Name = "lblInputFilePath";
            //
            // txtInputFilePath
            //
            resources.ApplyResources(this.txtInputFilePath, "txtInputFilePath");
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.TextChanged += new System.EventHandler(this.txtInputFilePath_TextChanged);
            //
            // btnInputFilePathBrowse
            //
            resources.ApplyResources(this.btnInputFilePathBrowse, "btnInputFilePathBrowse");
            this.btnInputFilePathBrowse.Name = "btnInputFilePathBrowse";
            this.btnInputFilePathBrowse.UseVisualStyleBackColor = true;
            this.btnInputFilePathBrowse.Click += new System.EventHandler(this.btnInputFilePathBrowse_Click);
            //
            // txtOutputFolder
            //
            resources.ApplyResources(this.txtOutputFolder, "txtOutputFolder");
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.TextChanged += new System.EventHandler(this.txtOutputFolder_TextChanged);
            //
            // lblOutputFolder
            //
            resources.ApplyResources(this.lblOutputFolder, "lblOutputFolder");
            this.lblOutputFolder.Name = "lblOutputFolder";
            //
            // btnOutputFolderBrowse
            //
            resources.ApplyResources(this.btnOutputFolderBrowse, "btnOutputFolderBrowse");
            this.btnOutputFolderBrowse.Name = "btnOutputFolderBrowse";
            this.btnOutputFolderBrowse.UseVisualStyleBackColor = true;
            this.btnOutputFolderBrowse.Click += new System.EventHandler(this.btnOutputFolderBrowse_Click);
            //
            // lblOutputFileName
            //
            resources.ApplyResources(this.lblOutputFileName, "lblOutputFileName");
            this.lblOutputFileName.Name = "lblOutputFileName";
            //
            // txtOutputFileName
            //
            resources.ApplyResources(this.txtOutputFileName, "txtOutputFileName");
            this.txtOutputFileName.Name = "txtOutputFileName";
            this.txtOutputFileName.TextChanged += new System.EventHandler(this.txtOutputFileName_TextChanged);
            //
            // cbVideoEncoder
            //
            this.cbVideoEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoEncoder.FormattingEnabled = true;
            resources.ApplyResources(this.cbVideoEncoder, "cbVideoEncoder");
            this.cbVideoEncoder.Name = "cbVideoEncoder";
            this.cbVideoEncoder.SelectedIndexChanged += new System.EventHandler(this.cbVideoEncoder_SelectedIndexChanged);
            //
            // lblVideoQuality
            //
            resources.ApplyResources(this.lblVideoQuality, "lblVideoQuality");
            this.lblVideoQuality.Name = "lblVideoQuality";
            //
            // btnEncode
            //
            resources.ApplyResources(this.btnEncode, "btnEncode");
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            //
            // txtArguments
            //
            resources.ApplyResources(this.txtArguments, "txtArguments");
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.TextChanged += new System.EventHandler(this.txtArguments_TextChanged);
            //
            // cbAutoOpenFolder
            //
            resources.ApplyResources(this.cbAutoOpenFolder, "cbAutoOpenFolder");
            this.cbAutoOpenFolder.Name = "cbAutoOpenFolder";
            this.cbAutoOpenFolder.UseVisualStyleBackColor = true;
            this.cbAutoOpenFolder.CheckedChanged += new System.EventHandler(this.cbAutoOpenFolder_CheckedChanged);
            //
            // pbProgress
            //
            resources.ApplyResources(this.pbProgress, "pbProgress");
            this.pbProgress.ForeColor = System.Drawing.Color.White;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.ShowPercentageText = true;
            //
            // cbUseCustomArguments
            //
            resources.ApplyResources(this.cbUseCustomArguments, "cbUseCustomArguments");
            this.cbUseCustomArguments.Name = "cbUseCustomArguments";
            this.cbUseCustomArguments.UseVisualStyleBackColor = true;
            this.cbUseCustomArguments.CheckedChanged += new System.EventHandler(this.cbUseCustomArguments_CheckedChanged);
            //
            // lblVideoEncoder
            //
            resources.ApplyResources(this.lblVideoEncoder, "lblVideoEncoder");
            this.lblVideoEncoder.Name = "lblVideoEncoder";
            //
            // tbVideoQuality
            //
            resources.ApplyResources(this.tbVideoQuality, "tbVideoQuality");
            this.tbVideoQuality.BackColor = System.Drawing.SystemColors.Window;
            this.tbVideoQuality.Name = "tbVideoQuality";
            this.tbVideoQuality.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVideoQuality.ValueChanged += new System.EventHandler(this.tbVideoQuality_ValueChanged);
            //
            // lblVideoQualityValue
            //
            resources.ApplyResources(this.lblVideoQualityValue, "lblVideoQualityValue");
            this.lblVideoQualityValue.Name = "lblVideoQualityValue";
            //
            // lblVideoQualityHigher
            //
            resources.ApplyResources(this.lblVideoQualityHigher, "lblVideoQualityHigher");
            this.lblVideoQualityHigher.Name = "lblVideoQualityHigher";
            //
            // lblVideoQualityLower
            //
            resources.ApplyResources(this.lblVideoQualityLower, "lblVideoQualityLower");
            this.lblVideoQualityLower.Name = "lblVideoQualityLower";
            //
            // nudVideoQualityBitrate
            //
            resources.ApplyResources(this.nudVideoQualityBitrate, "nudVideoQualityBitrate");
            this.nudVideoQualityBitrate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudVideoQualityBitrate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudVideoQualityBitrate.Name = "nudVideoQualityBitrate";
            this.nudVideoQualityBitrate.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudVideoQualityBitrate.ValueChanged += new System.EventHandler(this.nudVideoQualityBitrate_ValueChanged);
            //
            // lblVideoQualityBitrateHint
            //
            resources.ApplyResources(this.lblVideoQualityBitrateHint, "lblVideoQualityBitrateHint");
            this.lblVideoQualityBitrateHint.Name = "lblVideoQualityBitrateHint";
            //
            // cbVideoQualityUseBitrate
            //
            resources.ApplyResources(this.cbVideoQualityUseBitrate, "cbVideoQualityUseBitrate");
            this.cbVideoQualityUseBitrate.Name = "cbVideoQualityUseBitrate";
            this.cbVideoQualityUseBitrate.UseVisualStyleBackColor = true;
            this.cbVideoQualityUseBitrate.CheckedChanged += new System.EventHandler(this.cbVideoQualityUseBitrate_CheckedChanged);
            //
            // VideoConverterForm
            //
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.cbVideoQualityUseBitrate);
            this.Controls.Add(this.lblVideoQualityBitrateHint);
            this.Controls.Add(this.nudVideoQualityBitrate);
            this.Controls.Add(this.lblVideoEncoder);
            this.Controls.Add(this.lblVideoQualityValue);
            this.Controls.Add(this.cbUseCustomArguments);
            this.Controls.Add(this.cbAutoOpenFolder);
            this.Controls.Add(this.lblVideoQualityHigher);
            this.Controls.Add(this.lblVideoQualityLower);
            this.Controls.Add(this.txtOutputFileName);
            this.Controls.Add(this.lblOutputFileName);
            this.Controls.Add(this.tbVideoQuality);
            this.Controls.Add(this.btnOutputFolderBrowse);
            this.Controls.Add(this.cbVideoEncoder);
            this.Controls.Add(this.lblOutputFolder);
            this.Controls.Add(this.lblVideoQuality);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.btnInputFilePathBrowse);
            this.Controls.Add(this.txtInputFilePath);
            this.Controls.Add(this.lblInputFilePath);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.txtArguments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VideoConverterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoConverterForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideoConverterForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.VideoConverterForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.tbVideoQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVideoQualityBitrate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputFilePath;
        private System.Windows.Forms.TextBox txtInputFilePath;
        private System.Windows.Forms.Button btnInputFilePathBrowse;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label lblOutputFolder;
        private System.Windows.Forms.Button btnOutputFolderBrowse;
        private System.Windows.Forms.Label lblOutputFileName;
        private System.Windows.Forms.TextBox txtOutputFileName;
        private System.Windows.Forms.ComboBox cbVideoEncoder;
        private System.Windows.Forms.Label lblVideoQuality;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox txtArguments;
        private BlackStyleProgressBar pbProgress;
        private System.Windows.Forms.CheckBox cbAutoOpenFolder;
        private System.Windows.Forms.CheckBox cbUseCustomArguments;
        private System.Windows.Forms.Label lblVideoEncoder;
        private System.Windows.Forms.TrackBar tbVideoQuality;
        private System.Windows.Forms.Label lblVideoQualityValue;
        private System.Windows.Forms.Label lblVideoQualityHigher;
        private System.Windows.Forms.Label lblVideoQualityLower;
        private System.Windows.Forms.NumericUpDown nudVideoQualityBitrate;
        private System.Windows.Forms.Label lblVideoQualityBitrateHint;
        private System.Windows.Forms.CheckBox cbVideoQualityUseBitrate;
    }
}