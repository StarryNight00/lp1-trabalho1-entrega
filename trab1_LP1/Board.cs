using System;
using System.Collections.Generic;
using System.Text;

namespace trab1_LP1
{
    class Board
    {
        private State[,] state;
        public State NextTurn { get; private set; }
        private BasePiece[,] basePiece;

        /// <summary>
        /// A Board Class constructor
        /// </summary>
        public Board()
        {
            state = new State[5, 5];
            basePiece = new BasePiece[5, 5];
        }

        /// <summary>
        /// Receives a 2 dimentional position to insert in an array
        ///  of possible game states
        /// </summary>
        /// <param name="position">Calls the Position class to set a 2 dimential coordinate (row, column)</param>
        /// <returns></returns>
        public State GetState(Position position)
        {
            return state[position.Row, position.Column];
        }

        /// <summary>
        /// Receives a 2 dimentional position to insert in an array
        ///  of game piece locations
        /// </summary>
        /// <param name="position">Calls the Position class to set a 2 dimential coordinate (row, column)</param>
        /// <returns></returns>
        public BasePiece GetPiece(Position position)
        {
            return basePiece[position.Row, position.Column];
        }

        /// <summary>
        /// Boolean value that tracks the current state of a given position,
        ///  updates it and switches the current game turn.
        /// </summary>
        /// <param name="position">2 dimentional coordinate (row, column)</param>
        /// <param name="newState">New state, from Enumeration, desired to apply</param>
        /// <returns></returns>
        public bool CheckTurn(Position position, State newState)
        {
            if (newState != NextTurn) return false;
            if (state[position.Row, position.Column] != State.Empty) return false;

            state[position.Row, position.Column] = newState;
            SwitchNextTurn();
            return true;
        }

        /// <summary>
        /// Method that tracks current turn by switching the State value of a turn tracking variable
        /// </summary>
        private void SwitchNextTurn()
        {
            if (NextTurn == State.J1) NextTurn = State.J2;
            else NextTurn = State.J1;
        }
    }
}
