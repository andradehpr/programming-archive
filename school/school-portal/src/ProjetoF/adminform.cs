using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ProjetoF
{
    public partial class ADMINFORM : Form
    {
        public ADMINFORM()
        {
            InitializeComponent();
            adminpanel.Visible = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox4.Text;
            string pass = textBox3.Text;


            if(username == "admin" && pass == "admin")
            {
                adminpanel.Visible = true;
            }
            else
            {
                MessageBox.Show("You think your smarter than me?", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void procurarbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

            connection.Open();
            SqlCommand cmd = new SqlCommand("Select id, username, email, morada1, morada2, conselho, cidade, codigo_postal, genero, dia, mes, ano, anoescolar, telemovel, pais_estudo1, pais_estudo2, pais_estudo3, faculdade, funcao  from utilizador", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ForeColor = Color.Black;
        
        }

        private void apagarbutton_Click(object sender, EventArgs e)
        {

            if (IDtextBox.Text == "")
            {
                MessageBox.Show("Campos Obrigatórios por preencher! 'ID' ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

                connection.Open();
                SqlCommand cmd = new SqlCommand("delete utilizador where id=@id", connection);
                cmd.Parameters.AddWithValue("@id", int.Parse(IDtextBox.Text));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Apagado com sucesso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
