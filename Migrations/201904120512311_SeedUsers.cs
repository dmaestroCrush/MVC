namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4c073816-c568-4a2d-b782-44070dd67d88', N'guest@vidly.com', 0, N'AAf0Cd8xA0VsQabXM7LzxLf9gWg57SBT7IV0mc7Bd4jJVjvI1LJcCgrb/ZGDuYQS2A==', N'504f0ff1-e31f-4949-b8c9-c8d7b1719fd9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f4f5dc6a-403d-48f6-9e57-dbbe80ea6fd4', N'admin@vidly.com', 0, N'AFNSyfisOSTMwDNYSnn7r+lpdWOxrFohJAflNByUgdJNBbhGXbLsKwnXWOzc5BUQUQ==', N'9939b17e-c553-41ba-968f-42bab11d9c56', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'29f0e158-478c-40bb-baee-af0d45b25ccc', N'canManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f4f5dc6a-403d-48f6-9e57-dbbe80ea6fd4', N'29f0e158-478c-40bb-baee-af0d45b25ccc')



 
");
        }
        
        public override void Down()
        {
        }
    }
}
