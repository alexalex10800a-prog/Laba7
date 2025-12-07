namespace DAL7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.employee")]
    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            contracts = new HashSet<contract>();
            participations = new HashSet<participation>();
        }

        [Key]
        public int employee_id { get; set; }

        [Required]
        [StringLength(200)]
        public string full_name { get; set; }

        public int specialty_code_FK1 { get; set; }

        public int department_code_FK2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contract> contracts { get; set; }

        public virtual department department { get; set; }

        public virtual specialty specialty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participation> participations { get; set; }
    }
}
