using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChangeReminder
{
    class PCRStatics
    {
        public const string PluginName = "PasswordChangeReminder";
        public const string PluginNameShort = "PCR";
        public const string PluginRepository = "https://github.com/tiuub/PasswordChangeReminder";
        public const string PluginUpdateUrl = "https://raw.githubusercontent.com/tiuub/PasswordChangeReminder/master/VERSION";
        public const string RepositoryLicenseLink = PluginRepository + "#license";
        public const string ColumnName = "Renew Password in";


        public static readonly string OK = "OK";
        public static readonly string Close = "Close";
        public static readonly string Reset = "Reset";
        public static readonly string Donate = "Donate";
        public static readonly string DonateLink = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=5F5QB7744AD5G&source=url";
        public static readonly string Today = "Today";
        public static readonly string Days = "Days";
        public static readonly string Name = "Name";
        public static readonly string Soon = "Soon";
        public static readonly string Created = "Created";
        public static readonly string LastModified = "Last Modified";
        public static readonly string Dependencies = "Dependencies";
        public static readonly string Dependencie = "Dependencie";
        public static readonly string Author = "Author";
        public static readonly string License = "License";
        public static readonly string GitHubRepository = "GitHub Repository";
        public static readonly string Error = "Error";
        public static readonly string Placeholder = "...";

        public static readonly string Overview = "Overview";
        public static readonly string OverviewSubline = "This is a overview of all your configured entries.";
        public static readonly string OverviewShow = "Show Overview";
        public static readonly string OverviewEntriesListDescription = "Entries list and when you have to renew them:";
        public static readonly string OverviewColumnNextChangeIn = "Next change in";
        public static readonly string OverviewColumnAge = "Password age";
        public static readonly string OverviewColumnRemindEvery = "Remind every";
        public static readonly string OverviewNothingConfigured = "Nothing configured";

        public static readonly string Settings = "Settings";
        public static readonly string SettingsSubline = "Here you can customize some settings.";

        public static readonly string About = "About";
        public static readonly string AboutSubline = "PasswordChangeReminder Plugin.";
        public static readonly string AboutDisclaimer = "PasswordChangeReminder by tiuub.\nVersion: {0}\nLicense: MIT";
        public static readonly string AboutMessageBoxOpenRepository = "The GitHub Repository will now be opened.\nYou can open the ReadMe and scroll down, until you see Dependencies. There you will find references to the source code, the author and the license of the dependencies.\n\nDo you want to continue?";
        public static readonly string AboutMessageBoxCantLoadLicense = "Cant load license of {0}.\n\nJust try to open the GitHub Repository and scroll down, until Dependencies.There are all licenses!";

        public static readonly string AddEditFormRemindIn = "Remind changing password every (in days):";
    }
}
