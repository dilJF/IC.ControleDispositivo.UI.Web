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
    
    public partial class TB_UNIDADE
    {
        public TB_UNIDADE()
        {
            this.TB_DISPOSITIVO = new HashSet<TB_DISPOSITIVO>();
        }
    
        public int CODIGO_UNIDADE { get; set; }
        public int CODIGO_AGENCIA { get; set; }
        public string NM_UNIDADE { get; set; }
    
        public virtual TB_AGENCIA TB_AGENCIA { get; set; }
        public virtual ICollection<TB_DISPOSITIVO> TB_DISPOSITIVO { get; set; }
    }
}
