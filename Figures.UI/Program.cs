namespace Figures.UI
{
    using System;
    using FiguresApp.Figures_Entities;

    class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase(@"DESKTOP-LTPHR86\CLOVER", "Figures");
            int choice;

            do
            {
                Console.Clear();
                choice = _2d_Figures.Main_Menu();
                switch (choice)
                {
                    case 1: _2d_Figures.TopicTriangle(db); break;
                    case 2: 
                        int sub_choice = _2d_Figures.Quadrangles_Submenu();
                        _2d_Figures.SelectFigure(db, sub_choice);
                        break;
                    case 3:
                        _3d_Figures.TopicCube(db);
                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 0: break;
                }
            }
            while (choice != 0);
        }
    }
}
