using BattleSystem;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace TurnSystem
{
    public class TurnInvoker : MonoBehaviour
    {
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
            foreach (CardTurn ct in Turns)
            {
                finalString += ct.ToString() + "\n";
            }
            Debug.Log(finalString);
        }

        public void Display(int index)
        {
            try
            {
                Debug.Log(Turns[index]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Debug.Log("HAH you thought; arg out of bounds baby");
            }
        }
    }
}