using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SantaLilShop
{
    

    public partial class Form1 : Form
    {
        private string connString;


        public Form1()
        {

            connString = ConfigurationManager.ConnectionStrings["SantaLilShopProperties.Settings.conString"].ConnectionString;
            InitializeComponent();
            panel2.Enabled = false;
        }



        static void basedados()
        {
            string Cnstring = "Data Source=.\\SQLEXPRESS;Initial Catalog=ListaPaiNatal;Integrated Security=true;TrustServerCertificate=true;MultipleActiveResultSets=True;";
            SqlConnection dbCn = new SqlConnection(Cnstring);
            dbCn.Open();
        }







            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void button4_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                panel1.Enabled = false;
                panel2.Enabled = true;

            }



            private void button6_Click(object sender, EventArgs e)
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
            }

            private void button5_Click(object sender, EventArgs e)
            {
            SqlConnection sqlConn = new SqlConnection(connString);

            sqlConn.Open();
            string qur = "INSERT INTO presentes VALUES ('" + richTextBox1.Text + "','" + richTextBox2.Text + "','" + Convert.ToInt32(checkBox1.Checked) + "')";
            SqlCommand cmd = new SqlCommand(qur, sqlConn);
            cmd.ExecuteNonQuery();
            sqlConn.Close();

            MessageBox.Show("Adicionado com sucesso.");
            textBox1.Text = "";
            checkBox1.Checked = false;
            panel2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(connString);
            string qur = "DELETE FROM presentes (nome, presente, carvao) = '" + richTextBox1.Text + "','" + richTextBox2.Text + "'," + Convert.ToInt32(checkBox1.Checked) + "";
            SqlCommand cmdDel = new SqlCommand(qur, sqlConn);
            cmdDel.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listaPaiNatalDataSet.presentes' table. You can move, or remove it, as needed.
            this.presentesTableAdapter.Fill(this.listaPaiNatalDataSet.presentes);

        }
    }
}
