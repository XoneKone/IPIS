using DesignStudio.Controllers;
using System.Windows;

namespace DesignStudio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



       // Controller controller = new Controller();

        public MainWindow()
        {
            InitializeComponent();

            //controller.ShowClients(ref ClientGrid);
            //controller.ShowDesigners(ref DesignerGrid);
            //controller.ShowOrders(ref OrderGrid);

            this.Closing += MainWindow_Closing;
        }



        private void Add_kl_Click(object sender, RoutedEventArgs e)
        {
            Add_kl add_kl = new Add_kl();
            add_kl.Show();
        }

        private void Del_kl_Click(object sender, RoutedEventArgs e)
        {
            Del_kl del_kl = new Del_kl();
            del_kl.Show();
        }

        private void Ch_kl_Click(object sender, RoutedEventArgs e)
        {
            Ch_kl ch_kl = new Ch_kl();
            ch_kl.Show();
        }

        private void Add_zakaz_Click(object sender, RoutedEventArgs e)
        {
            Add_zakaz add_zakaz = new Add_zakaz();
            add_zakaz.Show();
        }



        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
          //  controller.Dispose();
        }

    }
}
