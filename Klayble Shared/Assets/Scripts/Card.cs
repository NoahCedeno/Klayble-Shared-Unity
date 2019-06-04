using UnityEngine;

public class Card : BattlePiece
{
    [SerializeField] public int CardID { get; set; }
    [SerializeField] public Player Player { get; set; }

    public Card(int CardID) : base()
    {
        this.CardID = CardID;
    }

    public Card(string Name, int Level) : base(Name, Level)
    {
        this.CardID = CardID;
    }

    public Card(string Name, int Level, int HP, int Atk, int Def, int CardID) : base(Name, Level, HP, Atk, Def)
    {
        this.CardID = CardID;
    }

    public Card() : base()
    {
    }

    private void OnEnable()
    {
        Debug.Log("Card " + Name + " made under owner " + Player.Name);
    }
}