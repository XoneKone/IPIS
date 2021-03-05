using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStudio.Models
{
    class Client
    {
        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата рождения клиента
        /// </summary>
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Возраст клиента
        /// </summary>
        public int Age { get { return DateTime.Now.Year - Birthdate.Year; } }

        /// <summary>
        /// Cсылка на заказы
        /// </summary>
        public List<Order> Orders { get; set; }
    }
}
