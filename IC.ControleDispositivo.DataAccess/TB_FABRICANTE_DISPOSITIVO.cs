//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IC.ControleDispositivo.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_FABRICANTE_DISPOSITIVO
    {
        public TB_FABRICANTE_DISPOSITIVO()
        {
            this.TB_DISPOSITIVO = new HashSet<TB_DISPOSITIVO>();
            this.TB_MODELO_DISPOSITIVO = new HashSet<TB_MODELO_DISPOSITIVO>();
        }
    
        public int CODIGO_FABRICANTE { get; set; }
        public string NM_FABRICANTE_DISPOSITIVO { get; set; }
    
        public virtual ICollection<TB_DISPOSITIVO> TB_DISPOSITIVO { get; set; }
        public virtual ICollection<TB_MODELO_DISPOSITIVO> TB_MODELO_DISPOSITIVO { get; set; }
    }
}
