using Battleship.API.Models;

namespace Battleship.API.Repository
{
    public interface IShipPlacer
    {
        // Board -> Ship -> cells
        void AddShipToBoard(Ship ship, Board board, int row, int column);
    }
}