using UnityEngine;

namespace TurnSystem
{
    public class MoveTurn : CardTurn
    {
        public readonly Vector3 OrigPosition;
        public readonly Vector3 ToPosition;

        public MoveTurn(Card receiver, float ToX, float ToZ) : base(receiver, TurnActions.Move)
        {
            OrigPosition = receiver.getPosition();
            ToPosition = new Vector3(OrigPosition.x + ToX, 0f, OrigPosition.z + ToZ);
        }

        public override void ExecuteTurn()
        {
            Debug.Log(this.Receiver + " wants to move to " + ToPosition.x.ToString() + ", " + ToPosition.z.ToString() + ".");
        }
    }
}