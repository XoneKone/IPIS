using DesignStudio.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Controls;


namespace DesignStudio.Controllers
{
    class Controller
    {
        private MyDbContext DbContext;

        public Controller()
        {
            DbContext = new MyDbContext();
        }

        public void AddClient(string name, string surname, string middlename, string birthdate, string mobilephone, string address)
        {
            Client client = new Client();
            client.Name = name;
            client.Surname = surname;
            client.MiddleName = middlename;
            client.Birthdate = DateTime.Parse(birthdate);
            client.MobilePhone = mobilephone;
            client.Address = address;
            DbContext.Clients.Add(client);
            DbContext.SaveChanges();
        }

        public void AddDesigner(string name, string surname, string middlename, string birthdate, string mobilephone, string address)
        {
            Designer designer = new Designer();
            designer.Name = name;
            designer.Surname = surname;
            designer.MiddleName = middlename;
            designer.Birthdate = DateTime.Parse(birthdate);
            designer.MobilePhone = mobilephone;
            designer.Address = address;
            DbContext.Designers.Add(designer);
            DbContext.SaveChanges();
        }


        public void AddOrder(string number, string description,double cost, int readyStatus,
                              int clientId, int designerId, int paymentStatus,
                              DateTime orderDate, string deadlinework, string comments)
        {
            Order order = new Order();
            order.Number = number;
            order.Description = description;
            order.Cost = cost;
            order.ReadyStatus = (ReadyStatus)readyStatus;
            order.ClientId = clientId;
            order.DesignerId = designerId;
            order.PaymentStatus = (PaymentStatus)paymentStatus;
            order.OrderDate = orderDate;
            order.DeadlineWork = DateTime.Parse(deadlinework);
            order.Comments = comments;
            DbContext.Orders.Add(order);
            DbContext.SaveChanges();
        }

        public int GetLastClient()
        {
            return DbContext.Clients.MaxAsync(x => x.Id).Result;
        }

        public void ShowClients(ref DataGrid dataGrid)
        {
            DbContext.Clients.Load();
            dataGrid.ItemsSource = DbContext.Clients.Local.ToBindingList();

        }

        public ObservableCollection<string> GetListDesigners()
        {
            ObservableCollection<string> designers = new ObservableCollection<string>();
            var Designers = DbContext.Designers.ToList();
            foreach(Designer designer in Designers)
            {
                designers.Add(designer.ToString());
            }
            return designers;
        }

        public void ShowDesigners(ref DataGrid dataGrid)
        {
            DbContext.Designers.Load();
            dataGrid.ItemsSource = DbContext.Designers.Local.ToBindingList();
        }

        public void ShowOrders(ref DataGrid dataGrid)
        {
            DbContext.Orders.Load();
            dataGrid.ItemsSource = DbContext.Orders.Local.ToBindingList();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}
