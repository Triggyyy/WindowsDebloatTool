using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDebloatTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckRegistrySettingsQoL();
            CheckRegistrySettingsTheme();
            CheckRegistrySettingsPerformance();
        }

        // Method to set registry values to Windows default
        private void RestoreRegistryToDefault(string registryPath, string valueName, object defaultValue)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath, true))
                {
                    if (key != null)
                    {
                        //check if the value exists 
                        object currentValue = key.GetValue(valueName, null);
                        if (currentValue == null || !currentValue.Equals(defaultValue))
                        {
                            // Restore the default value
                            key.SetValue(valueName, defaultValue);
                        }
                    }
                    else
                    {
                        // If the key doesn't exist, create it and set the default value
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(registryPath))
                        {
                            newKey?.SetValue(valueName, defaultValue);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                qolFeedback.Text = ("Error: " + ex.Message + " has occurred.");
            }
        }

        //This method's parameters allow us to check off the checkboxes should the expected value be met
        private void CheckRegistrySetting(string registryPath, string valueName, object expectedValue, CheckBox checkBoxToUpdate)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Read the value from the registry
                        object value = key.GetValue(valueName, null);

                        // Update the checkbox based on whether the value matches the expected value
                        checkBoxToUpdate.Checked = value != null && value.Equals(expectedValue);
                    }
                    else
                    {
                        // If the registry key doesn't exist, uncheck the checkbox
                        checkBoxToUpdate.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                qolFeedback.Text = ("Error: " + ex.Message + " has occurred.");
            }
        }

        //This is a method used to check if a registry setting requiring 2 values to take effect is properly set in regedit
        private void CheckRegistrySetting2(string registryPath, string valueName1, object expectedValue1, string valueName2, object expectedValue2, CheckBox checkBoxToUpdate)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Read both values from the registry
                        object value1 = key.GetValue(valueName1, null);
                        object value2 = key.GetValue(valueName2, null);

                        // Update the checkbox based on whether both values match the expected values
                        checkBoxToUpdate.Checked =
                            value1 != null && value1.Equals(expectedValue1) &&
                            value2 != null && value2.Equals(expectedValue2);
                    }
                    else
                    {
                        // If the registry key doesn't exist, uncheck the checkbox
                        checkBoxToUpdate.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        




        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // QUALITY OF LIFE CHECK LISTENER
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void CheckRegistrySettingsQoL()
        {
            // Check for "DisableSearchBoxSuggestions"
            CheckRegistrySetting(
                @"SOFTWARE\Policies\Microsoft\Windows\Explorer",
                "DisableSearchBoxSuggestions",
                1,
                checkSearchBarSuggestions
            );

            // Check for "TaskbarAl"
            CheckRegistrySetting(
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced",
                "TaskbarAl",
                0,
                checkLeftTaskbar
            );

            // Check for "Enabled"
            CheckRegistrySetting(
                @"Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo",
                "Enabled",
                0,
                checkWindowsAdID
            );

            // Check for "HideFileExt"
            CheckRegistrySetting(
                @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced",
                "HideFileExt",
                0,
                checkFileExtensions
            );

            // Check for "SoftLandingEnabled"
            CheckRegistrySetting(
                @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager",
                "SoftLandingEnabled",
                0,
                checkAppPromotions
            );



            // Check for "HttpAcceptLanguageOptOut"
            CheckRegistrySetting(
                @"Control Panel\International\User Profile",
                "HttpAcceptLanguageOptOut",
                1,
                checkWebsiteLanguage
            );

            // Check for "DisableAIDataAnalytics" and "TurnOffSavingSnapshots"
            CheckRegistrySetting2(
                @"Software\Policies\Microsoft\Windows\WindowsAI",
                "DisableAIDataAnalysis", 1,
                "TurnOffSavingSnapshots", 1,
                checkWindowsReplay
            );

            // Check for "Start_TrackProgs"
            CheckRegistrySetting(
                @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced",
                "Start_TrackProgs",
                0,
                checkAppLaunches
            );

            // Check for "EnableAccountNotifications"
            CheckRegistrySetting(
                @"Software\Microsoft\Windows\CurrentVersion\SystemSettings\AccountNotifications",
                "EnableAccountNotifications",
                0,
                checkSettingsNotifications
            );
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // QUALITY OF LIFE DEFAULT VALUES
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            //Searchbar
            RestoreRegistryToDefault(
                @"SOFTWARE\Policies\Microsoft\Windows\Explorer",
                "DisableSearchBoxSuggestions",
                0);

            //Taskbar Al
            RestoreRegistryToDefault(
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced",
                "TaskbarAl",
                1);

            //AD ID
            RestoreRegistryToDefault(
                @"Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo",
                "Enabled",
                1);

            //File extenstion
            RestoreRegistryToDefault(
                @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced",
                "HideFileExt",
                1);

            //Softlanding
            RestoreRegistryToDefault(
                @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager",
                "SoftLandingEnabled",
                1);

            //Http Accept
            RestoreRegistryToDefault(
                @"Control Panel\International\User Profile",
                "HttpAcceptLanguageOptOut",
                0);

            //AI Analytics
            RestoreRegistryToDefault(
                @"Software\Policies\Microsoft\Windows\WindowsAI",
                "DisableAIDataAnalysis",
                0);

            //Saving Snapshots
            RestoreRegistryToDefault(
                @"Software\Policies\Microsoft\Windows\WindowsAI",
                "TurnOffSavingSnapshots",
                0);

            //Track Prog
            RestoreRegistryToDefault(
                 @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced",
                "Start_TrackProgs",
                1);

            //Account Notif
            RestoreRegistryToDefault(
                @"Software\Microsoft\Windows\CurrentVersion\SystemSettings\AccountNotifications",
                "EnableAccountNotifications",
                1);

            qolFeedback.Text = ("QoL set to default");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // THEME CHECK LISTENER
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CheckRegistrySettingsTheme()
        {
            // Check for "SystemUsesLightTheme" and "AppsUseLightTheme"
            CheckRegistrySetting2(
                @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize",
                "SystemUsesLightTheme", 0,
                "AppsUseLightTheme", 0,
                checkDarkMode
            );

            // Check for "UseSystemAccentColor"
            CheckRegistrySetting(
                @"Software\Microsoft\Lighting",
                "UseSystemAccentColor",
                0,
                checkWindowsAccent
            );

            // Check for "NOC_GLOBAL_SETTING_ALLOW_NOTIFICATION_SOUND"
            CheckRegistrySetting(
                @"Software\Microsoft\Windows\CurrentVersion\Notifications\Settings",
                "NOC_GLOBAL_SETTING_ALLOW_NOTIFICATION_SOUND",
                0,
                checkNotifSound
            );

            // Check for "AmbientLightingEnabled"
            CheckRegistrySetting(
                @"Software\Microsoft\Lighting",
                "AmbientLightingEnabled",
                0,
                checkDynamicLight
            );

            // Check for "ControlledByForegroundApp"
            CheckRegistrySetting(
                @"Software\Microsoft\Lighting",
                "ControlledByForegroundApp",
                0,
                checkAppControlLights
            );

            // Check for "CNOC_GLOBAL_SETTING_ALLOW_TOASTS_ABOVE_LOCK"
            CheckRegistrySetting(
                @"Software\Microsoft\Windows\CurrentVersion\Notifications\Settings",
                "NOC_GLOBAL_SETTING_ALLOW_TOASTS_ABOVE_LOCK",
                0,
                checkLockScreenNotif
            );


            CheckArrowIconSetting(checkArrowIconsRemoved);

            CheckScrollbarWidthChange(checkScrollbarWidthChange);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // THEME DEFAULT VALUES
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button2_Click(object sender, EventArgs e)
        {
            // Dark Theme
            RestoreRegistryToDefault(
                @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize",
                "SystemUsesLightTheme", 
                1);

            RestoreRegistryToDefault(
                @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize",
                "AppsUseLightTheme",
                1);

            // AccentColor
            RestoreRegistryToDefault(
                @"Software\Microsoft\Lighting",
                "UseSystemAccentColor",
                1);

            // Check for "NOC_GLOBAL_SETTING_ALLOW_NOTIFICATION_SOUND"
            RestoreRegistryToDefault(
                @"Software\Microsoft\Windows\CurrentVersion\Notifications\Settings",
                "NOC_GLOBAL_SETTING_ALLOW_NOTIFICATION_SOUND",
                1);

            // Check for "AmbientLightingEnabled"
            RestoreRegistryToDefault(
                @"Software\Microsoft\Lighting",
                "AmbientLightingEnabled",
                1);

            //ControlledByForegroundApp
            RestoreRegistryToDefault(
                @"Software\Microsoft\Lighting",
                "ControlledByForegroundApp",
                1
            );

            //NotifSounds
            RestoreRegistryToDefault(
                @"Software\Microsoft\Windows\CurrentVersion\Notifications\Settings",
                "NOC_GLOBAL_SETTING_ALLOW_TOASTS_ABOVE_LOCK",
                1
            );

            //Scrollbar
            RestoreRegistryToDefault(
                @"Control Panel\Desktop\WindowMetrics",
                "ScrollWidth",
                -255);

            themeFeedback.Text = ("Theming set to default");

        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // PERFORMANCE DEFAULT VALUES
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button3_Click(object sender, EventArgs e)
        {
            //VideoQuality
            RestoreRegistryToDefault(
                @"Software\Microsoft\Windows\CurrentVersion\VideoSettings",
                "VideoQualityOnBattery", 
                0
               
            );

            // Gamebar
            RestoreRegistryToDefault(
                @"Software\Microsoft\GameBar",
                "UseNexusForGameBarEnabled",
                1
            );



            // CPU Priority
            RestoreRegistryToDefault(
                @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games",
                "Priority",
                5
            );

            // Auto Gamemode
            RestoreRegistryToDefault(
                @"Software\Microsoft\GameBar",
                "AutoGameModeEnabled",
                0
            );

            // GPU Prio
            RestoreRegistryToDefault(
                @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games",
                "GPU Priority",
                7
            );

            // Prio Separation
            RestoreRegistryToDefault(
                @"SYSTEM\CurrentControlSet\Control\PriorityControl",
                "Win32PrioritySeparation",
                2
            );

            performanceFeedback.Text = ("Performance set to default");
        }




        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // PERFORMANCE CHECK LISTENER
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CheckRegistrySettingsPerformance()
        {
            // Check for "VideoQualityOnBattery"
            CheckRegistrySetting(
                @"Software\Microsoft\Windows\CurrentVersion\VideoSettings",
                "VideoQualityOnBattery", 1,
                checkVideoBattery
            );

            // Check for "UseNexusForGameBarEnabled"
            CheckRegistrySetting(
                @"Software\Microsoft\GameBar",
                "UseNexusForGameBarEnabled",
                0,
                checkGameBar
            );




            // Check for "Priority"
            CheckRegistrySetting(
                @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games",
                "Priority",
                6,
                checkCPU
            );

            // Check for "AutoGameModeEnabled"
            CheckRegistrySetting(
                @"Software\Microsoft\GameBar",
                "AutoGameModeEnabled",
                1,
                checkGameMode
            );

            // Check for "GPU Priority"
            CheckRegistrySetting(
                @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games",
                "GPU Priority",
                8,
                checkGPU
            );

            // Check for "Win32PrioritySeparation"
            CheckRegistrySetting(
                @"SYSTEM\CurrentControlSet\Control\PriorityControl",
                "Win32PrioritySeparation",
                26,
                checkResourcePrio
            );
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // QUALITY OF LIFE FUNCTIONS 
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void buttonDisableSearchSuggestions_Click(object sender, EventArgs e)
        {
            // Registry modification code goes here
            string registryPath = @"SOFTWARE\Policies\Microsoft\Windows\Explorer";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        key.SetValue("DisableSearchBoxSuggestions", 1, RegistryValueKind.DWord);
                        qolFeedback.Text = ("Search Bar Suggestions have been disabled.");
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                qolFeedback.Text = ("Error: " + ex.Message + ". Try running the application as an administrator.");
            }
            catch (Exception ex)
            {
                qolFeedback.Text = ("Error: " + ex.Message + " has occured");
            }
        }

        private void buttonDisplayFileExtensions_Click(object sender, EventArgs e)
        {
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Enable File Extensions
                        key.SetValue("HideFileExt", 0, RegistryValueKind.DWord);
                        qolFeedback.Text = "File extensions are now displayed.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonTaskbarLeft_Click(object sender, EventArgs e)
        {
            // Registry modification code goes here
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        key.SetValue("TaskbarAl", 0, RegistryValueKind.DWord);
                        qolFeedback.Text = "Taskbar aligned to the left.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonDisableWindowsReplay_Click(object sender, EventArgs e)
        {
            string registryPath = @"Software\Policies\Microsoft\Windows\WindowsAI";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        key.SetValue("DisableAIDataAnalysis", 1, RegistryValueKind.DWord);
                        key.SetValue("TurnOffSavingSnapshots", 1, RegistryValueKind.DWord);
                        qolFeedback.Text = "Windows Replay has been disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }


        private void buttonDisableConsumerFeatures_Click(object sender, EventArgs e)
        {
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Disables tips, app suggestions, and other Start menu recommendations
                        key.SetValue("SoftLandingEnabled", 0, RegistryValueKind.DWord);
                        qolFeedback.Text = "Tips and app promotions have been disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonAdvertisingID_Click(object sender, EventArgs e)
        {
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo";

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Disables tips, app suggestions, and other Start menu recommendations
                        key.SetValue("Enabled", 0, RegistryValueKind.DWord);
                        qolFeedback.Text = "Windows Advertising ID has been disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonDisableLanguageList_Click(object sender, EventArgs e)
        {
            // Registry path for language access setting
            string registryPath = @"Control Panel\International\User Profile";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "LetAppsAccessLanguage" to 0 to disable language list access
                        key.SetValue("HttpAcceptLanguageOptOut", 1, RegistryValueKind.DWord);
                        qolFeedback.Text = "Access to the language list has been disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonDisableWindowsAppTracking_Click(object sender, EventArgs e)
        {
            // Registry path for the app tracking setting
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "LetAppsAccessLanguage" to 0 to disable language list access
                        key.SetValue("Start_TrackProgs", 0, RegistryValueKind.DWord);
                        qolFeedback.Text = "Windows tracking app launches has been disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonDisableSettingsNotifications_Click(object sender, EventArgs e)
        {
            // Registry path for the settings notification setting
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\SystemSettings\AccountNotifications";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "EnableAccountNotifications" to 0 to disable the setting
                        key.SetValue("EnableAccountNotifications", 0, RegistryValueKind.DWord);
                        qolFeedback.Text = "Settings notifications have been disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                qolFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // THEMING FUNCTIONS 
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void buttonEnableDark_Click(object sender, EventArgs e)
        {
            //Reg path for key
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "SystemUsesLightTheme" and "AppsUseLightTheme" to 0 to disable the setting
                        key.SetValue("SystemUsesLightTheme", 0, RegistryValueKind.DWord);
                        key.SetValue("AppsUseLightTheme", 0, RegistryValueKind.DWord);
                        themeFeedback.Text = "Dark mode enabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonDisableDynamicLight_Click(object sender, EventArgs e)
        {
            // Registry path for the key
            string registryPath = @"Software\Microsoft\Lighting";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "AmbientLightingEnabled" to 0 to disable the setting
                        key.SetValue("AmbientLightingEnabled", 0, RegistryValueKind.DWord);
                        themeFeedback.Text = "Dynamic Lighting disabled.";
                    }
                    else
                    {
                        themeFeedback.Text = "Unable to create or open the registry key.";
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonAppsControlLighting_Click(object sender, EventArgs e)
        {
            // Registry path for key
            string registryPath = @"Software\Microsoft\Lighting";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "ControlledByForegroundApp" to 0 to disable the setting
                        key.SetValue("ControlledByForegroundApp", 0, RegistryValueKind.DWord);
                        themeFeedback.Text = "Foregound app lighting control disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonDisableWindowsAccent_Click(object sender, EventArgs e)
        {
            // Registry path for key
            string registryPath = @"Software\Microsoft\Lighting";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "UseSystemAccentColor" to 0 to disable the setting
                        key.SetValue("UseSystemAccentColor", 0, RegistryValueKind.DWord);
                        themeFeedback.Text = "Matching Windows accent color disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonDisableNotifSound_Click(object sender, EventArgs e)
        {
            // Registry path for key
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\Notifications\Settings";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "NOC_GLOBAL_SETTING_ALLOW_NOTIFICATION_SOUND" to 0 to disable the setting
                        key.SetValue("NOC_GLOBAL_SETTING_ALLOW_NOTIFICATION_SOUND", 0, RegistryValueKind.DWord);
                        themeFeedback.Text = "Notification sounds disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonDisableLockNotif_Click(object sender, EventArgs e)
        {
            // Registry path for key
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\Notifications\Settings";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "NOC_GLOBAL_SETTING_ALLOW_TOASTS_ABOVE_LOCK" to 0 to disable the setting
                        key.SetValue("NOC_GLOBAL_SETTING_ALLOW_TOASTS_ABOVE_LOCK", 0, RegistryValueKind.DWord);
                        themeFeedback.Text = "Lock screen notifications disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                themeFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        //Special method to enable shortcut arrow checkbox within the GUI//
        private void CheckArrowIconSetting(CheckBox checkArrowIconsRemoved)
        {
            try
            {
                //values for path, valuename, expected value
                string registryPath = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons";
                string valueName = "29";
                string expectedValue = @"%windir%\System32\shell32.dll,-52";

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath))
                {
                    if (key != null)
                    {
                        object value = key.GetValue(valueName, null);

                        checkArrowIconsRemoved.Checked = value != null && value.Equals(expectedValue);
                    }
                    else
                    {
                        checkArrowIconsRemoved.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                //Error check
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void removeArrowIcon_Click(object sender, EventArgs e)
        {
            try
            {
                // Registry path for key
                string registryPath = @"Software\Microsoft\Windows\CurrentVersion\Explorer";

                // used to view and edit the registry in a 64 bit view
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                                             .OpenSubKey(registryPath, writable: true);

                if (key == null)
                {
                    // create new path if it doesn't already exist
                    key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                                      .CreateSubKey(registryPath);
                }

                // creating the subkey itself
                RegistryKey shellIconsKey = key.CreateSubKey("Shell Icons");

                // setting value
                shellIconsKey.SetValue("29", @"%windir%\System32\shell32.dll,-52");

                // Close the registry key
                shellIconsKey.Close();
                key.Close();


                themeFeedback.Text = "The 'Shell Icons' registry key and value have been added successfully!";

            }
            catch (Exception ex)
            {
                // Error check
                themeFeedback.Text = $"Error: {ex.Message}\nTry running the application as an administrator."; ;
            }


        }

        //Special method to enable the scrollbar checkbox within the GUI//
        private void CheckScrollbarWidthChange(CheckBox checkScrollbarWidthChange)
        {
            try
            {
                //reg path and value defined here
                string registryPath = @"Control Panel\Desktop\WindowMetrics";
                string valueName = "ScrollWidth";

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // read value as a string
                        object value = key.GetValue(valueName, null);

                        // Check if the value is not equal to the string "-255" (default size)
                        checkScrollbarWidthChange.Checked = value != null && value.ToString() != "-255";
                    }
                    else
                    {
                        // If the registry key doesn't exist, uncheck the checkbox
                        checkScrollbarWidthChange.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Error check
                themeFeedback.Text = $"Error: {ex.Message}\nTry running the application as an administrator.";
            }
        }


        private void editScrollbarWidth_Click(object sender, EventArgs e)
        {
            try
            {
                // Prompt the user to enter the desired scrollbar width in pixels
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter the desired scrollbar width in pixels (positive integer):",
                    "Set Scrollbar Width",
                    "15");

                // Validate the input
                if (int.TryParse(input, out int pixelValue) && pixelValue > 0)
                {
                    // conversion for registry UI (-15 = 1 pixel)
                    int registryValue = pixelValue * -15;

                    // Update the registry to adjust the scrollbar width
                    Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Desktop\WindowMetrics", "ScrollWidth", registryValue.ToString());


                    themeFeedback.Text = $"Scrollbar width has been set to {pixelValue} pixels.";
                }
                else
                {
                    // Handle invalid input
                    themeFeedback.Text = "Please enter a valid positive integer for the scrollbar width.";
                }
            }
            catch (Exception ex)
            {
                // Error Check
                themeFeedback.Text = $"Error: {ex.Message}\nTry running the application as an administrator.";
            }
        }

        //Special method for cursor button that creates a prompt for different type of cursors (arrow, hand, wait)//
        private bool PromptToChangeCursor(string cursorType)
        {
            // show message box asking user if they would like to change the cursor dependant on what type is currently on screen
            var result = MessageBox.Show($"Would you like to change the {cursorType} cursor?",
                                         $"Change {cursorType} Cursor",
                                         MessageBoxButtons.YesNo);
            return result == DialogResult.Yes; // Return true if Yes, false if No
        }

        //Special method for cursor button that creates a file directory window if user accepts prompt//
        private string SelectCursorFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a cursor file (.cur or .ani)";
                openFileDialog.Filter = "Cursor Files (*.cur;*.ani)|*.cur;*.ani";
                openFileDialog.Multiselect = false;

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return openFileDialog.FileName;  // Return the selected cursor file path
                }
                else
                {
                    return null; // Return null if the user cancels the file selection
                }
            }
        }

        // Method that applies the selected file to the registry //
        private void ApplyCursorToRegistry(string cursorType, string cursorFilePath)
        {
            // Registry path for key
            string registryPath = @"HKEY_CURRENT_USER\Control Panel\Cursors";

            // Apply the cursor file path dependant on cursor type
            Registry.SetValue(registryPath, cursorType, cursorFilePath);

        }

        private void changeCursor_Click(object sender, EventArgs e)
        {
            // Change Arrow cursor
            if (PromptToChangeCursor("Arrow"))
            {
                string arrowCursor = SelectCursorFile();
                if (arrowCursor != null)
                {
                    ApplyCursorToRegistry("Arrow", arrowCursor);
                    MessageBox.Show("Arrow cursor changed!");
                }
                else
                {
                    MessageBox.Show("Arrow cursor change skipped.");
                }
            }

            // Change Hand cursor
            if (PromptToChangeCursor("Hand"))
            {
                string handCursor = SelectCursorFile();
                if (handCursor != null)
                {
                    ApplyCursorToRegistry("Hand", handCursor);
                    MessageBox.Show("Hand cursor changed!");
                }
                else
                {
                    MessageBox.Show("Hand cursor change skipped.");
                }
            }

            // Change Wait cursor
            if (PromptToChangeCursor("Wait"))
            {
                string waitCursor = SelectCursorFile();
                if (waitCursor != null)
                {
                    ApplyCursorToRegistry("Wait", waitCursor);
                    MessageBox.Show("Wait cursor changed!");
                }
                else
                {
                    MessageBox.Show("Wait cursor change skipped.");
                }
            }
            themeFeedback.Text = "Cursor was changed";
        }







        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // PERFORMANCE FUNCTIONS 
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void buttonOptimizeBatteryVideo_Click(object sender, EventArgs e)
        {
            // Registry path for the settings notification setting
            string registryPath = @"Software\Microsoft\Windows\CurrentVersion\VideoSettings";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "VideoQualityOnBattery" to 1 to optimize the setting
                        key.SetValue("VideoQualityOnBattery", 1, RegistryValueKind.DWord);
                        performanceFeedback.Text = "Video playback optimized.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonEnableGameMode_Click(object sender, EventArgs e)
        {
            // Registry path for the settings notification setting
            string registryPath = @"Software\Microsoft\GameBar";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "AutoGameModeEnabled" to 1 to optimize the setting
                        key.SetValue("AutoGameModeEnabled", 1, RegistryValueKind.DWord);
                        performanceFeedback.Text = "Game mode enabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonDisableGameBar_Click(object sender, EventArgs e)
        {
            // Registry path for the settings notification setting
            string registryPath = @"Software\Microsoft\GameBar";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "AutoGameModeEnabled" to 0 to optimize the setting
                        key.SetValue("UseNexusForGameBarEnabled", 0, RegistryValueKind.DWord);
                        performanceFeedback.Text = "Game bar disabled.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void performanceGPUPrio_Click(object sender, EventArgs e)
        {
            // Registry path for the settings notification setting
            string registryPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "AutoGameModeEnabled" to 8 to optimize the setting
                        key.SetValue("GPU Priority", 8, RegistryValueKind.DWord);
                        performanceFeedback.Text = "GPU performance optimized.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonCPUPrio_Click(object sender, EventArgs e)
        {
            // Registry path for the settings notification setting
            string registryPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "Priority" to 6 to optimize the setting
                        key.SetValue("Priority", 6, RegistryValueKind.DWord);
                        performanceFeedback.Text = "CPU performance optimized.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void buttonPrioAdjust_Click(object sender, EventArgs e)
        {
            // Registry path for the settings notification setting
            string registryPath = @"SYSTEM\CurrentControlSet\Control\PriorityControl";

            try
            {
                // Open the registry key for the current user
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
                {
                    if (key != null)
                    {
                        // Set "Win32PrioritySeparation" to 26 to optimize the setting
                        key.SetValue("Win32PrioritySeparation", 26, RegistryValueKind.DWord);
                        performanceFeedback.Text = "Current open application is now prioritized.";
                    }
                    else
                    {
                        MessageBox.Show("Unable to create or open the registry key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + ". Try running the application as an administrator.";
            }
            catch (Exception ex)
            {
                performanceFeedback.Text = "Error: " + ex.Message + " has occurred.";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }  
}
    

