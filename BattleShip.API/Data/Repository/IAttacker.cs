using Battleship.API.Models;
using Battleship.API.Enums;

namespace Battleship.API.Repository
{
    public interface IAttacker
    {
         AttackStatus Attack(Board board, int row, int column);
    }
}