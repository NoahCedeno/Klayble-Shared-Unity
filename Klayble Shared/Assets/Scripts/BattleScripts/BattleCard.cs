using UnityEngine;

namespace BattleSystem
{
    [System.Serializable] // I want to serialize this WHOLE class!
    public class BattleCard : BattleCharacter
    {
        // TODO: Reference Model and other stuff!

        readonly CardData CardData;

        public override string ToString()
        {
            return this.CardData.CardID.ToString();
        }

        new private void OnEnable()
        {
            Debug.Log("Card " + Name + " made under owner " + CardData.Player.Name);
        }
    }
}