using System;
using Enumeracao.Entities.Enums;
namespace Enumeracao.Entities
{
    class Orders
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
