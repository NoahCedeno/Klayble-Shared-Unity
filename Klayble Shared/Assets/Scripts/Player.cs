using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Player : MonoBehaviour
{
    [SerializeField] public int hp { get; private set; }
    [SerializeField] public int atk { get; private set; }
    [SerializeField] public int def { get; private set; }
    [SerializeField] public string name { get; private set; }
    [SerializeField] public List<Card> deck { get; private set; }

    public void AddToDeck(Card card)
    {
        card.player = this;
        deck.Add(card);
    }
}