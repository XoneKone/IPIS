using System;
using System.Collections.Generic;


namespace DesignStudio.Models
{
    class Designer
    {
        /// <summary>
        /// Идентификатор дизайнера
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя дизайнера
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия дизайнера
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество дизайнера
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата рождения дизайнера
        /// </summary>
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Возраст дизайнера
        /// </summary>
        public int Age { get { return DateTime.Now.Year - Birthdate.Year; } }

        /// <summary>
        /// Cсылка на заказы
        /// </summary>
        public List<Order> Orders { get; set; }
    }
}
