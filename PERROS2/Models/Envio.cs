public class Envio
{
    public int EnvioID { get; set; }
    public string MetodoDeEnvio { get; set; }
    public string DireccionDeEnvio { get; set; }
    public DateTime FechaDeEnvio { get; set; }

    // Relación con Pedido (Un envío pertenece a un pedido)
    public int PedidoID { get; set; }
    public Pedido Pedido { get; set; }
}
