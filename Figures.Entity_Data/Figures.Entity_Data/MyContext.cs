namespace Figures.Entity_Data
{
    using Figures.Entity_Data.Figures_Entities;
    using System.Data.Entity;

    public class MyContext : DbContext
    {
        public MyContext() : base("name=connection") { }

        public virtual DbSet<Triangle> Triangles { get; set; }
    }
}
