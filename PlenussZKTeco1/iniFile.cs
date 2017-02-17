using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlenussZKTeco1
{
    class IniFile
    {

        /// <summary> 
        /// Store for the name property.</summary> 
        private string ConfigurationFile;

        private string ODBC;
        private string UID;
        private string Password;

        /// <summary> 
        /// Receives a file path to the Ini file.</summary> 
        public IniFile(string FilePath)
        {
            ConfigurationFile = FilePath;

        }

        /// <summary> 
        /// Receives a file path to the Ini file.</summary> 
        public Boolean setConfiguration(string ODBC, string UID, string Password)
        {
            if (String.IsNullOrWhiteSpace(ODBC) || String.IsNullOrWhiteSpace(UID) || String.IsNullOrWhiteSpace(Password))
                return false;
            if (!File.Exists(Environment.CurrentDirectory + "\\" + this.ConfigurationFile))
            {
                File.Create(ConfigurationFile).Close();
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(ConfigurationFile);
                data.Sections.AddSection("Base");
                data.Sections.GetSectionData("Base").Keys.AddKey("ODBC", ODBC);
                data.Sections.GetSectionData("Base").Keys.AddKey("UID", UID);
                data.Sections.GetSectionData("Base").Keys.AddKey("PWD", Password);
                parser.WriteFile(ConfigurationFile, data);
            }
            else
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("config.ini");
                data["Base"]["ODBC"] = ODBC;
                data["Base"]["UID"] = UID;
                data["Base"]["PWD"] = Password;
                parser.WriteFile(ConfigurationFile, data);
            }
            return true;
        }

        private IniData readConfig()
        {
            if (File.Exists(Environment.CurrentDirectory + "\\" + this.ConfigurationFile))
            {
                FileIniDataParser parser = new FileIniDataParser();
                IniData data = parser.ReadFile(ConfigurationFile);
                ODBC = data["Base"]["ODBC"];
                UID = data["Base"]["UID"];
                Password = data["Base"]["PWD"];
                return data;
            }
            else
                return null;
        }
    }
}
