using UnityEngine;
using BattleSystem;

namespace TurnSystem
{
    public class InteractTurn : CardTurn
    {
        public readonly BattlePiece Target;

        public InteractTurn(BattleCard receiver, BattlePiece target) : base(receiver, TurnActions.Interact)
        {
            Target = target;
        }

        public override string ToString()
        {
            return this.Receiver.ToString() + " wants to interact with " + Target.ToString() + "!";
        }

        public override void ExecuteTurn()
        {
            // TODO: Implent a generic Interaction Sequence
            Debug.Log(this.ToString());
        }
    }
}