//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarCenterWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VEHICULOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEHICULOS()
        {
            this.PERSONA_VEHICULO = new HashSet<PERSONA_VEHICULO>();
        }
    
        public string PLACA { get; set; }
        public string MARCA { get; set; }
        public decimal MODELO { get; set; }
        public string COLOR { get; set; }
        public string TIPO_VEHICULO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONA_VEHICULO> PERSONA_VEHICULO { get; set; }
    }
}
