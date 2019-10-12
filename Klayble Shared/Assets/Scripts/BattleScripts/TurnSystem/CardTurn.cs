namespace TurnSystem
{
    public abstract class CardTurn : ITurn
    {
        public Card Receiver;
        public TurnActions TurnAction;

        public CardTurn(Card receiver, TurnActions turnAction)
        {
            Receiver = receiver;
            TurnAction = turnAction;
        }

        public abstract void ExecuteTurn();

        public abstract override string ToString();

    }
}

/**
 * 10/1/19 Update:
 * I haven't implemented any of the sequences nor mutations nor mutator methods within BattlePieces as of yet.
 * My goal tonight was only to build myself a Command Pattern that would handle the Turn System in the game.
 * 
 * I still don't know how I plan to incorporate the sequences and animations into these CardTurns, but it will likely be
 * in ExecuteTurn()'s implementation for all of them.
 */