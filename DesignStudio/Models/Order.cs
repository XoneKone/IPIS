using System;


namespace DesignStudio.Models
{
    enum ReadyStatus
    {
        InProgress,
        Ready,
        Cancelled
    }

    enum PaymentStatus
    {
        FullPayment,
        Installment
    }

    class Order
    {
        /// <summary>
        /// Идентификатор заказа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Номер заказа
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Описание заказа
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Статус готовности заказа
        /// </summary>
        public ReadyStatus ReadyStatus { get; set; }

        /// <summary>
        /// Ссылка на клиента, сделавшего заказ
        /// </summary>
        public int? ClientId { get; set; }
        public Client Client { get; set; }

        /// <summary>
        /// Ссылка на дизайнера, который делает/делал заказ
        /// </summary>
        public int? DesignerId { get; set; }
        public Designer Designer { get; set; }

        /// <summary>
        /// Статус оплаты (оплачено/рассрочка)
        /// </summary>
        public PaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// Дата оформления заказа
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Сроки выполнения работы
        /// </summary>
        public int DeadlineWork { get; set; }

        /// <summary>
        /// Комментарии клиента
        /// </summary>
        public string Comments { get; set; }

        
    }
}
