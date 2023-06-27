using System.Text;

namespace EstanteriaPoo2023.Entidades
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos() { return productos; }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto p in e.productos)
            {
                if (!(p is null))
                {
                    sb.AppendLine(Producto.MostrarProducto(p));
                    //sb.AppendLine("-----------------");
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            foreach (Producto producto in e.productos)
            {
                if (producto == p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (!(e == p))
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        return e;
                    }
                }
            }
            return e;
        }
    }
}
