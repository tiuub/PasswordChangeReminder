using KeePass.App.Configuration;
using KeePass.Plugins;

using System;
using System.Collections.Generic;
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
        private const String XMLPATH_PCR_PASSWORDS_FORM_HEIGHT = XMLPATH_PLUGINNAME + ".PCRPasswordsFormHeight";

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
    }
}
