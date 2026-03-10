namespace _2048_Core
{
    public class Board
    {
        private const int boardSize = 4;
        public Tile[,] Tiles { get; set;} 

        public Board()
        {
            Tiles = new Tile[boardSize, boardSize];
        }

    }
}
