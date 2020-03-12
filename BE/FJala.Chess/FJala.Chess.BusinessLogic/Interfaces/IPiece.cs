namespace FJala.Chess.BusinessLogic.Interfaces
{
    public interface IPiece
    {
        Coordinate Move(Coordinate coordinate);
        Coordinate GetPosition();
    }
}
