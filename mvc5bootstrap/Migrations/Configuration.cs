namespace mvc5bootstrap.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<mvc5bootstrap.Concrete.EfContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //  AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(mvc5bootstrap.Concrete.EfContext context)
        {
            Team t1 = new Team() { TeamID = 1, Name = "Barcelona" };
            Team t2 = new Team() { TeamID = 2, Name = "Real Madrid" };

            Player pl1 = new Player() { PLayerID = 1, Name = "Lionel", SurName = "Messi", Age = 29, TeamID = 1 };
            Player pl2 = new Player() { PLayerID = 2, Name = "Cristiano", SurName = "Ronaldo", Age = 31, TeamID = 2 };
            t1.PLayers.Add(pl1);
            t2.PLayers.Add(pl2);
            context.Teams.Add(t1);
            context.Teams.Add(t2);

            context.Players.Add(pl1);
            context.Players.Add(pl2);
        }
    }
}
