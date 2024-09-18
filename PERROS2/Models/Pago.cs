public class Pago
{
    public int PagoID { get; set; }
    public decimal MontoDePago { get; set; }
    public string MetodoDePago { get; set; }

    // Relación con Pedido (Un pago pertenece a un pedido)
    public int PedidoID { get; set; }
    public Pedido Pedido { get; set; }
}
