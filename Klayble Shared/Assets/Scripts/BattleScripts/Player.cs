using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] public List<CardData> Deck { get; private set; }
    [SerializeField] public string Name { get; private set; }

    public void AddToDeck(CardData card)
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