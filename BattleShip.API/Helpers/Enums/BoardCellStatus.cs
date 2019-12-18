namespace BattleShip.API.Enums
{
    //this class represents the individual cell status on the board
    public enum BoardCellStatus
    {
        Unoccupied, // Board cell on creation
        Occupied, // Once ship is placed
        Hit,     // Succesful attack
        Miss     // Failed Attack
    }
}
