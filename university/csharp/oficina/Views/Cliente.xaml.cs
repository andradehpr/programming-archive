using Oficina.Controllers;
using Oficina.Model;
using System.Windows;
using System.Windows.Controls;

namespace Oficina
{
    public partial class Clientes : Page
    {
        ClienteController clienteController = new ClienteController();

        int idSelecionado = 0;

        public Clientes()
        {
            InitializeComponent();
            ListarClientes();
        }

        private void ListarClientes()
        {
            dgClientes.ItemsSource = clienteController.ListarClientes();
        }

        private void LimparCampos()
        {
            idSelecionado = 0;
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtNIF.Clear();
            dgClientes.SelectedItem = null;
        }

        // Obter os dados do formulário
        private Cliente ObterClienteDoFormulario()
        {
            // Cria objeto Cliente
            return new Cliente
            {
                Nome = txtNome.Text.Trim(), // .Trim() remove espaços no início e no fim da string
                Telefone = txtTelefone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                NIF = txtNIF.Text.Trim()
            };
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Insira o nome do cliente.");
                return false;
            }

            return true;
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (idSelecionado != 0)
            {
                MessageBox.Show("O Cliente que está a tentar criar já existe, se quiser atualizar dados, clique em 'Atualizar'.");
                return;
            }

            if (!ValidarFormulario())
            {
                return;
            }

            clienteController.InserirCliente(ObterClienteDoFormulario());
            MessageBox.Show("Cliente adicionado!");
            LimparCampos();
            ListarClientes();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um cliente primeiro.");
                return;
            }

            if (!ValidarFormulario())
            {
                return;
            }

            Cliente cliente = ObterClienteDoFormulario();
            cliente.Id = idSelecionado;
            clienteController.AtualizarCliente(cliente);
            MessageBox.Show("Cliente atualizado!");
            LimparCampos();
            ListarClientes();
        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um cliente primeiro.");
                return;
            }

            if (MessageBox.Show("Tem a certeza que deseja apagar este cliente?", "Confirmar",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }

            try
            {
                clienteController.ApagarCliente(idSelecionado);
                MessageBox.Show("Cliente apagado!");
                LimparCampos();
                ListarClientes();
            }
            catch
            {
                MessageBox.Show("Não foi possível apagar. O cliente pode ter folhas de obra associadas.");
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparCampos();
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            string texto = txtPesquisa.Text;

            if (texto == "")
            {
                ListarClientes();
            }
            else
            {
                dgClientes.ItemsSource = clienteController.PesquisarClientes(texto);
            }
        }

        private void btnMostrarTodos_Click(object sender, RoutedEventArgs e)
        {
            txtPesquisa.Clear();
            ListarClientes();
        }

        // Preenche os campos com os dados do cliente selecionado
        private void dgClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cliente cliente = dgClientes.SelectedItem as Cliente;

            if (cliente != null)
            {
                idSelecionado = cliente.Id;
                txtNome.Text = cliente.Nome;
                txtTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
                txtNIF.Text = cliente.NIF;
            }
        }
    }
}
