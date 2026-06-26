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
    public partial class INFORM : Form
    {
        
        public string username1 { get; set; }

        
        
       
        
        public string email { get; set; }

        public string telemovel { get; set; }
        
        
        
       



        class dados
        {
            public string nome { get; set; }
            public string email { get; set; }
            public string telemovel { get; set; }
            public string desporto { get; set; }
            public string dia { get; set; }
            public string mes { get; set; }
            public string ano { get; set; }
            public string morada1 { get; set; }
            public string morada2 { get; set; }
            public string cidade { get; set; }
            public string conselho { get; set; }
            public string genero { get; set; }
            public string anoescolar { get; set; }
            public string codigo_postal { get; set; }
            public string pais_estudo1 { get; set; }
            public string pais_estudo2 { get; set; }
            public string pais_estudo3 { get; set; }
            public string faculdade { get; set; }
            public string funcao { get; set; }
        }


        public INFORM()
        {
            InitializeComponent();

            telemovelptextBox.Enabled = false;
            emailptextBox.Enabled = false;


           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bepanel.Visible = true;
            bolsapanel.Visible = false;

         }


        private void pROCURADEBOLSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bolsapanel.Visible = true;
            emprestimospanel.Visible = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

            dados dados = new dados();

            morada1textBox.Enabled = false;
            morada2textBox.Enabled = false;
            cidadetextBox.Enabled = false;
            conselhotextBox.Enabled = false;
            telemoveltextBox.Enabled = false;
            nomedtextBox.Enabled = false;
            codigo_postaltextbox.Enabled = false;
            emailtextBox.Enabled = false;
            nometextBox.Enabled = false;

            desportocomboBox.Enabled = false;
            pais1comboBox.Enabled = false;
            pais2comboBox.Enabled = false;
            pais3comboBox.Enabled = false;
            mescomboBox.Enabled = false;
            anocomboBox.Enabled = false;
            generocomboBox.Enabled = false;
            diacomboBox.Enabled = false;
            anoescolarcomboBox.Enabled = false;


            try
            {


                string query = "SELECT desporto ,dia ,mes ,ano ,morada1 ,morada2 ,cidade ,conselho  ,telemovel ,genero ,anoescolar ,codigo_postal ,email ,nome ,pais_estudo1 , pais_estudo2 , pais_estudo3 from utilizador where username = @username";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username1;
                SqlDataReader myreader;
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    dados.desporto = myreader["desporto"].ToString();
                    dados.dia = myreader["dia"].ToString();
                    dados.mes = myreader["mes"].ToString();
                    dados.ano = myreader["ano"].ToString();
                    dados.morada1 = myreader["morada1"].ToString();
                    dados.morada2 = myreader["morada2"].ToString();
                    dados.cidade = myreader["cidade"].ToString();
                    dados.conselho = myreader["conselho"].ToString();
                    dados.telemovel = myreader["telemovel"].ToString();
                    dados.genero = myreader["genero"].ToString();
                    dados.anoescolar = myreader["anoescolar"].ToString();
                    dados.codigo_postal = myreader["codigo_postal"].ToString();
                    dados.pais_estudo1 = myreader["pais_estudo1"].ToString();
                    dados.pais_estudo2 = myreader["pais_estudo2"].ToString();
                    dados.pais_estudo3 = myreader["pais_estudo3"].ToString();
                    dados.nome = myreader["nome"].ToString();
                    dados.email = myreader["email"].ToString();



                }

                desportocomboBox.Text = dados.desporto;
                diacomboBox.Text = dados.dia;
                mescomboBox.Text = dados.mes;
                anocomboBox.Text = dados.ano;
                morada1textBox.Text = dados.morada1;
                morada2textBox.Text = dados.morada2;
                cidadetextBox.Text = dados.cidade;
                conselhotextBox.Text = dados.conselho;
                telemoveltextBox.Text = dados.telemovel;
                generocomboBox.Text = dados.genero;
                anoescolarcomboBox.Text = dados.anoescolar;
                pais1comboBox.Text = dados.pais_estudo1;
                pais2comboBox.Text = dados.pais_estudo2;
                pais3comboBox.Text = dados.pais_estudo3;
                nometextBox.Text = dados.nome;
                codigo_postaltextbox.Text = dados.codigo_postal;
                emailtextBox.Text = dados.email;



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

        private void bERECOGNIZEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bolsapanel.Visible = false;
            bepanel.Visible = true;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bolsapanel.Visible = false;
            bepanel.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bepanel.Visible = true;
        }

        private void label26_Click(object sender, EventArgs e)
        {
           

        }

        private void label25_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label24_Click(object sender, EventArgs e)
        {
            

        }



        

        private void eMPRÉSTIMOSAESTUDANTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bolsapanel.Visible = true;
            emprestimospanel.Visible = true;
            docentespanel.Visible = false;


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bepanel.Visible = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            bepanel.Visible = true;
            emprestimospanel.Visible = false;
            bolsapanel.Visible = false;
        }

        private void dOCENTESOLHEIROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bolsapanel.Visible = true;
            emprestimospanel.Visible = true;
            docentespanel.Visible = true;
            newspanel.Visible = false;


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

            dados dados = new dados();


            faculdadedtextBox.Enabled = false;
            funcaodtextBox.Enabled = false;
            nomedtextBox.Enabled = false;
            telemoveldtextBox.Enabled = false;
            cidadedtextBox.Enabled = false;
            morada2dtextBox.Enabled = false;
            conselhodtextBox.Enabled = false;
            morada1dtextBox.Enabled = false;
            emaildtextBox.Enabled = false;
            codigo_postaldtextBox.Enabled = false;

            desportodcomboBox.Enabled = false;
            diadcomboBox.Enabled = false;
            anodcomboBox.Enabled = false;
            mesdcomboBox.Enabled = false;
            generodcomboBox.Enabled = false;

            try
            {


                string query = "SELECT desporto ,dia ,mes ,ano ,morada1 ,morada2 ,cidade ,conselho  ,telemovel ,genero ,codigo_postal ,email ,nome ,faculdade, funcao from utilizador where username = @username";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username1;
                SqlDataReader myreader;
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    dados.desporto = myreader["desporto"].ToString();
                    dados.dia = myreader["dia"].ToString();
                    dados.mes = myreader["mes"].ToString();
                    dados.ano = myreader["ano"].ToString();
                    dados.morada1 = myreader["morada1"].ToString();
                    dados.morada2 = myreader["morada2"].ToString();
                    dados.cidade = myreader["cidade"].ToString();
                    dados.conselho = myreader["conselho"].ToString();
                    dados.telemovel = myreader["telemovel"].ToString();
                    dados.genero = myreader["genero"].ToString();
                    dados.faculdade = myreader["faculdade"].ToString();
                    dados.codigo_postal = myreader["codigo_postal"].ToString();
                    dados.funcao = myreader["funcao"].ToString();
                    dados.nome = myreader["nome"].ToString();
                    dados.email = myreader["email"].ToString();



                }

                desportodcomboBox.Text = dados.desporto;
                diadcomboBox.Text = dados.dia;
                mesdcomboBox.Text = dados.mes;
                anodcomboBox.Text = dados.ano;
                morada1dtextBox.Text = dados.morada1;
                morada2dtextBox.Text = dados.morada2;
                cidadedtextBox.Text = dados.cidade;
                conselhodtextBox.Text = dados.conselho;
                telemoveldtextBox.Text = dados.telemovel;
                generodcomboBox.Text = dados.genero;
                faculdadedtextBox.Text = dados.faculdade;
                funcaodtextBox.Text = dados.funcao;
                nomedtextBox.Text = dados.nome;
                codigo_postaldtextBox.Text = dados.codigo_postal;
                emaildtextBox.Text = dados.email;



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

       

       

        private void label55_Click(object sender, EventArgs e)
        {

            
        }

        private void label51_Click(object sender, EventArgs e)
        {
            
            

        }

        private void label50_Click(object sender, EventArgs e)
        {
            bepanel.Visible = true;
            emprestimospanel.Visible = false;
            bolsapanel.Visible = false;

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bepanel.Visible = true;
            emprestimospanel.Visible = false;
            bolsapanel.Visible = false;
        }

        private void nOTÍCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bolsapanel.Visible = true;
            emprestimospanel.Visible = true;
            docentespanel.Visible = true;
            newspanel.Visible = true;
            profilepanel.Visible = false;
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bepanel.Visible = true;
            emprestimospanel.Visible = false;
            bolsapanel.Visible = false;
            docentespanel.Visible = false;
        }

        private void pERFILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bolsapanel.Visible = true;
            emprestimospanel.Visible = true;
            docentespanel.Visible = true;
            newspanel.Visible = true;
            profilepanel.Visible = true;
            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

            try
            {
                

                dados dados = new dados();

                string query = "SELECT email, telemovel from utilizador where username = @username";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username1;
                SqlDataReader myreader;
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    dados.email = myreader["email"].ToString();
                    dados.telemovel = myreader["telemovel"].ToString();



                }

                telemovelptextBox.Text = dados.telemovel;
                emailptextBox.Text = dados.email;



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

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bepanel.Visible = true;
            emprestimospanel.Visible = false;
            bolsapanel.Visible = false;
            docentespanel.Visible = false;
            newspanel.Visible = false;
        }

        

        
        


        BEFORM f1;

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            
            f1 = new BEFORM();
            f1.Show();
            this.Close();
   

        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            telemovelptextBox.Enabled = true;
            emailptextBox.Enabled = true;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

            try
            {

                dados dados = new dados();
                string query = "UPDATE utilizador SET email = '" + this.emailptextBox.Text + "', telemovel = '" + telemovelptextBox.Text + "' WHERE username = @username ";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username1);
                SqlDataReader myreader;
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    
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

            MessageBox.Show("Edições feitas !", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            telemovelptextBox.Enabled = false;
            emailptextBox.Enabled = false;
        }

        private void aplicarbutton_Click(object sender, EventArgs e)
        {

            aplicarabutton.Enabled = false;


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);


            if (desportodcomboBox.Text == "" || diadcomboBox.Text == "" || anodcomboBox.Text == "" || mesdcomboBox.Text == "" || generodcomboBox.Text == "" || faculdadedtextBox.Text == "" || funcaodtextBox.Text == "" || nomedtextBox.Text == "" || telemoveldtextBox.Text == "" || cidadedtextBox.Text == "" || morada2dtextBox.Text == "" || conselhodtextBox.Text == "" || morada1dtextBox.Text == "" || codigo_postaldtextBox.Text == "" || emaildtextBox.Text == "")
            {
                MessageBox.Show("Campos Obrigatórios por preencher!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                try
                {
                    string query = "UPDATE utilizador SET desporto = '" + this.desportodcomboBox.Text.ToString() + "',nome = '" + this.nomedtextBox.Text + "', dia = '" + diadcomboBox.Text.ToString() + "',mes = '" + this.mesdcomboBox.Text.ToString() + "',ano = '" + this.anodcomboBox.Text.ToString() + "',morada1 = '" + this.morada1dtextBox.Text + "',morada2 = '" + this.morada2dtextBox.Text + "' ,cidade = '" + this.cidadedtextBox.Text + "' ,conselho = '" + this.conselhodtextBox.Text + "' ,telemovel = '" + this.telemoveldtextBox.Text + "' ,genero = '" + this.generodcomboBox.Text.ToString() + "' ,codigo_postal = '" + this.codigo_postaldtextBox.Text + "',email = '" + this.emaildtextBox.Text + "',faculdade = '" + this.faculdadedtextBox.Text + "',funcao = '" + this.funcaodtextBox.Text + "' WHERE username = @username ";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username1);
                    SqlDataReader myreader;
                    connection.Open();
                    myreader = cmd.ExecuteReader();
                    while (myreader.Read())
                    {

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


                MessageBox.Show("Aplicação Efetuada!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                faculdadedtextBox.Enabled = false;
                funcaodtextBox.Enabled = false;
                nomedtextBox.Enabled = false;
                telemoveldtextBox.Enabled = false;
                cidadedtextBox.Enabled = false;
                morada2dtextBox.Enabled = false;
                conselhodtextBox.Enabled = false;
                morada1dtextBox.Enabled = false;
                emaildtextBox.Enabled = false;
                codigo_postaldtextBox.Enabled = false;
                nometextBox.Enabled = false;

                desportodcomboBox.Enabled = false;
                diadcomboBox.Enabled = false;
                anodcomboBox.Enabled = false;
                mesdcomboBox.Enabled = false;
                generodcomboBox.Enabled = false;

                morada1textBox.Enabled = false;
                morada2textBox.Enabled = false;
                cidadetextBox.Enabled = false;
                conselhotextBox.Enabled = false;
                telemoveltextBox.Enabled = false;
                nomedtextBox.Enabled = false;
                codigo_postaltextbox.Enabled = false;
                emailtextBox.Enabled = false;
                nomedtextBox.Enabled = false;

                desportocomboBox.Enabled = false;
                pais1comboBox.Enabled = false;
                pais2comboBox.Enabled = false;
                pais3comboBox.Enabled = false;
                mescomboBox.Enabled = false;
                anocomboBox.Enabled = false;
                generocomboBox.Enabled = false;
                diacomboBox.Enabled = false;
                anoescolarcomboBox.Enabled = false;



                ALUMNI f5 = new ALUMNI();
                f5.Show();


            }
        }

        private void voltarbutton_Click(object sender, EventArgs e)
        {
            bepanel.Visible = true;
            emprestimospanel.Visible = false;
            bolsapanel.Visible = false;
        }

        private void apagarbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que deseja apagar?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                faculdadedtextBox.Clear();
                funcaodtextBox.Clear();
                nomedtextBox.Clear();
                telemoveldtextBox.Clear();
                cidadedtextBox.Clear();
                morada2dtextBox.Clear();
                conselhodtextBox.Clear();
                morada1dtextBox.Clear();
                emaildtextBox.Clear();
                codigo_postaldtextBox.Clear();

                desportodcomboBox.SelectedIndex = -1;
                diadcomboBox.SelectedIndex = -1;
                anodcomboBox.SelectedIndex = -1;
                mesdcomboBox.SelectedIndex = -1;
                generodcomboBox.SelectedIndex = -1;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aplicarbutton.Enabled = false;

            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

            if (desportocomboBox.Text == "" || pais1comboBox.Text == "" || pais2comboBox.Text == "" || pais3comboBox.Text == "" || diacomboBox.Text == "" || mescomboBox.Text == "" || anocomboBox.Text == "" || morada1textBox.Text == "" || morada2textBox.Text == "" || cidadetextBox.Text == "" || conselhotextBox.Text == "" || telemoveltextBox.Text == "" || generocomboBox.Text == "" || anoescolarcomboBox.Text == "" || codigo_postaltextbox.Text == "" || nometextBox.Text == "" || emailtextBox.Text == "")
            {
                MessageBox.Show("Campos Obrigatórios por preencher!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {


                    string query = "UPDATE utilizador SET desporto = '" + this.desportocomboBox.Text.ToString() + "', dia = '" + diacomboBox.Text.ToString() + "',mes = '" + this.mescomboBox.Text.ToString() + "',ano = '" + this.anocomboBox.Text.ToString() + "',morada1 = '" + this.morada1textBox.Text + "',morada2 = '" + this.morada2textBox.Text + "' ,cidade = '" + this.cidadetextBox.Text + "' ,conselho = '" + this.conselhotextBox.Text + "' ,telemovel = '" + this.telemoveltextBox.Text + "' ,genero = '" + this.generocomboBox.Text.ToString() + "' ,anoescolar = '" + this.anoescolarcomboBox.Text.ToString() + "' ,codigo_postal = '" + this.codigo_postaltextbox.Text + "',email = '" + this.emailtextBox.Text + "',nome = '" + this.nometextBox.Text + "',pais_estudo1 = '" + this.pais1comboBox.Text.ToString() + "', pais_estudo2 = '" + this.pais2comboBox.Text.ToString() + "', pais_estudo3 = '" + this.pais3comboBox.Text.ToString() + "' WHERE username = @username ";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username1);
                    SqlDataReader myreader;
                    connection.Open();
                    myreader = cmd.ExecuteReader();
                    while (myreader.Read())
                    {

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

                MessageBox.Show("Aplicação Efetuada. Agora espera até alguém te contactar !", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                morada1textBox.Enabled = false;
                morada2textBox.Enabled = false;
                cidadetextBox.Enabled = false;
                conselhotextBox.Enabled = false;
                telemoveltextBox.Enabled = false;
                nometextBox.Enabled = false;
                codigo_postaltextbox.Enabled = false;
                emailtextBox.Enabled = false;
                nometextBox.Enabled = false;

                desportocomboBox.Enabled = false;
                pais1comboBox.Enabled = false;
                pais2comboBox.Enabled = false;
                pais3comboBox.Enabled = false;
                mescomboBox.Enabled = false;
                anocomboBox.Enabled = false;
                generocomboBox.Enabled = false;
                diacomboBox.Enabled = false;
                anoescolarcomboBox.Enabled = false;


                faculdadedtextBox.Enabled = false;
                funcaodtextBox.Enabled = false;
                nomedtextBox.Enabled = false;
                telemoveldtextBox.Enabled = false;
                cidadedtextBox.Enabled = false;
                morada2dtextBox.Enabled = false;
                conselhodtextBox.Enabled = false;
                morada1dtextBox.Enabled = false;
                emaildtextBox.Enabled = false;
                codigo_postaldtextBox.Enabled = false;

                desportodcomboBox.Enabled = false;
                diadcomboBox.Enabled = false;
                anodcomboBox.Enabled = false;
                mesdcomboBox.Enabled = false;
                generodcomboBox.Enabled = false;

                telemovel = telemoveldtextBox.Text;
                email = emaildtextBox.Text;

                telemovelptextBox.Text = telemovel;
                emailptextBox.Text = email;


                FACULS f6 = new FACULS();
                f6.Show();

            }

        }

        private void voltarabutton_Click(object sender, EventArgs e)
        {
            bolsapanel.Visible = false;
            bepanel.Visible = true;
        }

        private void apagarabutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que deseja apagar?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                morada1textBox.Clear();
                morada2textBox.Clear();
                cidadetextBox.Clear();
                conselhotextBox.Clear();
                telemoveltextBox.Clear();
                codigo_postaltextbox.Clear();
                emailtextBox.Clear();
                nometextBox.Clear();

                desportocomboBox.SelectedIndex = -1;
                pais1comboBox.SelectedIndex = -1;
                pais2comboBox.SelectedIndex = -1;
                pais3comboBox.SelectedIndex = -1;
                mescomboBox.SelectedIndex = -1;
                anocomboBox.SelectedIndex = -1;
                generocomboBox.SelectedIndex = -1;
                diacomboBox.SelectedIndex = -1;
                anoescolarcomboBox.SelectedIndex = -1;
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }
        Bibliografia f4;

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f4 = new Bibliografia();
            f4.Show();
            
        }

        private void emailptextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            morada1textBox.Enabled = true;
            morada2textBox.Enabled = true;
            cidadetextBox.Enabled = true;
            conselhotextBox.Enabled = true;
            telemoveltextBox.Enabled = true;
            nomedtextBox.Enabled = true;
            codigo_postaltextbox.Enabled = true;
            emailtextBox.Enabled = true;
            nometextBox.Enabled = true;

            desportocomboBox.Enabled = true;
            pais1comboBox.Enabled = true;
            pais2comboBox.Enabled = true;
            pais3comboBox.Enabled = true;
            mescomboBox.Enabled = true;
            anocomboBox.Enabled = true;
            generocomboBox.Enabled = true;
            diacomboBox.Enabled = true;
            anoescolarcomboBox.Enabled = true;

            
        }

        private void editbutton3_Click(object sender, EventArgs e)
        {
            faculdadedtextBox.Enabled = true;
            funcaodtextBox.Enabled = true;
            nomedtextBox.Enabled = true;
            telemoveldtextBox.Enabled = true;
            cidadedtextBox.Enabled = true;
            morada2dtextBox.Enabled = true;
            conselhodtextBox.Enabled = true;
            morada1dtextBox.Enabled = true;
            emaildtextBox.Enabled = true;
            codigo_postaldtextBox.Enabled = true;

            desportodcomboBox.Enabled = true;
            diadcomboBox.Enabled = true;
            anodcomboBox.Enabled = true;
            mesdcomboBox.Enabled = true;
            generodcomboBox.Enabled = true;

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

