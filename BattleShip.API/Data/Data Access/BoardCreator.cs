using System;
using Battleship.API.Models;
using Battleship.API.Repository;
using BattleShip.API.Enums;

namespace Battleship.API.Data
{
    public class BoardCreator : IBoardCreator
    {
        public Board CreateBoard(int rows, int columns) 
        {
            try
            {
                //create the board and mark all cells as unoccupied
                BoardCellStatus[,] statusArray = new BoardCellStatus[rows, columns];
                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        statusArray[row, column] = BoardCellStatus.Unoccupied;
                    }
                }

                //return the board
                return new Board
                {
                    BoardCellStatuses = statusArray,
                    Rows = rows,
                    Columns = columns
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while creating board : {ex.Message}");
            }
        }
    }
}