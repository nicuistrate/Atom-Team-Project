namespace Atom.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Atom.PharmacyData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Atom.PharmacyData context)
        {
            context.Medicaments.AddOrUpdate(x => x.Id,
                new Medicament() { Id = 1, IdUser = 1, IdPharm = 1, IdProspect = 1, MedName = "Paracetamol", MedPrice = 5, MedQuantity = 10 },
                new Medicament() { Id = 2, IdUser = 2, IdPharm = 2, IdProspect = 2, MedName = "Coldrex", MedPrice = 3, MedQuantity = 0 },
                new Medicament() { Id = 3, IdUser = 1, IdPharm = 3, IdProspect = 1, MedName = "Algocalmin", MedPrice = 7, MedQuantity = 5 },
                new Medicament() { Id = 4, IdUser = 2, IdPharm = 4, IdProspect = 1, MedName = "Vitamine", MedPrice = 2, MedQuantity = 10 });

            context.Pharmacies.AddOrUpdate(x => x.Id,
                new Pharmacy() { Id = 1, IdDoctor = 1, PharmName = "Catena", City = "Cluj", },
                new Pharmacy() { Id = 2, IdDoctor = 2, PharmName = "Remedium", City = "Bucuresti", },
                new Pharmacy() { Id = 3, IdDoctor = 3, PharmName = "Help Net", City = "Brasov", },
                new Pharmacy() { Id = 4, IdDoctor = 4, PharmName = "Dona", City = "Timisoara" });


            context.Prospects.AddOrUpdate(x => x.Id,
                new Prospect() { Id = 1, Usage = "Cold", Recommandations = "2xDay", Reactions = "Better health", },
                new Prospect() { Id = 2, Usage = "Headache", Recommandations = "3xDay", Reactions = "Unknown" });

            context.TbUsers.AddOrUpdate(x => x.Id,
                new TbUser() { Id = 1, Username = "admin", Password = "admin", },
                new TbUser() { Id = 2, Username = "nicu1234", Password = "1234" });

            context.Users.AddOrUpdate(x => x.Id,
                new User() { Id = 1, FirstName = "Nicu", LastName = "Istrate", City = "Cluj", CNP = 1970401323901, },
                new User() { Id = 2, FirstName = "John", LastName = "Andrei", City = "Bucuresti", CNP = 1930201121212 });
        }
    }
}
