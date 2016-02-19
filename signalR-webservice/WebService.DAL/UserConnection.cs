namespace WebService.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserConnection
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ConnectionID { get; set; }
    }
}
