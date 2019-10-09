using System.Collections.Generic;
using TurnSystem;
using UnityEngine;

namespace SaveSystem
{
    public class BattleRecord
    {
        [SerializeField] public readonly BattleDetails Details;
        [SerializeField] public readonly List<CardTurn> Turns;
        [SerializeField] public readonly int NumTurns;
        [SerializeField] public readonly bool DidPlayerWin;

        public BattleRecord(BattleDetails details, List<CardTurn> turns, bool didPlayerWin)
        {
            Details = details;
            Turns = turns;
            NumTurns = turns.Capacity;
            DidPlayerWin = didPlayerWin;
        }
    }
}