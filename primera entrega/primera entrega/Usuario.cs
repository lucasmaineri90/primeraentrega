using System.Runtime.CompilerServices;

//CLASE

namespace primera_entrega

{
    public class Usuario
    {
        private int _Id;
        private string _Nombre;
        private string _Apellido;
        private string _NombreUsuario;
        private string _Contrasenia;
        private string _Mail;


// CONSTRUCTOR

        public Usuario()
        {
            this._Id = 0;
            this._Nombre = string.Empty;
            this._Apellido = string.Empty;
            this._NombreUsuario = string.Empty;
            this._Contrasenia = string.Empty;
            this._Mail = string.Empty;
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

        public string nombre
        {
            get
            {
                return this._Nombre;
            }
            set
            {
                this._Nombre = value;
            }
        }

        public string apellido
        {
            get
            {
                return this._Apellido;
            }
            set
            {
                this._Apellido = value;
            }
        }


        public string NombreUsuario
        {
            get
            {
                return this._Nombre;
            }
            set
            {
                this._Nombre = value;
            }
        }

        public string Contrasenia
        {
            get
            {
                return this.Contrasenia;
            }
            set
            {
                this.Contrasenia = value;
            }
        }

        public string Mail
        {
            get
            {
                return this._Mail;
            }
            set
            {
                this._Mail = value;
            }
        }
    }
    






}