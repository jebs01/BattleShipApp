using Battleship.API.Models;

namespace Battleship.API.Repository
{
    public interface IBoardCreator
    {
        //Default board size is 10*10
         Board CreateBoard(int rows, int columns);
    }
}