//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace szkolkarz
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADM_ARTICLE
    {
        public ADM_ARTICLE()
        {
            this.ADM_CERTIFICATE_ARTICLE_REF = new HashSet<ADM_CERTIFICATE_ARTICLE_REF>();
        }
    
        public int ID { get; set; }
        public string ARTICLE { get; set; }
        public System.DateTime YEAR { get; set; }
    
        public virtual ICollection<ADM_CERTIFICATE_ARTICLE_REF> ADM_CERTIFICATE_ARTICLE_REF { get; set; }
    }
}