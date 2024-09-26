using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProgram
{
    internal class Program
    {
        enum chesspieces : int
        {
            T_W = 2,
            T_B = 20,
            KnW = 3,
            KnB = 30,
            B_W = 4,
            B_B = 40,
            KiW = 6,
            KiB = 60,
            Q_W = 5,
            Q_B = 50,
            P_W = 1,
            P_B = 10,
            OOO = 0
        }
        static void Main(string[] args)
        {
            int[,] chessboard = new int[8, 8];
            bool loop = true;
            string line;
            int movepiece_y = 0;
            int movepiece_x;
            int moveto_y = 0;
            int moveto_x;
            chessboard[0, 0] = 20; //Towers
            chessboard[0, 7] = 20;
            chessboard[7, 0] = 2;
            chessboard[7, 7] = 2;
            chessboard[0, 1] = 30; //Knights
            chessboard[0, 6] = 30;
            chessboard[7, 1] = 3;
            chessboard[7, 6] = 3;
            chessboard[0, 2] = 40; //Bishops
            chessboard[0, 5] = 40;
            chessboard[7, 2] = 4;
            chessboard[7, 5] = 4;
            chessboard[0, 3] = 60; //Kings
            chessboard[7, 3] = 6;
            chessboard[0, 4] = 50; //Queens
            chessboard[7, 4] = 5;
            chessboard[1, 0] = 10; //Pawns
            chessboard[1, 1] = 10;
            chessboard[1, 2] = 10;
            chessboard[1, 3] = 10;
            chessboard[1, 4] = 10;
            chessboard[1, 5] = 10;
            chessboard[1, 6] = 10;
            chessboard[1, 7] = 10;
            chessboard[6, 0] = 1;
            chessboard[6, 1] = 1;
            chessboard[6, 2] = 1;
            chessboard[6, 3] = 1;
            chessboard[6, 4] = 1;
            chessboard[6, 5] = 1;
            chessboard[6, 6] = 1;
            chessboard[6, 7] = 1;
            do
            {
                for (int x = 0; x < chessboard.GetLength(0); x++)
                {
                    Console.Write($"{x + 1}  ");
                    for (int y = 0; y < chessboard.GetLength(1); y++)
                    {
                        Console.Write($"{(chesspieces)chessboard[x, y]}" + " ");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("    A   B   C   D   E   F   G   H");
                Console.WriteLine("==================================");
                Console.WriteLine("Type which column(letters) you would like to move a piece from");
                line = Console.ReadLine().ToLower();
                if (line == "quit")
                {
                    loop = false;
                    break;
                }
                switch (line)
                {
                    case "a":
                        movepiece_y = 0;
                        break;
                    case "b":
                        movepiece_y = 1;
                        break;
                    case "c":
                        movepiece_y = 2;
                        break;
                    case "d":
                        movepiece_y = 3;
                        break;
                    case "e":
                        movepiece_y = 4;
                        break;
                    case "f":
                        movepiece_y = 5;
                        break;
                    case "g":
                        movepiece_y = 6;
                        break;
                    case "h":
                        movepiece_y = 7;
                        break;
                }
                Console.WriteLine("Next type which line(number)");
                movepiece_x = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Which column do you want to move it to?");
                line = Console.ReadLine().ToLower();
                switch (line)
                {
                    case "a":
                        moveto_y = 0;
                        break;
                    case "b":
                        moveto_y = 1;
                        break;
                    case "c":
                        moveto_y = 2;
                        break;
                    case "d":
                        moveto_y = 3;
                        break;
                    case "e":
                        moveto_y = 4;
                        break;
                    case "f":
                        moveto_y = 5;
                        break;
                    case "g":
                        moveto_y = 6;
                        break;
                    case "h":
                        moveto_y = 7;
                        break;
                }
                Console.WriteLine("Which line (numbers) do you want to move it to?");
                moveto_x = Convert.ToInt32(Console.ReadLine()) - 1;
                chessboard[moveto_x, moveto_y] = chessboard[movepiece_x, movepiece_y];
                chessboard[movepiece_x, movepiece_y] = 0;
                Console.Clear();
            } while (loop);
        }
    }
}
