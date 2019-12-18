using Battleship.API.Enums;
using Battleship.API.Data;
using BattleShip.API.Enums;

using System;
using Xunit;
using BattleShip.API.Data;

namespace Battleship.Tests
{
    public class ShipPlacementTests
    {
        /*this test verifies that a ship is placed on the board when valid
        coordinates are provided*/ 
        [Theory]
        //boardRows,boardColumns,placementRow,placementColumn,shipType
        [InlineData(10, 10, 0, 0, ShipType.Carrier)]
        [InlineData(10, 10, 0, 6, ShipType.Attacker)]
        public void ShouldPlaceAShip_WhenCorrectPositionsProvided(
            int boardRows, int boardColumns,
            int placementRow, int placementColumn,
            ShipType shipType)
        {
            //arrange

            //first create a board
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            //then create a ship
            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            //act
            //now place the ship on the board
            var shipPlacer = new ShipPlacer();
            shipPlacer.AddShipToBoard(ship, board, placementRow, placementColumn);

            //assert

            /*check that the ship has been placed on the board and that the board's
             status is occupied for the ship*/
            Assert.True(
                board.BoardCellStatuses[placementRow, placementColumn] == BoardCellStatus.Occupied &&
                board.BoardCellStatuses[placementRow, placementColumn + ship.Size - 1] == BoardCellStatus.Occupied
            );
        }

        /*this test verifies that an IndexOutOfRangeException exception is returned
         when invalid coordinates are provided*/
        [Theory]
        //boardRows,boardColumns,placementRow,placementColumn,shipType
        [InlineData(10, 10, 11, 11, ShipType.Carrier)]
        [InlineData(10, 10, 20, 14, ShipType.Carrier)]
        [InlineData(10, 10, 5, 10, ShipType.Attacker)]
        [InlineData(10, 10, 2, 7, ShipType.Carrier)]
        public void ShouldFailToPlaceAShip_WhenIncorrectCorrectPositionsProvided(
            int boardRows, int boardColumns,
            int placementRow, int placementColumn,
            ShipType shipType)
        {
            //arrange

            //first create a board
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            //then create a ship
            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            //act
            //now place the ship on the board
            var shipPlacer = new ShipPlacer();

            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() =>
                shipPlacer.AddShipToBoard(ship, board, placementRow, placementColumn));

            //assert
            Assert.Equal("Ship's placement position is out of bounds", ex.Message);
        }
    }
}
