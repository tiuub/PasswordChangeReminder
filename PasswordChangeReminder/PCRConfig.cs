using KeePass.App.Configuration;
using KeePass.Plugins;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChangeReminder
{
    public class PCRConfig
    {
        private AceCustomConfig m_config = null;
        public PCRConfig(IPluginHost host)
        {
            m_config = host.CustomConfig;
        }

        private const String XMLPATH_PLUGINNAME = "PasswordChangeReminder";
        private const String XMLPATH_CHECK_ON_STARTUP = XMLPATH_PLUGINNAME + ".CheckOnStartup";
        private const String XMLPATH_CHECK_ON_STARTUP_DAYS = XMLPATH_PLUGINNAME + ".CheckOnStartupDays";
        private const String XMLPATH_PCR_PASSWORDS_FORM_HEIGHT = XMLPATH_PLUGINNAME + ".PCRPasswordsFormHeight";
        private const String XMLPATH_PCR_PASSWORDS_FORM_GREAT_COLOR = XMLPATH_PLUGINNAME + ".PCRPasswordsFormGreatColor";
        private const String XMLPATH_PCR_PASSWORDS_FORM_TENTATIVE_COLOR = XMLPATH_PLUGINNAME + ".PCRPasswordsFormTentativeColor";
        private const String XMLPATH_PCR_PASSWORDS_FORM_CRITICAL_COLOR = XMLPATH_PLUGINNAME + ".PCRPasswordsFormCriticalColor";
        private const String XMLPATH_PCR_PASSWORDS_FORM_TENTATIVE_STATE = XMLPATH_PLUGINNAME + ".PCRPasswordsFormTentativeState";
        private const String XMLPATH_PCR_PASSWORDS_FORM_CRITICAL_STATE = XMLPATH_PLUGINNAME + ".PCRPasswordsFormCriticalState";

        public bool checkOnStartup
        {
            get
            {
                return m_config.GetBool(XMLPATH_CHECK_ON_STARTUP, true);
            }
            set
            {
                m_config.SetBool(XMLPATH_CHECK_ON_STARTUP, value); ;
            }
        }

        public int checkOnStartupDays
        {
            get
            {
                return (int)m_config.GetLong(XMLPATH_CHECK_ON_STARTUP_DAYS, 5);
            }
            set
            {
                m_config.SetLong(XMLPATH_CHECK_ON_STARTUP_DAYS, value); ;
            }
        }

        public int pcrPasswordsFormHeight
        {
            get
            {
                return (int)m_config.GetLong(XMLPATH_PCR_PASSWORDS_FORM_HEIGHT, 300);
            }
            set
            {
                m_config.SetLong(XMLPATH_PCR_PASSWORDS_FORM_HEIGHT, value); ;
            }
        }

        public Color pcrPasswordsFormGreatColor
        {
            get
            {
                return Color.FromArgb((int)m_config.GetLong(XMLPATH_PCR_PASSWORDS_FORM_GREAT_COLOR, Color.LightGreen.ToArgb()));
            }
            set
            {
                m_config.SetLong(XMLPATH_PCR_PASSWORDS_FORM_GREAT_COLOR, value.ToArgb()); ;
            }
        }

        public Color pcrPasswordsFormTentativeColor
        {
            get
            {
                return Color.FromArgb((int)m_config.GetLong(XMLPATH_PCR_PASSWORDS_FORM_TENTATIVE_COLOR, Color.LightGoldenrodYellow.ToArgb()));
            }
            set
            {
                m_config.SetLong(XMLPATH_PCR_PASSWORDS_FORM_TENTATIVE_COLOR, value.ToArgb()); ;
            }
        }

        public Color pcrPasswordsFormCriticalColor
        {
            get
            {
                return Color.FromArgb((int)m_config.GetLong(XMLPATH_PCR_PASSWORDS_FORM_CRITICAL_COLOR, Color.LightSalmon.ToArgb()));
            }
            set
            {
                m_config.SetLong(XMLPATH_PCR_PASSWORDS_FORM_CRITICAL_COLOR, value.ToArgb()); ;
            }
        }

        public int pcrPasswordsFormTentativeState
        {
            get
            {
                return (int)m_config.GetLong(XMLPATH_PCR_PASSWORDS_FORM_TENTATIVE_STATE, 10);
            }
            set
            {
                m_config.SetLong(XMLPATH_PCR_PASSWORDS_FORM_TENTATIVE_STATE, value); ;
            }
        }

        public int pcrPasswordsFormCriticalState
        {
            get
            {
                return (int)m_config.GetLong(XMLPATH_PCR_PASSWORDS_FORM_CRITICAL_STATE, 0);
            }
            set
            {
                m_config.SetLong(XMLPATH_PCR_PASSWORDS_FORM_CRITICAL_STATE, value); ;
            }
        }
    }
}
