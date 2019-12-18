using Battleship.API.Enums;
using Battleship.API.Data;
using Xunit;

namespace Battleship.Tests
{
    public class ShipTests
    {
        [Theory]
        [InlineData(ShipType.Carrier)]
        public void ShouldReturnShip_WhenShipCreated(ShipType shipType)
        {
            //arrange
            var shipCreator = new ShipCreator();

            //act
            var ship = shipCreator.CreateShip(shipType);

            //assert
            Assert.NotNull(ship);
        }
    }
}
