using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlenussZKTeco1
{
    /// <summary> 
    /// Forms a wrapper with the ODBC and the Ini File </summary> 
    /// <remarks> 
    /// Longer comments can be associated with a type or member through 
    /// the remarks tag.</remarks> 
    class ODBCWrapper
    {
        /// <summary> 
        /// Store for the name property.</summary> 
        private string ConfigurationFile;

        private string ODBC;
        private string UID;
        private string Password;
        private OdbcConnection conexion;

        public ODBCWrapper(string FilePath)
        {
            ConfigurationFile = FilePath;
            
        }

        public Boolean setConfiguration(string ODBC,string UID,string Password)
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
            }else
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("config.ini");
                data["Base"]["ODBC"] = ODBC;
                data["Base"]["UID"] = UID;
                data["Base"]["PWD"] = Password;
                parser.WriteFile(ConfigurationFile, data);
            }
            return readConfig();
        }

        private bool readConfig()
        {
            if (File.Exists(Environment.CurrentDirectory + "\\" + this.ConfigurationFile))
            {
                FileIniDataParser parser = new FileIniDataParser();
                IniData data = parser.ReadFile(ConfigurationFile);
                ODBC = data["Base"]["ODBC"];
                UID = data["Base"]["UID"];
                Password = data["Base"]["PWD"];
                return true;
            }
            else
                return false;
        }

        public bool connect()
        {
            if (String.IsNullOrEmpty(ODBC) || String.IsNullOrEmpty(UID) || String.IsNullOrEmpty(Password))
                if (!readConfig())
                {
                    throw new Exception("No configuration file");
                }

            conexion = new OdbcConnection($"DSN={ODBC};UID={UID};PWD={Password};");
            try
            {
                conexion.Open();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public OdbcDataReader executeQuery(string command) { 
            OdbcCommand comm = new OdbcCommand(command,conexion);
            return comm.ExecuteReader();
        }
    }
}
