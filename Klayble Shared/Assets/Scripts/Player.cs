using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int HP { get; private set; }
    [SerializeField] public DeckMaster DeckMaster { get; private set; }
    [SerializeField] public List<Card> Deck { get; private set; }

    public void AddToDeck(Card card)
    {
        card.Player = this;
        Deck.Add(card);
    }

    /* -- Use this for Serialization at a later time or something!
    public string Serialize()
    {
        return JsonConvert.SerializeObject(this);
    }
    */
}