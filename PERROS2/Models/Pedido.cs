public class Pedido
{
    public int PedidoID { get; set; }
    public DateTime FechaDePedido { get; set; }
    public decimal MontoTotal { get; set; }
    public string EstadoDelPedido { get; set; }

    // Relación con Clientes (Un pedido pertenece a un cliente)
    public int ClienteID { get; set; }
    public Cliente Cliente { get; set; }

    // Relación con ItemsDePedido (Un pedido puede tener muchos items)
    public ICollection<ItemDePedido> ItemsDePedido { get; set; }

    // Relación con Pagos y Envíos
    public Pago Pago { get; set; }
    public Envio Envio { get; set; }
}
