using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesignStudio.Controllers;


namespace DesignStudio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller = new Controller();

        public MainWindow()
        {
            InitializeComponent();
            controller.ShowClients(ref ClientGrid);
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            controller.Dispose();
        }

        //protected virtual void dob_kl_Click(object sender, System.EventArgs e)
        //{
           // dob_kl dob_kl = new dob_kl();
            //dob_kl.Show();
        //}

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


    }
}
