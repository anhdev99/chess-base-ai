namespace ChessBaseAI.Interfaces
{
    /// <summary>
    /// King interface.
    /// </summary>
    public interface IKing
    {
        /// <summary>
        /// Verifies if the king can castle long.
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="from">The starting square</param>
        /// <param name="to">The ending square</param>
        /// <returns></returns>
        bool CanCastleLong(Board board, int from, int to);

        /// <summary>
        /// Verifies if the king can castle short.
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="from">The starting square</param>
        /// <param name="to">The ending square</param>
        /// <returns></returns>
        bool CanCastleShort(Board board, int from, int to); 
    } 
}