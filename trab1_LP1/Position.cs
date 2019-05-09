using System;
using System.Collections.Generic;
using System.Text;

namespace trab1_LP1
{
    class Position
    {
        public int Row { get; }
        public int Column { get; }

        /// <summary>
        /// Receives 2 int variables, row and column,
        ///  to set a 2 dimentional position - like in an array
        /// </summary>
        /// <param name="row">horizontal line value</param>
        /// <param name="column">vertical line value</param>
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
