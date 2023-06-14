using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    public class Board
    {
        public const int BOARD_SIZE = 4;    //kích thước cố định
        public Cell[,] board;               //ma trận 2 chiều
        //Khởi tạo bảng rỗng
        public Board(){
            board = new Cell[BOARD_SIZE,BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    board[i, j] = new Cell();
                }
            }
        }
        //Hiển thị bảng
        public void printBoard(){
            Console.ForegroundColor = ConsoleColor.Green;
            int fieldNumber = 1;
            Console.WriteLine("   a  b  c  d  ");
            for (int i = 0; i < BOARD_SIZE; i++){
                for (int j = 0; j < BOARD_SIZE; j++){

                    if (j == 0) Console.Write(BOARD_SIZE - i + " ");

                    if (board[i, j].isEmpty())
                    {
                        
                        Console.Write("[ ]");
                    }

                    else
                    {
                        Console.Write("[" + (char)(board[i, j].getFieldState()) + "]");
                        

                    }

                    fieldNumber++;

                }
                Console.Write("\n");
            }
            Console.WriteLine("-----");
        }
        //Xác định tạo độ
        public void putMark(Player player, int verticalY, int horizontalX){
            //int verticalY = (fieldNumber - 1) / BOARD_SIZE;
            //int horizontalX = (fieldNumber - 1) % BOARD_SIZE;
            if (board[verticalY, horizontalX].isEmpty())
                board[verticalY, horizontalX].markField(player);
            else  {
                if(player.Sign == 'X')
                {
                Console.WriteLine("This place is taken. Select the field again: ");

                }
                putMark(player, player.takeVertical(), player.takeHorizontal());
            }
        }
        //Xóa bảng
        public void clearBoard(){
            Console.Clear();
        }
    
    }
}
