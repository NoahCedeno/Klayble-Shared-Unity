using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TurnSystem
{
    public class TurnInvoker : MonoBehaviour {

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

        public void Display()
        {
            Debug.Log("Here's the Turns List");
            string finalString = "";
            foreach(CardTurn ct in Turns)
            {
                finalString += ct.ToString() + "\n";
            }
            Debug.Log(finalString);
        }

        public void Display(int index)
        {
            try {
                Debug.Log(Turns[index]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Debug.Log("HAH you thought; arg out of bounds baby");
            }
        }

        void Test()
        {
            // Tests UwU

            TurnInvoker TI = new TurnInvoker();
            TI.SetCardTurn(new AttackTurn(new Card(1), new Card(2)));
            TI.InvokeTurn();
            TI.SetCardTurn(new MoveTurn(new Card(69), 1, 1));
            TI.InvokeTurn();
            TI.SetCardTurn(new InteractTurn(new Card(5), new Card(6)));
            TI.InvokeTurn();

            TI.Display(0);
            TI.Display(3);
            TI.Display();
        }

    }

}
