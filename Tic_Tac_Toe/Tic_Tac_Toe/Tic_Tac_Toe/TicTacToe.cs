using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
		//Khoi tao
        public TicTacToe(){
            play();
        }
        
        //Luot choi
        public void play() {
            int moveCounter = 0;
            Board gameBoard = new Board();
            
            Player playerX = new Player('X');
            Player playerO = new Player('O');


            Player currentPlayer = playerX;
            
            bool play = false;
            Console.WriteLine("---Game Options---");
            Console.WriteLine("1. 1 Player");
            Console.WriteLine("2. 2 Players ");
            Console.WriteLine("0. Exit");
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    play = true;
                    playerO = new Bot('O');
                }
                else if (input == 2)
                {
                    playerO = new Player('O');
                    play = true;
                }
                else
                {
                    Environment.Exit(0);

                }
            }
            catch (Exception e)
            {
                Environment.Exit(0);
            }
      
          
            while (play)
            {
                Console.Clear();
                gameBoard.printBoard();
                Console.WriteLine("Player {0} turn", currentPlayer.getSign() =='X' ? 1 : 2);

                try
                {
                    gameBoard.putMark(currentPlayer, currentPlayer.takeVertical(), currentPlayer.takeHorizontal());
                    gameBoard.clearBoard();
                    moveCounter++;

                    if (currentPlayer.checkWin(gameBoard))
                    {
                        Console.WriteLine("Player: {0} won!", currentPlayer.getSign());
                        gameBoard.printBoard();
                        play = false;
                    }
                    else if (checkDraw(moveCounter))
                    {
                        Console.WriteLine("DRAW");
                        gameBoard.printBoard();
                        play = false;
                    }
                    currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
      
        //Kiem tra luot di cuoi
        private bool checkDraw(int turnCounter)
        {
            if (turnCounter == 16)
                return true;
            return false;
        }

    }

}

