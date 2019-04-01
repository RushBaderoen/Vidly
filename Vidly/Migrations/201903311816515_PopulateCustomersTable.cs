namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Johnny Customer', 0, 1, '1990/01/01')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Jimmy Customer', 1, 2, '1995/12/12')");
        }

        public override void Down()
        {
        }
    }
}
