using System.Data.Entity;

namespace Atom
{
    public class PharmacyData:DbContext
    {
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Prospect> Prospects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TbUser> TbUsers { get; set; }
    }
}
