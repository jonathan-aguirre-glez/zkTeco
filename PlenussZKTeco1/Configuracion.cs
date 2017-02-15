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
        public Configuracion()
        {
            InitializeComponent();
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
            parser.WriteFile("config.ini", data);
            MessageBox.Show("Se guardo la configuracion");
        }
    }
}
