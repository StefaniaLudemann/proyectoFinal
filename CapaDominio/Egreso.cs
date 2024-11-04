using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Egreso
    {

        //atributos
        public int Id { get; set; }

        [DisplayName("Descripción")]

        public string Descripcion { set; get; }


        [DisplayName("Monto")]
        public decimal Monto { set; get; }

        /// preguntar si se debe cargar la fecha de manera manual o automatica 
        [DisplayName( "Fecha De Egreso")]
        public DateTime FechaPublicacion { get; set; } = DateTime.Now;

        
        [DisplayName("Tipo De Egreso")]
        public TipoEgreso TipoEgreso { set; get; }


    }
}
