namespace Figures.UI
{
    using System;
    using System.Collections;
    using FiguresApp.Figures_Entities;

    class Program
    {
        static Random rand = new Random();

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
                    case 3: _3d_Figures.TopicCube(db); break;
                    case 4:
                        _3d_Figures.TopicPyramid(db);
                        break;
                    case 5:
                        _3d_Figures.TopicPrism(db);
                        break;
                    case 6:
                        _3d_Figures.TopicParallelepiped(db);
                        break;
                    case 7:
                        Console.Clear();
                        ArrayList collection_figures = AllFigures_Storage.FiguresInfo();
                        for (int i = 0; i < collection_figures.Count; i++)
                        {
                            if (collection_figures[i] == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Tha Table of EMPTY...");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("\n" + new string('=', 120));
                                Console.ForegroundColor = _2d_Figures.RandColors()[rand.Next(0, 5)];
                                Console.WriteLine($"\n{i + 1} Record: \n");
                                Console.WriteLine(collection_figures[i]);
                                Console.ResetColor();
                            }
                        }
                        Console.WriteLine("\n" + new string('=', 120));
                        _2d_Figures.Pause();
                        break;
                    case 0: break;
                }
            }
            while (choice != 0);
        }
    }
}
