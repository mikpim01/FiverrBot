﻿namespace FiverrBot
{
    partial class Form1
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
            this.txtAddUsername = new System.Windows.Forms.TextBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAccountsLoaded = new System.Windows.Forms.Label();
            this.lblProxiesLoaded = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveAllProxies = new System.Windows.Forms.Button();
            this.btnRemoveAllAccounts = new System.Windows.Forms.Button();
            this.btnRemoveSelectedAccounts = new System.Windows.Forms.Button();
            this.chklstAccounts = new System.Windows.Forms.CheckedListBox();
            this.grpImExAccounts = new System.Windows.Forms.GroupBox();
            this.btnExportProxies = new System.Windows.Forms.Button();
            this.btnLoadProxies = new System.Windows.Forms.Button();
            this.btnExportAccounts = new System.Windows.Forms.Button();
            this.btnLoadAccounts = new System.Windows.Forms.Button();
            this.grpAddAccount = new System.Windows.Forms.GroupBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtAddProxyPassword = new System.Windows.Forms.TextBox();
            this.txtAddProxyUsername = new System.Windows.Forms.TextBox();
            this.txtAddPort = new System.Windows.Forms.TextBox();
            this.txtAddProxy = new System.Windows.Forms.TextBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpCheckerOverview = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExportActive = new System.Windows.Forms.Button();
            this.lblCheckerThreadsRunning = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDisabledAccounts = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblActiveAccounts = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpAccountChecker = new System.Windows.Forms.GroupBox();
            this.btnStopChecking = new System.Windows.Forms.Button();
            this.btnStartChecking = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboCheckingMode = new System.Windows.Forms.ComboBox();
            this.cmboAccountsToCheck = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabAccountCreator = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAccountsVerrified = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnExportUserPass = new System.Windows.Forms.Button();
            this.btnExportCreated = new System.Windows.Forms.Button();
            this.btnExportUnusedEmails = new System.Windows.Forms.Button();
            this.btnExportUnusedUsernames = new System.Windows.Forms.Button();
            this.lblCreatorThreadsRunning = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblAccountsCreated = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStopCreating = new System.Windows.Forms.Button();
            this.btnCreateAccounts = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCreateDelay = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkRotateProxyUponFailure = new System.Windows.Forms.CheckBox();
            this.chkRotateEmailUponFailure = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmails = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUsernames = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabUsernameGenerator = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblAccountsGenerated = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnExportToCreator = new System.Windows.Forms.Button();
            this.txtProxyReuses = new System.Windows.Forms.TextBox();
            this.btnTieProxies = new System.Windows.Forms.Button();
            this.btnGenerateUsernames = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtGeneratedUsernames = new System.Windows.Forms.TextBox();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.chkDisplayLogMessages = new System.Windows.Forms.CheckBox();
            this.lblThreadsRunning = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpImExAccounts.SuspendLayout();
            this.grpAddAccount.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpCheckerOverview.SuspendLayout();
            this.grpAccountChecker.SuspendLayout();
            this.tabAccountCreator.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabUsernameGenerator.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddUsername.Location = new System.Drawing.Point(6, 21);
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(143, 22);
            this.txtAddUsername.TabIndex = 6;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabAccountCreator);
            this.tabs.Controls.Add(this.tabUsernameGenerator);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Location = new System.Drawing.Point(12, 43);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(875, 275);
            this.tabs.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpImExAccounts);
            this.tabPage1.Controls.Add(this.grpAddAccount);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accounts";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAccountsLoaded);
            this.groupBox1.Controls.Add(this.lblProxiesLoaded);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRemoveAllProxies);
            this.groupBox1.Controls.Add(this.btnRemoveAllAccounts);
            this.groupBox1.Controls.Add(this.btnRemoveSelectedAccounts);
            this.groupBox1.Controls.Add(this.chklstAccounts);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(316, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 233);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Manager";
            // 
            // lblAccountsLoaded
            // 
            this.lblAccountsLoaded.AutoSize = true;
            this.lblAccountsLoaded.Location = new System.Drawing.Point(446, 165);
            this.lblAccountsLoaded.Name = "lblAccountsLoaded";
            this.lblAccountsLoaded.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccountsLoaded.Size = new System.Drawing.Size(16, 17);
            this.lblAccountsLoaded.TabIndex = 18;
            this.lblAccountsLoaded.Text = "0";
            // 
            // lblProxiesLoaded
            // 
            this.lblProxiesLoaded.AutoSize = true;
            this.lblProxiesLoaded.Location = new System.Drawing.Point(446, 135);
            this.lblProxiesLoaded.Name = "lblProxiesLoaded";
            this.lblProxiesLoaded.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProxiesLoaded.Size = new System.Drawing.Size(16, 17);
            this.lblProxiesLoaded.TabIndex = 17;
            this.lblProxiesLoaded.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Accounts Loaded: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proxies Loaded: ";
            // 
            // btnRemoveAllProxies
            // 
            this.btnRemoveAllProxies.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveAllProxies.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveAllProxies.Location = new System.Drawing.Point(306, 89);
            this.btnRemoveAllProxies.Name = "btnRemoveAllProxies";
            this.btnRemoveAllProxies.Size = new System.Drawing.Size(233, 28);
            this.btnRemoveAllProxies.TabIndex = 14;
            this.btnRemoveAllProxies.Text = "Remove All Proxies";
            this.btnRemoveAllProxies.UseVisualStyleBackColor = false;
            // 
            // btnRemoveAllAccounts
            // 
            this.btnRemoveAllAccounts.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveAllAccounts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveAllAccounts.Location = new System.Drawing.Point(306, 55);
            this.btnRemoveAllAccounts.Name = "btnRemoveAllAccounts";
            this.btnRemoveAllAccounts.Size = new System.Drawing.Size(233, 28);
            this.btnRemoveAllAccounts.TabIndex = 13;
            this.btnRemoveAllAccounts.Text = "Remove All Accounts";
            this.btnRemoveAllAccounts.UseVisualStyleBackColor = false;
            // 
            // btnRemoveSelectedAccounts
            // 
            this.btnRemoveSelectedAccounts.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveSelectedAccounts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveSelectedAccounts.Location = new System.Drawing.Point(306, 21);
            this.btnRemoveSelectedAccounts.Name = "btnRemoveSelectedAccounts";
            this.btnRemoveSelectedAccounts.Size = new System.Drawing.Size(233, 28);
            this.btnRemoveSelectedAccounts.TabIndex = 12;
            this.btnRemoveSelectedAccounts.Text = "Remove Selected Accounts";
            this.btnRemoveSelectedAccounts.UseVisualStyleBackColor = false;
            // 
            // chklstAccounts
            // 
            this.chklstAccounts.FormattingEnabled = true;
            this.chklstAccounts.Location = new System.Drawing.Point(7, 21);
            this.chklstAccounts.Name = "chklstAccounts";
            this.chklstAccounts.Size = new System.Drawing.Size(293, 208);
            this.chklstAccounts.TabIndex = 0;
            // 
            // grpImExAccounts
            // 
            this.grpImExAccounts.Controls.Add(this.btnExportProxies);
            this.grpImExAccounts.Controls.Add(this.btnLoadProxies);
            this.grpImExAccounts.Controls.Add(this.btnExportAccounts);
            this.grpImExAccounts.Controls.Add(this.btnLoadAccounts);
            this.grpImExAccounts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpImExAccounts.Location = new System.Drawing.Point(6, 150);
            this.grpImExAccounts.Name = "grpImExAccounts";
            this.grpImExAccounts.Size = new System.Drawing.Size(304, 89);
            this.grpImExAccounts.TabIndex = 12;
            this.grpImExAccounts.TabStop = false;
            this.grpImExAccounts.Text = "Import / Export Accounts";
            // 
            // btnExportProxies
            // 
            this.btnExportProxies.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExportProxies.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportProxies.Location = new System.Drawing.Point(155, 55);
            this.btnExportProxies.Name = "btnExportProxies";
            this.btnExportProxies.Size = new System.Drawing.Size(143, 28);
            this.btnExportProxies.TabIndex = 12;
            this.btnExportProxies.Text = "Export Proxies";
            this.btnExportProxies.UseVisualStyleBackColor = false;
            // 
            // btnLoadProxies
            // 
            this.btnLoadProxies.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoadProxies.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoadProxies.Location = new System.Drawing.Point(6, 55);
            this.btnLoadProxies.Name = "btnLoadProxies";
            this.btnLoadProxies.Size = new System.Drawing.Size(143, 28);
            this.btnLoadProxies.TabIndex = 11;
            this.btnLoadProxies.Text = "Load Proxies";
            this.btnLoadProxies.UseVisualStyleBackColor = false;
            this.btnLoadProxies.Click += new System.EventHandler(this.btnLoadProxies_Click);
            // 
            // btnExportAccounts
            // 
            this.btnExportAccounts.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExportAccounts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportAccounts.Location = new System.Drawing.Point(155, 21);
            this.btnExportAccounts.Name = "btnExportAccounts";
            this.btnExportAccounts.Size = new System.Drawing.Size(143, 28);
            this.btnExportAccounts.TabIndex = 10;
            this.btnExportAccounts.Text = "Export Accounts";
            this.btnExportAccounts.UseVisualStyleBackColor = false;
            // 
            // btnLoadAccounts
            // 
            this.btnLoadAccounts.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoadAccounts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoadAccounts.Location = new System.Drawing.Point(6, 21);
            this.btnLoadAccounts.Name = "btnLoadAccounts";
            this.btnLoadAccounts.Size = new System.Drawing.Size(143, 28);
            this.btnLoadAccounts.TabIndex = 9;
            this.btnLoadAccounts.Text = "Load Accounts";
            this.btnLoadAccounts.UseVisualStyleBackColor = false;
            this.btnLoadAccounts.Click += new System.EventHandler(this.btnLoadAccounts_Click);
            // 
            // grpAddAccount
            // 
            this.grpAddAccount.Controls.Add(this.btnAddAccount);
            this.grpAddAccount.Controls.Add(this.txtAddProxyPassword);
            this.grpAddAccount.Controls.Add(this.txtAddProxyUsername);
            this.grpAddAccount.Controls.Add(this.txtAddPort);
            this.grpAddAccount.Controls.Add(this.txtAddProxy);
            this.grpAddAccount.Controls.Add(this.txtAddPassword);
            this.grpAddAccount.Controls.Add(this.txtAddUsername);
            this.grpAddAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpAddAccount.Location = new System.Drawing.Point(6, 6);
            this.grpAddAccount.Name = "grpAddAccount";
            this.grpAddAccount.Size = new System.Drawing.Size(304, 138);
            this.grpAddAccount.TabIndex = 7;
            this.grpAddAccount.TabStop = false;
            this.grpAddAccount.Text = "Add Account";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddAccount.Location = new System.Drawing.Point(6, 105);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(292, 28);
            this.btnAddAccount.TabIndex = 8;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtAddProxyPassword
            // 
            this.txtAddProxyPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddProxyPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddProxyPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddProxyPassword.Location = new System.Drawing.Point(155, 77);
            this.txtAddProxyPassword.Name = "txtAddProxyPassword";
            this.txtAddProxyPassword.Size = new System.Drawing.Size(143, 22);
            this.txtAddProxyPassword.TabIndex = 11;
            // 
            // txtAddProxyUsername
            // 
            this.txtAddProxyUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddProxyUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddProxyUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddProxyUsername.Location = new System.Drawing.Point(6, 77);
            this.txtAddProxyUsername.Name = "txtAddProxyUsername";
            this.txtAddProxyUsername.Size = new System.Drawing.Size(143, 22);
            this.txtAddProxyUsername.TabIndex = 10;
            // 
            // txtAddPort
            // 
            this.txtAddPort.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPort.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddPort.Location = new System.Drawing.Point(155, 49);
            this.txtAddPort.Name = "txtAddPort";
            this.txtAddPort.Size = new System.Drawing.Size(143, 22);
            this.txtAddPort.TabIndex = 9;
            // 
            // txtAddProxy
            // 
            this.txtAddProxy.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddProxy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddProxy.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddProxy.Location = new System.Drawing.Point(6, 49);
            this.txtAddProxy.Name = "txtAddProxy";
            this.txtAddProxy.Size = new System.Drawing.Size(143, 22);
            this.txtAddProxy.TabIndex = 8;
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddPassword.Location = new System.Drawing.Point(155, 21);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(143, 22);
            this.txtAddPassword.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage2.Controls.Add(this.grpCheckerOverview);
            this.tabPage2.Controls.Add(this.grpAccountChecker);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(867, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Account Checker";
            // 
            // grpCheckerOverview
            // 
            this.grpCheckerOverview.Controls.Add(this.button2);
            this.grpCheckerOverview.Controls.Add(this.button1);
            this.grpCheckerOverview.Controls.Add(this.btnExportActive);
            this.grpCheckerOverview.Controls.Add(this.lblCheckerThreadsRunning);
            this.grpCheckerOverview.Controls.Add(this.label10);
            this.grpCheckerOverview.Controls.Add(this.lblDisabledAccounts);
            this.grpCheckerOverview.Controls.Add(this.label11);
            this.grpCheckerOverview.Controls.Add(this.lblActiveAccounts);
            this.grpCheckerOverview.Controls.Add(this.label9);
            this.grpCheckerOverview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpCheckerOverview.Location = new System.Drawing.Point(467, 6);
            this.grpCheckerOverview.Name = "grpCheckerOverview";
            this.grpCheckerOverview.Size = new System.Drawing.Size(394, 209);
            this.grpCheckerOverview.TabIndex = 24;
            this.grpCheckerOverview.TabStop = false;
            this.grpCheckerOverview.Text = "Overview";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(130, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 62);
            this.button2.TabIndex = 26;
            this.button2.Text = "Remove Disabled From System";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(9, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Export Disabled";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnExportActive
            // 
            this.btnExportActive.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExportActive.Enabled = false;
            this.btnExportActive.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportActive.Location = new System.Drawing.Point(9, 137);
            this.btnExportActive.Name = "btnExportActive";
            this.btnExportActive.Size = new System.Drawing.Size(115, 28);
            this.btnExportActive.TabIndex = 24;
            this.btnExportActive.Text = "Export Active";
            this.btnExportActive.UseVisualStyleBackColor = false;
            // 
            // lblCheckerThreadsRunning
            // 
            this.lblCheckerThreadsRunning.AutoSize = true;
            this.lblCheckerThreadsRunning.Location = new System.Drawing.Point(150, 108);
            this.lblCheckerThreadsRunning.Name = "lblCheckerThreadsRunning";
            this.lblCheckerThreadsRunning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCheckerThreadsRunning.Size = new System.Drawing.Size(16, 17);
            this.lblCheckerThreadsRunning.TabIndex = 23;
            this.lblCheckerThreadsRunning.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Threads Running:";
            // 
            // lblDisabledAccounts
            // 
            this.lblDisabledAccounts.AutoSize = true;
            this.lblDisabledAccounts.Location = new System.Drawing.Point(150, 70);
            this.lblDisabledAccounts.Name = "lblDisabledAccounts";
            this.lblDisabledAccounts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDisabledAccounts.Size = new System.Drawing.Size(16, 17);
            this.lblDisabledAccounts.TabIndex = 21;
            this.lblDisabledAccounts.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Disabled Accounts:";
            // 
            // lblActiveAccounts
            // 
            this.lblActiveAccounts.AutoSize = true;
            this.lblActiveAccounts.Location = new System.Drawing.Point(150, 31);
            this.lblActiveAccounts.Name = "lblActiveAccounts";
            this.lblActiveAccounts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblActiveAccounts.Size = new System.Drawing.Size(16, 17);
            this.lblActiveAccounts.TabIndex = 19;
            this.lblActiveAccounts.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Active Accounts:";
            // 
            // grpAccountChecker
            // 
            this.grpAccountChecker.Controls.Add(this.btnStopChecking);
            this.grpAccountChecker.Controls.Add(this.btnStartChecking);
            this.grpAccountChecker.Controls.Add(this.comboBox1);
            this.grpAccountChecker.Controls.Add(this.label7);
            this.grpAccountChecker.Controls.Add(this.cmboCheckingMode);
            this.grpAccountChecker.Controls.Add(this.cmboAccountsToCheck);
            this.grpAccountChecker.Controls.Add(this.label6);
            this.grpAccountChecker.Controls.Add(this.label5);
            this.grpAccountChecker.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpAccountChecker.Location = new System.Drawing.Point(6, 6);
            this.grpAccountChecker.Name = "grpAccountChecker";
            this.grpAccountChecker.Size = new System.Drawing.Size(455, 209);
            this.grpAccountChecker.TabIndex = 0;
            this.grpAccountChecker.TabStop = false;
            this.grpAccountChecker.Text = "Account Checker";
            // 
            // btnStopChecking
            // 
            this.btnStopChecking.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStopChecking.Enabled = false;
            this.btnStopChecking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStopChecking.Location = new System.Drawing.Point(333, 171);
            this.btnStopChecking.Name = "btnStopChecking";
            this.btnStopChecking.Size = new System.Drawing.Size(115, 28);
            this.btnStopChecking.TabIndex = 23;
            this.btnStopChecking.Text = "Stop Checking";
            this.btnStopChecking.UseVisualStyleBackColor = false;
            // 
            // btnStartChecking
            // 
            this.btnStartChecking.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStartChecking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartChecking.Location = new System.Drawing.Point(212, 171);
            this.btnStartChecking.Name = "btnStartChecking";
            this.btnStartChecking.Size = new System.Drawing.Size(115, 28);
            this.btnStartChecking.TabIndex = 22;
            this.btnStartChecking.Text = "Start Checking";
            this.btnStartChecking.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Threads To Run:";
            // 
            // cmboCheckingMode
            // 
            this.cmboCheckingMode.FormattingEnabled = true;
            this.cmboCheckingMode.Location = new System.Drawing.Point(146, 67);
            this.cmboCheckingMode.Name = "cmboCheckingMode";
            this.cmboCheckingMode.Size = new System.Drawing.Size(302, 24);
            this.cmboCheckingMode.TabIndex = 19;
            // 
            // cmboAccountsToCheck
            // 
            this.cmboAccountsToCheck.FormattingEnabled = true;
            this.cmboAccountsToCheck.Location = new System.Drawing.Point(146, 28);
            this.cmboAccountsToCheck.Name = "cmboAccountsToCheck";
            this.cmboAccountsToCheck.Size = new System.Drawing.Size(302, 24);
            this.cmboAccountsToCheck.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Checking Mode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Accounts To Check:";
            // 
            // tabAccountCreator
            // 
            this.tabAccountCreator.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabAccountCreator.Controls.Add(this.groupBox3);
            this.tabAccountCreator.Controls.Add(this.groupBox2);
            this.tabAccountCreator.Location = new System.Drawing.Point(4, 25);
            this.tabAccountCreator.Name = "tabAccountCreator";
            this.tabAccountCreator.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccountCreator.Size = new System.Drawing.Size(867, 246);
            this.tabAccountCreator.TabIndex = 2;
            this.tabAccountCreator.Text = "Account Creator";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAccountsVerrified);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.btnExportUserPass);
            this.groupBox3.Controls.Add(this.btnExportCreated);
            this.groupBox3.Controls.Add(this.btnExportUnusedEmails);
            this.groupBox3.Controls.Add(this.btnExportUnusedUsernames);
            this.groupBox3.Controls.Add(this.lblCreatorThreadsRunning);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.lblAccountsCreated);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(657, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 234);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Overview";
            // 
            // lblAccountsVerrified
            // 
            this.lblAccountsVerrified.AutoSize = true;
            this.lblAccountsVerrified.Location = new System.Drawing.Point(136, 50);
            this.lblAccountsVerrified.Name = "lblAccountsVerrified";
            this.lblAccountsVerrified.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccountsVerrified.Size = new System.Drawing.Size(16, 17);
            this.lblAccountsVerrified.TabIndex = 32;
            this.lblAccountsVerrified.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 17);
            this.label21.TabIndex = 31;
            this.label21.Text = "Accounts Verified:";
            // 
            // btnExportUserPass
            // 
            this.btnExportUserPass.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExportUserPass.Enabled = false;
            this.btnExportUserPass.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportUserPass.Location = new System.Drawing.Point(6, 199);
            this.btnExportUserPass.Name = "btnExportUserPass";
            this.btnExportUserPass.Size = new System.Drawing.Size(195, 28);
            this.btnExportUserPass.TabIndex = 30;
            this.btnExportUserPass.Text = "Export User:Pass Format";
            this.btnExportUserPass.UseVisualStyleBackColor = false;
            // 
            // btnExportCreated
            // 
            this.btnExportCreated.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExportCreated.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportCreated.Location = new System.Drawing.Point(6, 167);
            this.btnExportCreated.Name = "btnExportCreated";
            this.btnExportCreated.Size = new System.Drawing.Size(195, 28);
            this.btnExportCreated.TabIndex = 29;
            this.btnExportCreated.Text = "Export Created Accounts";
            this.btnExportCreated.UseVisualStyleBackColor = false;
            this.btnExportCreated.Click += new System.EventHandler(this.btnExportCreated_Click);
            // 
            // btnExportUnusedEmails
            // 
            this.btnExportUnusedEmails.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExportUnusedEmails.Enabled = false;
            this.btnExportUnusedEmails.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportUnusedEmails.Location = new System.Drawing.Point(6, 136);
            this.btnExportUnusedEmails.Name = "btnExportUnusedEmails";
            this.btnExportUnusedEmails.Size = new System.Drawing.Size(195, 28);
            this.btnExportUnusedEmails.TabIndex = 28;
            this.btnExportUnusedEmails.Text = "Export Unused Emails";
            this.btnExportUnusedEmails.UseVisualStyleBackColor = false;
            // 
            // btnExportUnusedUsernames
            // 
            this.btnExportUnusedUsernames.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExportUnusedUsernames.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportUnusedUsernames.Location = new System.Drawing.Point(6, 105);
            this.btnExportUnusedUsernames.Name = "btnExportUnusedUsernames";
            this.btnExportUnusedUsernames.Size = new System.Drawing.Size(195, 28);
            this.btnExportUnusedUsernames.TabIndex = 27;
            this.btnExportUnusedUsernames.Text = "Export Unused Usernames";
            this.btnExportUnusedUsernames.UseVisualStyleBackColor = false;
            this.btnExportUnusedUsernames.Click += new System.EventHandler(this.btnExportUnusedUsernames_Click);
            // 
            // lblCreatorThreadsRunning
            // 
            this.lblCreatorThreadsRunning.AutoSize = true;
            this.lblCreatorThreadsRunning.Location = new System.Drawing.Point(136, 85);
            this.lblCreatorThreadsRunning.Name = "lblCreatorThreadsRunning";
            this.lblCreatorThreadsRunning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCreatorThreadsRunning.Size = new System.Drawing.Size(16, 17);
            this.lblCreatorThreadsRunning.TabIndex = 26;
            this.lblCreatorThreadsRunning.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 17);
            this.label19.TabIndex = 25;
            this.label19.Text = "Threads Running:";
            // 
            // lblAccountsCreated
            // 
            this.lblAccountsCreated.AutoSize = true;
            this.lblAccountsCreated.Location = new System.Drawing.Point(136, 22);
            this.lblAccountsCreated.Name = "lblAccountsCreated";
            this.lblAccountsCreated.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccountsCreated.Size = new System.Drawing.Size(16, 17);
            this.lblAccountsCreated.TabIndex = 24;
            this.lblAccountsCreated.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Accounts Created:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStopCreating);
            this.groupBox2.Controls.Add(this.btnCreateAccounts);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtCreateDelay);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.chkRotateProxyUponFailure);
            this.groupBox2.Controls.Add(this.chkRotateEmailUponFailure);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtEmails);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtUsernames);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Settings";
            // 
            // btnStopCreating
            // 
            this.btnStopCreating.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStopCreating.Enabled = false;
            this.btnStopCreating.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStopCreating.Location = new System.Drawing.Point(376, 190);
            this.btnStopCreating.Name = "btnStopCreating";
            this.btnStopCreating.Size = new System.Drawing.Size(115, 28);
            this.btnStopCreating.TabIndex = 26;
            this.btnStopCreating.Text = "Stop Creating";
            this.btnStopCreating.UseVisualStyleBackColor = false;
            // 
            // btnCreateAccounts
            // 
            this.btnCreateAccounts.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCreateAccounts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateAccounts.Location = new System.Drawing.Point(255, 190);
            this.btnCreateAccounts.Name = "btnCreateAccounts";
            this.btnCreateAccounts.Size = new System.Drawing.Size(115, 28);
            this.btnCreateAccounts.TabIndex = 25;
            this.btnCreateAccounts.Text = "Start Creating";
            this.btnCreateAccounts.UseVisualStyleBackColor = false;
            this.btnCreateAccounts.Click += new System.EventHandler(this.btnCreateAccounts_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(386, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 24);
            this.comboBox2.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(487, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 22);
            this.textBox2.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(573, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "Seconds";
            // 
            // txtCreateDelay
            // 
            this.txtCreateDelay.Enabled = false;
            this.txtCreateDelay.Location = new System.Drawing.Point(487, 17);
            this.txtCreateDelay.Name = "txtCreateDelay";
            this.txtCreateDelay.Size = new System.Drawing.Size(78, 22);
            this.txtCreateDelay.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Threads To Run:";
            // 
            // chkRotateProxyUponFailure
            // 
            this.chkRotateProxyUponFailure.AutoSize = true;
            this.chkRotateProxyUponFailure.Enabled = false;
            this.chkRotateProxyUponFailure.Location = new System.Drawing.Point(255, 90);
            this.chkRotateProxyUponFailure.Name = "chkRotateProxyUponFailure";
            this.chkRotateProxyUponFailure.Size = new System.Drawing.Size(196, 21);
            this.chkRotateProxyUponFailure.TabIndex = 7;
            this.chkRotateProxyUponFailure.Text = "Rotate Proxy Upon Failure";
            this.chkRotateProxyUponFailure.UseVisualStyleBackColor = true;
            // 
            // chkRotateEmailUponFailure
            // 
            this.chkRotateEmailUponFailure.AutoSize = true;
            this.chkRotateEmailUponFailure.Enabled = false;
            this.chkRotateEmailUponFailure.Location = new System.Drawing.Point(255, 63);
            this.chkRotateEmailUponFailure.Name = "chkRotateEmailUponFailure";
            this.chkRotateEmailUponFailure.Size = new System.Drawing.Size(195, 21);
            this.chkRotateEmailUponFailure.TabIndex = 6;
            this.chkRotateEmailUponFailure.Text = "Rotate Email Upon Failure";
            this.chkRotateEmailUponFailure.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Max Accounts To Create: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(252, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Delay Between Creating Accounts: ";
            // 
            // txtEmails
            // 
            this.txtEmails.Location = new System.Drawing.Point(9, 145);
            this.txtEmails.Multiline = true;
            this.txtEmails.Name = "txtEmails";
            this.txtEmails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmails.Size = new System.Drawing.Size(237, 73);
            this.txtEmails.TabIndex = 3;
            this.txtEmails.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Email:Password (Hotmail, 1 Per Line):";
            // 
            // txtUsernames
            // 
            this.txtUsernames.Location = new System.Drawing.Point(9, 40);
            this.txtUsernames.Multiline = true;
            this.txtUsernames.Name = "txtUsernames";
            this.txtUsernames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUsernames.Size = new System.Drawing.Size(237, 72);
            this.txtUsernames.TabIndex = 1;
            this.txtUsernames.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username:Proxy (1 Per Line):";
            // 
            // tabUsernameGenerator
            // 
            this.tabUsernameGenerator.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabUsernameGenerator.Controls.Add(this.groupBox5);
            this.tabUsernameGenerator.Controls.Add(this.groupBox4);
            this.tabUsernameGenerator.Location = new System.Drawing.Point(4, 25);
            this.tabUsernameGenerator.Name = "tabUsernameGenerator";
            this.tabUsernameGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsernameGenerator.Size = new System.Drawing.Size(867, 246);
            this.tabUsernameGenerator.TabIndex = 3;
            this.tabUsernameGenerator.Text = "Username Gen";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(570, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 234);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Note";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(7, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(278, 206);
            this.label20.TabIndex = 0;
            this.label20.Text = "This module will generate usernames based on how many proxies you have, and how m" +
                "any times you want to reuse a proxy. 100 proxies with no reuse is 100 usernames," +
                " 1 reuses is 200 accounts, etc...";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblAccountsGenerated);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.btnExportToCreator);
            this.groupBox4.Controls.Add(this.txtProxyReuses);
            this.groupBox4.Controls.Add(this.btnTieProxies);
            this.groupBox4.Controls.Add(this.btnGenerateUsernames);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtGeneratedUsernames);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(558, 234);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Username Generator";
            // 
            // lblAccountsGenerated
            // 
            this.lblAccountsGenerated.AutoSize = true;
            this.lblAccountsGenerated.Location = new System.Drawing.Point(451, 201);
            this.lblAccountsGenerated.Name = "lblAccountsGenerated";
            this.lblAccountsGenerated.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAccountsGenerated.Size = new System.Drawing.Size(16, 17);
            this.lblAccountsGenerated.TabIndex = 31;
            this.lblAccountsGenerated.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(293, 201);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(142, 17);
            this.label22.TabIndex = 30;
            this.label22.Text = "Accounts Generated:";
            // 
            // btnExportToCreator
            // 
            this.btnExportToCreator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExportToCreator.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportToCreator.Location = new System.Drawing.Point(293, 106);
            this.btnExportToCreator.Name = "btnExportToCreator";
            this.btnExportToCreator.Size = new System.Drawing.Size(152, 44);
            this.btnExportToCreator.TabIndex = 29;
            this.btnExportToCreator.Text = "Export Accounts to Creator";
            this.btnExportToCreator.UseVisualStyleBackColor = false;
            this.btnExportToCreator.Click += new System.EventHandler(this.btnExportToCreator_Click);
            // 
            // txtProxyReuses
            // 
            this.txtProxyReuses.Location = new System.Drawing.Point(451, 75);
            this.txtProxyReuses.Name = "txtProxyReuses";
            this.txtProxyReuses.Size = new System.Drawing.Size(100, 22);
            this.txtProxyReuses.TabIndex = 28;
            // 
            // btnTieProxies
            // 
            this.btnTieProxies.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTieProxies.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTieProxies.Location = new System.Drawing.Point(293, 72);
            this.btnTieProxies.Name = "btnTieProxies";
            this.btnTieProxies.Size = new System.Drawing.Size(152, 28);
            this.btnTieProxies.TabIndex = 27;
            this.btnTieProxies.Text = "Tie Proxies";
            this.btnTieProxies.UseVisualStyleBackColor = false;
            this.btnTieProxies.Click += new System.EventHandler(this.btnTieProxies_Click);
            // 
            // btnGenerateUsernames
            // 
            this.btnGenerateUsernames.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGenerateUsernames.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerateUsernames.Location = new System.Drawing.Point(293, 38);
            this.btnGenerateUsernames.Name = "btnGenerateUsernames";
            this.btnGenerateUsernames.Size = new System.Drawing.Size(152, 28);
            this.btnGenerateUsernames.TabIndex = 26;
            this.btnGenerateUsernames.Text = "Generate Usernames";
            this.btnGenerateUsernames.UseVisualStyleBackColor = false;
            this.btnGenerateUsernames.Click += new System.EventHandler(this.btnGenerateUsernames_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(6, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Username:Proxy";
            // 
            // txtGeneratedUsernames
            // 
            this.txtGeneratedUsernames.Location = new System.Drawing.Point(6, 38);
            this.txtGeneratedUsernames.Multiline = true;
            this.txtGeneratedUsernames.Name = "txtGeneratedUsernames";
            this.txtGeneratedUsernames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGeneratedUsernames.Size = new System.Drawing.Size(281, 190);
            this.txtGeneratedUsernames.TabIndex = 3;
            this.txtGeneratedUsernames.WordWrap = false;
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpLog.Location = new System.Drawing.Point(12, 324);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(875, 146);
            this.grpLog.TabIndex = 8;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLog.Location = new System.Drawing.Point(6, 21);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(859, 118);
            this.txtLog.TabIndex = 0;
            this.txtLog.WordWrap = false;
            // 
            // chkDisplayLogMessages
            // 
            this.chkDisplayLogMessages.AutoSize = true;
            this.chkDisplayLogMessages.Checked = true;
            this.chkDisplayLogMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayLogMessages.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkDisplayLogMessages.Location = new System.Drawing.Point(715, 476);
            this.chkDisplayLogMessages.Name = "chkDisplayLogMessages";
            this.chkDisplayLogMessages.Size = new System.Drawing.Size(172, 21);
            this.chkDisplayLogMessages.TabIndex = 9;
            this.chkDisplayLogMessages.Text = "Display Log Messages";
            this.chkDisplayLogMessages.UseVisualStyleBackColor = true;
            // 
            // lblThreadsRunning
            // 
            this.lblThreadsRunning.AutoSize = true;
            this.lblThreadsRunning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblThreadsRunning.Location = new System.Drawing.Point(168, 477);
            this.lblThreadsRunning.Name = "lblThreadsRunning";
            this.lblThreadsRunning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblThreadsRunning.Size = new System.Drawing.Size(16, 17);
            this.lblThreadsRunning.TabIndex = 20;
            this.lblThreadsRunning.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Threads Running";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text Files|*.txt";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(867, 246);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Username Scraper";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(899, 501);
            this.Controls.Add(this.lblThreadsRunning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkDisplayLogMessages);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpImExAccounts.ResumeLayout(false);
            this.grpAddAccount.ResumeLayout(false);
            this.grpAddAccount.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpCheckerOverview.ResumeLayout(false);
            this.grpCheckerOverview.PerformLayout();
            this.grpAccountChecker.ResumeLayout(false);
            this.grpAccountChecker.PerformLayout();
            this.tabAccountCreator.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabUsernameGenerator.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddUsername;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpAddAccount;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveAllProxies;
        private System.Windows.Forms.Button btnRemoveAllAccounts;
        private System.Windows.Forms.Button btnRemoveSelectedAccounts;
        private System.Windows.Forms.CheckedListBox chklstAccounts;
        private System.Windows.Forms.GroupBox grpImExAccounts;
        private System.Windows.Forms.Button btnExportProxies;
        private System.Windows.Forms.Button btnLoadProxies;
        private System.Windows.Forms.Button btnExportAccounts;
        private System.Windows.Forms.Button btnLoadAccounts;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtAddProxyPassword;
        private System.Windows.Forms.TextBox txtAddProxyUsername;
        private System.Windows.Forms.TextBox txtAddPort;
        private System.Windows.Forms.TextBox txtAddProxy;
        private System.Windows.Forms.Label lblAccountsLoaded;
        private System.Windows.Forms.Label lblProxiesLoaded;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox chkDisplayLogMessages;
        private System.Windows.Forms.Label lblThreadsRunning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartChecking;
        private System.Windows.Forms.GroupBox grpAccountChecker;
        private System.Windows.Forms.Button btnStopChecking;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboCheckingMode;
        private System.Windows.Forms.ComboBox cmboAccountsToCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabAccountCreator;
        private System.Windows.Forms.GroupBox grpCheckerOverview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExportActive;
        private System.Windows.Forms.Label lblCheckerThreadsRunning;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDisabledAccounts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblActiveAccounts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsernames;
        private System.Windows.Forms.TextBox txtEmails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCreateDelay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkRotateProxyUponFailure;
        private System.Windows.Forms.CheckBox chkRotateEmailUponFailure;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCreatorThreadsRunning;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblAccountsCreated;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnStopCreating;
        private System.Windows.Forms.Button btnCreateAccounts;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnExportUserPass;
        private System.Windows.Forms.Button btnExportCreated;
        private System.Windows.Forms.Button btnExportUnusedEmails;
        private System.Windows.Forms.Button btnExportUnusedUsernames;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabUsernameGenerator;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGenerateUsernames;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtGeneratedUsernames;
        private System.Windows.Forms.TextBox txtProxyReuses;
        private System.Windows.Forms.Button btnTieProxies;
        private System.Windows.Forms.Button btnExportToCreator;
        private System.Windows.Forms.Label lblAccountsGenerated;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblAccountsVerrified;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tabPage3;

    }
}

