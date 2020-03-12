namespace FJala.Chess.BusinessLogic.Pieces
{
    using FJala.Chess.BusinessLogic.Interfaces;

    public class Pawn : IPiece
    {
        public Rule Rule { get; }
        public Coordinate Position { get; set; }
        public Pawn(Rule rule, Coordinate startingPosition)
        {
            this.Rule = rule;
            this.Position = startingPosition;
        }

        public Coordinate Move(Coordinate coordinate)
        {
            throw new System.NotImplementedException();
        }

        public Rule SetRules(Rule rule)
        {
            throw new System.NotImplementedException();
        }

        public Coordinate GetPosition()
        {
            throw new System.NotImplementedException();
        }
    }
}
