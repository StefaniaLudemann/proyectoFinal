using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Edificio
    {
        //atributos
        public int Id {  get; set; }

        [DisplayName("Nombre")]
        public string Nombre { set; get; }


        [DisplayName("Dirección")]
        public string Direccion { set; get; }

        //relacion 1:n

        public ICollection<Unidad> Unidades { set; get; }

        public ICollection<Egreso> Egresos { set; get; }


    }
}
