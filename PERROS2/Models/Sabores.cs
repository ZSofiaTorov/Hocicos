namespace PERROS2.Models
{
    public class Sabores
    {
        public int SaborID { get; set; }
        public int ProductoID { get; set; }
        public string Nombredesabor { get; set; } = "";
        public string Contenidodelcolageno { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public int cantidadenstock { get; set; }


    }
}
