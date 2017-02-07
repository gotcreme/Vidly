namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1a3a9d42-2a58-435b-a7c2-900b0b37d152', N'guest@vidly.com', 0, N'AN44zYFEFL9wg12kkyCbtX3hIHIVXLJ4i+X0Pq/aveXTe/PkCtBy0Z02aBTDfJplCA==', N'cbee61f3-f875-410b-a214-15d253e3bf40', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7e124cfa-8ac8-4a47-832c-a552040cfa15', N'admin@vidly.com', 0, N'ACbsQg74fdBEb9RoZDHRVtatIJXfTKsqt23NnX0ELMJO1E5QvXeyHgCiCx1K6xWJcw==', N'0b5ee6cc-bf5e-4df4-846c-ca47fd985790', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3c765be0-2812-452f-b231-d7b8471e6b40', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7e124cfa-8ac8-4a47-832c-a552040cfa15', N'3c765be0-2812-452f-b231-d7b8471e6b40')
");
        }

        public override void Down()
        {
        }
    }
}
