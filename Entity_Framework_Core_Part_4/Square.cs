//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Framework_Core_Part_4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Square
    {
        public int id { get; set; }
        public string square1 { get; set; }
    
        public virtual Countris Countris { get; set; }
    }
}
