namespace DataLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Library")]
    public partial class Library
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int BookID { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime Deadline { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReturnedDate { get; set; }

        public virtual Books Books { get; set; }

        public virtual Books Books1 { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
