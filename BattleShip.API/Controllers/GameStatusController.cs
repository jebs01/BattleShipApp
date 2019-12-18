using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

using BattleShip.API.Data;

using BattleShip.API;
using BattleShip.API.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Battleship.API.Repository;
using Battleship.API.Enums;

namespace BattleShip.API.Controllers 
{
    
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GameStatusController : ControllerBase
    {
        private readonly IBoardCreator _repoBoardCreator;
        private readonly IShipCreator _repoShipCreator;
        private readonly IShipPlacer _repoShipPlacer;
        private readonly IAttacker _repoAttacker;
        private readonly IGameStatus _repoGameStatus;
       
/*
        public GameStatusController(
            IBoardCreator repoBoardCreator, 
            IShipCreator repoShipCreator,
            IShipPlacer repoShipPlacer, 
            IAttacker repoAttacker, 
            IGameStatus repoGameStatus 
            )
        {
            
            _repoBoardCreator = repoBoardCreator;
            _repoShipCreator = repoShipCreator;
            _repoShipPlacer = repoShipPlacer;
            _repoAttacker = repoAttacker;
            _repoGameStatus = repoGameStatus;
        }


        [HttpGet(Name = "TrackStatus")]
        public async Task<IActionResult> TrackStatus()
        {

            
            var board =  _repoBoardCreator.CreateBoard(10,10);
            var shipCarrier =  _repoShipCreator.CreateShip(ShipType.Carrier);                  
            _repoShipPlacer.AddShipToBoard(shipCarrier,board, 0,0);
            var AttackStatus =  _repoAttacker.Attack(board, 0,0);
            var gamestatus = _repoGameStatus.GameStatus(board);
            
           
           return Ok(gamestatus);

        }
 */
       
        [HttpGet(Name = "TrackStatus")]
        public  bool TrackStatus()
        {
             return true;
        }
    }
}