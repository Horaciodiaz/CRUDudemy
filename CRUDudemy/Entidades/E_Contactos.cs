using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDudemy.Entidades
{
    public class E_Contactos
    {
        public int Contacto_id { get; set; }
        public string Nombre_contacto { get; set; }
        public string Telefono_contacto { get; set; }
        public string Correo_contacto { get; set; }   
        public string Fechanac_contacto { get; set; }
        public int Cargo_id { get; set; }
    }
}
