using Oficina.Controllers;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Oficina
{
    public partial class Inicio : Page
    {
        private DashboardController dashboardController = new DashboardController();

        public Inicio()
        {
            InitializeComponent();
            txtDataHoje.Text = DateTime.Now.ToString("dddd, d MMMM yyyy", new CultureInfo("pt-PT"));
            CarregarDados();
        }

        private void CarregarDados()
        {
            var resumo = dashboardController.ObterResumo();

            txtTotalClientes.Text = resumo.TotalClientes.ToString();
            txtFolhasAbertas.Text = resumo.FolhasAbertas.ToString();
            txtEmReparacao.Text = resumo.EmReparacao.ToString();
            txtConcluidas.Text = resumo.Concluidas.ToString();

            dgUltimasEntradas.ItemsSource = dashboardController.ObterUltimasEntradas(8);
        }

        private MainWindow ObterJanelaPrincipal()
        {
            return Window.GetWindow(this) as MainWindow;
        }

        private void btnNovoCliente_Click(object sender, RoutedEventArgs e)
        {
            ObterJanelaPrincipal()?.GoToClientes();
        }

        private void btnNovaFolha_Click(object sender, RoutedEventArgs e)
        {
            ObterJanelaPrincipal()?.GoToFolhasObra();
        }

        private void btnVerClientes_Click(object sender, RoutedEventArgs e)
        {
            ObterJanelaPrincipal()?.GoToClientes();
        }

        private void dgUltimasEntradas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ObterJanelaPrincipal()?.GoToFolhasObra();
        }
    }
}
