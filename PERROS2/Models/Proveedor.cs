public class Proveedor
{
    public int ID_Proveedor { get; set; }
    public string Nombre_Proveedor { get; set; }
    public string Telefono_Proveedor { get; set; }
    public string Direccion_Proveedor { get; set; }
    public string Email_Proveedor { get; set; }

    // Relación con Productos (Un proveedor puede tener muchos productos)
    public ICollection<Producto> Productos { get; set; }
}
