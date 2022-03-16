using System;
using Enumeracao.Entities;
using Enumeracao.Entities.Enums;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Orders order = new Orders
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);


            string txt = OrderStatus.PendingPayment.ToString(); //converte o tipo 'enumerado' para String

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //converte string para o tipo 'enumerado'

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
