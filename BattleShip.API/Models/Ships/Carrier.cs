using Battleship.API.Enums;

namespace Battleship.API.Models.Ships
{
    public class Carrier : Ship
    {
        public Carrier()
        {
            Size =5;
            ShipType = ShipType.Carrier;
        }
    }
}