﻿using UnityEngine;

public class Card : MonoBehaviour, IBattlePiece
{
    [SerializeField] public int HP { get; private set; }
    [SerializeField] public int Atk { get; private set; }
    [SerializeField] public int Def { get; private set; }
    [SerializeField] public string Name { get; private set; }
    [SerializeField] public int CardID { get; set; }
    [SerializeField] public Player Player { get; set; }

    private void OnEnable()
    {
        Debug.Log("Card " + Name + " made under owner " + Player.Name);
    }

    private void loadCardData(int CardID)
    {
        // Deserialize and Load from file.
    }

    public void Move(IBattlePiece Target)
    {
        throw new System.NotImplementedException();
    }

    public void Attack(IBattlePiece Target)
    {
        throw new System.NotImplementedException();
    }

    public void ApplyEffect(IBattlePiece Target)
    {
        throw new System.NotImplementedException();
    }
}