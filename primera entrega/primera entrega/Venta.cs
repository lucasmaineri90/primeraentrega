using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primera_entrega
{
    public class Venta
    {
        private int _Id;
        private string _Comentarios;
        private string _IdUsuario;

        public Venta ()
        {
            this._Id = 0;
            this._Comentarios = string.Empty;
            this._IdUsuario = string.Empty; 
        }

        public int Id
        {
            get
            {
                return this._Id;
            }
            set 
            {
            this.Id = value;    
            }
        }

        public string Comentarios
        {
            get
            {
                return this._Comentarios;
            }
            set 
            {
            this.Comentarios = value;   
            }
        }    
        
        public string IdUsuario 
        {
            get 
            {
            return this._IdUsuario;
            }
            set 
            {
            this.IdUsuario= value;
            }
 
        }
    }
}
