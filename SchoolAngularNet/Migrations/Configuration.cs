namespace SchoolAngularNet.Migrations
{
    using SchoolAngularNet.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolAngularNet.Models.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolAngularNet.Models.SchoolDbContext context)
        {
            IList<Grade> defaultGrades = new List<Grade>();

            defaultGrades.Add(new Grade() { GradeId = 1, GradeName = "10" });
            defaultGrades.Add(new Grade() { GradeId = 2, GradeName = "11" });
            defaultGrades.Add(new Grade() { GradeId = 3, GradeName = "12" });

            context.Grades.AddRange(defaultGrades);

            base.Seed(context);
        }
    }
}
