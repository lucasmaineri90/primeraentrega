using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primera_entrega
{
    public class Producto
    {
        private int _Id;
        private string _Descripcion;
        private double _Costo;
        private double _PrecioVenta;
        private int _Stock;
        private string _IdUsuario;


        // CONSTRUCTOR

        public Producto()
        {
            this._Id = 0;
            this._Descripcion = string.Empty;
            this._Costo = 0;
            this._PrecioVenta = 0;
            this._Stock = 0;
            this._IdUsuario = string.Empty;
        }

        // GET Y SET


        public int Id
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }

        }

        public string Descripcion
        {
            get
            {
                return this.Descripcion;
            }
            set
            {
                this.Descripcion = value;
            }
        }

        public double Costo
        {
            get
            {
                return this.Costo;
            }
            set
            {
                this.Costo = value;
            }
        }


        public double PrecioVenta
        {
            get
            {
                return this.PrecioVenta;
            }
            set
            {
                this.PrecioVenta = value;
            }
        }

        public int Stock
        {
            get
            {
                return this.Stock;
            }
            set
            {
                this.Stock = value;
            }
        }

        public string IdUsuario
        {
            get
            {
                return this.IdUsuario;
            }
            set
            {
                this.IdUsuario = value;
            }
        }
    }
}





