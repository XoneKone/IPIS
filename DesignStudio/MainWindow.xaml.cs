﻿using System;
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
        MyDbContext myDb;
        public MainWindow()
        {
            InitializeComponent();
            myDb = new MyDbContext();
            myDb.Clients.Load();
            ClientGrid.ItemsSource = myDb.Clients.Local.ToBindingList();
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            myDb.Dispose();
        }
    }
}
