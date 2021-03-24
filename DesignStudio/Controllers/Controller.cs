using DesignStudio.Models;
using System;
using System.Data.Entity;
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


        public void AddOrder(string number, string description, ReadyStatus readyStatus,
                              int clientId, int designerId, PaymentStatus paymentStatus,
                              DateTime orderDate, int deadlinework, string comments)
        {
            Order order = new Order();
            order.Number = number;
            order.Description = description;
            order.ReadyStatus = readyStatus;
            order.ClientId = clientId;
            order.DesignerId = designerId;
            order.PaymentStatus = paymentStatus;
            order.OrderDate = orderDate;
            order.DeadlineWork = deadlinework;
            order.Comments = comments;
            DbContext.Orders.Add(order);
            DbContext.SaveChanges();
        }

        public void ShowClients(ref DataGrid dataGrid)
        {
            DbContext.Clients.Load();
            dataGrid.ItemsSource = DbContext.Clients.Local.ToBindingList();

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
