using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlenussZKTeco1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public zkemkeeper.CZKEMClass aparato = new zkemkeeper.CZKEMClass();


        #region Communication
        private bool bIsConnected = false;
        private int iMachineNumber = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write("Hola");
        }
        #endregion
    }
}
