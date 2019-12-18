using System;
using Battleship.API.Models;
using Battleship.API.Enums;
using Battleship.API.Repository;
using BattleShip.API.Enums;

namespace BattleShip.API.Data
{
    public class GameStatusCheck: IGameStatus 
    {
        public bool GameStatus (Board board)
        {
            return board.HasLost;
        }

    }
}