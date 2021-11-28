namespace languageDetecter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Word { get; set; }

        public int? LanguagesId { get; set; }

        public virtual Languages Languages { get; set; }
    }
}
