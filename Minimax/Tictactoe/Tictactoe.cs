using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Minimax.Tictactoe
{
    public class Game
    {
        // Match vars
        private static bool isPlayerTime = true;
        private static Char playerChar;
        private static Char minimaxChar;
        private static bool isFirstTime = true;


        /// <summary>
        /// Game Logic
        /// </summary>
        public static void Play()
        {

            Char[] board = new Char[9];  // true is O, false is X, null is ' '

            // Only enter here the first game
            if (isFirstTime)
            {
                // Welcome
                Console.WriteLine("Tic Tac Toe");

                // Choose player
                Console.WriteLine("Select X or O");
                do
                {
                    playerChar = Console.ReadKey().KeyChar;
                    Char.ToUpper(playerChar);  // ! Upper case doest work as expected
                } while (playerChar != 'X' && playerChar != 'O');
                Console.WriteLine($"You Choose: {playerChar}");
                if (playerChar == 'X')
                    minimaxChar = 'O';
                else
                    minimaxChar = 'X';

                isFirstTime = false;
            }

            // Print initial board
            Utils.RenderGame(board);

            Char winner;
            bool isPlayerTimeThisMatch = isPlayerTime;
            do
            {
                // Read Inputs
                var poss = -1;
                if (isPlayerTimeThisMatch)
                {
                    // Player
                    poss = Utils.ReadInput(board);
                    board[poss] = playerChar;
                }
                else
                {
                    // Minimax
                    (poss, _ ) = Minimax(minimaxChar, playerChar, board);
                    board[poss] = minimaxChar;
                }

                // Render Game
                Utils.RenderGame(board);

                // Check for winner
                winner = Utils.CheckForWinner(board);

                // Change player only for this match
                isPlayerTimeThisMatch = !isPlayerTimeThisMatch;

            } while (winner == 'C');


            Console.WriteLine($" \n\n Winner is {winner} \n\n\n\n\n ");

            // Change the start player for the next game
            isPlayerTime = !isPlayerTime;
            Play();

        }





        /// <summary>
        /// Minimax Logic
        /// </summary>
        /// <param name="winner">The char for the winner</param>
        /// <param name="loser">The char for the losser</param>
        /// <param name="board">The board</param>
        /// <param name="actual">If minimax will play for the winner or for the loser</param>
        /// <returns></returns>
        private static (int position, int score) Minimax(Char winner, Char loser, Char[] board, bool actual = true)
        {
            
            // If terminal node end recursion
            var wn = Utils.CheckForWinner(board);
            if (wn == winner)
            {
                return (-10, 1);
            }
            else if (wn == loser)
            {
                return (-10, -1);
            }
            else if (wn == 'E')
            {
                return (-10, 0);
            }

            // Continue playing
            var scores = new List<(int position, int score)>();
            for (int i = 0; i < board.Length; i++)
            {
                // if is empty, dont play in this position
                if (board[i] != '\0') continue;

                // Clone the board
                var boardCpy = (Char[])board.Clone();

                // play for the actual
                if (actual) boardCpy[i] = winner;
                else boardCpy[i] = loser;

                // call minimax with new parameters
                (_, int score) = Minimax(winner, loser, boardCpy, !actual);
                scores.Add((i, score));

            }

            // If Minimax is player, return MAX, else return MIN
            if (actual)
            {
                return scores.OrderByDescending(e => e.score).FirstOrDefault();
            }
            else
            {
                return scores.OrderBy(e => e.score).FirstOrDefault();
            }

        }


    }
}
