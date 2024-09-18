public class ItemDePedido
{
    public int ItemDePedidoID { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }

    // Relación con Pedidos
    public int PedidoID { get; set; }
    public Pedido Pedido { get; set; }

    // Relación con Productos y Sabores
    public int ProductoID { get; set; }
    public Producto Producto { get; set; }

    public int SaborID { get; set; }
    public Sabor Sabor { get; set; }
}
