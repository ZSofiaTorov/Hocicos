public class Producto
{
    public int ProductoID { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal PrecioDeCompra { get; set; }
    public decimal PrecioDeVenta { get; set; }
    public DateTime FechaDeCreacion { get; set; }

    // Relación con Proveedores (Un proveedor puede tener muchos productos)
    public int ID_Proveedor { get; set; }
    public Proveedor Proveedor { get; set; }

    // Relación con Sabores (Un producto puede tener muchos sabores)
    public ICollection<Sabor> Sabores { get; set; }
}
