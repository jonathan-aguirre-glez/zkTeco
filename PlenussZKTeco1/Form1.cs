using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlenussZKTeco1
{
    public partial class Form1 : Form
    {
        string connetionString = "Data Source=SERVERAVATTIA;Initial Catalog =EjerciciosJonathan; User ID =sa; Password=aitva;Server=SERVERAVATTIA\\AVATTIA";
        public Form1()
        {
            InitializeComponent();
            portTB.Text = Properties.Settings.Default.Puerto;
            ipTB.Text = Properties.Settings.Default.IP;
            aparato.OnAttTransactionEx += Aparato_OnAttTransactionEx;


        }

        private async void Aparato_OnAttTransactionEx(string EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second, int WorkCode)
        {
            await Imprimir(EnrollNumber);
        }

        private static Task Imprimir(String numero)
        {
            return Task.Run(()=> {
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine(numero);  });
        }
        private void Aparato_OnAttTransaction(int EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second)
        {
            MessageBox.Show(Convert.ToString(EnrollNumber));
        }

        public zkemkeeper.CZKEMClass aparato = new zkemkeeper.CZKEMClass();
        
        

        #region Communication
        private bool bIsConnected = false;
        private int iMachineNumber = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Conectado");
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se conecto a la base de datos");
            }
            if(IpLabel.Text.Trim() == "" || portLabel.Text.Trim() == "")
            {
                MessageBox.Show("Llege por favor el puerto e IP","Error");
                return;
            }
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            if(conectarBtn.Text == "DisConnect")
            {
                aparato.Disconnect();
                bIsConnected = false;
                conectarBtn.Text = "Conectar";
                Cursor = Cursors.Default;
                return;
            }

            bIsConnected = aparato.Connect_Net(ipTB.Text, Convert.ToInt32(portTB.Text));
            Properties.Settings.Default.IP = ipTB.Text;
            Properties.Settings.Default.Puerto = portTB.Text;
            Properties.Settings.Default.Save();
            if (bIsConnected == true)
            {
                conectarBtn.Text = "DisConnect";
                conectarBtn.Refresh();
                //.Text = "Current State:Connected";
                iMachineNumber = 1;
                aparato.RegEvent(iMachineNumber, 65535);
            }
            else
            {
                aparato.GetLastError(ref idwErrorCode);
                MessageBox.Show("No se pudo conectar el dispositivo, Codigo de Error = " + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }
        #endregion

   
    }
}
