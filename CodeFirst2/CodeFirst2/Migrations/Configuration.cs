namespace CodeFirst2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst2.entity.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CodeFirst2.entity.Context";
        }

        protected override void Seed(CodeFirst2.entity.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
