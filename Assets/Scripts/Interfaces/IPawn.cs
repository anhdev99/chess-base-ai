namespace ChessBaseAI.Interfaces
{
    /// <summary>
    /// Pawn interface.
    /// </summary>
    public interface IPawn
    {
        /// <summary>
        /// Checks if it's the two-squares move.
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="from">The starting square</param>
        /// <param name="to">The ending square</param>
        /// <returns></returns>
        bool IsTwoSquaresMove(Board board, int from, int to);

        /// <summary>
        /// Checks if it's the en passant move.
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="from">The starting square</param>
        /// <param name="to">The ending square</param>
        /// <returns></returns>
        bool IsEnPassantCaptureMove(Board board, int from, int to); 
    } 
}