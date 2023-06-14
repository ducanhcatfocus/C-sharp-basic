using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum FIELD { EMPTY = ' ', X = 'X', O = 'O' }

    public class Cell
    {
        //Giá trị hiển thị tại ô
        FIELD fieldState=FIELD.EMPTY;
        //Khởi tạo ô giá trị rỗng
        public Cell(){
            fieldState = FIELD.EMPTY;
        }
        //Lấy giá trị tại ô
        public FIELD getFieldState() {
            return fieldState;
        }
        //Kiểm tra ô rỗng
        public bool isEmpty(){
            if (fieldState!= FIELD.EMPTY)
                return false;
            return true;
        }
        //Gán giá trị tại ô theo dấu
        public void markField(Player player){
            if(isEmpty())
            {
                if (player.getSign() == 'X')
                    fieldState = FIELD.X;
                else
                    fieldState = FIELD.O;
            }
        }
    }
}
