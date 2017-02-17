using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlenussZKTeco1
{
    public partial class Configuracion : Form
    {
        FileIniDataParser parser;
        IniData data;
        public Configuracion()
        {
            InitializeComponent();
            if (File.Exists("config.ini"))
            {
                parser = new FileIniDataParser();
                data = parser.ReadFile("config.ini");
                odbcTb.Text = data["Base"]["ODBC"];
                userTb.Text = data["Base"]["UID"];
                passwordTb.Text = data["Base"]["PWD"]; 
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists("config.ini"))
            {
                File.Create("config.ini").Close();
            }
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("config.ini");
            data.Sections.AddSection("Base");
            data.Sections.GetSectionData("Base").Keys.AddKey("ODBC", odbcTb.Text);
            data.Sections.GetSectionData("Base").Keys.AddKey("UID", userTb.Text);
            data.Sections.GetSectionData("Base").Keys.AddKey("PWD", passwordTb.Text);
            parser.WriteFile("config.ini", data);
            MessageBox.Show("Se guardo la configuracion");
            var main = (Main)Tag;
            main.Show();
            Close();
            main.connect();
        }
    }
}
