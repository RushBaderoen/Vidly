namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Fast & The Furious', 'Action', '22 June 2001', '18 March 2019', 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('2 Fast 2 Furious', 'Crime', '6 June 2003', '18 March 2019', 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Fast and The Furious: Tokyo Drift', 'Action', '16 June 2006', '18 March 2019', 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Gone in 60 Seconds', 'Action', '9 June 2000', '18 March 2019', 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Baby Driver', 'Action', '28 June 2017', '18 March 2019', 5)");
        }
        
        public override void Down()
        {
        }
    }
}
