﻿namespace FiguresApp.Figures_Entities
{
    public class Square : Quadrangle
    {
        public Square() { }
        public Square(float a) : base(a) { }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override float A { get; set; }
        public override float Areaa { get => base.area; set => base.area = value; }
        public override float Perim { get => base.perim; set => base.perim = value; }

        public override float Perimeter()
        {
            return perim = a * 4;
        }

        public override float Area()
        {
            return area = (float)System.Math.Pow(a, 2);
        }

        public override int Tops
        {
            get { return sizeof(int); }
            set { tops = value; }
        }
        public override int Edges
        {
            get { return sizeof(int); }
            set { edges = value; }
        }
    }
}
