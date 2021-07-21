using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Inmobilaria
    {

        float _precio;
        public float precio_m2
        {
            get
            {
                return _precio;
            }

            set
            {
                _precio = value;
            }
        }
        public Inmobilaria()
        {
            PROPIEDADES = new List<Propiedad>();
        }

        public List<Propiedad> PROPIEDADES { get; set; }

    }
}


