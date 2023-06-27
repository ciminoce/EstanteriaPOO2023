namespace EstanteriaPoo2023.Entidades
{
    public class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarras, string marca, float precio)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.marca = marca;
            this.precio = precio;
        }
        public string GetMarca() => marca;
        public float GetPrecio() => precio;
        public static string MostrarProducto(Producto p)
        {
            return $"{p.codigoDeBarras}-{p.marca}-{p.precio}";
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarras;
        }

        public static bool operator ==(Producto producto1, Producto producto2)
        {
            if (!(producto1 is null) && !(producto2 is null))
            {
                return producto1.codigoDeBarras == producto2.codigoDeBarras
                    && producto1.marca.ToUpper() == producto2.marca.ToUpper();

            }
            return false;
        }
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }
        public static bool operator ==(Producto producto, string marca)
        {
            return producto.marca.ToUpper() == marca.ToUpper();
        }
        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto == marca);
        }
    }
}
