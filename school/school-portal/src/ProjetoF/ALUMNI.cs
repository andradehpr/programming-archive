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
    public partial class ALUMNI : Form
    {
        public ALUMNI()
        {
            InitializeComponent();
        }

        private void ALUMNI_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

            connection.Open();
            SqlCommand cmd = new SqlCommand(@"Select email as 'Email', telemovel as 'Telemóvel',desporto as 'Desporto', nome as 'Nome', dia as 'Dia', mes as 'Mês', ano as 'Ano', genero  as 'Genéro', anoescolar as 'Ano Escolar', pais_estudo1 as 'País de Preferência 1', pais_estudo2 as 'País de Preferência 2', pais_estudo3 as 'País de Preferência 3' from utilizador", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ForeColor = Color.Black;



          
        }
    }
}
