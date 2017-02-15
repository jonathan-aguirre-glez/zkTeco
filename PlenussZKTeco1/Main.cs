using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using IniParser;
using IniParser.Model;
using System.Data.Odbc;

namespace PlenussZKTeco1
{
    public partial class Main : Form
    {
        OdbcConnection conex;   
        public Main()
        {
            InitializeComponent();
            if (File.Exists(Environment.CurrentDirectory + "\\config.ini"))
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile("config.ini");
                string odbc = data["Base"]["ODBC"];
                MessageBox.Show(odbc);
                conex = new OdbcConnection("Provider=SQLNCLI10;Data Source=" + odbc);
                try
                {
                    MessageBox.Show("Server=RGARCIA-PC\\AVATTIA;Database=ZKTeko;User Id=sa;Password = aitva; ");
                    conex.Open();
                        }
                catch (Exception) {
                    MessageBox.Show("No se pudo conectar a la base de datos");
                }
                conex.Close();
            }
            else {
                Configuracion config = new Configuracion();
                config.ShowDialog();
            }
            

        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
