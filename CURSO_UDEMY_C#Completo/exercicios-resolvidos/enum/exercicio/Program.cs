using Exercicio.Entities;
using Exercicio.Entities.Enums;

Order order = new Order(){
        Id = 100,
        Moment = DateTime.Now,
        Status = OrderStatus.PadingPayment
};
System.Console.WriteLine(order);