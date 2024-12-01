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
            // Registry path for the settings notification setting
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
            // Registry path for the settings notification setting
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

        private void buttonAppsControlLighting_Click(object sender, EventArgs e)
        {
            // Registry path for the settings notification setting
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
            // Registry path for the settings notification setting
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
            // Registry path for the settings notification setting
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
            // Registry path for the settings notification setting
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
    }
}
