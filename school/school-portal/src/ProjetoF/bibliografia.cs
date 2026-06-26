using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;
namespace ProjetoF
{
    public partial class Bibliografia : Form
    {
        public Bibliografia()
        {
            InitializeComponent();





        }


        private void Bibliografia_Load(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (1 * 60 * 1000);
            MyTimer.Tick += new EventHandler(timer1_Tick);
            MyTimer.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Close();
        }


    }
}
