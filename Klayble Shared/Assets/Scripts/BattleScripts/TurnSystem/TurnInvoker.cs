using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TurnSystem
{
    public class TurnInvoker {

        public readonly List<CardTurn> Turns;
        public CardTurn cardTurn;

        public TurnInvoker()
        {
            Turns = new List<CardTurn>();
        }

        public void SetCardTurn(CardTurn ct)
        {
            cardTurn = ct;
        }

        public void InvokeTurn()
        {
            Turns.Add(cardTurn);
            cardTurn.ExecuteTurn();
        }

    }

}
