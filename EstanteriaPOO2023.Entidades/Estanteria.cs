using System;
using System.Text;

namespace EstanteriaPOO2023.Entidades
{
    public class Estanteria
    {
        private int ubicacionEstante;
        private Producto[] productos;
        private Estanteria(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estanteria(int capacidad, int ubicacion):this(capacidad)
        {
            ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos() { return  productos; }

        public static string MostrarEstanteria(Estanteria e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estante ubicacion: {e.ubicacionEstante} \n");

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (!Object.ReferenceEquals(e.productos[i], null))
                {
                    sb.AppendLine(Producto.MostrarProducto(e.productos[i]));
                    sb.AppendLine("----------------------");

                }

            }
            return sb.ToString();
        }

        public static bool operator ==(Estanteria e, Producto p)
        {
            foreach (var p2 in e.productos)
            {
                if (p2==p)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(Estanteria e, Producto p) { return !(e == p); }
        public static bool operator +(Estanteria e, Producto p)
        {
            if (e != p)
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

        public static Estanteria operator -(Estanteria e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }
    }
}
