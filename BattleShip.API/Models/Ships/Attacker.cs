using Battleship.API.Enums;

namespace Battleship.API.Models.Ships
{
    public class Attacker : Ship
    {
        public Attacker()
        {
            Size = 2;
            ShipType = ShipType.Attacker;
        }
    }
}