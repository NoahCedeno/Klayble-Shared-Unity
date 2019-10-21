using BattleSystem;

namespace TurnSystem
{
    public abstract class CardTurn : ITurn
    {
        public BattleCard Receiver;
        public TurnActions TurnAction;

        public CardTurn(BattleCard receiver, TurnActions turnAction)
        {
            Receiver = receiver;
            TurnAction = turnAction;
        }

        public abstract void ExecuteTurn();

        public abstract override string ToString();

    }
}
