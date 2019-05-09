using System;
using System.Collections.Generic;
using System.Text;

namespace trab1_LP1
{
    class Renderer
    {
        private char[,] tiles = new char[5, 5];

        /// <summary>
        /// Prints the game board on the console
        /// </summary>
        /// <param name="board">Board class variable that calls a 2 dimentional array</param>
        public void Render(Board board)
        {
            for (int row = 0; row < 5; row++)
                for (int column = 0; column < 5; column++)
                    tiles[row, column] = TileFill(board.GetState(new Position(row, column)));

            Console.WriteLine(" ___ ___ ___ ___ ___");
            Console.WriteLine($"  {tiles[0, 0]} | {tiles[0, 1]} | {tiles[0, 2]} | {tiles[0, 3]} | {tiles[0, 4]} ");
            Console.WriteLine("|---+---+---+---+---|");
            Console.WriteLine($"  {tiles[1, 0]} | {tiles[1, 1]} | {tiles[1, 2]} | {tiles[1, 3]} | {tiles[1, 4]} ");
            Console.WriteLine("|---+---+---+---+---|");
            Console.WriteLine($"  {tiles[2, 0]} | {tiles[2, 1]} | {tiles[2, 2]} | {tiles[2, 3]} | {tiles[2, 4]} ");
            Console.WriteLine("|---+---+---+---+---|");
            Console.WriteLine($"  {tiles[3, 0]} | {tiles[3, 1]} | {tiles[3, 2]} | {tiles[3, 3]} | {tiles[3, 4]} ");
            Console.WriteLine("|---+---+---+---+---|");
            Console.WriteLine($"  {tiles[4, 0]} | {tiles[4, 1]} | {tiles[4, 2]} | {tiles[4, 3]} | {tiles[4, 4]} ");
            Console.WriteLine(" ___ ___ ___ ___ ___");
        }

        /// <summary>
        /// Sets specific coordinates to a base piece from
        ///  the BasePiece enumeration
        /// </summary>
        private void FixedPositions()
        {
            tiles[1, 1] = (char)BasePiece.Mirror;
            tiles[1, 3] = (char)BasePiece.Mirror;
            tiles[3, 1] = (char)BasePiece.Mirror;
            tiles[1, 3] = (char)BasePiece.Mirror;

            tiles[0, 2] = (char)BasePiece.Portal;
            tiles[2, 4] = (char)BasePiece.Portal;
            tiles[4, 2] = (char)BasePiece.Portal;
        }

        /// <summary>
        /// Prints a specific char character according to the
        ///  set State enumeration
        /// </summary>
        /// <param name="state">Variable that calls the State enumeration </param>
        /// <returns></returns>
        private char TileFill(State state)
        {
            switch (state)
            {
                case State.J1: return 'F';
                case State.J2: return 'G';
                default: return 'O';
            }
        }
    }
}
