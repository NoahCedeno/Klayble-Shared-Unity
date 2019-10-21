using UnityEngine;
using BattleSystem;

namespace TurnSystem
{
    public class MoveTurn : CardTurn
    {
        public readonly Vector2 OrigPosition;
        public readonly Vector2 ToPosition;

        public MoveTurn(BattleCard receiver, float ToX, float ToY) : base(receiver, TurnActions.Move)
        {
            //OrigPosition = receiver.getPosition();
            ToPosition = new Vector3(OrigPosition.x + ToX, 0f, OrigPosition.y + ToY);
        }

        public override string ToString()
        {
            return (this.Receiver + " wants to move to " + ToPosition.x.ToString() + ", " + ToPosition.y.ToString() + ".");
        }

        public override void ExecuteTurn()
        {
            Debug.Log(this.ToString());
        }
    }
}

/**
 * I'm using Vector2 types to specify where a BattlePiece is on the field. It refers to the X and Y (actually Z) that the object is on, at the height sitting on the Tile.
 */