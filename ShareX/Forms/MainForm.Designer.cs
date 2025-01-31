﻿using ShareNot.Controls;
using ShareNot.HelpersLib.Controls;

namespace ShareNot.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scMain = new SplitContainerCustomSplitter();
            this.lvUploads = new MyListView();
            this.chFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbPreview = new MyPictureBox();
            this.tsMain = new ToolStripBorderRight();
            this.tsddbCapture = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRectangleLight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRectangleTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLastRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenRecordingFFmpeg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenRecordingGIF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScrollingCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.tssCapture1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowCursor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenshotDelay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenshotDelay0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenshotDelay1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenshotDelay2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenshotDelay3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenshotDelay4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenshotDelay5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbWorkflows = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddbTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiColorPicker = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenColorPicker = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRuler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPinToScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTools1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiImageEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImageBeautifier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImageEffects = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImageViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImageCombiner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImageSplitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImageThumbnailer = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTools2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiVideoConverter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVideoThumbnailer = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTools3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOCR = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQRCode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHashChecker = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIndexFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTools4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClipboardViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBorderlessWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInspectWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMonitorTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDNSChanger = new System.Windows.Forms.ToolStripMenuItem();
            this.tssMain1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbAfterCaptureTasks = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbApplicationSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbTaskSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbHotkeySettings = new System.Windows.Forms.ToolStripButton();
            this.tssMain2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbScreenshotsFolder = new System.Windows.Forms.ToolStripButton();
            this.tsbHistory = new System.Windows.Forms.ToolStripButton();
            this.tsbImageHistory = new System.Windows.Forms.ToolStripButton();
            this.tssMain3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbDebug = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiShowDebugLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTestImageUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDonate = new System.Windows.Forms.ToolStripButton();
            this.tsbDiscord = new System.Windows.Forms.ToolStripButton();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.cmsTaskInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowErrors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStopUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tssOpen1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenThumbnailFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tssCopy1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCopyFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyImageDimensions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyThumbnailFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyThumbnailImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tssCopy2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCopyFilePath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyFileName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyFileNameWithExtension = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tssCopy6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditSelectedFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBeautifyImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddImageEffects = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPinSelectedFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRunAction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSelectedItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSelectedFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOCRImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCombineImages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCombineImagesHorizontally = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCombineImagesVertically = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearList = new System.Windows.Forms.ToolStripMenuItem();
            this.tssUploadInfo1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSwitchTaskViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.niTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTrayCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayRectangleLight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayRectangleTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayLastRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScreenRecordingFFmpeg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScreenRecordingGIF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScrollingCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayAutoCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTrayCapture1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTrayShowCursor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScreenshotDelay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScreenshotDelay0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScreenshotDelay1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScreenshotDelay2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScreenshotDelay3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScreenshotDelay4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScreenshotDelay5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayWorkflows = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayColorPicker = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayScreenColorPicker = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayRuler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayPinToScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTrayTools1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTrayImageEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayImageBeautifier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayImageEffects = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayImageViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayImageCombiner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayImageSplitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayImageThumbnailer = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTrayTools2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTrayVideoConverter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayVideoThumbnailer = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTrayTools3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTrayOCR = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayQRCode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayHashChecker = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayIndexFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTrayTools4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTrayClipboardViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayBorderlessWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayInspectWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayMonitorTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayDNSChanger = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTray1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTrayAfterCaptureTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayApplicationSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayTaskSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayHotkeySettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayToggleHotkeys = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTray2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiScreenshotsFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayImageHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTray3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRestartAsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayRecentItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenActionsToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTrayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTraySingleClick = new System.Windows.Forms.Timer(this.components);
            this.ucTaskThumbnailView = new TaskThumbnailView();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.pToolbars = new System.Windows.Forms.Panel();
            this.dgvHotkeys = new System.Windows.Forms.DataGridView();
            this.cHotkeyStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHotkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMain = new System.Windows.Forms.Panel();
            this.pHotkeys = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.cmsTaskInfo.SuspendLayout();
            this.cmsTray.SuspendLayout();
            this.pToolbars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotkeys)).BeginInit();
            this.pMain.SuspendLayout();
            this.pHotkeys.SuspendLayout();
            this.SuspendLayout();
            //
            // scMain
            //
            resources.ApplyResources(this.scMain, "scMain");
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Name = "scMain";
            //
            // scMain.Panel1
            //
            this.scMain.Panel1.Controls.Add(this.lvUploads);
            //
            // scMain.Panel2
            //
            this.scMain.Panel2.Controls.Add(this.pbPreview);
            this.scMain.SplitterColor = System.Drawing.Color.White;
            this.scMain.SplitterLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.scMain.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.scMain_SplitterMoved);
            //
            // lvUploads
            //
            this.lvUploads.AutoFillColumn = true;
            this.lvUploads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvUploads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilename,
            this.chURL});
            resources.ApplyResources(this.lvUploads, "lvUploads");
            this.lvUploads.FullRowSelect = true;
            this.lvUploads.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUploads.HideSelection = false;
            this.lvUploads.Name = "lvUploads";
            this.lvUploads.ShowItemToolTips = true;
            this.lvUploads.UseCompatibleStateImageBehavior = false;
            this.lvUploads.View = System.Windows.Forms.View.Details;
            this.lvUploads.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lvUploads_ColumnWidthChanged);
            this.lvUploads.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvUploads_ItemDrag);
            this.lvUploads.SelectedIndexChanged += new System.EventHandler(this.lvUploads_SelectedIndexChanged);
            this.lvUploads.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvUploads_KeyDown);
            this.lvUploads.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvUploads_MouseDoubleClick);
            this.lvUploads.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvUploads_MouseUp);
            //
            // chFilename
            //
            resources.ApplyResources(this.chFilename, "chFilename");
            //
            // chURL
            //
            resources.ApplyResources(this.chURL, "chURL");
            //
            // pbPreview
            //
            this.pbPreview.BackColor = System.Drawing.SystemColors.Window;
            this.pbPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pbPreview, "pbPreview");
            this.pbPreview.DrawCheckeredBackground = true;
            this.pbPreview.EnableRightClickMenu = true;
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.PictureBoxBackColor = System.Drawing.SystemColors.Control;
            this.pbPreview.ShowImageSizeLabel = true;
            this.pbPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPreview_MouseDown);
            //
            // tsMain
            //
            this.tsMain.CanOverflow = false;
            resources.ApplyResources(this.tsMain, "tsMain");
            this.tsMain.DrawCustomBorder = true;
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbCapture,
            this.tsddbWorkflows,
            this.tsddbTools,
            this.tssMain1,
            this.tsddbAfterCaptureTasks,
            this.tsbApplicationSettings,
            this.tsbTaskSettings,
            this.tsbHotkeySettings,
            this.tssMain2,
            this.tsbScreenshotsFolder,
            this.tsbHistory,
            this.tsbImageHistory,
            this.tssMain3,
            this.tsddbDebug,
            this.tsbDonate,
            this.tsbDiscord,
            this.tsbAbout});
            this.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsMain.Name = "tsMain";
            this.tsMain.ShowItemToolTips = false;
            this.tsMain.TabStop = true;
            //
            // tsddbCapture
            //
            this.tsddbCapture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFullscreen,
            this.tsmiWindow,
            this.tsmiMonitor,
            this.tsmiRectangle,
            this.tsmiRectangleLight,
            this.tsmiRectangleTransparent,
            this.tsmiLastRegion,
            this.tsmiScreenRecordingFFmpeg,
            this.tsmiScreenRecordingGIF,
            this.tsmiScrollingCapture,
            this.tsmiAutoCapture,
            this.tssCapture1,
            this.tsmiShowCursor,
            this.tsmiScreenshotDelay});
            this.tsddbCapture.Image = global::ShareNot.Properties.Resources.camera;
            resources.ApplyResources(this.tsddbCapture, "tsddbCapture");
            this.tsddbCapture.Name = "tsddbCapture";
            this.tsddbCapture.DropDownOpening += new System.EventHandler(this.tsddbCapture_DropDownOpening);
            //
            // tsmiFullscreen
            //
            this.tsmiFullscreen.Image = global::ShareNot.Properties.Resources.layer_fullscreen;
            this.tsmiFullscreen.Name = "tsmiFullscreen";
            resources.ApplyResources(this.tsmiFullscreen, "tsmiFullscreen");
            this.tsmiFullscreen.Click += new System.EventHandler(this.tsmiFullscreen_Click);
            //
            // tsmiWindow
            //
            this.tsmiWindow.Image = global::ShareNot.Properties.Resources.application_blue;
            this.tsmiWindow.Name = "tsmiWindow";
            resources.ApplyResources(this.tsmiWindow, "tsmiWindow");
            //
            // tsmiMonitor
            //
            this.tsmiMonitor.Image = global::ShareNot.Properties.Resources.monitor;
            this.tsmiMonitor.Name = "tsmiMonitor";
            resources.ApplyResources(this.tsmiMonitor, "tsmiMonitor");
            //
            // tsmiRectangle
            //
            this.tsmiRectangle.Image = global::ShareNot.Properties.Resources.layer_shape;
            this.tsmiRectangle.Name = "tsmiRectangle";
            resources.ApplyResources(this.tsmiRectangle, "tsmiRectangle");
            this.tsmiRectangle.Click += new System.EventHandler(this.tsmiRectangle_Click);
            //
            // tsmiRectangleLight
            //
            this.tsmiRectangleLight.Image = global::ShareNot.Properties.Resources.Rectangle;
            this.tsmiRectangleLight.Name = "tsmiRectangleLight";
            resources.ApplyResources(this.tsmiRectangleLight, "tsmiRectangleLight");
            this.tsmiRectangleLight.Click += new System.EventHandler(this.tsmiRectangleLight_Click);
            //
            // tsmiRectangleTransparent
            //
            this.tsmiRectangleTransparent.Image = global::ShareNot.Properties.Resources.layer_transparent;
            this.tsmiRectangleTransparent.Name = "tsmiRectangleTransparent";
            resources.ApplyResources(this.tsmiRectangleTransparent, "tsmiRectangleTransparent");
            this.tsmiRectangleTransparent.Click += new System.EventHandler(this.tsmiRectangleTransparent_Click);
            //
            // tsmiLastRegion
            //
            this.tsmiLastRegion.Image = global::ShareNot.Properties.Resources.layers;
            this.tsmiLastRegion.Name = "tsmiLastRegion";
            resources.ApplyResources(this.tsmiLastRegion, "tsmiLastRegion");
            this.tsmiLastRegion.Click += new System.EventHandler(this.tsmiLastRegion_Click);
            //
            // tsmiScreenRecordingFFmpeg
            //
            this.tsmiScreenRecordingFFmpeg.Image = global::ShareNot.Properties.Resources.camcorder_image;
            this.tsmiScreenRecordingFFmpeg.Name = "tsmiScreenRecordingFFmpeg";
            resources.ApplyResources(this.tsmiScreenRecordingFFmpeg, "tsmiScreenRecordingFFmpeg");
            this.tsmiScreenRecordingFFmpeg.Click += new System.EventHandler(this.tsmiScreenRecordingFFmpeg_Click);
            //
            // tsmiScreenRecordingGIF
            //
            this.tsmiScreenRecordingGIF.Image = global::ShareNot.Properties.Resources.film;
            this.tsmiScreenRecordingGIF.Name = "tsmiScreenRecordingGIF";
            resources.ApplyResources(this.tsmiScreenRecordingGIF, "tsmiScreenRecordingGIF");
            this.tsmiScreenRecordingGIF.Click += new System.EventHandler(this.tsmiScreenRecordingGIF_Click);
            //
            // tsmiScrollingCapture
            //
            this.tsmiScrollingCapture.Image = global::ShareNot.Properties.Resources.ui_scroll_pane_image;
            this.tsmiScrollingCapture.Name = "tsmiScrollingCapture";
            resources.ApplyResources(this.tsmiScrollingCapture, "tsmiScrollingCapture");
            this.tsmiScrollingCapture.Click += new System.EventHandler(this.tsmiScrollingCapture_Click);
            //
            // tsmiAutoCapture
            //
            this.tsmiAutoCapture.Image = global::ShareNot.Properties.Resources.clock;
            this.tsmiAutoCapture.Name = "tsmiAutoCapture";
            resources.ApplyResources(this.tsmiAutoCapture, "tsmiAutoCapture");
            this.tsmiAutoCapture.Click += new System.EventHandler(this.tsmiAutoCapture_Click);
            //
            // tssCapture1
            //
            this.tssCapture1.Name = "tssCapture1";
            resources.ApplyResources(this.tssCapture1, "tssCapture1");
            //
            // tsmiShowCursor
            //
            this.tsmiShowCursor.CheckOnClick = true;
            this.tsmiShowCursor.Image = global::ShareNot.Properties.Resources.cursor;
            this.tsmiShowCursor.Name = "tsmiShowCursor";
            resources.ApplyResources(this.tsmiShowCursor, "tsmiShowCursor");
            this.tsmiShowCursor.Click += new System.EventHandler(this.tsmiShowCursor_Click);
            //
            // tsmiScreenshotDelay
            //
            this.tsmiScreenshotDelay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScreenshotDelay0,
            this.tsmiScreenshotDelay1,
            this.tsmiScreenshotDelay2,
            this.tsmiScreenshotDelay3,
            this.tsmiScreenshotDelay4,
            this.tsmiScreenshotDelay5});
            this.tsmiScreenshotDelay.Image = global::ShareNot.Properties.Resources.clock_select;
            this.tsmiScreenshotDelay.Name = "tsmiScreenshotDelay";
            resources.ApplyResources(this.tsmiScreenshotDelay, "tsmiScreenshotDelay");
            //
            // tsmiScreenshotDelay0
            //
            this.tsmiScreenshotDelay0.Name = "tsmiScreenshotDelay0";
            resources.ApplyResources(this.tsmiScreenshotDelay0, "tsmiScreenshotDelay0");
            this.tsmiScreenshotDelay0.Click += new System.EventHandler(this.tsmiScreenshotDelay0_Click);
            //
            // tsmiScreenshotDelay1
            //
            this.tsmiScreenshotDelay1.Name = "tsmiScreenshotDelay1";
            resources.ApplyResources(this.tsmiScreenshotDelay1, "tsmiScreenshotDelay1");
            this.tsmiScreenshotDelay1.Click += new System.EventHandler(this.tsmiScreenshotDelay1_Click);
            //
            // tsmiScreenshotDelay2
            //
            this.tsmiScreenshotDelay2.Name = "tsmiScreenshotDelay2";
            resources.ApplyResources(this.tsmiScreenshotDelay2, "tsmiScreenshotDelay2");
            this.tsmiScreenshotDelay2.Click += new System.EventHandler(this.tsmiScreenshotDelay2_Click);
            //
            // tsmiScreenshotDelay3
            //
            this.tsmiScreenshotDelay3.Name = "tsmiScreenshotDelay3";
            resources.ApplyResources(this.tsmiScreenshotDelay3, "tsmiScreenshotDelay3");
            this.tsmiScreenshotDelay3.Click += new System.EventHandler(this.tsmiScreenshotDelay3_Click);
            //
            // tsmiScreenshotDelay4
            //
            this.tsmiScreenshotDelay4.Name = "tsmiScreenshotDelay4";
            resources.ApplyResources(this.tsmiScreenshotDelay4, "tsmiScreenshotDelay4");
            this.tsmiScreenshotDelay4.Click += new System.EventHandler(this.tsmiScreenshotDelay4_Click);
            //
            // tsmiScreenshotDelay5
            //
            this.tsmiScreenshotDelay5.Name = "tsmiScreenshotDelay5";
            resources.ApplyResources(this.tsmiScreenshotDelay5, "tsmiScreenshotDelay5");
            this.tsmiScreenshotDelay5.Click += new System.EventHandler(this.tsmiScreenshotDelay5_Click);
            //
            // tsddbWorkflows
            //
            this.tsddbWorkflows.Image = global::ShareNot.Properties.Resources.categories;
            resources.ApplyResources(this.tsddbWorkflows, "tsddbWorkflows");
            this.tsddbWorkflows.Name = "tsddbWorkflows";
            //
            // tsddbTools
            //
            this.tsddbTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiColorPicker,
            this.tsmiScreenColorPicker,
            this.tsmiRuler,
            this.tsmiPinToScreen,
            this.tssTools1,
            this.tsmiImageEditor,
            this.tsmiImageBeautifier,
            this.tsmiImageEffects,
            this.tsmiImageViewer,
            this.tsmiImageCombiner,
            this.tsmiImageSplitter,
            this.tsmiImageThumbnailer,
            this.tssTools2,
            this.tsmiVideoConverter,
            this.tsmiVideoThumbnailer,
            this.tssTools3,
            this.tsmiOCR,
            this.tsmiQRCode,
            this.tsmiHashChecker,
            this.tsmiIndexFolder,
            this.tssTools4,
            this.tsmiClipboardViewer,
            this.tsmiBorderlessWindow,
            this.tsmiInspectWindow,
            this.tsmiMonitorTest,
            this.tsmiDNSChanger});
            this.tsddbTools.Image = global::ShareNot.Properties.Resources.toolbox;
            resources.ApplyResources(this.tsddbTools, "tsddbTools");
            this.tsddbTools.Name = "tsddbTools";
            //
            // tsmiColorPicker
            //
            this.tsmiColorPicker.Image = global::ShareNot.Properties.Resources.color;
            this.tsmiColorPicker.Name = "tsmiColorPicker";
            resources.ApplyResources(this.tsmiColorPicker, "tsmiColorPicker");
            this.tsmiColorPicker.Click += new System.EventHandler(this.tsmiColorPicker_Click);
            //
            // tsmiScreenColorPicker
            //
            this.tsmiScreenColorPicker.Image = global::ShareNot.Properties.Resources.pipette;
            this.tsmiScreenColorPicker.Name = "tsmiScreenColorPicker";
            resources.ApplyResources(this.tsmiScreenColorPicker, "tsmiScreenColorPicker");
            this.tsmiScreenColorPicker.Click += new System.EventHandler(this.tsmiScreenColorPicker_Click);
            //
            // tsmiRuler
            //
            this.tsmiRuler.Image = global::ShareNot.Properties.Resources.ruler_triangle;
            this.tsmiRuler.Name = "tsmiRuler";
            resources.ApplyResources(this.tsmiRuler, "tsmiRuler");
            this.tsmiRuler.Click += new System.EventHandler(this.tsmiRuler_Click);
            //
            // tsmiPinToScreen
            //
            this.tsmiPinToScreen.Image = global::ShareNot.Properties.Resources.pin;
            this.tsmiPinToScreen.Name = "tsmiPinToScreen";
            resources.ApplyResources(this.tsmiPinToScreen, "tsmiPinToScreen");
            this.tsmiPinToScreen.Click += new System.EventHandler(this.tsmiPinToScreen_Click);
            //
            // tssTools1
            //
            this.tssTools1.Name = "tssTools1";
            resources.ApplyResources(this.tssTools1, "tssTools1");
            //
            // tsmiImageEditor
            //
            this.tsmiImageEditor.Image = global::ShareNot.Properties.Resources.image_pencil;
            this.tsmiImageEditor.Name = "tsmiImageEditor";
            resources.ApplyResources(this.tsmiImageEditor, "tsmiImageEditor");
            this.tsmiImageEditor.Click += new System.EventHandler(this.tsmiImageEditor_Click);
            //
            // tsmiImageBeautifier
            //
            this.tsmiImageBeautifier.Image = global::ShareNot.Properties.Resources.picture_sunset;
            this.tsmiImageBeautifier.Name = "tsmiImageBeautifier";
            resources.ApplyResources(this.tsmiImageBeautifier, "tsmiImageBeautifier");
            this.tsmiImageBeautifier.Click += new System.EventHandler(this.tsmiImageBeautifier_Click);
            //
            // tsmiImageEffects
            //
            this.tsmiImageEffects.Image = global::ShareNot.Properties.Resources.image_saturation;
            this.tsmiImageEffects.Name = "tsmiImageEffects";
            resources.ApplyResources(this.tsmiImageEffects, "tsmiImageEffects");
            this.tsmiImageEffects.Click += new System.EventHandler(this.tsmiImageEffects_Click);
            //
            // tsmiImageViewer
            //
            this.tsmiImageViewer.Image = global::ShareNot.Properties.Resources.images_flickr;
            this.tsmiImageViewer.Name = "tsmiImageViewer";
            resources.ApplyResources(this.tsmiImageViewer, "tsmiImageViewer");
            this.tsmiImageViewer.Click += new System.EventHandler(this.tsmiImageViewer_Click);
            //
            // tsmiImageCombiner
            //
            this.tsmiImageCombiner.Image = global::ShareNot.Properties.Resources.document_break;
            this.tsmiImageCombiner.Name = "tsmiImageCombiner";
            resources.ApplyResources(this.tsmiImageCombiner, "tsmiImageCombiner");
            this.tsmiImageCombiner.Click += new System.EventHandler(this.tsmiImageCombiner_Click);
            //
            // tsmiImageSplitter
            //
            this.tsmiImageSplitter.Image = global::ShareNot.Properties.Resources.image_split;
            this.tsmiImageSplitter.Name = "tsmiImageSplitter";
            resources.ApplyResources(this.tsmiImageSplitter, "tsmiImageSplitter");
            this.tsmiImageSplitter.Click += new System.EventHandler(this.TsmiImageSplitter_Click);
            //
            // tsmiImageThumbnailer
            //
            this.tsmiImageThumbnailer.Image = global::ShareNot.Properties.Resources.image_resize_actual;
            this.tsmiImageThumbnailer.Name = "tsmiImageThumbnailer";
            resources.ApplyResources(this.tsmiImageThumbnailer, "tsmiImageThumbnailer");
            this.tsmiImageThumbnailer.Click += new System.EventHandler(this.tsmiImageThumbnailer_Click);
            //
            // tssTools2
            //
            this.tssTools2.Name = "tssTools2";
            resources.ApplyResources(this.tssTools2, "tssTools2");
            //
            // tsmiVideoConverter
            //
            this.tsmiVideoConverter.Image = global::ShareNot.Properties.Resources.camcorder_pencil;
            this.tsmiVideoConverter.Name = "tsmiVideoConverter";
            resources.ApplyResources(this.tsmiVideoConverter, "tsmiVideoConverter");
            this.tsmiVideoConverter.Click += new System.EventHandler(this.tsmiVideoConverter_Click);
            //
            // tsmiVideoThumbnailer
            //
            this.tsmiVideoThumbnailer.Image = global::ShareNot.Properties.Resources.images_stack;
            this.tsmiVideoThumbnailer.Name = "tsmiVideoThumbnailer";
            resources.ApplyResources(this.tsmiVideoThumbnailer, "tsmiVideoThumbnailer");
            this.tsmiVideoThumbnailer.Click += new System.EventHandler(this.tsmiVideoThumbnailer_Click);
            //
            // tssTools3
            //
            this.tssTools3.Name = "tssTools3";
            resources.ApplyResources(this.tssTools3, "tssTools3");
            //
            // tsmiOCR
            //
            this.tsmiOCR.Image = global::ShareNot.Properties.Resources.edit_drop_cap;
            this.tsmiOCR.Name = "tsmiOCR";
            resources.ApplyResources(this.tsmiOCR, "tsmiOCR");
            this.tsmiOCR.Click += new System.EventHandler(this.tsmiOCR_Click);
            //
            // tsmiQRCode
            //
            this.tsmiQRCode.Image = global::ShareNot.Properties.Resources.barcode_2d;
            this.tsmiQRCode.Name = "tsmiQRCode";
            resources.ApplyResources(this.tsmiQRCode, "tsmiQRCode");
            this.tsmiQRCode.Click += new System.EventHandler(this.tsmiQRCode_Click);
            //
            // tsmiHashChecker
            //
            this.tsmiHashChecker.Image = global::ShareNot.Properties.Resources.application_task;
            this.tsmiHashChecker.Name = "tsmiHashChecker";
            resources.ApplyResources(this.tsmiHashChecker, "tsmiHashChecker");
            this.tsmiHashChecker.Click += new System.EventHandler(this.tsmiHashChecker_Click);
            //
            // tsmiIndexFolder
            //
            this.tsmiIndexFolder.Image = global::ShareNot.Properties.Resources.folder_tree;
            this.tsmiIndexFolder.Name = "tsmiIndexFolder";
            resources.ApplyResources(this.tsmiIndexFolder, "tsmiIndexFolder");
            this.tsmiIndexFolder.Click += new System.EventHandler(this.tsmiIndexFolder_Click);
            //
            // tssTools4
            //
            this.tssTools4.Name = "tssTools4";
            resources.ApplyResources(this.tssTools4, "tssTools4");
            //
            // tsmiClipboardViewer
            //
            this.tsmiClipboardViewer.Image = global::ShareNot.Properties.Resources.clipboard_block;
            this.tsmiClipboardViewer.Name = "tsmiClipboardViewer";
            resources.ApplyResources(this.tsmiClipboardViewer, "tsmiClipboardViewer");
            this.tsmiClipboardViewer.Click += new System.EventHandler(this.tsmiClipboardViewer_Click);
            //
            // tsmiBorderlessWindow
            //
            this.tsmiBorderlessWindow.Image = global::ShareNot.Properties.Resources.application_resize_full;
            this.tsmiBorderlessWindow.Name = "tsmiBorderlessWindow";
            resources.ApplyResources(this.tsmiBorderlessWindow, "tsmiBorderlessWindow");
            this.tsmiBorderlessWindow.Click += new System.EventHandler(this.tsmiBorderlessWindow_Click);
            //
            // tsmiInspectWindow
            //
            this.tsmiInspectWindow.Image = global::ShareNot.Properties.Resources.application_search_result;
            this.tsmiInspectWindow.Name = "tsmiInspectWindow";
            resources.ApplyResources(this.tsmiInspectWindow, "tsmiInspectWindow");
            this.tsmiInspectWindow.Click += new System.EventHandler(this.tsmiInspectWindow_Click);
            //
            // tsmiMonitorTest
            //
            this.tsmiMonitorTest.Image = global::ShareNot.Properties.Resources.monitor;
            this.tsmiMonitorTest.Name = "tsmiMonitorTest";
            resources.ApplyResources(this.tsmiMonitorTest, "tsmiMonitorTest");
            this.tsmiMonitorTest.Click += new System.EventHandler(this.tsmiMonitorTest_Click);
            //
            // tsmiDNSChanger
            //
            this.tsmiDNSChanger.Image = global::ShareNot.Properties.Resources.network_ip;
            this.tsmiDNSChanger.Name = "tsmiDNSChanger";
            resources.ApplyResources(this.tsmiDNSChanger, "tsmiDNSChanger");
            this.tsmiDNSChanger.Click += new System.EventHandler(this.tsmiDNSChanger_Click);
            //
            // tssMain1
            //
            this.tssMain1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.tssMain1.Name = "tssMain1";
            resources.ApplyResources(this.tssMain1, "tssMain1");
            //
            // tsddbAfterCaptureTasks
            //
            this.tsddbAfterCaptureTasks.Image = global::ShareNot.Properties.Resources.image_export;
            resources.ApplyResources(this.tsddbAfterCaptureTasks, "tsddbAfterCaptureTasks");
            this.tsddbAfterCaptureTasks.Name = "tsddbAfterCaptureTasks";
            //
            // tsbApplicationSettings
            //
            this.tsbApplicationSettings.Image = global::ShareNot.Properties.Resources.wrench_screwdriver;
            resources.ApplyResources(this.tsbApplicationSettings, "tsbApplicationSettings");
            this.tsbApplicationSettings.Name = "tsbApplicationSettings";
            this.tsbApplicationSettings.Click += new System.EventHandler(this.tsbApplicationSettings_Click);
            //
            // tsbTaskSettings
            //
            this.tsbTaskSettings.Image = global::ShareNot.Properties.Resources.gear;
            resources.ApplyResources(this.tsbTaskSettings, "tsbTaskSettings");
            this.tsbTaskSettings.Name = "tsbTaskSettings";
            this.tsbTaskSettings.Click += new System.EventHandler(this.tsbTaskSettings_Click);
            //
            // tsbHotkeySettings
            //
            this.tsbHotkeySettings.Image = global::ShareNot.Properties.Resources.keyboard;
            resources.ApplyResources(this.tsbHotkeySettings, "tsbHotkeySettings");
            this.tsbHotkeySettings.Name = "tsbHotkeySettings";
            this.tsbHotkeySettings.Click += new System.EventHandler(this.tsbHotkeySettings_Click);
            //
            // tssMain2
            //
            this.tssMain2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.tssMain2.Name = "tssMain2";
            resources.ApplyResources(this.tssMain2, "tssMain2");
            //
            // tsbScreenshotsFolder
            //
            this.tsbScreenshotsFolder.Image = global::ShareNot.Properties.Resources.folder_open_image;
            resources.ApplyResources(this.tsbScreenshotsFolder, "tsbScreenshotsFolder");
            this.tsbScreenshotsFolder.Name = "tsbScreenshotsFolder";
            this.tsbScreenshotsFolder.Click += new System.EventHandler(this.tsbScreenshotsFolder_Click);
            //
            // tsbHistory
            //
            this.tsbHistory.Image = global::ShareNot.Properties.Resources.application_blog;
            resources.ApplyResources(this.tsbHistory, "tsbHistory");
            this.tsbHistory.Name = "tsbHistory";
            this.tsbHistory.Click += new System.EventHandler(this.tsbHistory_Click);
            //
            // tsbImageHistory
            //
            this.tsbImageHistory.Image = global::ShareNot.Properties.Resources.application_icon_large;
            resources.ApplyResources(this.tsbImageHistory, "tsbImageHistory");
            this.tsbImageHistory.Name = "tsbImageHistory";
            this.tsbImageHistory.Click += new System.EventHandler(this.tsbImageHistory_Click);
            //
            // tssMain3
            //
            this.tssMain3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.tssMain3.Name = "tssMain3";
            resources.ApplyResources(this.tssMain3, "tssMain3");
            //
            // tsddbDebug
            //
            this.tsddbDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDebugLog,
            this.tsmiTestImageUpload});
            this.tsddbDebug.Image = global::ShareNot.Properties.Resources.traffic_cone;
            resources.ApplyResources(this.tsddbDebug, "tsddbDebug");
            this.tsddbDebug.Name = "tsddbDebug";
            //
            // tsmiShowDebugLog
            //
            this.tsmiShowDebugLog.Image = global::ShareNot.Properties.Resources.application_monitor;
            this.tsmiShowDebugLog.Name = "tsmiShowDebugLog";
            resources.ApplyResources(this.tsmiShowDebugLog, "tsmiShowDebugLog");
            this.tsmiShowDebugLog.Click += new System.EventHandler(this.tsmiShowDebugLog_Click);
            //
            // tsmiTestImageUpload
            //
            this.tsmiTestImageUpload.Image = global::ShareNot.Properties.Resources.image;
            this.tsmiTestImageUpload.Name = "tsmiTestImageUpload";
            resources.ApplyResources(this.tsmiTestImageUpload, "tsmiTestImageUpload");
            this.tsmiTestImageUpload.Click += new System.EventHandler(this.tsmiTestImageUpload_Click);
            //
            // tsbDonate
            //
            this.tsbDonate.Image = global::ShareNot.Properties.Resources.heart;
            resources.ApplyResources(this.tsbDonate, "tsbDonate");
            this.tsbDonate.Name = "tsbDonate";
            this.tsbDonate.Click += new System.EventHandler(this.tsbDonate_Click);
            //
            // tsbDiscord
            //
            this.tsbDiscord.Image = global::ShareNot.Properties.Resources.Discord_black;
            resources.ApplyResources(this.tsbDiscord, "tsbDiscord");
            this.tsbDiscord.Name = "tsbDiscord";
            this.tsbDiscord.Click += new System.EventHandler(this.tsbDiscord_Click);
            //
            // tsbAbout
            //
            this.tsbAbout.Image = global::ShareNot.Properties.Resources.crown;
            resources.ApplyResources(this.tsbAbout, "tsbAbout");
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            //
            // cmsTaskInfo
            //
            this.cmsTaskInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowErrors,
            this.tsmiStopUpload,
            this.tsmiOpen,
            this.tsmiCopy,
            this.tsmiEditSelectedFile,
            this.tsmiBeautifyImage,
            this.tsmiAddImageEffects,
            this.tsmiPinSelectedFile,
            this.tsmiRunAction,
            this.tsmiDeleteSelectedItem,
            this.tsmiDeleteSelectedFile,
            this.tsmiOCRImage,
            this.tsmiCombineImages,
            this.tsmiClearList,
            this.tssUploadInfo1,
            this.tsmiSwitchTaskViewMode});
            this.cmsTaskInfo.Name = "cmsHistory";
            resources.ApplyResources(this.cmsTaskInfo, "cmsTaskInfo");
            this.cmsTaskInfo.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.cmsTaskInfo_Closing);
            this.cmsTaskInfo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cmsTaskInfo_PreviewKeyDown);
            //
            // tsmiShowErrors
            //
            this.tsmiShowErrors.Image = global::ShareNot.Properties.Resources.exclamation_button;
            this.tsmiShowErrors.Name = "tsmiShowErrors";
            resources.ApplyResources(this.tsmiShowErrors, "tsmiShowErrors");
            this.tsmiShowErrors.Click += new System.EventHandler(this.tsmiShowErrors_Click);
            //
            // tsmiStopUpload
            //
            this.tsmiStopUpload.Image = global::ShareNot.Properties.Resources.cross_button;
            this.tsmiStopUpload.Name = "tsmiStopUpload";
            resources.ApplyResources(this.tsmiStopUpload, "tsmiStopUpload");
            this.tsmiStopUpload.Click += new System.EventHandler(this.tsmiStopUpload_Click);
            //
            // tsmiOpen
            //
            this.tsmiOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssOpen1,
            this.tsmiOpenFile,
            this.tsmiOpenFolder,
            this.tsmiOpenThumbnailFile});
            this.tsmiOpen.Image = global::ShareNot.Properties.Resources.folder_open_document;
            this.tsmiOpen.Name = "tsmiOpen";
            resources.ApplyResources(this.tsmiOpen, "tsmiOpen");
            //
            // tssOpen1
            //
            this.tssOpen1.Name = "tssOpen1";
            resources.ApplyResources(this.tssOpen1, "tssOpen1");
            //
            // tsmiOpenFile
            //
            this.tsmiOpenFile.Name = "tsmiOpenFile";
            resources.ApplyResources(this.tsmiOpenFile, "tsmiOpenFile");
            this.tsmiOpenFile.Click += new System.EventHandler(this.tsmiOpenFile_Click);
            //
            // tsmiOpenFolder
            //
            this.tsmiOpenFolder.Name = "tsmiOpenFolder";
            resources.ApplyResources(this.tsmiOpenFolder, "tsmiOpenFolder");
            this.tsmiOpenFolder.Click += new System.EventHandler(this.tsmiOpenFolder_Click);
            //
            // tsmiOpenThumbnailFile
            //
            this.tsmiOpenThumbnailFile.Name = "tsmiOpenThumbnailFile";
            resources.ApplyResources(this.tsmiOpenThumbnailFile, "tsmiOpenThumbnailFile");
            this.tsmiOpenThumbnailFile.Click += new System.EventHandler(this.tsmiOpenThumbnailFile_Click);
            //
            // tsmiCopy
            //
            this.tsmiCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCopy1,
            this.tsmiCopyFile,
            this.tsmiCopyImage,
            this.tsmiCopyImageDimensions,
            this.tsmiCopyText,
            this.tsmiCopyThumbnailFile,
            this.tsmiCopyThumbnailImage,
            this.tssCopy2,
            this.tsmiCopyFilePath,
            this.tsmiCopyFileName,
            this.tsmiCopyFileNameWithExtension,
            this.tsmiCopyFolder,
            this.tssCopy6});
            this.tsmiCopy.Image = global::ShareNot.Properties.Resources.document_copy;
            this.tsmiCopy.Name = "tsmiCopy";
            resources.ApplyResources(this.tsmiCopy, "tsmiCopy");
            //
            // tssCopy1
            //
            this.tssCopy1.Name = "tssCopy1";
            resources.ApplyResources(this.tssCopy1, "tssCopy1");
            //
            // tsmiCopyFile
            //
            this.tsmiCopyFile.Name = "tsmiCopyFile";
            resources.ApplyResources(this.tsmiCopyFile, "tsmiCopyFile");
            this.tsmiCopyFile.Click += new System.EventHandler(this.tsmiCopyFile_Click);
            //
            // tsmiCopyImage
            //
            this.tsmiCopyImage.Name = "tsmiCopyImage";
            resources.ApplyResources(this.tsmiCopyImage, "tsmiCopyImage");
            this.tsmiCopyImage.Click += new System.EventHandler(this.tsmiCopyImage_Click);
            //
            // tsmiCopyImageDimensions
            //
            this.tsmiCopyImageDimensions.Name = "tsmiCopyImageDimensions";
            resources.ApplyResources(this.tsmiCopyImageDimensions, "tsmiCopyImageDimensions");
            this.tsmiCopyImageDimensions.Click += new System.EventHandler(this.tsmiCopyImageDimensions_Click);
            //
            // tsmiCopyText
            //
            this.tsmiCopyText.Name = "tsmiCopyText";
            resources.ApplyResources(this.tsmiCopyText, "tsmiCopyText");
            this.tsmiCopyText.Click += new System.EventHandler(this.tsmiCopyText_Click);
            //
            // tsmiCopyThumbnailFile
            //
            this.tsmiCopyThumbnailFile.Name = "tsmiCopyThumbnailFile";
            resources.ApplyResources(this.tsmiCopyThumbnailFile, "tsmiCopyThumbnailFile");
            this.tsmiCopyThumbnailFile.Click += new System.EventHandler(this.tsmiCopyThumbnailFile_Click);
            //
            // tsmiCopyThumbnailImage
            //
            this.tsmiCopyThumbnailImage.Name = "tsmiCopyThumbnailImage";
            resources.ApplyResources(this.tsmiCopyThumbnailImage, "tsmiCopyThumbnailImage");
            this.tsmiCopyThumbnailImage.Click += new System.EventHandler(this.tsmiCopyThumbnailImage_Click);
            //
            // tssCopy2
            //
            this.tssCopy2.Name = "tssCopy2";
            resources.ApplyResources(this.tssCopy2, "tssCopy2");
            //
            // tsmiCopyFilePath
            //
            this.tsmiCopyFilePath.Name = "tsmiCopyFilePath";
            resources.ApplyResources(this.tsmiCopyFilePath, "tsmiCopyFilePath");
            this.tsmiCopyFilePath.Click += new System.EventHandler(this.tsmiCopyFilePath_Click);
            //
            // tsmiCopyFileName
            //
            this.tsmiCopyFileName.Name = "tsmiCopyFileName";
            resources.ApplyResources(this.tsmiCopyFileName, "tsmiCopyFileName");
            this.tsmiCopyFileName.Click += new System.EventHandler(this.tsmiCopyFileName_Click);
            //
            // tsmiCopyFileNameWithExtension
            //
            this.tsmiCopyFileNameWithExtension.Name = "tsmiCopyFileNameWithExtension";
            resources.ApplyResources(this.tsmiCopyFileNameWithExtension, "tsmiCopyFileNameWithExtension");
            this.tsmiCopyFileNameWithExtension.Click += new System.EventHandler(this.tsmiCopyFileNameWithExtension_Click);
            //
            // tsmiCopyFolder
            //
            this.tsmiCopyFolder.Name = "tsmiCopyFolder";
            resources.ApplyResources(this.tsmiCopyFolder, "tsmiCopyFolder");
            this.tsmiCopyFolder.Click += new System.EventHandler(this.tsmiCopyFolder_Click);
            //
            // tssCopy6
            //
            this.tssCopy6.Name = "tssCopy6";
            resources.ApplyResources(this.tssCopy6, "tssCopy6");
            //
            // tsmiEditSelectedFile
            //
            this.tsmiEditSelectedFile.Image = global::ShareNot.Properties.Resources.image_pencil;
            this.tsmiEditSelectedFile.Name = "tsmiEditSelectedFile";
            resources.ApplyResources(this.tsmiEditSelectedFile, "tsmiEditSelectedFile");
            this.tsmiEditSelectedFile.Click += new System.EventHandler(this.tsmiEditSelectedFile_Click);
            //
            // tsmiBeautifyImage
            //
            this.tsmiBeautifyImage.Image = global::ShareNot.Properties.Resources.picture_sunset;
            this.tsmiBeautifyImage.Name = "tsmiBeautifyImage";
            resources.ApplyResources(this.tsmiBeautifyImage, "tsmiBeautifyImage");
            this.tsmiBeautifyImage.Click += new System.EventHandler(this.tsmiBeautifyImage_Click);
            //
            // tsmiAddImageEffects
            //
            this.tsmiAddImageEffects.Image = global::ShareNot.Properties.Resources.image_saturation;
            this.tsmiAddImageEffects.Name = "tsmiAddImageEffects";
            resources.ApplyResources(this.tsmiAddImageEffects, "tsmiAddImageEffects");
            this.tsmiAddImageEffects.Click += new System.EventHandler(this.tsmiAddImageEffects_Click);
            //
            // tsmiPinSelectedFile
            //
            this.tsmiPinSelectedFile.Image = global::ShareNot.Properties.Resources.pin;
            this.tsmiPinSelectedFile.Name = "tsmiPinSelectedFile";
            resources.ApplyResources(this.tsmiPinSelectedFile, "tsmiPinSelectedFile");
            this.tsmiPinSelectedFile.Click += new System.EventHandler(this.tsmiPinSelectedFile_Click);
            //
            // tsmiRunAction
            //
            this.tsmiRunAction.Image = global::ShareNot.Properties.Resources.application_terminal;
            this.tsmiRunAction.Name = "tsmiRunAction";
            resources.ApplyResources(this.tsmiRunAction, "tsmiRunAction");
            //
            // tsmiDeleteSelectedItem
            //
            this.tsmiDeleteSelectedItem.Image = global::ShareNot.Properties.Resources.script__minus;
            this.tsmiDeleteSelectedItem.Name = "tsmiDeleteSelectedItem";
            resources.ApplyResources(this.tsmiDeleteSelectedItem, "tsmiDeleteSelectedItem");
            this.tsmiDeleteSelectedItem.Click += new System.EventHandler(this.tsmiDeleteSelectedItem_Click);
            //
            // tsmiDeleteSelectedFile
            //
            this.tsmiDeleteSelectedFile.Image = global::ShareNot.Properties.Resources.bin;
            this.tsmiDeleteSelectedFile.Name = "tsmiDeleteSelectedFile";
            resources.ApplyResources(this.tsmiDeleteSelectedFile, "tsmiDeleteSelectedFile");
            this.tsmiDeleteSelectedFile.Click += new System.EventHandler(this.tsmiDeleteSelectedFile_Click);
            //
            // tsmiOCRImage
            //
            this.tsmiOCRImage.Image = global::ShareNot.Properties.Resources.edit_drop_cap;
            this.tsmiOCRImage.Name = "tsmiOCRImage";
            resources.ApplyResources(this.tsmiOCRImage, "tsmiOCRImage");
            this.tsmiOCRImage.Click += new System.EventHandler(this.tsmiOCRImage_Click);
            //
            // tsmiCombineImages
            //
            this.tsmiCombineImages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCombineImagesHorizontally,
            this.tsmiCombineImagesVertically});
            this.tsmiCombineImages.Image = global::ShareNot.Properties.Resources.document_break;
            this.tsmiCombineImages.Name = "tsmiCombineImages";
            resources.ApplyResources(this.tsmiCombineImages, "tsmiCombineImages");
            this.tsmiCombineImages.Click += new System.EventHandler(this.tsmiCombineImages_Click);
            //
            // tsmiCombineImagesHorizontally
            //
            this.tsmiCombineImagesHorizontally.Image = global::ShareNot.Properties.Resources.application_tile_horizontal;
            this.tsmiCombineImagesHorizontally.Name = "tsmiCombineImagesHorizontally";
            resources.ApplyResources(this.tsmiCombineImagesHorizontally, "tsmiCombineImagesHorizontally");
            this.tsmiCombineImagesHorizontally.Click += new System.EventHandler(this.tsmiCombineImagesHorizontally_Click);
            //
            // tsmiCombineImagesVertically
            //
            this.tsmiCombineImagesVertically.Image = global::ShareNot.Properties.Resources.application_tile_vertical;
            this.tsmiCombineImagesVertically.Name = "tsmiCombineImagesVertically";
            resources.ApplyResources(this.tsmiCombineImagesVertically, "tsmiCombineImagesVertically");
            this.tsmiCombineImagesVertically.Click += new System.EventHandler(this.tsmiCombineImagesVertically_Click);
            //
            // tsmiClearList
            //
            this.tsmiClearList.Image = global::ShareNot.Properties.Resources.eraser;
            this.tsmiClearList.Name = "tsmiClearList";
            resources.ApplyResources(this.tsmiClearList, "tsmiClearList");
            this.tsmiClearList.Click += new System.EventHandler(this.tsmiClearList_Click);
            //
            // tssUploadInfo1
            //
            this.tssUploadInfo1.Name = "tssUploadInfo1";
            resources.ApplyResources(this.tssUploadInfo1, "tssUploadInfo1");
            //
            // tsmiSwitchTaskViewMode
            //
            this.tsmiSwitchTaskViewMode.Name = "tsmiSwitchTaskViewMode";
            resources.ApplyResources(this.tsmiSwitchTaskViewMode, "tsmiSwitchTaskViewMode");
            this.tsmiSwitchTaskViewMode.Click += new System.EventHandler(this.TsmiSwitchTaskViewMode_Click);
            //
            // niTray
            //
            this.niTray.ContextMenuStrip = this.cmsTray;
            resources.ApplyResources(this.niTray, "niTray");
            this.niTray.BalloonTipClicked += new System.EventHandler(this.niTray_BalloonTipClicked);
            this.niTray.MouseUp += new System.Windows.Forms.MouseEventHandler(this.niTray_MouseUp);
            //
            // cmsTray
            //
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTrayCapture,
            this.tsmiTrayWorkflows,
            this.tsmiTrayTools,
            this.tssTray1,
            this.tsmiTrayAfterCaptureTasks,
            this.tsmiTrayApplicationSettings,
            this.tsmiTrayTaskSettings,
            this.tsmiTrayHotkeySettings,
            this.tsmiTrayToggleHotkeys,
            this.tssTray2,
            this.tsmiScreenshotsFolder,
            this.tsmiTrayHistory,
            this.tsmiTrayImageHistory,
            this.tssTray3,
            this.tsmiRestartAsAdmin,
            this.tsmiTrayRecentItems,
            this.tsmiOpenActionsToolbar,
            this.tsmiTrayShow,
            this.tsmiTrayExit});
            this.cmsTray.Name = "cmsTray";
            resources.ApplyResources(this.cmsTray, "cmsTray");
            this.cmsTray.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cmsTray_Closed);
            this.cmsTray.Opened += new System.EventHandler(this.cmsTray_Opened);
            //
            // tsmiTrayCapture
            //
            this.tsmiTrayCapture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTrayFullscreen,
            this.tsmiTrayWindow,
            this.tsmiTrayMonitor,
            this.tsmiTrayRectangle,
            this.tsmiTrayRectangleLight,
            this.tsmiTrayRectangleTransparent,
            this.tsmiTrayLastRegion,
            this.tsmiTrayScreenRecordingFFmpeg,
            this.tsmiTrayScreenRecordingGIF,
            this.tsmiTrayScrollingCapture,
            this.tsmiTrayAutoCapture,
            this.tssTrayCapture1,
            this.tsmiTrayShowCursor,
            this.tsmiTrayScreenshotDelay});
            this.tsmiTrayCapture.Image = global::ShareNot.Properties.Resources.camera;
            this.tsmiTrayCapture.Name = "tsmiTrayCapture";
            resources.ApplyResources(this.tsmiTrayCapture, "tsmiTrayCapture");
            this.tsmiTrayCapture.DropDownOpening += new System.EventHandler(this.tsmiCapture_DropDownOpening);
            //
            // tsmiTrayFullscreen
            //
            this.tsmiTrayFullscreen.Image = global::ShareNot.Properties.Resources.layer_fullscreen;
            this.tsmiTrayFullscreen.Name = "tsmiTrayFullscreen";
            resources.ApplyResources(this.tsmiTrayFullscreen, "tsmiTrayFullscreen");
            this.tsmiTrayFullscreen.Click += new System.EventHandler(this.tsmiTrayFullscreen_Click);
            //
            // tsmiTrayWindow
            //
            this.tsmiTrayWindow.Image = global::ShareNot.Properties.Resources.application_blue;
            this.tsmiTrayWindow.Name = "tsmiTrayWindow";
            resources.ApplyResources(this.tsmiTrayWindow, "tsmiTrayWindow");
            //
            // tsmiTrayMonitor
            //
            this.tsmiTrayMonitor.Image = global::ShareNot.Properties.Resources.monitor;
            this.tsmiTrayMonitor.Name = "tsmiTrayMonitor";
            resources.ApplyResources(this.tsmiTrayMonitor, "tsmiTrayMonitor");
            //
            // tsmiTrayRectangle
            //
            this.tsmiTrayRectangle.Image = global::ShareNot.Properties.Resources.layer_shape;
            this.tsmiTrayRectangle.Name = "tsmiTrayRectangle";
            resources.ApplyResources(this.tsmiTrayRectangle, "tsmiTrayRectangle");
            this.tsmiTrayRectangle.Click += new System.EventHandler(this.tsmiTrayRectangle_Click);
            //
            // tsmiTrayRectangleLight
            //
            this.tsmiTrayRectangleLight.Image = global::ShareNot.Properties.Resources.Rectangle;
            this.tsmiTrayRectangleLight.Name = "tsmiTrayRectangleLight";
            resources.ApplyResources(this.tsmiTrayRectangleLight, "tsmiTrayRectangleLight");
            this.tsmiTrayRectangleLight.Click += new System.EventHandler(this.tsmiTrayRectangleLight_Click);
            //
            // tsmiTrayRectangleTransparent
            //
            this.tsmiTrayRectangleTransparent.Image = global::ShareNot.Properties.Resources.layer_transparent;
            this.tsmiTrayRectangleTransparent.Name = "tsmiTrayRectangleTransparent";
            resources.ApplyResources(this.tsmiTrayRectangleTransparent, "tsmiTrayRectangleTransparent");
            this.tsmiTrayRectangleTransparent.Click += new System.EventHandler(this.tsmiTrayRectangleTransparent_Click);
            //
            // tsmiTrayLastRegion
            //
            this.tsmiTrayLastRegion.Image = global::ShareNot.Properties.Resources.layers;
            this.tsmiTrayLastRegion.Name = "tsmiTrayLastRegion";
            resources.ApplyResources(this.tsmiTrayLastRegion, "tsmiTrayLastRegion");
            this.tsmiTrayLastRegion.Click += new System.EventHandler(this.tsmiTrayLastRegion_Click);
            //
            // tsmiTrayScreenRecordingFFmpeg
            //
            this.tsmiTrayScreenRecordingFFmpeg.Image = global::ShareNot.Properties.Resources.camcorder_image;
            this.tsmiTrayScreenRecordingFFmpeg.Name = "tsmiTrayScreenRecordingFFmpeg";
            resources.ApplyResources(this.tsmiTrayScreenRecordingFFmpeg, "tsmiTrayScreenRecordingFFmpeg");
            this.tsmiTrayScreenRecordingFFmpeg.Click += new System.EventHandler(this.tsmiScreenRecordingFFmpeg_Click);
            //
            // tsmiTrayScreenRecordingGIF
            //
            this.tsmiTrayScreenRecordingGIF.Image = global::ShareNot.Properties.Resources.film;
            this.tsmiTrayScreenRecordingGIF.Name = "tsmiTrayScreenRecordingGIF";
            resources.ApplyResources(this.tsmiTrayScreenRecordingGIF, "tsmiTrayScreenRecordingGIF");
            this.tsmiTrayScreenRecordingGIF.Click += new System.EventHandler(this.tsmiScreenRecordingGIF_Click);
            //
            // tsmiTrayScrollingCapture
            //
            this.tsmiTrayScrollingCapture.Image = global::ShareNot.Properties.Resources.ui_scroll_pane_image;
            this.tsmiTrayScrollingCapture.Name = "tsmiTrayScrollingCapture";
            resources.ApplyResources(this.tsmiTrayScrollingCapture, "tsmiTrayScrollingCapture");
            this.tsmiTrayScrollingCapture.Click += new System.EventHandler(this.tsmiScrollingCapture_Click);
            //
            // tsmiTrayAutoCapture
            //
            this.tsmiTrayAutoCapture.Image = global::ShareNot.Properties.Resources.clock;
            this.tsmiTrayAutoCapture.Name = "tsmiTrayAutoCapture";
            resources.ApplyResources(this.tsmiTrayAutoCapture, "tsmiTrayAutoCapture");
            this.tsmiTrayAutoCapture.Click += new System.EventHandler(this.tsmiAutoCapture_Click);
            //
            // tssTrayCapture1
            //
            this.tssTrayCapture1.Name = "tssTrayCapture1";
            resources.ApplyResources(this.tssTrayCapture1, "tssTrayCapture1");
            //
            // tsmiTrayShowCursor
            //
            this.tsmiTrayShowCursor.CheckOnClick = true;
            this.tsmiTrayShowCursor.Image = global::ShareNot.Properties.Resources.cursor;
            this.tsmiTrayShowCursor.Name = "tsmiTrayShowCursor";
            resources.ApplyResources(this.tsmiTrayShowCursor, "tsmiTrayShowCursor");
            this.tsmiTrayShowCursor.Click += new System.EventHandler(this.tsmiShowCursor_Click);
            //
            // tsmiTrayScreenshotDelay
            //
            this.tsmiTrayScreenshotDelay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTrayScreenshotDelay0,
            this.tsmiTrayScreenshotDelay1,
            this.tsmiTrayScreenshotDelay2,
            this.tsmiTrayScreenshotDelay3,
            this.tsmiTrayScreenshotDelay4,
            this.tsmiTrayScreenshotDelay5});
            this.tsmiTrayScreenshotDelay.Image = global::ShareNot.Properties.Resources.clock_select;
            this.tsmiTrayScreenshotDelay.Name = "tsmiTrayScreenshotDelay";
            resources.ApplyResources(this.tsmiTrayScreenshotDelay, "tsmiTrayScreenshotDelay");
            //
            // tsmiTrayScreenshotDelay0
            //
            this.tsmiTrayScreenshotDelay0.Name = "tsmiTrayScreenshotDelay0";
            resources.ApplyResources(this.tsmiTrayScreenshotDelay0, "tsmiTrayScreenshotDelay0");
            this.tsmiTrayScreenshotDelay0.Click += new System.EventHandler(this.tsmiScreenshotDelay0_Click);
            //
            // tsmiTrayScreenshotDelay1
            //
            this.tsmiTrayScreenshotDelay1.Name = "tsmiTrayScreenshotDelay1";
            resources.ApplyResources(this.tsmiTrayScreenshotDelay1, "tsmiTrayScreenshotDelay1");
            this.tsmiTrayScreenshotDelay1.Click += new System.EventHandler(this.tsmiScreenshotDelay1_Click);
            //
            // tsmiTrayScreenshotDelay2
            //
            this.tsmiTrayScreenshotDelay2.Name = "tsmiTrayScreenshotDelay2";
            resources.ApplyResources(this.tsmiTrayScreenshotDelay2, "tsmiTrayScreenshotDelay2");
            this.tsmiTrayScreenshotDelay2.Click += new System.EventHandler(this.tsmiScreenshotDelay2_Click);
            //
            // tsmiTrayScreenshotDelay3
            //
            this.tsmiTrayScreenshotDelay3.Name = "tsmiTrayScreenshotDelay3";
            resources.ApplyResources(this.tsmiTrayScreenshotDelay3, "tsmiTrayScreenshotDelay3");
            this.tsmiTrayScreenshotDelay3.Click += new System.EventHandler(this.tsmiScreenshotDelay3_Click);
            //
            // tsmiTrayScreenshotDelay4
            //
            this.tsmiTrayScreenshotDelay4.Name = "tsmiTrayScreenshotDelay4";
            resources.ApplyResources(this.tsmiTrayScreenshotDelay4, "tsmiTrayScreenshotDelay4");
            this.tsmiTrayScreenshotDelay4.Click += new System.EventHandler(this.tsmiScreenshotDelay4_Click);
            //
            // tsmiTrayScreenshotDelay5
            //
            this.tsmiTrayScreenshotDelay5.Name = "tsmiTrayScreenshotDelay5";
            resources.ApplyResources(this.tsmiTrayScreenshotDelay5, "tsmiTrayScreenshotDelay5");
            this.tsmiTrayScreenshotDelay5.Click += new System.EventHandler(this.tsmiScreenshotDelay5_Click);
            //
            // tsmiTrayWorkflows
            //
            this.tsmiTrayWorkflows.Image = global::ShareNot.Properties.Resources.categories;
            this.tsmiTrayWorkflows.Name = "tsmiTrayWorkflows";
            resources.ApplyResources(this.tsmiTrayWorkflows, "tsmiTrayWorkflows");
            //
            // tsmiTrayTools
            //
            this.tsmiTrayTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTrayColorPicker,
            this.tsmiTrayScreenColorPicker,
            this.tsmiTrayRuler,
            this.tsmiTrayPinToScreen,
            this.tssTrayTools1,
            this.tsmiTrayImageEditor,
            this.tsmiTrayImageBeautifier,
            this.tsmiTrayImageEffects,
            this.tsmiTrayImageViewer,
            this.tsmiTrayImageCombiner,
            this.tsmiTrayImageSplitter,
            this.tsmiTrayImageThumbnailer,
            this.tssTrayTools2,
            this.tsmiTrayVideoConverter,
            this.tsmiTrayVideoThumbnailer,
            this.tssTrayTools3,
            this.tsmiTrayOCR,
            this.tsmiTrayQRCode,
            this.tsmiTrayHashChecker,
            this.tsmiTrayIndexFolder,
            this.tssTrayTools4,
            this.tsmiTrayClipboardViewer,
            this.tsmiTrayBorderlessWindow,
            this.tsmiTrayInspectWindow,
            this.tsmiTrayMonitorTest,
            this.tsmiTrayDNSChanger});
            this.tsmiTrayTools.Image = global::ShareNot.Properties.Resources.toolbox;
            this.tsmiTrayTools.Name = "tsmiTrayTools";
            resources.ApplyResources(this.tsmiTrayTools, "tsmiTrayTools");
            //
            // tsmiTrayColorPicker
            //
            this.tsmiTrayColorPicker.Image = global::ShareNot.Properties.Resources.color;
            this.tsmiTrayColorPicker.Name = "tsmiTrayColorPicker";
            resources.ApplyResources(this.tsmiTrayColorPicker, "tsmiTrayColorPicker");
            this.tsmiTrayColorPicker.Click += new System.EventHandler(this.tsmiColorPicker_Click);
            //
            // tsmiTrayScreenColorPicker
            //
            this.tsmiTrayScreenColorPicker.Image = global::ShareNot.Properties.Resources.pipette;
            this.tsmiTrayScreenColorPicker.Name = "tsmiTrayScreenColorPicker";
            resources.ApplyResources(this.tsmiTrayScreenColorPicker, "tsmiTrayScreenColorPicker");
            this.tsmiTrayScreenColorPicker.Click += new System.EventHandler(this.tsmiScreenColorPicker_Click);
            //
            // tsmiTrayRuler
            //
            this.tsmiTrayRuler.Image = global::ShareNot.Properties.Resources.ruler_triangle;
            this.tsmiTrayRuler.Name = "tsmiTrayRuler";
            resources.ApplyResources(this.tsmiTrayRuler, "tsmiTrayRuler");
            this.tsmiTrayRuler.Click += new System.EventHandler(this.tsmiRuler_Click);
            //
            // tsmiTrayPinToScreen
            //
            this.tsmiTrayPinToScreen.Image = global::ShareNot.Properties.Resources.pin;
            this.tsmiTrayPinToScreen.Name = "tsmiTrayPinToScreen";
            resources.ApplyResources(this.tsmiTrayPinToScreen, "tsmiTrayPinToScreen");
            this.tsmiTrayPinToScreen.Click += new System.EventHandler(this.tsmiPinToScreen_Click);
            //
            // tssTrayTools1
            //
            this.tssTrayTools1.Name = "tssTrayTools1";
            resources.ApplyResources(this.tssTrayTools1, "tssTrayTools1");
            //
            // tsmiTrayImageEditor
            //
            this.tsmiTrayImageEditor.Image = global::ShareNot.Properties.Resources.image_pencil;
            this.tsmiTrayImageEditor.Name = "tsmiTrayImageEditor";
            resources.ApplyResources(this.tsmiTrayImageEditor, "tsmiTrayImageEditor");
            this.tsmiTrayImageEditor.Click += new System.EventHandler(this.tsmiImageEditor_Click);
            //
            // tsmiTrayImageBeautifier
            //
            this.tsmiTrayImageBeautifier.Image = global::ShareNot.Properties.Resources.picture_sunset;
            this.tsmiTrayImageBeautifier.Name = "tsmiTrayImageBeautifier";
            resources.ApplyResources(this.tsmiTrayImageBeautifier, "tsmiTrayImageBeautifier");
            this.tsmiTrayImageBeautifier.Click += new System.EventHandler(this.tsmiImageBeautifier_Click);
            //
            // tsmiTrayImageEffects
            //
            this.tsmiTrayImageEffects.Image = global::ShareNot.Properties.Resources.image_saturation;
            this.tsmiTrayImageEffects.Name = "tsmiTrayImageEffects";
            resources.ApplyResources(this.tsmiTrayImageEffects, "tsmiTrayImageEffects");
            this.tsmiTrayImageEffects.Click += new System.EventHandler(this.tsmiImageEffects_Click);
            //
            // tsmiTrayImageViewer
            //
            this.tsmiTrayImageViewer.Image = global::ShareNot.Properties.Resources.images_flickr;
            this.tsmiTrayImageViewer.Name = "tsmiTrayImageViewer";
            resources.ApplyResources(this.tsmiTrayImageViewer, "tsmiTrayImageViewer");
            this.tsmiTrayImageViewer.Click += new System.EventHandler(this.tsmiImageViewer_Click);
            //
            // tsmiTrayImageCombiner
            //
            this.tsmiTrayImageCombiner.Image = global::ShareNot.Properties.Resources.document_break;
            this.tsmiTrayImageCombiner.Name = "tsmiTrayImageCombiner";
            resources.ApplyResources(this.tsmiTrayImageCombiner, "tsmiTrayImageCombiner");
            this.tsmiTrayImageCombiner.Click += new System.EventHandler(this.tsmiImageCombiner_Click);
            //
            // tsmiTrayImageSplitter
            //
            this.tsmiTrayImageSplitter.Image = global::ShareNot.Properties.Resources.image_split;
            this.tsmiTrayImageSplitter.Name = "tsmiTrayImageSplitter";
            resources.ApplyResources(this.tsmiTrayImageSplitter, "tsmiTrayImageSplitter");
            this.tsmiTrayImageSplitter.Click += new System.EventHandler(this.TsmiImageSplitter_Click);
            //
            // tsmiTrayImageThumbnailer
            //
            this.tsmiTrayImageThumbnailer.Image = global::ShareNot.Properties.Resources.image_resize_actual;
            this.tsmiTrayImageThumbnailer.Name = "tsmiTrayImageThumbnailer";
            resources.ApplyResources(this.tsmiTrayImageThumbnailer, "tsmiTrayImageThumbnailer");
            this.tsmiTrayImageThumbnailer.Click += new System.EventHandler(this.tsmiImageThumbnailer_Click);
            //
            // tssTrayTools2
            //
            this.tssTrayTools2.Name = "tssTrayTools2";
            resources.ApplyResources(this.tssTrayTools2, "tssTrayTools2");
            //
            // tsmiTrayVideoConverter
            //
            this.tsmiTrayVideoConverter.Image = global::ShareNot.Properties.Resources.camcorder_pencil;
            this.tsmiTrayVideoConverter.Name = "tsmiTrayVideoConverter";
            resources.ApplyResources(this.tsmiTrayVideoConverter, "tsmiTrayVideoConverter");
            this.tsmiTrayVideoConverter.Click += new System.EventHandler(this.tsmiVideoConverter_Click);
            //
            // tsmiTrayVideoThumbnailer
            //
            this.tsmiTrayVideoThumbnailer.Image = global::ShareNot.Properties.Resources.images_stack;
            this.tsmiTrayVideoThumbnailer.Name = "tsmiTrayVideoThumbnailer";
            resources.ApplyResources(this.tsmiTrayVideoThumbnailer, "tsmiTrayVideoThumbnailer");
            this.tsmiTrayVideoThumbnailer.Click += new System.EventHandler(this.tsmiVideoThumbnailer_Click);
            //
            // tssTrayTools3
            //
            this.tssTrayTools3.Name = "tssTrayTools3";
            resources.ApplyResources(this.tssTrayTools3, "tssTrayTools3");
            //
            // tsmiTrayOCR
            //
            this.tsmiTrayOCR.Image = global::ShareNot.Properties.Resources.edit_drop_cap;
            this.tsmiTrayOCR.Name = "tsmiTrayOCR";
            resources.ApplyResources(this.tsmiTrayOCR, "tsmiTrayOCR");
            this.tsmiTrayOCR.Click += new System.EventHandler(this.tsmiTrayOCR_Click);
            //
            // tsmiTrayQRCode
            //
            this.tsmiTrayQRCode.Image = global::ShareNot.Properties.Resources.barcode_2d;
            this.tsmiTrayQRCode.Name = "tsmiTrayQRCode";
            resources.ApplyResources(this.tsmiTrayQRCode, "tsmiTrayQRCode");
            this.tsmiTrayQRCode.Click += new System.EventHandler(this.tsmiQRCode_Click);
            //
            // tsmiTrayHashChecker
            //
            this.tsmiTrayHashChecker.Image = global::ShareNot.Properties.Resources.application_task;
            this.tsmiTrayHashChecker.Name = "tsmiTrayHashChecker";
            resources.ApplyResources(this.tsmiTrayHashChecker, "tsmiTrayHashChecker");
            this.tsmiTrayHashChecker.Click += new System.EventHandler(this.tsmiHashChecker_Click);
            //
            // tsmiTrayIndexFolder
            //
            this.tsmiTrayIndexFolder.Image = global::ShareNot.Properties.Resources.folder_tree;
            this.tsmiTrayIndexFolder.Name = "tsmiTrayIndexFolder";
            resources.ApplyResources(this.tsmiTrayIndexFolder, "tsmiTrayIndexFolder");
            this.tsmiTrayIndexFolder.Click += new System.EventHandler(this.tsmiIndexFolder_Click);
            //
            // tssTrayTools4
            //
            this.tssTrayTools4.Name = "tssTrayTools4";
            resources.ApplyResources(this.tssTrayTools4, "tssTrayTools4");
            //
            // tsmiTrayClipboardViewer
            //
            this.tsmiTrayClipboardViewer.Image = global::ShareNot.Properties.Resources.clipboard_block;
            this.tsmiTrayClipboardViewer.Name = "tsmiTrayClipboardViewer";
            resources.ApplyResources(this.tsmiTrayClipboardViewer, "tsmiTrayClipboardViewer");
            this.tsmiTrayClipboardViewer.Click += new System.EventHandler(this.tsmiClipboardViewer_Click);
            //
            // tsmiTrayBorderlessWindow
            //
            this.tsmiTrayBorderlessWindow.Image = global::ShareNot.Properties.Resources.application_resize_full;
            this.tsmiTrayBorderlessWindow.Name = "tsmiTrayBorderlessWindow";
            resources.ApplyResources(this.tsmiTrayBorderlessWindow, "tsmiTrayBorderlessWindow");
            this.tsmiTrayBorderlessWindow.Click += new System.EventHandler(this.tsmiBorderlessWindow_Click);
            //
            // tsmiTrayInspectWindow
            //
            this.tsmiTrayInspectWindow.Image = global::ShareNot.Properties.Resources.application_search_result;
            this.tsmiTrayInspectWindow.Name = "tsmiTrayInspectWindow";
            resources.ApplyResources(this.tsmiTrayInspectWindow, "tsmiTrayInspectWindow");
            this.tsmiTrayInspectWindow.Click += new System.EventHandler(this.tsmiInspectWindow_Click);
            //
            // tsmiTrayMonitorTest
            //
            this.tsmiTrayMonitorTest.Image = global::ShareNot.Properties.Resources.monitor;
            this.tsmiTrayMonitorTest.Name = "tsmiTrayMonitorTest";
            resources.ApplyResources(this.tsmiTrayMonitorTest, "tsmiTrayMonitorTest");
            this.tsmiTrayMonitorTest.Click += new System.EventHandler(this.tsmiMonitorTest_Click);
            //
            // tsmiTrayDNSChanger
            //
            this.tsmiTrayDNSChanger.Image = global::ShareNot.Properties.Resources.network_ip;
            this.tsmiTrayDNSChanger.Name = "tsmiTrayDNSChanger";
            resources.ApplyResources(this.tsmiTrayDNSChanger, "tsmiTrayDNSChanger");
            this.tsmiTrayDNSChanger.Click += new System.EventHandler(this.tsmiDNSChanger_Click);
            //
            // tssTray1
            //
            this.tssTray1.Name = "tssTray1";
            resources.ApplyResources(this.tssTray1, "tssTray1");
            //
            // tsmiTrayAfterCaptureTasks
            //
            this.tsmiTrayAfterCaptureTasks.Image = global::ShareNot.Properties.Resources.image_export;
            this.tsmiTrayAfterCaptureTasks.Name = "tsmiTrayAfterCaptureTasks";
            resources.ApplyResources(this.tsmiTrayAfterCaptureTasks, "tsmiTrayAfterCaptureTasks");
            //
            // tsmiTrayApplicationSettings
            //
            this.tsmiTrayApplicationSettings.Image = global::ShareNot.Properties.Resources.wrench_screwdriver;
            this.tsmiTrayApplicationSettings.Name = "tsmiTrayApplicationSettings";
            resources.ApplyResources(this.tsmiTrayApplicationSettings, "tsmiTrayApplicationSettings");
            this.tsmiTrayApplicationSettings.Click += new System.EventHandler(this.tsbApplicationSettings_Click);
            //
            // tsmiTrayTaskSettings
            //
            this.tsmiTrayTaskSettings.Image = global::ShareNot.Properties.Resources.gear;
            this.tsmiTrayTaskSettings.Name = "tsmiTrayTaskSettings";
            resources.ApplyResources(this.tsmiTrayTaskSettings, "tsmiTrayTaskSettings");
            this.tsmiTrayTaskSettings.Click += new System.EventHandler(this.tsbTaskSettings_Click);
            //
            // tsmiTrayHotkeySettings
            //
            this.tsmiTrayHotkeySettings.Image = global::ShareNot.Properties.Resources.keyboard;
            this.tsmiTrayHotkeySettings.Name = "tsmiTrayHotkeySettings";
            resources.ApplyResources(this.tsmiTrayHotkeySettings, "tsmiTrayHotkeySettings");
            this.tsmiTrayHotkeySettings.Click += new System.EventHandler(this.tsbHotkeySettings_Click);
            //
            // tsmiTrayToggleHotkeys
            //
            this.tsmiTrayToggleHotkeys.Image = global::ShareNot.Properties.Resources.keyboard__minus;
            this.tsmiTrayToggleHotkeys.Name = "tsmiTrayToggleHotkeys";
            resources.ApplyResources(this.tsmiTrayToggleHotkeys, "tsmiTrayToggleHotkeys");
            this.tsmiTrayToggleHotkeys.Click += new System.EventHandler(this.tsmiTrayToggleHotkeys_Click);
            //
            // tssTray2
            //
            this.tssTray2.Name = "tssTray2";
            resources.ApplyResources(this.tssTray2, "tssTray2");
            //
            // tsmiScreenshotsFolder
            //
            this.tsmiScreenshotsFolder.Image = global::ShareNot.Properties.Resources.folder_open_image;
            this.tsmiScreenshotsFolder.Name = "tsmiScreenshotsFolder";
            resources.ApplyResources(this.tsmiScreenshotsFolder, "tsmiScreenshotsFolder");
            this.tsmiScreenshotsFolder.Click += new System.EventHandler(this.tsbScreenshotsFolder_Click);
            //
            // tsmiTrayHistory
            //
            this.tsmiTrayHistory.Image = global::ShareNot.Properties.Resources.application_blog;
            this.tsmiTrayHistory.Name = "tsmiTrayHistory";
            resources.ApplyResources(this.tsmiTrayHistory, "tsmiTrayHistory");
            this.tsmiTrayHistory.Click += new System.EventHandler(this.tsbHistory_Click);
            //
            // tsmiTrayImageHistory
            //
            this.tsmiTrayImageHistory.Image = global::ShareNot.Properties.Resources.application_icon_large;
            this.tsmiTrayImageHistory.Name = "tsmiTrayImageHistory";
            resources.ApplyResources(this.tsmiTrayImageHistory, "tsmiTrayImageHistory");
            this.tsmiTrayImageHistory.Click += new System.EventHandler(this.tsbImageHistory_Click);
            //
            // tssTray3
            //
            this.tssTray3.Name = "tssTray3";
            resources.ApplyResources(this.tssTray3, "tssTray3");
            //
            // tsmiRestartAsAdmin
            //
            this.tsmiRestartAsAdmin.Image = global::ShareNot.Properties.Resources.uac;
            this.tsmiRestartAsAdmin.Name = "tsmiRestartAsAdmin";
            resources.ApplyResources(this.tsmiRestartAsAdmin, "tsmiRestartAsAdmin");
            this.tsmiRestartAsAdmin.Click += new System.EventHandler(this.tsmiRestartAsAdmin_Click);
            //
            // tsmiTrayRecentItems
            //
            this.tsmiTrayRecentItems.Image = global::ShareNot.Properties.Resources.clipboard_list;
            this.tsmiTrayRecentItems.Name = "tsmiTrayRecentItems";
            resources.ApplyResources(this.tsmiTrayRecentItems, "tsmiTrayRecentItems");
            //
            // tsmiOpenActionsToolbar
            //
            this.tsmiOpenActionsToolbar.Image = global::ShareNot.Properties.Resources.ui_toolbar__arrow;
            this.tsmiOpenActionsToolbar.Name = "tsmiOpenActionsToolbar";
            resources.ApplyResources(this.tsmiOpenActionsToolbar, "tsmiOpenActionsToolbar");
            this.tsmiOpenActionsToolbar.Click += new System.EventHandler(this.tsmiOpenActionsToolbar_Click);
            //
            // tsmiTrayShow
            //
            this.tsmiTrayShow.Image = global::ShareNot.Properties.Resources.tick_button;
            this.tsmiTrayShow.Name = "tsmiTrayShow";
            resources.ApplyResources(this.tsmiTrayShow, "tsmiTrayShow");
            this.tsmiTrayShow.Click += new System.EventHandler(this.tsmiTrayShow_Click);
            //
            // tsmiTrayExit
            //
            this.tsmiTrayExit.Image = global::ShareNot.Properties.Resources.cross_button;
            this.tsmiTrayExit.Name = "tsmiTrayExit";
            resources.ApplyResources(this.tsmiTrayExit, "tsmiTrayExit");
            this.tsmiTrayExit.Click += new System.EventHandler(this.tsmiTrayExit_Click);
            this.tsmiTrayExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsmiTrayExit_MouseDown);
            //
            // timerTraySingleClick
            //
            this.timerTraySingleClick.Tick += new System.EventHandler(this.timerTraySingleClick_Tick);
            //
            // ucTaskThumbnailView
            //
            resources.ApplyResources(this.ucTaskThumbnailView, "ucTaskThumbnailView");
            this.ucTaskThumbnailView.BackColor = System.Drawing.SystemColors.Window;
            this.ucTaskThumbnailView.ClickAction = ThumbnailViewClickAction.Default;
            this.ucTaskThumbnailView.Name = "ucTaskThumbnailView";
            this.ucTaskThumbnailView.ThumbnailSize = new System.Drawing.Size(200, 150);
            this.ucTaskThumbnailView.TitleLocation = ThumbnailTitleLocation.Top;
            this.ucTaskThumbnailView.TitleVisible = true;
            this.ucTaskThumbnailView.ContextMenuRequested += new TaskThumbnailView.TaskViewMouseEventHandler(this.UcTaskView_ContextMenuRequested);
            this.ucTaskThumbnailView.SelectedPanelChanged += new System.EventHandler(this.ucTaskThumbnailView_SelectedPanelChanged);
            this.ucTaskThumbnailView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvUploads_KeyDown);
            //
            // ttMain
            //
            this.ttMain.AutoPopDelay = 5000;
            this.ttMain.InitialDelay = 200;
            this.ttMain.OwnerDraw = true;
            this.ttMain.ReshowDelay = 100;
            this.ttMain.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.TtMain_Draw);
            //
            // pToolbars
            //
            resources.ApplyResources(this.pToolbars, "pToolbars");
            this.pToolbars.Controls.Add(this.tsMain);
            this.pToolbars.Name = "pToolbars";
            //
            // dgvHotkeys
            //
            this.dgvHotkeys.AllowUserToAddRows = false;
            this.dgvHotkeys.AllowUserToDeleteRows = false;
            this.dgvHotkeys.AllowUserToResizeColumns = false;
            this.dgvHotkeys.AllowUserToResizeRows = false;
            this.dgvHotkeys.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHotkeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHotkeys.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHotkeys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHotkeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotkeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cHotkeyStatus,
            this.cHotkey,
            this.cDescription});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHotkeys.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.dgvHotkeys, "dgvHotkeys");
            this.dgvHotkeys.MultiSelect = false;
            this.dgvHotkeys.Name = "dgvHotkeys";
            this.dgvHotkeys.ReadOnly = true;
            this.dgvHotkeys.RowHeadersVisible = false;
            this.dgvHotkeys.TabStop = false;
            this.dgvHotkeys.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvHotkeys_MouseDoubleClick);
            this.dgvHotkeys.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvHotkeys_MouseUp);
            //
            // cHotkeyStatus
            //
            resources.ApplyResources(this.cHotkeyStatus, "cHotkeyStatus");
            this.cHotkeyStatus.Name = "cHotkeyStatus";
            this.cHotkeyStatus.ReadOnly = true;
            //
            // cHotkey
            //
            this.cHotkey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cHotkey.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.cHotkey, "cHotkey");
            this.cHotkey.Name = "cHotkey";
            this.cHotkey.ReadOnly = true;
            this.cHotkey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // cDescription
            //
            this.cDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.cDescription, "cDescription");
            this.cDescription.Name = "cDescription";
            this.cDescription.ReadOnly = true;
            this.cDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // pMain
            //
            this.pMain.Controls.Add(this.pHotkeys);
            this.pMain.Controls.Add(this.ucTaskThumbnailView);
            this.pMain.Controls.Add(this.scMain);
            resources.ApplyResources(this.pMain, "pMain");
            this.pMain.Name = "pMain";
            //
            // pHotkeys
            //
            this.pHotkeys.Controls.Add(this.dgvHotkeys);
            resources.ApplyResources(this.pHotkeys, "pHotkeys");
            this.pHotkeys.Name = "pHotkeys";
            //
            // MainForm
            //
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pToolbars);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.cmsTaskInfo.ResumeLayout(false);
            this.cmsTray.ResumeLayout(false);
            this.pToolbars.ResumeLayout(false);
            this.pToolbars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotkeys)).EndInit();
            this.pMain.ResumeLayout(false);
            this.pHotkeys.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion Windows Form Designer generated code
        private System.Windows.Forms.ColumnHeader chURL;
        private System.Windows.Forms.ColumnHeader chFilename;
        private ToolStripBorderRight tsMain;
        private System.Windows.Forms.ToolStripSeparator tssMain1;
        private System.Windows.Forms.ToolStripButton tsbHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayExit;
        private System.Windows.Forms.ToolStripSeparator tssTray1;
        public System.Windows.Forms.NotifyIcon niTray;
        private System.Windows.Forms.ToolStripDropDownButton tsddbCapture;
        private System.Windows.Forms.ToolStripMenuItem tsmiFullscreen;
        private System.Windows.Forms.ToolStripMenuItem tsmiRectangle;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayHistory;
        private System.Windows.Forms.ToolStripSeparator tssTray2;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayCapture;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayFullscreen;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayRectangle;
        private System.Windows.Forms.ToolStripMenuItem tsmiLastRegion;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayLastRegion;
        private SplitContainerCustomSplitter scMain;
        private System.Windows.Forms.ContextMenuStrip cmsTaskInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator tssOpen1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripSeparator tssCopy1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyText;
        private System.Windows.Forms.ToolStripSeparator tssCopy2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyFilePath;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyFileName;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyFileNameWithExtension;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyFolder;
        private System.Windows.Forms.ToolStripMenuItem tsmiStopUpload;
        private MyPictureBox pbPreview;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowErrors;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenshotsFolder;
        private System.Windows.Forms.ToolStripDropDownButton tsddbAfterCaptureTasks;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayAfterCaptureTasks;
        private System.Windows.Forms.ToolStripButton tsbScreenshotsFolder;
        private System.Windows.Forms.ToolStripSeparator tssUploadInfo1;
        private System.Windows.Forms.ToolStripButton tsbImageHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayImageHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayColorPicker;
        private System.Windows.Forms.ToolStripDropDownButton tsddbTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiColorPicker;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearList;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenRecordingGIF;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScreenRecordingGIF;
        private System.Windows.Forms.ToolStripMenuItem tsmiHashChecker;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayHashChecker;
        private System.Windows.Forms.ToolStripMenuItem tsmiMonitor;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayMonitor;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoCapture;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayAutoCapture;
        private System.Windows.Forms.ToolStripDropDownButton tsddbDebug;
        private System.Windows.Forms.ToolStripMenuItem tsmiTestImageUpload;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDebugLog;
        private System.Windows.Forms.ToolStripButton tsbApplicationSettings;
        private System.Windows.Forms.ToolStripButton tsbTaskSettings;
        private System.Windows.Forms.ToolStripButton tsbHotkeySettings;
        private System.Windows.Forms.ToolStripSeparator tssMain2;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayApplicationSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayTaskSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayHotkeySettings;
        private System.Windows.Forms.ToolStripSeparator tssTray3;
        private System.Windows.Forms.ToolStripMenuItem tsmiIndexFolder;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayIndexFolder;
        private System.Windows.Forms.ToolStripMenuItem tsmiImageEffects;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayImageEffects;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiMonitorTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayMonitorTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiDNSChanger;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayDNSChanger;
        private System.Windows.Forms.ToolStripMenuItem tsmiRuler;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayRuler;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenThumbnailFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyThumbnailFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyThumbnailImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiImageEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayImageEditor;
        private System.Windows.Forms.ToolStripDropDownButton tsddbWorkflows;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayWorkflows;
        private System.Windows.Forms.ToolStripMenuItem tsmiQRCode;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayQRCode;
        private System.Windows.Forms.ToolStripMenuItem tsmiRectangleLight;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayRectangleLight;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditSelectedFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSelectedFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenRecordingFFmpeg;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScreenRecordingFFmpeg;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenColorPicker;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScreenColorPicker;
        public System.Windows.Forms.ToolStripMenuItem tsmiTrayRecentItems;
        private System.Windows.Forms.ContextMenuStrip cmsTray;
        private System.Windows.Forms.ToolStripMenuItem tsmiRectangleTransparent;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayRectangleTransparent;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayToggleHotkeys;
        private System.Windows.Forms.ToolStripMenuItem tsmiVideoThumbnailer;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayVideoThumbnailer;
        private System.Windows.Forms.Timer timerTraySingleClick;
        private System.Windows.Forms.ToolStripMenuItem tsmiScrollingCapture;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScrollingCapture;
        private System.Windows.Forms.ToolStripMenuItem tsmiImageCombiner;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayImageCombiner;
        private System.Windows.Forms.ToolStripMenuItem tsmiOCRImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiCombineImages;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenActionsToolbar;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSelectedItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiImageThumbnailer;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayImageThumbnailer;
        private System.Windows.Forms.ToolStripSeparator tssCopy6;
        private System.Windows.Forms.ToolStripSeparator tssCapture1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowCursor;
        private System.Windows.Forms.ToolStripSeparator tssTrayCapture1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayShowCursor;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyImageDimensions;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenshotDelay;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenshotDelay0;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenshotDelay1;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenshotDelay2;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenshotDelay3;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenshotDelay4;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenshotDelay5;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScreenshotDelay;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScreenshotDelay0;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScreenshotDelay1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScreenshotDelay2;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScreenshotDelay3;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScreenshotDelay4;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayScreenshotDelay5;
        private TaskThumbnailView ucTaskThumbnailView;
        private System.Windows.Forms.ToolStripMenuItem tsmiSwitchTaskViewMode;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiRunAction;
        private System.Windows.Forms.Panel pToolbars;
        private System.Windows.Forms.ToolStripMenuItem tsmiImageSplitter;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayImageSplitter;
        private System.Windows.Forms.ToolStripMenuItem tsmiVideoConverter;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayVideoConverter;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddImageEffects;
        private System.Windows.Forms.ToolStripMenuItem tsmiClipboardViewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayClipboardViewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestartAsAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiInspectWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayInspectWindow;
        private System.Windows.Forms.ToolStripSeparator tssTools1;
        private System.Windows.Forms.ToolStripSeparator tssTools2;
        private System.Windows.Forms.ToolStripSeparator tssTools3;
        private System.Windows.Forms.ToolStripSeparator tssTools4;
        private System.Windows.Forms.ToolStripSeparator tssTrayTools1;
        private System.Windows.Forms.ToolStripSeparator tssTrayTools2;
        private System.Windows.Forms.ToolStripSeparator tssTrayTools3;
        private System.Windows.Forms.ToolStripSeparator tssTrayTools4;
        private System.Windows.Forms.ToolStripMenuItem tsmiCombineImagesHorizontally;
        private System.Windows.Forms.ToolStripMenuItem tsmiCombineImagesVertically;
        private System.Windows.Forms.ToolStripButton tsbDiscord;
        private System.Windows.Forms.ToolStripSeparator tssMain3;
        private System.Windows.Forms.ToolStripButton tsbDonate;
        private System.Windows.Forms.ToolStripMenuItem tsmiBorderlessWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayBorderlessWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiImageViewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayImageViewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiOCR;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayOCR;
        private System.Windows.Forms.ToolStripMenuItem tsmiPinSelectedFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiPinToScreen;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayPinToScreen;
        private System.Windows.Forms.ToolStripMenuItem tsmiImageBeautifier;
        private System.Windows.Forms.ToolStripMenuItem tsmiTrayImageBeautifier;
        private System.Windows.Forms.ToolStripMenuItem tsmiBeautifyImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHotkeyStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHotkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.DataGridView dgvHotkeys;
        internal System.Windows.Forms.Panel pHotkeys;
        private MyListView lvUploads;
    }
}