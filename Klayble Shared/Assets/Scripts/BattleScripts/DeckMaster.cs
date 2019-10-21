using UnityEngine;

namespace BattleSystem
{

    public class DeckMaster : BattleCharacter
    {
        [SerializeField] public Player Player { get; set; }
    }
}