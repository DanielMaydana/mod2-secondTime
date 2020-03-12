namespace FJala.Chess.Testing
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using FJala.Chess.BusinessLogic;
    using FJala.Chess.BusinessLogic.Interfaces;
    using FJala.Chess.BusinessLogic.Pieces;

    [TestClass]
    public class PawnUnitTesting
    {
        [TestMethod]
        public void GetPosition_ReturnsTheStartingPosition_WhenPawnInstantiated()
        {
            Rule pawnRule = new Rule(
                maxMovementDistance: new Coordinate(1, 1),
                pattern: new Coordinate(1, 1)
            );

            IPiece pawn = new Pawn(
                rule: pawnRule,
                startingPosition: new Coordinate(0, 0)
            );

            Coordinate expectedPosition = new Coordinate(0, 0);

            Assert.AreEqual(expectedPosition.x, pawn.GetPosition().x);
            Assert.AreEqual(expectedPosition.y, pawn.GetPosition().y);
        }
    }
}
