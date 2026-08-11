using Oficina.Controllers;
using Oficina.Model;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Oficina
{
    public partial class FolhasObra : Page
    {
        private FolhaObraController folhaObraController = new FolhaObraController();
        private ClienteController clienteController = new ClienteController();

        private int idSelecionado = 0;

        public FolhasObra()
        {
            InitializeComponent();
            CarregarComboBoxes();
            dpDataEntrada.SelectedDate = DateTime.Today;
            ListarFolhasObra();
        }

        private void CarregarComboBoxes()
        {
            comboCliente.ItemsSource = clienteController.ListarClientes();

            comboMarca.ItemsSource = new[]
            {
                "Audi", "BMW", "Citroën", "Dacia", "Fiat", "Ford", "Honda", "Hyundai",
                "Kia", "Mercedes-Benz", "Mini", "Nissan", "Opel", "Peugeot", "Renault",
                "Seat", "Skoda", "Tesla", "Toyota", "Volkswagen"
            };

            comboEstado.ItemsSource = new[]
            {
                "Aberta",
                "Em Reparação",
                "Concluída"
            };
        }

        private void ListarFolhasObra()
        {
            dgFolhasObra.ItemsSource = folhaObraController.ListarFolhasObra();
        }

        private void LimparCampos()
        {
            idSelecionado = 0;
            comboCliente.SelectedIndex = -1;
            dpDataEntrada.SelectedDate = DateTime.Today;
            txtMatricula.Clear();
            comboMarca.SelectedIndex = -1;
            comboMarca.Text = string.Empty;
            txtModelo.Clear();
            txtKm.Clear();
            txtProblema.Clear();
            txtServicos.Clear();
            comboEstado.SelectedIndex = -1;
            txtValor.Clear();
            dgFolhasObra.SelectedItem = null;
        }

        private FolhaObra ObterFolhaDoFormulario()
        {
            //TryParse tenat converter o valor do texto para decimal, se for inválido falha sem crashar a app ao contrário do Parse que pode crashar a app quando falha
            decimal valor = 0;
            decimal.TryParse(txtValor.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out valor);

            int km = 0;
            int.TryParse(txtKm.Text, out km);

            return new FolhaObra
            {
                ClienteId = (int)comboCliente.SelectedValue,
                DataEntrada = dpDataEntrada.SelectedDate ?? DateTime.Today,
                Matricula = txtMatricula.Text.Trim(),
                Marca = comboMarca.Text?.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Km = km,
                ProblemaDescrito = txtProblema.Text.Trim(),
                ServicosRealizados = txtServicos.Text.Trim(),
                Estado = comboEstado.SelectedItem?.ToString(),
                ValorTotal = valor
            };
        }

        private bool ValidarFormulario()
        {
            if (comboCliente.SelectedValue == null)
            {
                MessageBox.Show("Selecione um cliente.");
                return false;
            }

            if (dpDataEntrada.SelectedDate == null)
            {
                MessageBox.Show("Selecione a data de entrada.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Introduza a matrícula.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboMarca.Text))
            {
                MessageBox.Show("Introduza a marca do veículo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Introduza o modelo do veículo.");
                return false;
            }

            if (comboEstado.SelectedItem == null)
            {
                MessageBox.Show("Selecione o estado da folha de obra.");
                return false;
            }

            return true;
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (idSelecionado != 0)
            {
                MessageBox.Show("A folha selecionada já existe. Para atualizar, clique em 'Atualizar'. Para criar uma nova, clique em 'Limpar', preencha os dados e depois em 'Adicionar'.");
                return;
            }

            if (!ValidarFormulario())
            {
                return;
            }

            folhaObraController.InserirFolhaObra(ObterFolhaDoFormulario());
            MessageBox.Show("Folha de obra adicionada!");
            LimparCampos();
            ListarFolhasObra();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione uma folha de obra primeiro.");
                return;
            }

            if (!ValidarFormulario())
            {
                return;
            }

            FolhaObra folha = ObterFolhaDoFormulario();
            folha.Id = idSelecionado;
            folhaObraController.AtualizarFolhaObra(folha);
            MessageBox.Show("Folha de obra atualizada!");
            LimparCampos();
            ListarFolhasObra();
        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione uma folha de obra primeiro.");
                return;
            }

            if (MessageBox.Show("Tem a certeza que deseja apagar esta folha de obra?", "Confirmar",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }

            try
            {
                folhaObraController.ApagarFolhaObra(idSelecionado);
                MessageBox.Show("Folha de obra apagada!");
                LimparCampos();
                ListarFolhasObra();
            }
            catch
            {
                MessageBox.Show("Não foi possível apagar a folha de obra.");
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparCampos();
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            string texto = txtPesquisa.Text.Trim();

            if (texto == "")
            {
                ListarFolhasObra();
            }
            else
            {
                dgFolhasObra.ItemsSource = folhaObraController.PesquisarFolhasObra(texto);
            }
        }

        private void btnMostrarTodos_Click(object sender, RoutedEventArgs e)
        {
            txtPesquisa.Clear();
            ListarFolhasObra();
        }

        private void dgFolhasObra_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FolhaObra folha = dgFolhasObra.SelectedItem as FolhaObra;

            if (folha != null)
            {
                idSelecionado = folha.Id;
                comboCliente.SelectedValue = folha.ClienteId;
                dpDataEntrada.SelectedDate = folha.DataEntrada;
                txtMatricula.Text = folha.Matricula;
                comboMarca.Text = folha.Marca;
                txtModelo.Text = folha.Modelo;
                txtKm.Text = folha.Km.HasValue && folha.Km > 0 ? folha.Km.ToString() : string.Empty;
                txtProblema.Text = folha.ProblemaDescrito;
                txtServicos.Text = folha.ServicosRealizados;
                comboEstado.SelectedItem = folha.Estado;
                txtValor.Text = (folha.ValorTotal ?? 0).ToString("N2", CultureInfo.CurrentCulture);
            }
        }
    }
}
