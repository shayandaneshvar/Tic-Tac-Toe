using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Class1 : Interface1
    {
 

        public bool haveWon(char[,] board,char c)
        {
            if(board[0,0]==c &&((board[0,1]==c&&board[0,2]==c)||(board[1, 1] == c && board[2, 2] == c) ||(board[1, 0] == c && board[2, 0] == c)))
            {
                return true;
            }
            else if(board[0, 2] == c && ((board[1, 2] == c && board[2, 2] == c) || (board[1, 1] == c && board[2, 0] == c)))
            {
                return true;
            }
            else if (board[2, 2] == c&& board[2, 1] == c&& board[2, 0] == c)
            {
                return true;
            }
            else if (board[2, 1] == c&& board[1,1] == c&& board[0, 1] == c)
            {
                return true;
            }
            else if (board[1, 1] == c && board[1, 2] == c && board[1, 0] == c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}
