namespace languageDetecter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ö
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string word { get; set; }

        public int? LanguagesId { get; set; }
    }
}
