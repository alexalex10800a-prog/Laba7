namespace DAL7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.participation")]
    public partial class participation
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        public int employee_id_FK1 { get; set; }

        public int project_code_FK2 { get; set; }

        public virtual employee employee { get; set; }

        public virtual project project { get; set; }
    }
}
