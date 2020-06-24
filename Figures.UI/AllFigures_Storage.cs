namespace Figures.UI
{
    using Figures.Logic;
    using Figures.EntityData;
    using System.Collections;

    static class AllFigures_Storage
    {
        static MyContext db = new MyContext();
        public static string connect = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        public static ArrayList FiguresInfo()
        {
            ArrayList all = new ArrayList();
            all.AddRange(ReadFiguresFromDB.ReadAllTriangles(connect));
            all.AddRange(ReadFiguresFromDB.ReadAllSquares(connect));
            all.AddRange(ReadFiguresFromDB.ReadAllRectangles(connect));
            all.AddRange(ReadFiguresFromDB.ReadAllRhombs(connect));
            all.AddRange(ReadFiguresFromDB.ReadAllParallelograms(connect));
            all.AddRange(ReadFiguresFromDB.ReadAllCubes(connect));
            all.AddRange(ReadFiguresFromDB.ReadAllPrisms(connect));
            all.AddRange(ReadFiguresFromDB.ReadAllParallelepipeds(connect));
            all.AddRange(ReadFiguresFromDB.ReadAllPyramids(connect));

            return all;
        }
    }
}
