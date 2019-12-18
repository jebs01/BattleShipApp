using Battleship.API.Models;
using Battleship.API.Repository;
using BattleShip.API.Enums;
using System;

namespace BattleShip.API.Data
{
    public class ShipPlacer : IShipPlacer
    {
        //adds a ship to the board at a given position
        public void AddShipToBoard(Ship ship, Board board, int row, int column)
        {
            //check for valid coordinates 
            Validate(ship, board, row, column);

            for (int i = 0; i < ship.Size; i++)
            {
                //update all cell status to occupied
                board.BoardCellStatuses[row, column + i] = BoardCellStatus.Occupied;
                
                //update occupation count.               
                board.OccupationCount++;
            }
        }

        private void Validate(Ship ship, Board board, int row, int column)
        {
            var errorMessage = "Ship's placement position is out of bounds";
            //validate if starting positions in bounds of the board
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

            for (int c = 0; c < ship.Size; c++)
            {
                if (column + c > board.Columns)
                {
                    // "Invalid ship size - please check ship & board dimensions.";
                    throw new IndexOutOfRangeException(errorMessage);
                    // ToDO: Log Error in DB and/or in System files.
                }
            }

             for (int i = 0; i < ship.Size; i++)
            {
                //for each ship coordinate, update cell status to occupied
                if (board.BoardCellStatuses[row, column + i] == BoardCellStatus.Occupied)
                {
                    //"Board cells already occupied - please try another coordinates.";
                    throw new IndexOutOfRangeException(errorMessage);
                    // ToDO: Log Error in DB and/or in System files.
                }
            }
        }
    }
}
