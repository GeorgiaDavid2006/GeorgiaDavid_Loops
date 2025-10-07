using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_Loops
{
    internal class Program
    {
        static bool gameOver;

        static int playerX = 0;
        static int playerY = 0;

        static void Main(string[] args)
        {
            PlayerDraw(playerX, playerY);

            while(gameOver == false)
            {
                PlayerUpdate();
            }

            void PlayerDraw(int x, int y)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(x, y);
                Console.Write("O");
            }

            void TrailDraw(int x, int y)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            void PlayerUpdate()
            {
                ConsoleKeyInfo playerInput = Console.ReadKey();

                TrailDraw(playerX, playerY);

                if (playerInput.Key == ConsoleKey.LeftArrow)
                {
                    playerX = playerX - 1;
                    PlayerDraw(playerX, playerY);
                }
                else if (playerInput.Key == ConsoleKey.RightArrow)
                {
                    playerX = playerX + 1;
                    PlayerDraw(playerX, playerY);
                }
                else if (playerInput.Key == ConsoleKey.UpArrow)
                {
                    playerY = playerY - 1;
                    PlayerDraw(playerX, playerY);
                }
                else if (playerInput.Key == ConsoleKey.DownArrow)
                {
                    playerY = playerY + 1;
                    PlayerDraw(playerX, playerY);
                }
            }
        }
    }
}
