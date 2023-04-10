using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Minimax.Tictactoe
{
    public class Utils
    {

        internal static int ReadInput(Char[] board)
        {
            var selectedPoss = -1;
            do
            {
                // Read position
                Console.WriteLine("  \n Select position");
                selectedPoss = Console.ReadKey().KeyChar - '0';

                // Avoid repeated positions
                if (board[selectedPoss] == 'X' || board[selectedPoss] == 'O') selectedPoss = -1;

            } while (selectedPoss > 9 || selectedPoss < 0);

            Console.WriteLine($" Selected {selectedPoss}");

            return selectedPoss;
        }



        internal static void RenderGame(Char[] board)
        {
            Console.WriteLine("");
            Console.WriteLine($"   {GameToScreen(board, 0)} | {GameToScreen(board, 1)} | {GameToScreen(board, 2)}");
            Console.WriteLine($"  ----------");
            Console.WriteLine($"   {GameToScreen(board, 3)} | {GameToScreen(board, 4)} | {GameToScreen(board, 5)}");
            Console.WriteLine($"  ----------");
            Console.WriteLine($"   {GameToScreen(board, 6)} | {GameToScreen(board, 7)} | {GameToScreen(board, 8)}");
        }

        private static Char GameToScreen(Char[] board, int poss)
        {
            if (board[poss] == '\0') return (Char)(poss + ((int)'0'));
            else return board[poss];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <returns>
        /// Winner 'X' or 'O'
        /// Tie 'E'
        /// Continue 'C'
        /// </returns>
        internal static Char CheckForWinner(Char[] board)
        {
            // Horizontals
            if ((board[0] == board[1] && board[0] == board[2]) && board[0] != '\0')
                return board[0];
            else if ((board[3] == board[4] && board[3] == board[5]) && board[3] != '\0')
                return board[3];
            else if ((board[6] == board[7] && board[6] == board[8]) && board[6] != '\0')
                return board[6];
            // Verticals
            else if ((board[0] == board[3] && board[0] == board[6]) && board[0] != '\0')
                return board[0];
            else if ((board[1] == board[4] && board[1] == board[7]) && board[1] != '\0')
                return board[1];
            else if ((board[2] == board[5] && board[2] == board[8]) && board[2] != '\0')
                return board[2];
            // Diagonals
            else if ((board[0] == board[4] && board[0] == board[8]) && board[0] != '\0')
                return board[0];
            else if ((board[2] == board[4] && board[2] == board[6]) && board[2] != '\0')
                return board[2];
            // Tied
            else if (board[0] != '\0' &&
                     board[1] != '\0' &&
                     board[2] != '\0' &&
                     board[3] != '\0' &&
                     board[4] != '\0' &&
                     board[5] != '\0' &&
                     board[6] != '\0' &&
                     board[7] != '\0' &&
                     board[8] != '\0')
            {
                return 'E';
            }

            return 'C';
        }

    }
}
