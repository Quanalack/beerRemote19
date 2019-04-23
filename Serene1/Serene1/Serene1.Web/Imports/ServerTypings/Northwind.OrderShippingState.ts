namespace Serene1.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'Serene1.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
