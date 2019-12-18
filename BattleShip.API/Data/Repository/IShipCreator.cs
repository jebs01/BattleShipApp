using Battleship.API.Models;
using Battleship.API.Enums;

namespace Battleship.API.Repository
{
    public interface IShipCreator
    {
        Ship CreateShip(ShipType shipType);
    }
}