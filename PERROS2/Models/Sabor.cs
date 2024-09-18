public class Sabor
{
    public int SaborID { get; set; }
    public string NombreDeSabor { get; set; }
    public string ContenidoDeColageno { get; set; }
    public string Descripcion { get; set; }
    public int CantidadStock { get; set; }

    // Relación con Productos (Un producto puede tener muchos sabores)
    public int ProductoID { get; set; }
    public Producto Producto { get; set; }
}
