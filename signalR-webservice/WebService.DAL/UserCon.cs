namespace WebService.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UserCon : DbContext
    {
        public UserCon()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<UserConnection> UserConnections { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
