﻿namespace WindowsDebloatTool
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
            this.debloatTabs = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.welcomeText = new System.Windows.Forms.Label();
            this.debloatAuthors = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.qolTab = new System.Windows.Forms.TabPage();
            this.checkSettingsNotifications = new System.Windows.Forms.CheckBox();
            this.checkAppLaunches = new System.Windows.Forms.CheckBox();
            this.checkWindowsReplay = new System.Windows.Forms.CheckBox();
            this.checkWebsiteLanguage = new System.Windows.Forms.CheckBox();
            this.checkAppPromotions = new System.Windows.Forms.CheckBox();
            this.checkFileExtensions = new System.Windows.Forms.CheckBox();
            this.checkWindowsAdID = new System.Windows.Forms.CheckBox();
            this.checkLeftTaskbar = new System.Windows.Forms.CheckBox();
            this.qolInfo = new System.Windows.Forms.Label();
            this.buttonDisableSettingsNotifications = new System.Windows.Forms.Button();
            this.buttonDisableWindowsAppTracking = new System.Windows.Forms.Button();
            this.buttonDisableLanguageList = new System.Windows.Forms.Button();
            this.buttonAdvertisingID = new System.Windows.Forms.Button();
            this.buttonDisableConsumerFeatures = new System.Windows.Forms.Button();
            this.buttonDisplayFileExtensions = new System.Windows.Forms.Button();
            this.buttonDisableWindowsReplay = new System.Windows.Forms.Button();
            this.buttonTaskbarLeft = new System.Windows.Forms.Button();
            this.checkSearchBarSuggestions = new System.Windows.Forms.CheckBox();
            this.qolFeedback = new System.Windows.Forms.Label();
            this.buttonDisableSearchSuggestions = new System.Windows.Forms.Button();
            this.themeTab = new System.Windows.Forms.TabPage();
            this.checkLockScreenNotif = new System.Windows.Forms.CheckBox();
            this.checkAppControlLights = new System.Windows.Forms.CheckBox();
            this.checkDynamicLight = new System.Windows.Forms.CheckBox();
            this.checkNotifSound = new System.Windows.Forms.CheckBox();
            this.checkWindowsAccent = new System.Windows.Forms.CheckBox();
            this.checkDarkMode = new System.Windows.Forms.CheckBox();
            this.buttonDisableLockNotif = new System.Windows.Forms.Button();
            this.buttonDisableNotifSound = new System.Windows.Forms.Button();
            this.buttonDisableWindowsAccent = new System.Windows.Forms.Button();
            this.buttonAppsControlLighting = new System.Windows.Forms.Button();
            this.themeFeedback = new System.Windows.Forms.Label();
            this.buttonDisableDynamicLight = new System.Windows.Forms.Button();
            this.themingText = new System.Windows.Forms.Label();
            this.buttonEnableDark = new System.Windows.Forms.Button();
            this.performanceTab = new System.Windows.Forms.TabPage();
            this.checkResourcePrio = new System.Windows.Forms.CheckBox();
            this.checkGPU = new System.Windows.Forms.CheckBox();
            this.checkGameMode = new System.Windows.Forms.CheckBox();
            this.checkCPU = new System.Windows.Forms.CheckBox();
            this.checkGameBar = new System.Windows.Forms.CheckBox();
            this.checkVideoBattery = new System.Windows.Forms.CheckBox();
            this.buttonPrioAdjust = new System.Windows.Forms.Button();
            this.buttonCPUPrio = new System.Windows.Forms.Button();
            this.performanceGPUPrio = new System.Windows.Forms.Button();
            this.buttonDisableGameBar = new System.Windows.Forms.Button();
            this.buttonEnableGameMode = new System.Windows.Forms.Button();
            this.buttonOptimizeBatteryVideo = new System.Windows.Forms.Button();
            this.performanceFeedback = new System.Windows.Forms.Label();
            this.performanceText = new System.Windows.Forms.Label();
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.debloatTabs.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            this.qolTab.SuspendLayout();
            this.themeTab.SuspendLayout();
            this.performanceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // debloatTabs
            // 
            this.debloatTabs.Controls.Add(this.welcomeTab);
            this.debloatTabs.Controls.Add(this.qolTab);
            this.debloatTabs.Controls.Add(this.themeTab);
            this.debloatTabs.Controls.Add(this.performanceTab);
            this.debloatTabs.Location = new System.Drawing.Point(-3, -2);
            this.debloatTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debloatTabs.Name = "debloatTabs";
            this.debloatTabs.SelectedIndex = 0;
            this.debloatTabs.Size = new System.Drawing.Size(1021, 556);
            this.debloatTabs.TabIndex = 0;
            // 
            // welcomeTab
            // 
            this.welcomeTab.Controls.Add(this.welcomeMessage);
            this.welcomeTab.Controls.Add(this.welcomeText);
            this.welcomeTab.Controls.Add(this.debloatAuthors);
            this.welcomeTab.Controls.Add(this.welcomeLabel);
            this.welcomeTab.Location = new System.Drawing.Point(4, 25);
            this.welcomeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.welcomeTab.Size = new System.Drawing.Size(1013, 527);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.Text = "Welcome";
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // welcomeText
            // 
            this.welcomeText.Location = new System.Drawing.Point(0, 0);
            this.welcomeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(133, 28);
            this.welcomeText.TabIndex = 0;
            // 
            // debloatAuthors
            // 
            this.debloatAuthors.AutoSize = true;
            this.debloatAuthors.Location = new System.Drawing.Point(300, 30);
            this.debloatAuthors.Name = "debloatAuthors";
            this.debloatAuthors.Size = new System.Drawing.Size(360, 16);
            this.debloatAuthors.TabIndex = 1;
            this.debloatAuthors.Text = "Developed by Nygel Gomes, Logan Terpening, Tony Yang";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(412, 14);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(144, 16);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Windows Debloat Tool";
            // 
            // qolTab
            // 
            this.qolTab.Controls.Add(this.checkSettingsNotifications);
            this.qolTab.Controls.Add(this.checkAppLaunches);
            this.qolTab.Controls.Add(this.checkWindowsReplay);
            this.qolTab.Controls.Add(this.checkWebsiteLanguage);
            this.qolTab.Controls.Add(this.checkAppPromotions);
            this.qolTab.Controls.Add(this.checkFileExtensions);
            this.qolTab.Controls.Add(this.checkWindowsAdID);
            this.qolTab.Controls.Add(this.checkLeftTaskbar);
            this.qolTab.Controls.Add(this.qolInfo);
            this.qolTab.Controls.Add(this.buttonDisableSettingsNotifications);
            this.qolTab.Controls.Add(this.buttonDisableWindowsAppTracking);
            this.qolTab.Controls.Add(this.buttonDisableLanguageList);
            this.qolTab.Controls.Add(this.buttonAdvertisingID);
            this.qolTab.Controls.Add(this.buttonDisableConsumerFeatures);
            this.qolTab.Controls.Add(this.buttonDisplayFileExtensions);
            this.qolTab.Controls.Add(this.buttonDisableWindowsReplay);
            this.qolTab.Controls.Add(this.buttonTaskbarLeft);
            this.qolTab.Controls.Add(this.checkSearchBarSuggestions);
            this.qolTab.Controls.Add(this.qolFeedback);
            this.qolTab.Controls.Add(this.buttonDisableSearchSuggestions);
            this.qolTab.Location = new System.Drawing.Point(4, 25);
            this.qolTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qolTab.Name = "qolTab";
            this.qolTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qolTab.Size = new System.Drawing.Size(1013, 527);
            this.qolTab.TabIndex = 1;
            this.qolTab.Text = "QoL Features";
            this.qolTab.UseVisualStyleBackColor = true;
            // 
            // checkSettingsNotifications
            // 
            this.checkSettingsNotifications.AutoSize = true;
            this.checkSettingsNotifications.Enabled = false;
            this.checkSettingsNotifications.Location = new System.Drawing.Point(771, 313);
            this.checkSettingsNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSettingsNotifications.Name = "checkSettingsNotifications";
            this.checkSettingsNotifications.Size = new System.Drawing.Size(153, 20);
            this.checkSettingsNotifications.TabIndex = 20;
            this.checkSettingsNotifications.Text = "Settings Notifications";
            this.checkSettingsNotifications.UseVisualStyleBackColor = true;
            // 
            // checkAppLaunches
            // 
            this.checkAppLaunches.AutoSize = true;
            this.checkAppLaunches.Enabled = false;
            this.checkAppLaunches.Location = new System.Drawing.Point(771, 286);
            this.checkAppLaunches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkAppLaunches.Name = "checkAppLaunches";
            this.checkAppLaunches.Size = new System.Drawing.Size(168, 20);
            this.checkAppLaunches.TabIndex = 19;
            this.checkAppLaunches.Text = "Windows App Tracking";
            this.checkAppLaunches.UseVisualStyleBackColor = true;
            // 
            // checkWindowsReplay
            // 
            this.checkWindowsReplay.AutoSize = true;
            this.checkWindowsReplay.Enabled = false;
            this.checkWindowsReplay.Location = new System.Drawing.Point(771, 260);
            this.checkWindowsReplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkWindowsReplay.Name = "checkWindowsReplay";
            this.checkWindowsReplay.Size = new System.Drawing.Size(131, 20);
            this.checkWindowsReplay.TabIndex = 18;
            this.checkWindowsReplay.Text = "Windows Replay";
            this.checkWindowsReplay.UseVisualStyleBackColor = true;
            // 
            // checkWebsiteLanguage
            // 
            this.checkWebsiteLanguage.AutoSize = true;
            this.checkWebsiteLanguage.Enabled = false;
            this.checkWebsiteLanguage.Location = new System.Drawing.Point(771, 234);
            this.checkWebsiteLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkWebsiteLanguage.Name = "checkWebsiteLanguage";
            this.checkWebsiteLanguage.Size = new System.Drawing.Size(223, 20);
            this.checkWebsiteLanguage.TabIndex = 17;
            this.checkWebsiteLanguage.Text = "Websites Accessing Languages";
            this.checkWebsiteLanguage.UseVisualStyleBackColor = true;
            // 
            // checkAppPromotions
            // 
            this.checkAppPromotions.AutoSize = true;
            this.checkAppPromotions.Enabled = false;
            this.checkAppPromotions.Location = new System.Drawing.Point(771, 208);
            this.checkAppPromotions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkAppPromotions.Name = "checkAppPromotions";
            this.checkAppPromotions.Size = new System.Drawing.Size(125, 20);
            this.checkAppPromotions.TabIndex = 16;
            this.checkAppPromotions.Text = "App Promotions";
            this.checkAppPromotions.UseVisualStyleBackColor = true;
            // 
            // checkFileExtensions
            // 
            this.checkFileExtensions.AutoSize = true;
            this.checkFileExtensions.Enabled = false;
            this.checkFileExtensions.Location = new System.Drawing.Point(771, 182);
            this.checkFileExtensions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkFileExtensions.Name = "checkFileExtensions";
            this.checkFileExtensions.Size = new System.Drawing.Size(119, 20);
            this.checkFileExtensions.TabIndex = 15;
            this.checkFileExtensions.Text = "File Extensions";
            this.checkFileExtensions.UseVisualStyleBackColor = true;
            // 
            // checkWindowsAdID
            // 
            this.checkWindowsAdID.AutoSize = true;
            this.checkWindowsAdID.Enabled = false;
            this.checkWindowsAdID.Location = new System.Drawing.Point(771, 156);
            this.checkWindowsAdID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkWindowsAdID.Name = "checkWindowsAdID";
            this.checkWindowsAdID.Size = new System.Drawing.Size(127, 20);
            this.checkWindowsAdID.TabIndex = 14;
            this.checkWindowsAdID.Text = "Windows Ads ID";
            this.checkWindowsAdID.UseVisualStyleBackColor = true;
            // 
            // checkLeftTaskbar
            // 
            this.checkLeftTaskbar.AutoSize = true;
            this.checkLeftTaskbar.Enabled = false;
            this.checkLeftTaskbar.Location = new System.Drawing.Point(771, 130);
            this.checkLeftTaskbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkLeftTaskbar.Name = "checkLeftTaskbar";
            this.checkLeftTaskbar.Size = new System.Drawing.Size(169, 20);
            this.checkLeftTaskbar.TabIndex = 13;
            this.checkLeftTaskbar.Text = "Taskbar Left Allignment";
            this.checkLeftTaskbar.UseVisualStyleBackColor = true;
            // 
            // qolInfo
            // 
            this.qolInfo.Location = new System.Drawing.Point(11, 143);
            this.qolInfo.Name = "qolInfo";
            this.qolInfo.Size = new System.Drawing.Size(227, 204);
            this.qolInfo.TabIndex = 12;
            this.qolInfo.Text = "These features are quality of life improvements for Windows OS. Disabling these f" +
    "eatures harden your device and prevent unecessary processes from taking effect.";
            // 
            // buttonDisableSettingsNotifications
            // 
            this.buttonDisableSettingsNotifications.Location = new System.Drawing.Point(577, 286);
            this.buttonDisableSettingsNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisableSettingsNotifications.Name = "buttonDisableSettingsNotifications";
            this.buttonDisableSettingsNotifications.Size = new System.Drawing.Size(167, 84);
            this.buttonDisableSettingsNotifications.TabIndex = 11;
            this.buttonDisableSettingsNotifications.Text = "Disable Notifications in Settings App";
            this.buttonDisableSettingsNotifications.UseVisualStyleBackColor = true;
            this.buttonDisableSettingsNotifications.Click += new System.EventHandler(this.buttonDisableSettingsNotifications_Click);
            // 
            // buttonDisableWindowsAppTracking
            // 
            this.buttonDisableWindowsAppTracking.Location = new System.Drawing.Point(579, 178);
            this.buttonDisableWindowsAppTracking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisableWindowsAppTracking.Name = "buttonDisableWindowsAppTracking";
            this.buttonDisableWindowsAppTracking.Size = new System.Drawing.Size(165, 85);
            this.buttonDisableWindowsAppTracking.TabIndex = 10;
            this.buttonDisableWindowsAppTracking.Text = "Disable Windows Tracking App Launches";
            this.buttonDisableWindowsAppTracking.UseVisualStyleBackColor = true;
            this.buttonDisableWindowsAppTracking.Click += new System.EventHandler(this.buttonDisableWindowsAppTracking_Click);
            // 
            // buttonDisableLanguageList
            // 
            this.buttonDisableLanguageList.Location = new System.Drawing.Point(405, 286);
            this.buttonDisableLanguageList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisableLanguageList.Name = "buttonDisableLanguageList";
            this.buttonDisableLanguageList.Size = new System.Drawing.Size(165, 84);
            this.buttonDisableLanguageList.TabIndex = 9;
            this.buttonDisableLanguageList.Text = "Disable Websites Accessing Windows Language List";
            this.buttonDisableLanguageList.UseVisualStyleBackColor = true;
            this.buttonDisableLanguageList.Click += new System.EventHandler(this.buttonDisableLanguageList_Click);
            // 
            // buttonAdvertisingID
            // 
            this.buttonAdvertisingID.Location = new System.Drawing.Point(243, 286);
            this.buttonAdvertisingID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdvertisingID.Name = "buttonAdvertisingID";
            this.buttonAdvertisingID.Size = new System.Drawing.Size(157, 84);
            this.buttonAdvertisingID.TabIndex = 8;
            this.buttonAdvertisingID.Text = "Disable Windows Advertising ID";
            this.buttonAdvertisingID.UseVisualStyleBackColor = true;
            this.buttonAdvertisingID.Click += new System.EventHandler(this.buttonAdvertisingID_Click);
            // 
            // buttonDisableConsumerFeatures
            // 
            this.buttonDisableConsumerFeatures.Location = new System.Drawing.Point(405, 178);
            this.buttonDisableConsumerFeatures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisableConsumerFeatures.Name = "buttonDisableConsumerFeatures";
            this.buttonDisableConsumerFeatures.Size = new System.Drawing.Size(165, 84);
            this.buttonDisableConsumerFeatures.TabIndex = 7;
            this.buttonDisableConsumerFeatures.Text = "Disable App Promotions";
            this.buttonDisableConsumerFeatures.UseVisualStyleBackColor = true;
            this.buttonDisableConsumerFeatures.Click += new System.EventHandler(this.buttonDisableConsumerFeatures_Click);
            // 
            // buttonDisplayFileExtensions
            // 
            this.buttonDisplayFileExtensions.Location = new System.Drawing.Point(405, 73);
            this.buttonDisplayFileExtensions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisplayFileExtensions.Name = "buttonDisplayFileExtensions";
            this.buttonDisplayFileExtensions.Size = new System.Drawing.Size(165, 85);
            this.buttonDisplayFileExtensions.TabIndex = 6;
            this.buttonDisplayFileExtensions.Text = "Display File Extensions";
            this.buttonDisplayFileExtensions.UseVisualStyleBackColor = true;
            this.buttonDisplayFileExtensions.Click += new System.EventHandler(this.buttonDisplayFileExtensions_Click);
            // 
            // buttonDisableWindowsReplay
            // 
            this.buttonDisableWindowsReplay.Location = new System.Drawing.Point(579, 73);
            this.buttonDisableWindowsReplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisableWindowsReplay.Name = "buttonDisableWindowsReplay";
            this.buttonDisableWindowsReplay.Size = new System.Drawing.Size(165, 85);
            this.buttonDisableWindowsReplay.TabIndex = 5;
            this.buttonDisableWindowsReplay.Text = "(COPILOT+ PCS ONLY) Disable Windows Replay";
            this.buttonDisableWindowsReplay.UseVisualStyleBackColor = true;
            this.buttonDisableWindowsReplay.Click += new System.EventHandler(this.buttonDisableWindowsReplay_Click);
            // 
            // buttonTaskbarLeft
            // 
            this.buttonTaskbarLeft.Location = new System.Drawing.Point(243, 178);
            this.buttonTaskbarLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTaskbarLeft.Name = "buttonTaskbarLeft";
            this.buttonTaskbarLeft.Size = new System.Drawing.Size(156, 85);
            this.buttonTaskbarLeft.TabIndex = 4;
            this.buttonTaskbarLeft.Text = "(WINDOWS 11 ONLY) Allign Taskbar to Left";
            this.buttonTaskbarLeft.UseVisualStyleBackColor = true;
            this.buttonTaskbarLeft.Click += new System.EventHandler(this.buttonTaskbarLeft_Click);
            // 
            // checkSearchBarSuggestions
            // 
            this.checkSearchBarSuggestions.AutoSize = true;
            this.checkSearchBarSuggestions.Enabled = false;
            this.checkSearchBarSuggestions.Location = new System.Drawing.Point(771, 103);
            this.checkSearchBarSuggestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSearchBarSuggestions.Name = "checkSearchBarSuggestions";
            this.checkSearchBarSuggestions.Size = new System.Drawing.Size(174, 20);
            this.checkSearchBarSuggestions.TabIndex = 2;
            this.checkSearchBarSuggestions.Text = "Search Bar Suggestions";
            this.checkSearchBarSuggestions.UseVisualStyleBackColor = true;
            // 
            // qolFeedback
            // 
            this.qolFeedback.AutoSize = true;
            this.qolFeedback.Location = new System.Drawing.Point(3, 487);
            this.qolFeedback.Name = "qolFeedback";
            this.qolFeedback.Size = new System.Drawing.Size(626, 16);
            this.qolFeedback.TabIndex = 1;
            this.qolFeedback.Text = "Click a button to disable that process. Administrator access is required, make su" +
    "re to run as administrator.";
            // 
            // buttonDisableSearchSuggestions
            // 
            this.buttonDisableSearchSuggestions.Location = new System.Drawing.Point(243, 73);
            this.buttonDisableSearchSuggestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisableSearchSuggestions.Name = "buttonDisableSearchSuggestions";
            this.buttonDisableSearchSuggestions.Size = new System.Drawing.Size(157, 85);
            this.buttonDisableSearchSuggestions.TabIndex = 0;
            this.buttonDisableSearchSuggestions.Text = "Disable Search Bar Suggestions";
            this.buttonDisableSearchSuggestions.UseVisualStyleBackColor = true;
            this.buttonDisableSearchSuggestions.Click += new System.EventHandler(this.buttonDisableSearchSuggestions_Click);
            // 
            // themeTab
            // 
            this.themeTab.Controls.Add(this.checkLockScreenNotif);
            this.themeTab.Controls.Add(this.checkAppControlLights);
            this.themeTab.Controls.Add(this.checkDynamicLight);
            this.themeTab.Controls.Add(this.checkNotifSound);
            this.themeTab.Controls.Add(this.checkWindowsAccent);
            this.themeTab.Controls.Add(this.checkDarkMode);
            this.themeTab.Controls.Add(this.buttonDisableLockNotif);
            this.themeTab.Controls.Add(this.buttonDisableNotifSound);
            this.themeTab.Controls.Add(this.buttonDisableWindowsAccent);
            this.themeTab.Controls.Add(this.buttonAppsControlLighting);
            this.themeTab.Controls.Add(this.themeFeedback);
            this.themeTab.Controls.Add(this.buttonDisableDynamicLight);
            this.themeTab.Controls.Add(this.themingText);
            this.themeTab.Controls.Add(this.buttonEnableDark);
            this.themeTab.Location = new System.Drawing.Point(4, 25);
            this.themeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.themeTab.Name = "themeTab";
            this.themeTab.Size = new System.Drawing.Size(1013, 527);
            this.themeTab.TabIndex = 2;
            this.themeTab.Text = "Theming";
            this.themeTab.UseVisualStyleBackColor = true;
            // 
            // checkLockScreenNotif
            // 
            this.checkLockScreenNotif.AutoSize = true;
            this.checkLockScreenNotif.Enabled = false;
            this.checkLockScreenNotif.Location = new System.Drawing.Point(815, 294);
            this.checkLockScreenNotif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkLockScreenNotif.Name = "checkLockScreenNotif";
            this.checkLockScreenNotif.Size = new System.Drawing.Size(153, 20);
            this.checkLockScreenNotif.TabIndex = 14;
            this.checkLockScreenNotif.Text = "Lock Notifs Disabled";
            this.checkLockScreenNotif.UseVisualStyleBackColor = true;
            // 
            // checkAppControlLights
            // 
            this.checkAppControlLights.AutoSize = true;
            this.checkAppControlLights.Enabled = false;
            this.checkAppControlLights.Location = new System.Drawing.Point(815, 265);
            this.checkAppControlLights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkAppControlLights.Name = "checkAppControlLights";
            this.checkAppControlLights.Size = new System.Drawing.Size(161, 20);
            this.checkAppControlLights.TabIndex = 13;
            this.checkAppControlLights.Text = "App Lighting Disabled";
            this.checkAppControlLights.UseVisualStyleBackColor = true;
            // 
            // checkDynamicLight
            // 
            this.checkDynamicLight.AutoSize = true;
            this.checkDynamicLight.Enabled = false;
            this.checkDynamicLight.Location = new System.Drawing.Point(815, 235);
            this.checkDynamicLight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkDynamicLight.Name = "checkDynamicLight";
            this.checkDynamicLight.Size = new System.Drawing.Size(178, 20);
            this.checkDynamicLight.TabIndex = 12;
            this.checkDynamicLight.Text = "Dynamic Lights Disabled";
            this.checkDynamicLight.UseVisualStyleBackColor = true;
            // 
            // checkNotifSound
            // 
            this.checkNotifSound.AutoSize = true;
            this.checkNotifSound.Enabled = false;
            this.checkNotifSound.Location = new System.Drawing.Point(815, 206);
            this.checkNotifSound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkNotifSound.Name = "checkNotifSound";
            this.checkNotifSound.Size = new System.Drawing.Size(156, 20);
            this.checkNotifSound.TabIndex = 11;
            this.checkNotifSound.Text = "Notif Sound DIsabled";
            this.checkNotifSound.UseVisualStyleBackColor = true;
            // 
            // checkWindowsAccent
            // 
            this.checkWindowsAccent.AutoSize = true;
            this.checkWindowsAccent.Enabled = false;
            this.checkWindowsAccent.Location = new System.Drawing.Point(815, 177);
            this.checkWindowsAccent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkWindowsAccent.Name = "checkWindowsAccent";
            this.checkWindowsAccent.Size = new System.Drawing.Size(163, 20);
            this.checkWindowsAccent.TabIndex = 10;
            this.checkWindowsAccent.Text = "Accent Color Disabled";
            this.checkWindowsAccent.UseVisualStyleBackColor = true;
            // 
            // checkDarkMode
            // 
            this.checkDarkMode.AutoSize = true;
            this.checkDarkMode.Enabled = false;
            this.checkDarkMode.Location = new System.Drawing.Point(815, 150);
            this.checkDarkMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkDarkMode.Name = "checkDarkMode";
            this.checkDarkMode.Size = new System.Drawing.Size(150, 20);
            this.checkDarkMode.TabIndex = 9;
            this.checkDarkMode.Text = "Dark Mode Enabled";
            this.checkDarkMode.UseVisualStyleBackColor = true;
            // 
            // buttonDisableLockNotif
            // 
            this.buttonDisableLockNotif.Location = new System.Drawing.Point(579, 302);
            this.buttonDisableLockNotif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDisableLockNotif.Name = "buttonDisableLockNotif";
            this.buttonDisableLockNotif.Size = new System.Drawing.Size(147, 89);
            this.buttonDisableLockNotif.TabIndex = 8;
            this.buttonDisableLockNotif.Text = "Disable Lock Screen Notifications";
            this.buttonDisableLockNotif.UseVisualStyleBackColor = true;
            this.buttonDisableLockNotif.Click += new System.EventHandler(this.buttonDisableLockNotif_Click);
            // 
            // buttonDisableNotifSound
            // 
            this.buttonDisableNotifSound.Location = new System.Drawing.Point(375, 302);
            this.buttonDisableNotifSound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDisableNotifSound.Name = "buttonDisableNotifSound";
            this.buttonDisableNotifSound.Size = new System.Drawing.Size(159, 89);
            this.buttonDisableNotifSound.TabIndex = 7;
            this.buttonDisableNotifSound.Text = "Disable Notification Sounds";
            this.buttonDisableNotifSound.UseVisualStyleBackColor = true;
            this.buttonDisableNotifSound.Click += new System.EventHandler(this.buttonDisableNotifSound_Click);
            // 
            // buttonDisableWindowsAccent
            // 
            this.buttonDisableWindowsAccent.Location = new System.Drawing.Point(375, 190);
            this.buttonDisableWindowsAccent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDisableWindowsAccent.Name = "buttonDisableWindowsAccent";
            this.buttonDisableWindowsAccent.Size = new System.Drawing.Size(159, 89);
            this.buttonDisableWindowsAccent.TabIndex = 6;
            this.buttonDisableWindowsAccent.Text = "Disable Match Windows Accent Color";
            this.buttonDisableWindowsAccent.UseVisualStyleBackColor = true;
            this.buttonDisableWindowsAccent.Click += new System.EventHandler(this.buttonDisableWindowsAccent_Click);
            // 
            // buttonAppsControlLighting
            // 
            this.buttonAppsControlLighting.Location = new System.Drawing.Point(579, 190);
            this.buttonAppsControlLighting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAppsControlLighting.Name = "buttonAppsControlLighting";
            this.buttonAppsControlLighting.Size = new System.Drawing.Size(147, 89);
            this.buttonAppsControlLighting.TabIndex = 5;
            this.buttonAppsControlLighting.Text = "Disable Apps Control Lighting";
            this.buttonAppsControlLighting.UseVisualStyleBackColor = true;
            this.buttonAppsControlLighting.Click += new System.EventHandler(this.buttonAppsControlLighting_Click);
            // 
            // themeFeedback
            // 
            this.themeFeedback.AutoSize = true;
            this.themeFeedback.Location = new System.Drawing.Point(3, 489);
            this.themeFeedback.Name = "themeFeedback";
            this.themeFeedback.Size = new System.Drawing.Size(648, 16);
            this.themeFeedback.TabIndex = 4;
            this.themeFeedback.Text = "Click a button to customize your interface. Administrator access is required, mak" +
    "e sure to run as administrator.";
            // 
            // buttonDisableDynamicLight
            // 
            this.buttonDisableDynamicLight.Location = new System.Drawing.Point(579, 82);
            this.buttonDisableDynamicLight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisableDynamicLight.Name = "buttonDisableDynamicLight";
            this.buttonDisableDynamicLight.Size = new System.Drawing.Size(147, 89);
            this.buttonDisableDynamicLight.TabIndex = 3;
            this.buttonDisableDynamicLight.Text = "Disable Dynamic Lighting";
            this.buttonDisableDynamicLight.UseVisualStyleBackColor = true;
            this.buttonDisableDynamicLight.Click += new System.EventHandler(this.buttonDisableDynamicLight_Click);
            // 
            // themingText
            // 
            this.themingText.Location = new System.Drawing.Point(25, 190);
            this.themingText.Name = "themingText";
            this.themingText.Size = new System.Drawing.Size(284, 73);
            this.themingText.TabIndex = 2;
            this.themingText.Text = "These settings enable the user to customize the Windows interface. Please choose " +
    "processes to disable.";
            // 
            // buttonEnableDark
            // 
            this.buttonEnableDark.Location = new System.Drawing.Point(375, 82);
            this.buttonEnableDark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEnableDark.Name = "buttonEnableDark";
            this.buttonEnableDark.Size = new System.Drawing.Size(159, 89);
            this.buttonEnableDark.TabIndex = 0;
            this.buttonEnableDark.Text = "Enable Dark Mode";
            this.buttonEnableDark.UseVisualStyleBackColor = true;
            this.buttonEnableDark.Click += new System.EventHandler(this.buttonEnableDark_Click);
            // 
            // performanceTab
            // 
            this.performanceTab.Controls.Add(this.checkResourcePrio);
            this.performanceTab.Controls.Add(this.checkGPU);
            this.performanceTab.Controls.Add(this.checkGameMode);
            this.performanceTab.Controls.Add(this.checkCPU);
            this.performanceTab.Controls.Add(this.checkGameBar);
            this.performanceTab.Controls.Add(this.checkVideoBattery);
            this.performanceTab.Controls.Add(this.buttonPrioAdjust);
            this.performanceTab.Controls.Add(this.buttonCPUPrio);
            this.performanceTab.Controls.Add(this.performanceGPUPrio);
            this.performanceTab.Controls.Add(this.buttonDisableGameBar);
            this.performanceTab.Controls.Add(this.buttonEnableGameMode);
            this.performanceTab.Controls.Add(this.buttonOptimizeBatteryVideo);
            this.performanceTab.Controls.Add(this.performanceFeedback);
            this.performanceTab.Controls.Add(this.performanceText);
            this.performanceTab.Location = new System.Drawing.Point(4, 25);
            this.performanceTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.performanceTab.Name = "performanceTab";
            this.performanceTab.Size = new System.Drawing.Size(1013, 527);
            this.performanceTab.TabIndex = 3;
            this.performanceTab.Text = "Performance";
            this.performanceTab.UseVisualStyleBackColor = true;
            // 
            // checkResourcePrio
            // 
            this.checkResourcePrio.AutoSize = true;
            this.checkResourcePrio.Enabled = false;
            this.checkResourcePrio.Location = new System.Drawing.Point(797, 293);
            this.checkResourcePrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkResourcePrio.Name = "checkResourcePrio";
            this.checkResourcePrio.Size = new System.Drawing.Size(178, 20);
            this.checkResourcePrio.TabIndex = 13;
            this.checkResourcePrio.Text = "Resource Prio Optimized";
            this.checkResourcePrio.UseVisualStyleBackColor = true;
            // 
            // checkGPU
            // 
            this.checkGPU.AutoSize = true;
            this.checkGPU.Enabled = false;
            this.checkGPU.Location = new System.Drawing.Point(797, 263);
            this.checkGPU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkGPU.Name = "checkGPU";
            this.checkGPU.Size = new System.Drawing.Size(121, 20);
            this.checkGPU.TabIndex = 12;
            this.checkGPU.Text = "GPU Optimized";
            this.checkGPU.UseVisualStyleBackColor = true;
            // 
            // checkGameMode
            // 
            this.checkGameMode.AutoSize = true;
            this.checkGameMode.Enabled = false;
            this.checkGameMode.Location = new System.Drawing.Point(797, 234);
            this.checkGameMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkGameMode.Name = "checkGameMode";
            this.checkGameMode.Size = new System.Drawing.Size(158, 20);
            this.checkGameMode.TabIndex = 11;
            this.checkGameMode.Text = "Game Mode Enabled";
            this.checkGameMode.UseVisualStyleBackColor = true;
            // 
            // checkCPU
            // 
            this.checkCPU.AutoSize = true;
            this.checkCPU.Enabled = false;
            this.checkCPU.Location = new System.Drawing.Point(797, 204);
            this.checkCPU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkCPU.Name = "checkCPU";
            this.checkCPU.Size = new System.Drawing.Size(120, 20);
            this.checkCPU.TabIndex = 10;
            this.checkCPU.Text = "CPU Optimized";
            this.checkCPU.UseVisualStyleBackColor = true;
            // 
            // checkGameBar
            // 
            this.checkGameBar.AutoSize = true;
            this.checkGameBar.Enabled = false;
            this.checkGameBar.Location = new System.Drawing.Point(797, 175);
            this.checkGameBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkGameBar.Name = "checkGameBar";
            this.checkGameBar.Size = new System.Drawing.Size(148, 20);
            this.checkGameBar.TabIndex = 9;
            this.checkGameBar.Text = "Game Bar Disabled";
            this.checkGameBar.UseVisualStyleBackColor = true;
            // 
            // checkVideoBattery
            // 
            this.checkVideoBattery.AutoSize = true;
            this.checkVideoBattery.Enabled = false;
            this.checkVideoBattery.Location = new System.Drawing.Point(797, 146);
            this.checkVideoBattery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkVideoBattery.Name = "checkVideoBattery";
            this.checkVideoBattery.Size = new System.Drawing.Size(188, 20);
            this.checkVideoBattery.TabIndex = 8;
            this.checkVideoBattery.Text = "Video Playback Optimized";
            this.checkVideoBattery.UseVisualStyleBackColor = true;
            // 
            // buttonPrioAdjust
            // 
            this.buttonPrioAdjust.Location = new System.Drawing.Point(552, 292);
            this.buttonPrioAdjust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPrioAdjust.Name = "buttonPrioAdjust";
            this.buttonPrioAdjust.Size = new System.Drawing.Size(192, 82);
            this.buttonPrioAdjust.TabIndex = 7;
            this.buttonPrioAdjust.Text = "Adjust Resource Priority for Open Application";
            this.buttonPrioAdjust.UseVisualStyleBackColor = true;
            this.buttonPrioAdjust.Click += new System.EventHandler(this.buttonPrioAdjust_Click);
            // 
            // buttonCPUPrio
            // 
            this.buttonCPUPrio.Location = new System.Drawing.Point(340, 292);
            this.buttonCPUPrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCPUPrio.Name = "buttonCPUPrio";
            this.buttonCPUPrio.Size = new System.Drawing.Size(192, 82);
            this.buttonCPUPrio.TabIndex = 6;
            this.buttonCPUPrio.Text = "Prioritize CPU for Gaming";
            this.buttonCPUPrio.UseVisualStyleBackColor = true;
            this.buttonCPUPrio.Click += new System.EventHandler(this.buttonCPUPrio_Click);
            // 
            // performanceGPUPrio
            // 
            this.performanceGPUPrio.Location = new System.Drawing.Point(552, 188);
            this.performanceGPUPrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.performanceGPUPrio.Name = "performanceGPUPrio";
            this.performanceGPUPrio.Size = new System.Drawing.Size(192, 82);
            this.performanceGPUPrio.TabIndex = 5;
            this.performanceGPUPrio.Text = "Prioritize GPU for Gaming";
            this.performanceGPUPrio.UseVisualStyleBackColor = true;
            this.performanceGPUPrio.Click += new System.EventHandler(this.performanceGPUPrio_Click);
            // 
            // buttonDisableGameBar
            // 
            this.buttonDisableGameBar.Location = new System.Drawing.Point(340, 188);
            this.buttonDisableGameBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDisableGameBar.Name = "buttonDisableGameBar";
            this.buttonDisableGameBar.Size = new System.Drawing.Size(192, 82);
            this.buttonDisableGameBar.TabIndex = 4;
            this.buttonDisableGameBar.Text = "Disable Game Bar";
            this.buttonDisableGameBar.UseVisualStyleBackColor = true;
            this.buttonDisableGameBar.Click += new System.EventHandler(this.buttonDisableGameBar_Click);
            // 
            // buttonEnableGameMode
            // 
            this.buttonEnableGameMode.Location = new System.Drawing.Point(552, 86);
            this.buttonEnableGameMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnableGameMode.Name = "buttonEnableGameMode";
            this.buttonEnableGameMode.Size = new System.Drawing.Size(192, 82);
            this.buttonEnableGameMode.TabIndex = 3;
            this.buttonEnableGameMode.Text = "Enable Game Mode";
            this.buttonEnableGameMode.UseVisualStyleBackColor = true;
            this.buttonEnableGameMode.Click += new System.EventHandler(this.buttonEnableGameMode_Click);
            // 
            // buttonOptimizeBatteryVideo
            // 
            this.buttonOptimizeBatteryVideo.Location = new System.Drawing.Point(340, 86);
            this.buttonOptimizeBatteryVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOptimizeBatteryVideo.Name = "buttonOptimizeBatteryVideo";
            this.buttonOptimizeBatteryVideo.Size = new System.Drawing.Size(192, 82);
            this.buttonOptimizeBatteryVideo.TabIndex = 2;
            this.buttonOptimizeBatteryVideo.Text = "Optimize Battery Settings for Video Playback";
            this.buttonOptimizeBatteryVideo.UseVisualStyleBackColor = true;
            this.buttonOptimizeBatteryVideo.Click += new System.EventHandler(this.buttonOptimizeBatteryVideo_Click);
            // 
            // performanceFeedback
            // 
            this.performanceFeedback.AutoSize = true;
            this.performanceFeedback.Location = new System.Drawing.Point(13, 486);
            this.performanceFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.performanceFeedback.Name = "performanceFeedback";
            this.performanceFeedback.Size = new System.Drawing.Size(631, 16);
            this.performanceFeedback.TabIndex = 1;
            this.performanceFeedback.Text = "Click a button to optimize performance Administrator access is required, make sur" +
    "e to run as administrator.";
            // 
            // performanceText
            // 
            this.performanceText.Location = new System.Drawing.Point(25, 156);
            this.performanceText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.performanceText.Name = "performanceText";
            this.performanceText.Size = new System.Drawing.Size(224, 126);
            this.performanceText.TabIndex = 0;
            this.performanceText.Text = "These settings optimize Windows settings for performance. These can enhance syste" +
    "m performance and result in higher FPS counts in Game Mode.";
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.Location = new System.Drawing.Point(356, 172);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(290, 126);
            this.welcomeMessage.TabIndex = 2;
            this.welcomeMessage.Text = "Welcome to the Windows Debloat Tool. This application aims to harden, optimize, a" +
    "nd theme the Windows OS experience. Please navigate through the tabs to begin.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 553);
            this.Controls.Add(this.debloatTabs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Windows Debloat Tool";
            this.debloatTabs.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.welcomeTab.PerformLayout();
            this.qolTab.ResumeLayout(false);
            this.qolTab.PerformLayout();
            this.themeTab.ResumeLayout(false);
            this.themeTab.PerformLayout();
            this.performanceTab.ResumeLayout(false);
            this.performanceTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl debloatTabs;
        private System.Windows.Forms.TabPage welcomeTab;
        private System.Windows.Forms.TabPage qolTab;
        private System.Windows.Forms.Label debloatAuthors;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button buttonDisableSearchSuggestions;
        private System.Windows.Forms.Label qolFeedback;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.CheckBox checkSearchBarSuggestions;
        private System.Windows.Forms.TabPage themeTab;
        private System.Windows.Forms.TabPage performanceTab;
        private System.Windows.Forms.Button buttonEnableDark;
        private System.Windows.Forms.Label themingText;
        private System.Windows.Forms.Button buttonDisableDynamicLight;
        private System.Windows.Forms.Button buttonTaskbarLeft;
        private System.Windows.Forms.Button buttonDisableWindowsReplay;
        private System.Windows.Forms.Button buttonDisplayFileExtensions;
        private System.Windows.Forms.Button buttonDisableConsumerFeatures;
        private System.Windows.Forms.Button buttonAdvertisingID;
        private System.Windows.Forms.Button buttonDisableLanguageList;
        private System.Windows.Forms.Button buttonDisableWindowsAppTracking;
        private System.Windows.Forms.Button buttonDisableSettingsNotifications;
        private System.Windows.Forms.Label qolInfo;
        private System.Windows.Forms.CheckBox checkWebsiteLanguage;
        private System.Windows.Forms.CheckBox checkAppPromotions;
        private System.Windows.Forms.CheckBox checkFileExtensions;
        private System.Windows.Forms.CheckBox checkWindowsAdID;
        private System.Windows.Forms.CheckBox checkLeftTaskbar;
        private System.Windows.Forms.CheckBox checkSettingsNotifications;
        private System.Windows.Forms.CheckBox checkAppLaunches;
        private System.Windows.Forms.CheckBox checkWindowsReplay;
        private System.Windows.Forms.Label themeFeedback;
        private System.Windows.Forms.Button buttonAppsControlLighting;
        private System.Windows.Forms.Button buttonDisableWindowsAccent;
        private System.Windows.Forms.Button buttonDisableNotifSound;
        private System.Windows.Forms.Button buttonDisableLockNotif;
        private System.Windows.Forms.Label performanceFeedback;
        private System.Windows.Forms.Label performanceText;
        private System.Windows.Forms.Button buttonOptimizeBatteryVideo;
        private System.Windows.Forms.Button buttonEnableGameMode;
        private System.Windows.Forms.Button buttonDisableGameBar;
        private System.Windows.Forms.Button performanceGPUPrio;
        private System.Windows.Forms.Button buttonCPUPrio;
        private System.Windows.Forms.Button buttonPrioAdjust;
        private System.Windows.Forms.CheckBox checkDarkMode;
        private System.Windows.Forms.CheckBox checkLockScreenNotif;
        private System.Windows.Forms.CheckBox checkAppControlLights;
        private System.Windows.Forms.CheckBox checkDynamicLight;
        private System.Windows.Forms.CheckBox checkNotifSound;
        private System.Windows.Forms.CheckBox checkWindowsAccent;
        private System.Windows.Forms.CheckBox checkGPU;
        private System.Windows.Forms.CheckBox checkGameMode;
        private System.Windows.Forms.CheckBox checkCPU;
        private System.Windows.Forms.CheckBox checkGameBar;
        private System.Windows.Forms.CheckBox checkVideoBattery;
        private System.Windows.Forms.CheckBox checkResourcePrio;
        private System.Windows.Forms.Label welcomeMessage;
    }
}
