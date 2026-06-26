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
    public partial class FACULS : Form
    {
        public FACULS()
        {
            InitializeComponent();
        }

        private void FACULS_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnBe"].ConnectionString);

            connection.Open();
            SqlCommand cmd = new SqlCommand(@"Select nome as 'Nome', localidade as 'Localidade', alunos as 'Alunos', cursos as 'Cursos', desportos as 'Desportos' from faculdade", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ForeColor = Color.Black;
        }
    }
}
