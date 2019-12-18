using System;
using Battleship.API.Models;
using Battleship.API.Enums;
using Battleship.API.Repository;
using BattleShip.API.Enums;

namespace BattleShip.API.Data
{
    public class Attacker : IAttacker
    {
        public AttackStatus Attack(Board board, 
                                   int row, 
                                   int column)
        {
            //check attack coordinates 
            Validate(board, row, column);

            //if the attack is successful then mark the cell as hit
            if (board.BoardCellStatuses[row, column] == BoardCellStatus.Occupied ||
                board.BoardCellStatuses[row, column] == BoardCellStatus.Hit
                )
            {
                board.BoardCellStatuses[row, column] = BoardCellStatus.Hit;

                //update the hitcount to check whether game is over
                board.HitCount++;

                //successful attack status
                return AttackStatus.Hit;
            }

            board.BoardCellStatuses[row, column] = BoardCellStatus.Miss;
            return AttackStatus.Miss;
        }

        private void Validate(Board board, int row, int column)
        {
            var errorMessage = "Attack position is out of bounds";

            //validate check if attack positions in bounds of the board
            if (row > board.Rows)
            {
                //"Invalid attack coordinates - please check entered row value.";
                throw new IndexOutOfRangeException(errorMessage);
                // ToDO: Log Error in DB and/or in System files.
            }

            if (column > board.Columns)
            {
                 //"Invalid attack coordinates - please check entered column coordinates.";
                throw new IndexOutOfRangeException(errorMessage);
                 // ToDO: Log Error in DB and/or in System files.
            }
        }
    }
}