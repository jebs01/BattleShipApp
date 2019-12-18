using Battleship.API.Models;
using Battleship.API.Enums;

namespace Battleship.API.Repository
{
    public interface IGameStatus
    {
         bool GameStatus(Board board);
    }
}