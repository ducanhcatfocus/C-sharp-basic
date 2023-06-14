using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player{
        char sign;  //ký hiệu người chơi

      

        public char Sign { get => sign;}

        //Khởi tạo người chơi
        public Player(char playerSign='X'){
            sign = playerSign;
        }
        //Lấy ký hiệu người chơi
        public char getSign(){
            return sign;
        }
        //Đọc lượt đi người chơi
        public virtual int takeVertical(){
            Console.WriteLine("Enter vertical axis coordinates (1-8): ");
            int vertical = int.Parse(Console.ReadLine());
            switch (vertical)
            {
                case 1: 
                    vertical = 3;
        
                    break;
                case 2: vertical = 2; break;
                case 3: vertical = 1; break;
                case 4: vertical = 0; break;
                default: vertical = 0; break;

            }


            return vertical;
        }
        public virtual int takeHorizontal()
        {
            int horizontal;
            Console.WriteLine("Enter horzontal axis coordinates (a-h): ");
            char input = char.Parse(Console.ReadLine());
            switch (input)
            {
                case 'a': horizontal = 0; break;
                case 'b': horizontal = 1; break;
                case 'c': horizontal = 2; break;
                case 'd': horizontal = 3; break;
            

                default: horizontal = 0; break;

            }
       

            return horizontal;
        }
        //Xác định 3d thẳng hàng
        private bool checkRowCol(FIELD c1, FIELD c2, FIELD c3, FIELD c4){
            return (c1 != FIELD.EMPTY) && (c1 == c2) && (c2 == c3) && (c3 == c4);
        }
        //Kiểm tra 3d hàng ngang
        private bool checkRowsForWin(Board gameBoard){
            for (int i = 0; i < Board.BOARD_SIZE; i++)
            {
                if (checkRowCol(gameBoard.board[i, 0].getFieldState(),
                        gameBoard.board[i, 1].getFieldState(), 
                        gameBoard.board[i, 2].getFieldState(),
                         gameBoard.board[i, 3].getFieldState()
                        ))
                    return true;
            }
            return false;
        }
        //Kiểm tra 3d hàng dọc
        private bool checkColumnsForWin(Board gameBoard){
            for (int i = 0; i < Board.BOARD_SIZE; i++)
            {
                if (checkRowCol( gameBoard.board[0, i].getFieldState(),
                        gameBoard.board[1, i].getFieldState(),
                        gameBoard.board[2, i].getFieldState(),
                          gameBoard.board[3, i].getFieldState()
                        ))
                    return true;
            }
            return false;
        }
        //Kiểm tra 3d hàng chéo
        private bool checkDiagonalsForWin(Board gameBoard){
            return (( checkRowCol(gameBoard.board[0, 0].getFieldState(),
                    gameBoard.board[1, 1].getFieldState(), 
                    gameBoard.board[2, 2].getFieldState(),
                     gameBoard.board[3, 3].getFieldState()
                    ) == true) ||
                    (checkRowCol(gameBoard.board[0, 3].getFieldState(),
                    gameBoard.board[1, 2].getFieldState(),
                    gameBoard.board[2, 1].getFieldState(), 
                    gameBoard.board[3, 0].getFieldState()) == true));
        }
        //Kiểm tra trạng thái
        public bool checkWin(Board gameBoard) {
            return (checkRowsForWin(gameBoard) || checkColumnsForWin(gameBoard) || checkDiagonalsForWin(gameBoard));
        }
    
	}

    public class Bot: Player
    {
        Random random = new Random();


        public Bot(char playerSign = 'O') : base(playerSign) {
           
        }


        public override int takeVertical()
        {
          
            int vertical;
           
                vertical = random.Next(0, 4);
        
            return vertical;
        }

        public override int takeHorizontal()
        {
  
       

            int horizontal;
         
                horizontal = random.Next(0, 4);
          
            return horizontal;
        }
    }
}
