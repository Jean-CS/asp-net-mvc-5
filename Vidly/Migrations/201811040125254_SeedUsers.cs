namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO dbo.AspNetUsers (Id, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName)
VALUES 
  (N'155a0e69-0d53-43d3-bb35-bb09286e67d5', N'guest@vidly.com', 0, N'AOeKxtPdCxn9867t2qa/HK7XBctSCtG0Al85e42PyUT4CkbNGAIyvwLHiRXxzG1edw==', N'e9e446ce-9dcd-4de7-bbf5-9bb992482999', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com'),
  (N'6c4a605e-55fc-4c5f-8c42-3b60f1cc2cdd', N'admin@vidly.com', 0, N'AHbDWNGVvBCAsaerTwatQeXXx/5m99hN9e3fdpdZ3b4zCptyU4mbAZb72l+wkVpAvQ==', N'bee5daff-b243-4639-bca6-a54ef6294569', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO dbo.AspNetRoles (Id, Name)
VALUES 
  (N'b3025c72-9ac8-46cd-b9a7-9125637ad4cd', N'CanManageMovies')

INSERT INTO dbo.AspNetUserRoles (UserId, RoleId)
VALUES 
  (N'6c4a605e-55fc-4c5f-8c42-3b60f1cc2cdd', N'b3025c72-9ac8-46cd-b9a7-9125637ad4cd')
");
        }

        public override void Down()
        {
        }
    }
}
