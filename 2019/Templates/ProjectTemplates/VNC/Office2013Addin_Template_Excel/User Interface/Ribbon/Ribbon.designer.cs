﻿namespace $safeprojectname$
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpSupportTools = this.Factory.CreateRibbonGroup();
            this.tabSupportTools = this.Factory.CreateRibbonTab();
            this.grpTaskPanes = this.Factory.CreateRibbonGroup();
            this.btnAppUtilities = this.Factory.CreateRibbonButton();
            this.btnSharePoint = this.Factory.CreateRibbonButton();
            this.btnTFS = this.Factory.CreateRibbonButton();
            this.btnLogParser = this.Factory.CreateRibbonButton();
            this.btnNetworkTraces = this.Factory.CreateRibbonButton();
            this.btnMTreaty = this.Factory.CreateRibbonButton();
            this.btnLTC = this.Factory.CreateRibbonButton();
            this.btnSQLSMO = this.Factory.CreateRibbonButton();
            this.btnActiveDirectory = this.Factory.CreateRibbonButton();
            this.btnRally = this.Factory.CreateRibbonButton();
            this.btnSalesforce = this.Factory.CreateRibbonButton();
            this.grpDebug = this.Factory.CreateRibbonGroup();
            this.chkEnableAppEvents = this.Factory.CreateRibbonCheckBox();
            this.chkDisplayEvents = this.Factory.CreateRibbonCheckBox();
            this.chkScreenUpdates = this.Factory.CreateRibbonCheckBox();
            this.grpHelp = this.Factory.CreateRibbonGroup();
            this.btnAddInInfo = this.Factory.CreateRibbonButton();
            this.btnDeveloperMode = this.Factory.CreateRibbonButton();
            this.btnDebugWindow = this.Factory.CreateRibbonButton();
            this.btnWatchWindow = this.Factory.CreateRibbonButton();
            this.btnExaVault = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.tabSupportTools.SuspendLayout();
            this.grpTaskPanes.SuspendLayout();
            this.grpDebug.SuspendLayout();
            this.grpHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.grpSupportTools);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // grpSupportTools
            // 
            this.grpSupportTools.Label = "Support Tools";
            this.grpSupportTools.Name = "grpSupportTools";
            // 
            // tabSupportTools
            // 
            this.tabSupportTools.Groups.Add(this.grpTaskPanes);
            this.tabSupportTools.Groups.Add(this.grpDebug);
            this.tabSupportTools.Groups.Add(this.grpHelp);
            this.tabSupportTools.Label = "Support Tools";
            this.tabSupportTools.Name = "tabSupportTools";
            // 
            // grpTaskPanes
            // 
            this.grpTaskPanes.Items.Add(this.btnAppUtilities);
            this.grpTaskPanes.Items.Add(this.btnSharePoint);
            this.grpTaskPanes.Items.Add(this.btnTFS);
            this.grpTaskPanes.Items.Add(this.btnLogParser);
            this.grpTaskPanes.Items.Add(this.btnNetworkTraces);
            this.grpTaskPanes.Items.Add(this.btnMTreaty);
            this.grpTaskPanes.Items.Add(this.btnLTC);
            this.grpTaskPanes.Items.Add(this.btnSQLSMO);
            this.grpTaskPanes.Items.Add(this.btnActiveDirectory);
            this.grpTaskPanes.Items.Add(this.btnExaVault);
            this.grpTaskPanes.Items.Add(this.btnRally);
            this.grpTaskPanes.Items.Add(this.btnSalesforce);
            this.grpTaskPanes.Label = "Task Panes";
            this.grpTaskPanes.Name = "grpTaskPanes";
            // 
            // btnAppUtilities
            // 
            this.btnAppUtilities.Label = "Excel Utilities";
            this.btnAppUtilities.Name = "btnAppUtilities";
            this.btnAppUtilities.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAppUtilities_Click);
            // 
            // btnSharePoint
            // 
            this.btnSharePoint.Label = "SharePoint";
            this.btnSharePoint.Name = "btnSharePoint";
            this.btnSharePoint.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSharePoint_Click);
            // 
            // btnTFS
            // 
            this.btnTFS.Label = "TFS";
            this.btnTFS.Name = "btnTFS";
            this.btnTFS.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnTFS_Click);
            // 
            // btnLogParser
            // 
            this.btnLogParser.Label = "Log Parser";
            this.btnLogParser.Name = "btnLogParser";
            this.btnLogParser.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLogParser_Click);
            // 
            // btnNetworkTraces
            // 
            this.btnNetworkTraces.Label = "Network Traces";
            this.btnNetworkTraces.Name = "btnNetworkTraces";
            this.btnNetworkTraces.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnNetworkTraces_Click);
            // 
            // btnMTreaty
            // 
            this.btnMTreaty.Label = "MTreaty";
            this.btnMTreaty.Name = "btnMTreaty";
            this.btnMTreaty.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMTreaty_Click);
            // 
            // btnLTC
            // 
            this.btnLTC.Label = "LTC";
            this.btnLTC.Name = "btnLTC";
            this.btnLTC.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLTC_Click);
            // 
            // btnSQLSMO
            // 
            this.btnSQLSMO.Label = "SQLSMO";
            this.btnSQLSMO.Name = "btnSQLSMO";
            this.btnSQLSMO.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSQLSMO_Click);
            // 
            // btnActiveDirectory
            // 
            this.btnActiveDirectory.Label = "Active Directory";
            this.btnActiveDirectory.Name = "btnActiveDirectory";
            this.btnActiveDirectory.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnActiveDirectory_Click);
            // 
            // btnRally
            // 
            this.btnRally.Label = "Rally";
            this.btnRally.Name = "btnRally";
            this.btnRally.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnRally_Click);
            // 
            // btnSalesforce
            // 
            this.btnSalesforce.Label = "Salesforce";
            this.btnSalesforce.Name = "btnSalesforce";
            this.btnSalesforce.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSalesforce_Click);
            // 
            // grpDebug
            // 
            this.grpDebug.Items.Add(this.btnDebugWindow);
            this.grpDebug.Items.Add(this.btnWatchWindow);
            this.grpDebug.Items.Add(this.chkEnableAppEvents);
            this.grpDebug.Items.Add(this.chkDisplayEvents);
            this.grpDebug.Items.Add(this.chkScreenUpdates);
            this.grpDebug.Label = "Debug";
            this.grpDebug.Name = "grpDebug";
            this.grpDebug.Visible = false;
            // 
            // chkEnableAppEvents
            // 
            this.chkEnableAppEvents.Checked = true;
            this.chkEnableAppEvents.Label = "Enable App Events";
            this.chkEnableAppEvents.Name = "chkEnableAppEvents";
            this.chkEnableAppEvents.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.chkEnableAppEvents_Click);
            // 
            // chkDisplayEvents
            // 
            this.chkDisplayEvents.Label = "Display Events";
            this.chkDisplayEvents.Name = "chkDisplayEvents";
            this.chkDisplayEvents.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.chkDisplayEvents_Click);
            // 
            // chkScreenUpdates
            // 
            this.chkScreenUpdates.Label = "Display Screen Updates";
            this.chkScreenUpdates.Name = "chkScreenUpdates";
            this.chkScreenUpdates.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.chkScreenUpdates_Click);
            // 
            // grpHelp
            // 
            this.grpHelp.Items.Add(this.btnAddInInfo);
            this.grpHelp.Items.Add(this.btnDeveloperMode);
            this.grpHelp.Label = "Help";
            this.grpHelp.Name = "grpHelp";
            // 
            // btnAddInInfo
            // 
            this.btnAddInInfo.Label = "AddIn Info";
            this.btnAddInInfo.Name = "btnAddInInfo";
            this.btnAddInInfo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddInInfo_Click);
            // 
            // btnDeveloperMode
            // 
            this.btnDeveloperMode.Label = "Developer Mode";
            this.btnDeveloperMode.Name = "btnDeveloperMode";
            this.btnDeveloperMode.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnDeveloperMode_Click);
            // 
            // btnDebugWindow
            // 
            this.btnDebugWindow.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnDebugWindow.Image = global::$safeprojectname$.Properties.Resources.Auto_Debug_System_icon;
            this.btnDebugWindow.Label = "Debug Window";
            this.btnDebugWindow.Name = "btnDebugWindow";
            this.btnDebugWindow.ShowImage = true;
            this.btnDebugWindow.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnDebugWindow_Click);
            // 
            // btnWatchWindow
            // 
            this.btnWatchWindow.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnWatchWindow.Image = global::$safeprojectname$.Properties.Resources.WatchWindow;
            this.btnWatchWindow.Label = "Watch Window";
            this.btnWatchWindow.Name = "btnWatchWindow";
            this.btnWatchWindow.ShowImage = true;
            this.btnWatchWindow.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnWatchWindow_Click);
            // 
            // btnExaVault
            // 
            this.btnExaVault.Label = "ExaVault";
            this.btnExaVault.Name = "btnExaVault";
            this.btnExaVault.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnExaVault_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tabSupportTools);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabSupportTools.ResumeLayout(false);
            this.tabSupportTools.PerformLayout();
            this.grpTaskPanes.ResumeLayout(false);
            this.grpTaskPanes.PerformLayout();
            this.grpDebug.ResumeLayout(false);
            this.grpDebug.PerformLayout();
            this.grpHelp.ResumeLayout(false);
            this.grpHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpSupportTools;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tabSupportTools;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpTaskPanes;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpDebug;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDebugWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnWatchWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox chkEnableAppEvents;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox chkDisplayEvents;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpHelp;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddInInfo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDeveloperMode;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAppUtilities;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnNetworkTraces;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSharePoint;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLogParser;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox chkScreenUpdates;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTFS;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMTreaty;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLTC;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSQLSMO;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnActiveDirectory;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnRally;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSalesforce;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnExaVault;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get
            {
                return this.GetRibbon<Ribbon>();
            }
        }
    }
}
