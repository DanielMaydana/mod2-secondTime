namespace FJala.Chess.BusinessLogic
{
    public class Rule
    {
        public Coordinate MaxMovementDistance { get; }
        public Coordinate MovementPattern { get; }

        public Rule(Coordinate maxMovementDistance, Coordinate pattern)
        {
            this.MaxMovementDistance = maxMovementDistance;
            this.MovementPattern = pattern;
        }
    }
}
