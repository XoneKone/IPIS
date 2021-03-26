using System;
using System.Windows;
using System.Windows.Documents;
using DesignStudio.Controllers;

namespace DesignStudio
{
    /// <summary>
    /// Логика взаимодействия для Add_kl.xaml
    /// </summary>
    public partial class Add_kl : Window
    {
        Controller controller = new Controller();
        public Add_kl()
        {
            InitializeComponent();
            

            foreach (var s in controller.GetListDesigners())
            {
              
                this.designers_combobox.Items.Add(s);
            }
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            
            string text = new TextRange(address_richtextbox.Document.ContentStart, address_richtextbox.Document.ContentEnd).Text;
            controller.AddClient(Name_textbox.Text, Surname_textbox.Text, Midname_textbox.Text, birthdate_picker.SelectedDate.ToString(), mobphone_textbox.Text, text);
            text = new TextRange(descr_richtextbox.Document.ContentStart, descr_richtextbox.Document.ContentEnd).Text;
            int clienid = controller.GetLastClient();
            string comments = new TextRange(comments_richtextbox.Document.ContentStart, comments_richtextbox.Document.ContentEnd).Text;      
            controller.AddOrder(number_textbox.Text, text, Double.Parse(cost_textbox.Text), readystatus_combobox.SelectedIndex, clienid, designers_combobox.SelectedIndex+1, paystatus_combobox.SelectedIndex, DateTime.Now, deadline_picker.SelectedDate.ToString(), comments);
            controller.Dispose();
        }
    }
}
