using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class TipoEgreso
    {

        public int Id { get; set; }

        [DisplayName("Pago al portero")]
        public decimal PagoPortero { get; set; }

        [DisplayName("Cargas sociales")]
        public decimal CargasSociales { get; set; }

        [DisplayName("Sueldos")]
        public decimal Suterth { get; set; }

        [DisplayName("Horas extra")]
        public decimal ExtraHours { get; set; }

        [DisplayName("Día del padre")]
        public decimal FatherDay { get; set; }

        [DisplayName("Deudas")]
        public decimal Debt { get; set; }

        [DisplayName("SAT")]
        public decimal Sat { get; set; }

        [DisplayName("Honorarios del contador")]
        public decimal HonorariosContador { get; set; }

        [DisplayName("Honorarios del administrador")]
        public decimal HonorariosAdministrador { get; set; }

        [DisplayName("Salud pública")]
        public decimal SaludPublica { get; set; }

        [DisplayName("Seguro accidental")]
        public decimal SeguroAccidental { get; set; }

        [DisplayName("Fumigación")]
        public decimal Fumigacion { get; set; }

        [DisplayName("Remitos")]
        public decimal Remitos { get; set; }

        [DisplayName("Productos de limpieza")]
        public decimal ProdLimpieza { get; set; }

        [DisplayName("Gastos varios")]
        public decimal GastosVarios { get; set; }
    }
}
