using System;
using System.Collections.Generic;
using System.Text;

namespace trab1_LP1
{
    class Player
    {
        /// <summary>
        /// Gets the coordinates of a position inside an array
        /// </summary>
        /// <param name="board">Board class variable that calls a board array</param>
        /// <returns></returns>
        public Position GetPosition(Board board)
        {
            string position = Console.ReadLine();
            int sizePosition = position.Length;

            if (sizePosition > 2)
            {
                position = Console.ReadLine();
                sizePosition = position.Length;
            }

            Position desiredCoordinate = PiecePosition(position);
            return desiredCoordinate;
        }

        /// <summary>
        /// Receives a position string input and associates it with a coordinate
        /// </summary>
        /// <param name="position">string input</param>
        /// <returns></returns>
        private Position PiecePosition(string position)
        {
            switch (position) //row - column
            {
                //--row 1
                case "a1": return new Position(0, 0); // 1 - 1
                case "a2": return new Position(0, 1); // 1 - 2 
                case "a3": return new Position(0, 2); // 1 - 3
                case "a4": return new Position(0, 3); // 1 - 4
                case "a5": return new Position(0, 4); // 1 - 5
                //--row 2
                case "b1": return new Position(1, 0); // 2 - 1
                case "b2": return new Position(1, 1); // 2 - 2 
                case "b3": return new Position(1, 2); // 2 - 3
                case "b4": return new Position(1, 3); // 2 - 4
                case "b5": return new Position(1, 4); // 2 - 5
                //--row 3
                case "c1": return new Position(2, 0); // 3 - 1
                case "c2": return new Position(2, 1); // 3 - 2 
                case "c3": return new Position(2, 2); // 3 - 3
                case "c4": return new Position(2, 3); // 3 - 4
                case "c5": return new Position(2, 4); // 3 - 5
                //--row 4
                case "d1": return new Position(3, 0); // 3 - 1
                case "d2": return new Position(3, 1); // 3 - 2 
                case "d3": return new Position(3, 2); // 3 - 3
                case "d4": return new Position(3, 3); // 3 - 4
                case "d5": return new Position(3, 4); // 3 - 5
                //--row 5
                case "e1": return new Position(4, 0); // 3 - 1
                case "e2": return new Position(4, 1); // 3 - 2 
                case "e3": return new Position(4, 2); // 3 - 3
                case "e4": return new Position(4, 3); // 3 - 4
                case "e5": return new Position(4, 4); // 3 - 5

                default: return null;
            }
        }
    }
}
