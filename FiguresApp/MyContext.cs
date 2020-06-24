namespace Figures.EntityData
{
    using FiguresApp.Figures_Entities;
    using System.Data.Entity;

    public class MyContext : DbContext
    {
        public MyContext() : base("connection") { }

        public virtual DbSet<Triangle> Triangles { get; set; }
        public virtual DbSet<Square> Squares { get; set; }
        public virtual DbSet<Rectangle> Rectangles { get; set; }
        public virtual DbSet<Rhomb> Rhombs { get; set; }
        public virtual DbSet<Parallelogram> Parallelograms { get; set; }
        public virtual DbSet<Cube> Cubes { get; set; }
        public virtual DbSet<Prism> Prisms { get; set; }
        public virtual DbSet<Parallelepiped> Parallelepipeds { get; set; }
        public virtual DbSet<Pyramid> Pyramids { get; set; }

    }
}
