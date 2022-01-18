using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HotelWebApplication.Models
{
    public partial class GuestContext : DbContext
    {
        public GuestContext()
            : base("name=GuestContext")
        {
        }

        public virtual DbSet<guest> Guests { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
