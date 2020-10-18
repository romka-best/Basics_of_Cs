using System;

namespace ConsoleApp1
{
    class Program
    {
        static string[,] gameField =
        {
            {"*", "*", "*"},
            {"*", "*", "*"},
            {"*", "*", "*"}
        };

        private static string playerMark = "X";
        private static string computerMark = "O";


        /*static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                drawField();
                playerTurn();
                checkWin(playerMark);
                checkWin(computerMark);
            }
            // Console.WriteLine("Hello World!");
        }*/

        private static void drawField()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"| {gameField[i, j]} |");
                }
                Console.WriteLine();
            }
            checkWin(playerMark);
            checkWin(computerMark);
        }

        private static void playerTurn()
        {
            try
            {
                Console.WriteLine("Введите строку [0,2]: ");
                int i = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("Введите строку [0,2]: ");
                int j = Convert.ToInt32(Console.ReadLine());

                if (gameField[i, j].Equals("*"))
                {
                    gameField[i, j] = playerMark;
                    drawField();
                }
                else
                {
                    Console.WriteLine("Клетка занята");
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Введите корректные значения");
                playerTurn();
            }
        }

        private static void computerTurn()
        {
            // Рандомим два значения индексов 
            // Проверяем, свободна ли клетка
            // Если да - ставим туда "O" и отрисовываем поле
            // Если нет - возвращаем 
            
        }
        
        private static void checkWin(string tag)
        {
            /*if(gameField[0, 0].Equals(tag) && gameField[0, 1].Equals(tag) && gameField[0, 2].Equals(tag) ||
               )*/
        }
    }
}
