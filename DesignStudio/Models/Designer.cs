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
        /// Номер телефона
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Адресс
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Возраст дизайнера
        /// </summary>
        public int Age { get { return DateTime.Now.Year - Birthdate.Year; } }

        /// <summary>
        /// Оклад
        /// </summary>
        public double Salary { get; set; }


        /// <summary>
        /// Должность
        /// </summary>
        public double Post { get; set; }

        /// <summary>
        /// Cсылка на заказы
        /// </summary>
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return Surname + " " + Name + " " + MiddleName;
        }
    }
}
