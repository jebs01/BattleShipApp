using System;
using Battleship.API.Models;
using Battleship.API.Enums;
using Battleship.API.Models.Ships;
using Battleship.API.Repository;

namespace Battleship.API.Data
{
    public class ShipCreator : IShipCreator
    {
        public Ship CreateShip(ShipType shipType)
        {
            try
            {
                switch (shipType)
                {
                    case ShipType.Carrier:
                        return new Carrier();

                    case ShipType.Attacker:
                        return new Attacker();

                    default:
                        return new Carrier();
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception($"Could not create ship : {ex.Message}");
            }
        }
    }
}