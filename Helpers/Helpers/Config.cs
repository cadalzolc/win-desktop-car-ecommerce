using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class Config
    {
        public static string GetValue(string Key)
        {
            return ConfigurationManager.AppSettings[Key].ToNullString();
        }

        public static bool SetValue(string Key, string Value)
        {
            try
            {
                var Cnf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                Cnf.AppSettings.Settings[Key].Value = Value;
                Cnf.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
