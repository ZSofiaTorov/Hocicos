using PERROS2.Models;

public class Cliente
{
    public int ClienteID { get; set; }
    public string NombreComercial { get; set; }
    public string TipoDeCliente { get; set; }
    public string CorreoElectronico { get; set; }
    public string ContrasenaHash { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public DateTime FechaDeCreacion { get; set; }

    // Relación con Pedidos (Un cliente puede tener muchos pedidos)
    public ICollection<Pedido> Pedidos { get; set; }
}
