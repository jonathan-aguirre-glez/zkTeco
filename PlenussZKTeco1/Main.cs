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
        DispositivoZK Dispositivos = new DispositivoZK("Matriz","192.168.1.201",4370);

        ODBCWrapper conexion = new ODBCWrapper("config.ini");
        ContextMenu mnuContextMenu = new ContextMenu();
        public Main()
        {
            InitializeComponent();
            connect();
           

             
          

        }
         async Task connect(DispositivoZK disp)
        {
            await Task.Run(() =>
            {
                toolStripStatusLabel1.Text = "Conectando dispositivo";
                if (Dispositivos.Connect_Net("192.168.1.201", 4370)) MessageBox.Show("Conectado");
                else
                {
                    MessageBox.Show("No");
                    toolStripStatusLabel1.Text = "Error al conectarse";
                }
            });
                
      
            
        }

        private void Dispositivos_OnDisConnected()
        {
            MessageBox.Show("Desconectado");
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion conf = new Configuracion();
            conf.Tag = this;
            conf.Show(this);
            Hide();
        }

        public void connect()
        {
            Cursor = Cursors.AppStarting;
            if (conexion.connect()) MessageBox.Show("Conexion Establecida");
            else MessageBox.Show("Error en la conexion");
            Cursor = Cursors.Default;
            OdbcDataReader data = conexion.executeQuery("select * from p_disp;");
            object[] meta = new object[6];

            while (data.Read())
            {
                data.GetValues(meta);
                dataGridView1.Rows.Add(meta);
                //Console.WriteLine(meta[1]);
            }

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await connect(Dispositivos);
        }
    }
}
