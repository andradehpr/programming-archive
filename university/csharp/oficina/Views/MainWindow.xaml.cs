using System.Windows;

namespace Oficina
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GoToInicio();
        }

        // Métodos para navegar entre as páginas
        public void GoToInicio()
        {
            framePrincipal.Navigate(new Inicio());
        }

        public void GoToClientes()
        {
            framePrincipal.Navigate(new Clientes());
        }

        public void GoToFolhasObra()
        {
            framePrincipal.Navigate(new FolhasObra());
        }

        // Botões do menu
        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            GoToInicio();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            GoToClientes();
        }

        private void btnFolhasObra_Click(object sender, RoutedEventArgs e)
        {
            GoToFolhasObra();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
