using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MODELO
{
    public class Propiedad
    {
        public Inmobilaria inmobiliaria { get; set; }
        public string domicilioPropiedad { get; set; }

        public string nombrePropietario { get; set; }

        public int telefono { get; set; }

        public int superficieCubierta { get; set; }
         
        public float importe { get; set; }
    }
    public class Casa: Propiedad
    {
        public int superficieDescubierta { get; set; }

        public float valor
        {
            get
            {
                return calcularValor(superficieCubierta, superficieDescubierta);
            }
        }
        public float calcularValor(float supCubierta, float supDescubierta)
        {
            float valorPropiedad = 0;
            

            valorPropiedad = superficieCubierta * inmobiliaria.precio_m2 + superficieDescubierta * inmobiliaria.precio_m2;

            return valorPropiedad;
        }
    }
    public class Departamento: Propiedad
    {
        public float valor
        {
            get
            {
                return calcularValor(superficieCubierta);
            }
        }

        float calcularValor(float supTotal)
        {
            float valorPropiedad = 0;
            
            valorPropiedad = supTotal * inmobiliaria.precio_m2;

            return valorPropiedad;
        }
    }
}
