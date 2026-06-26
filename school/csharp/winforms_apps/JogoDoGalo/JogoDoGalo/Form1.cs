using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDoGalo
{
    public partial class Form1: Form    
    {

        

      
        public Form1()
        {
            InitializeComponent();

           foreach(var item in Controls)
            {
                if( (item is Button) && ((item as Button).Text == "X"))
                {
                    (item as Button).Text = "";
                }
            }
        }

       

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "O";
        }
    }
}
