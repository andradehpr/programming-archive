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


namespace ProjetoF
{
    public partial class BEFORM : Form
    {



        public BEFORM()
        {


            InitializeComponent();
            signpanel.Hide();
            loginpanel.Show();

        }


        private void BERECOGNIZED_Load(object sender, EventArgs e)
        {
           

        }

        public class Dados
        {
            public string id_utlizador { get; set; }

           

        }

        public string username1 { get; set; }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            signpanel.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signpanel.Hide();
            loginpanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        INFORM f3 = new INFORM();

        

        public static string username2 { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

            Dados dados = new Dados();
            username2 = usernamestextBox.Text;

            if (usernamestextBox.Text == "" || passwordstextBox.Text == "")
            {
                MessageBox.Show("Campos Obrigatórios por preencher!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passwordstextBox.Text != passwordschecktextBox.Text)
            {
                MessageBox.Show("Passwords Diferentes!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordstextBox.Clear();
                passwordschecktextBox.Clear();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    

                        cmd.CommandText = @"insert into utilizador(username,pass)
                                    values (@username,@pass)";

                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = usernamestextBox.Text;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = passwordstextBox.Text;


                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Registo efetuado com sucesso!", "INFO",MessageBoxButtons.OK, MessageBoxIcon.Information);


                        loginpanel.Visible = true;
                        signpanel.Visible = false;
                   


                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)

                        connection.Close();
                }

                

            }

        }




       




        private void button3_Click_1(object sender, EventArgs e)
        {




            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

            if (passwordltextBox.Text == "" || usernameltextBox.Text == "")
            {
                MessageBox.Show("You think your smarter than me?", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();

                    cmd.CommandText = @"select *
                        from utilizador
                        where username = @username
                        and
                        pass = @pass";


                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = usernameltextBox.Text;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = passwordltextBox.Text;
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        MessageBox.Show("Bem-Vindo à BE RECOGNIZED!","WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        f3 = new INFORM();
                        loginpanel.Hide();
                        signpanel.Hide();
                        f3.Show();
                        this.Hide();
                        


                    }
                    else if (rd.Read() == false)
                    {
                        MessageBox.Show("Nome ou senha invalidos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordltextBox.Clear();
                        usernameltextBox.Clear();

                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)

                        connection.Close();
                }
            }
            Dados dados = new Dados();

            
            f3.username1 = usernameltextBox.Text;

        }


        
        

        private void button5_Click(object sender, EventArgs e)
        {
            ADMINFORM f4 = new ADMINFORM();
            f4.Show();
        }

    }
    }


    







