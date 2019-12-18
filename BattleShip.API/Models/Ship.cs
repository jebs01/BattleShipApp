using Battleship.API.Enums;

namespace Battleship.API.Models
{
    public abstract class Ship
    {
        public ShipType ShipType { get; set; }
        public int Size { get; set; }
    }
}