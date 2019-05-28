using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Player : MonoBehaviour
{
    [SerializeField] public int HP { get; private set; }
    [SerializeField] public int Atk { get; private set; }
    [SerializeField] public int Def { get; private set; }
    [SerializeField] public string Name { get; private set; }
    [SerializeField] public List<Card> Deck { get; private set; }

    public void AddToDeck(Card card)
    {
        card.Player = this;
        Deck.Add(card);
        
    }

    public string Serialize()
    {
        return JsonConvert.SerializeObject(this);
    }
}