using System;
using Xunit;
using Battleship.API.Data;
using Battleship.API.Models;

namespace BattleShip.API.Tests
{
    public class UnitTest1
    {
       // [Fact]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        public void UnitTest (int rows, int columns)
        {

      
         var boardCreator = new BoardCreator();

            //act
            var board = boardCreator.CreateBoard(rows, columns);

            //assert
           // Assert.Equal(rows * columns, board.BoardCellStatuses.Length);
           Assert.Equal(0, board.BoardCellStatuses.Length);
        }
    }
}
