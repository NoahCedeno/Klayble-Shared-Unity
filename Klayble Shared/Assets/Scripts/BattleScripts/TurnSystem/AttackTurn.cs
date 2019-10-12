using UnityEngine;

namespace TurnSystem
{
    public class AttackTurn : CardTurn
    {
        public readonly BattlePiece Target;

        public AttackTurn(Card receiver, BattlePiece target) : base(receiver, TurnActions.Attack)
        {
            Target = target;
        }

        public override string ToString()
        {
            return this.Receiver.ToString() + " wants to attack " + Target.ToString() + "!";
        }

        public override void ExecuteTurn()
        {
            Debug.Log(this.ToString());
        }

    }
}