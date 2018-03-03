using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telemarketer_Simulator;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x++ < 1500)
            {
                
                GameTools.WriteColoredParagraph(" ", ConsoleColor.White, ConsoleColor.White);
                GameTools.WriteColoredParagraph(" ", ConsoleColor.Blue, ConsoleColor.Blue);
                while (x++ > 1100 && x++ < 1500)
                {
                    GameTools.WriteColoredParagraph(" ", ConsoleColor.Black, ConsoleColor.Black);
                }
            }

                       ETC s = new ETC();
            GameTools.WriteColoredParagraph("", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();
            GameTools.WriteColoredParagraph("", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();
            GameTools.WriteColoredParagraph("", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();
            GameTools.WriteColoredParagraph("_________________________TELEMARKETER SIMULATOR______________________________", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();
            GameTools.WriteColoredParagraph("_________________________Made by: Aaron Prather_________________________", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();
            GameTools.WriteColoredParagraph(@"_________________________A C# Production!_________________________", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();
            GameTools.WriteColoredParagraph(@"___Think you have what it takes to make it in the telemarketing business?___", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();
            GameTools.WriteColoredParagraph(@"_________________________Are you Ready to begin?_________________________", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();
            GameTools.WriteColoredParagraph("", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();
            GameTools.WriteColoredParagraph("", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();
            GameTools.WriteColoredParagraph("", ConsoleColor.Cyan, ConsoleColor.DarkBlue);
            s.sp();

            string c = GameTools.GetChoice("y", "n");
            

            while (c == "y")
            {               
                Phone p = new Phone();
                s.s();
                p.Play();
                s.sp();
               
                
            }
        }
    }
}