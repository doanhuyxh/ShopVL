namespace Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LEVEL")]
    public partial class LEVEL
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TEN_LEVEL { get; set; }

        [StringLength(50)]
        public string SLUG { get; set; }

        [StringLength(250)]
        public string MO_TA { get; set; }

        public bool? TRANG_THAI { get; set; }

        public bool? IS_REMOVE { get; set; }
    }
}
