using KeePass.Forms;
using KeePass.Plugins;
using KeePass.UI;
using KeePassLib;
using KeePassLib.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordChangeReminder
{
    class Tools
    {
        private static bool OptionsEnabled = (KeePass.Program.Config.UI.UIFlags & (ulong)KeePass.App.Configuration.AceUIFlags.DisableOptions) != (ulong)KeePass.App.Configuration.AceUIFlags.DisableOptions;
        public static object GetField(string field, object obj)
        {
            BindingFlags bf = BindingFlags.Instance | BindingFlags.NonPublic;
            return GetField(field, obj, bf);
        }

        public static object GetField(string field, object obj, BindingFlags bf)
        {
            if (obj == null) return null;
            FieldInfo fi = obj.GetType().GetField(field, bf);
            if (fi == null) return null;
            return fi.GetValue(obj);
        }

        public static Control GetControl(string control)
        {
            return GetControl(control, KeePass.Program.MainForm);
        }

        public static Control GetControl(string control, Control form)
        {
            if (form == null) return null;
            if (string.IsNullOrEmpty(control)) return null;
            Control[] cntrls = form.Controls.Find(control, true);
            if (cntrls.Length == 0) return null;
            return cntrls[0];
        }

        public static int calculateAge(PwEntry pe)
        {
            DateTime dateLastModified = pe.LastModificationTime;
            string strPassword = pe.Strings.ReadSafe(PwDefs.PasswordField);
            int iPasswordAge = DateTime.Now.Subtract(dateLastModified).Days;
            foreach (PwEntry tmpPe in pe.History.ToArray().Reverse())
            {
                if (tmpPe.Strings.ReadSafe(PwDefs.PasswordField) == strPassword)
                {
                    dateLastModified = tmpPe.LastModificationTime;
                    iPasswordAge = DateTime.Now.Subtract(dateLastModified).Days;
                }
                else
                {
                    break;
                }
            }

            return iPasswordAge;
        }

        public static PwObjectList<PwEntry> GetExpiringPasswords(IPluginHost m_host)
        {
            SearchParameters sp = SearchParameters.None.Clone();
            sp.SearchInStringNames = true;
            sp.ComparisonMode = StringComparison.CurrentCulture;
            sp.RegularExpression = true;
            sp.SearchString = "^" + PasswordChangeReminderExt._EntryStringKey + "$";

            PwObjectList<PwEntry> listResult = new PwObjectList<PwEntry>();
            m_host.Database.RootGroup.SearchEntries(sp, listResult);

            return listResult;
        }
    }
}
