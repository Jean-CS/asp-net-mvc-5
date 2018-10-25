namespace Vidly.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.MembershipType.AddOrUpdate(x => x.Id,
                new MembershipType() { Id = 1, Name = "Pay as you go", SignUpFee = 0, DiscountRate = 0, DurationInMonths = 0 },
                new MembershipType() { Id = 2, Name = "Monthly", SignUpFee = 30, DiscountRate = 10, DurationInMonths = 1 },
                new MembershipType() { Id = 3, Name = "Quarterly", SignUpFee = 90, DiscountRate = 15, DurationInMonths = 4 },
                new MembershipType() { Id = 4, Name = "Annual", SignUpFee = 300, DiscountRate = 20, DurationInMonths = 12 }
                );
        }
    }
}
