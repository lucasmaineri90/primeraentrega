using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace primera_entrega
{ 
    public class ProductoVendido
    {
        private int _Id;
        private string _IdProducto;
        private int _Stock;
        private string _IdUsuario;

        // CONSTRUCTOR

        public ProductoVendido () 
        {
            this._Id = 0;
            this._IdProducto = string.Empty;
            this._Stock = 0;
            this._IdUsuario = string.Empty;

        }

        // GET Y SET 

        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
            }
        }

        public string IdProducto 
        {
            get 
            {
               return _IdProducto;
            }
            set 
            {
             this.IdProducto = value;
            }
        }

        public int Stock
        {
            get
            {
                return _Stock;
            }
            set
            {
                this._Stock = value;
            }
        }

        public string IdUsuario
        {
        get
            {
                return _IdUsuario;
            }
            set 
            {
            this._IdUsuario= value;
            }
        }


    }
}
