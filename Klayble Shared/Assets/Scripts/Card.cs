using UnityEngine;

public class Card : BattlePiece 
{
    [SerializeField] public int CardID { get; set; }
    [SerializeField] public Player Player { get; set; }

    private void OnEnable()
    {
        Debug.Log("Card " + Name + " made under owner " + Player.Name);
    }

    private void LoadCardData(int CardID)
    {
        // Deserialize and Load from file.
    }

    public override void Move(TileScript Target)
    {
        throw new System.NotImplementedException();
    }

    public override void ApplyEffect(BattlePiece Target)
    {
        throw new System.NotImplementedException();
    }

    public override void Interact(BattlePiece Target)
    {
        throw new System.NotImplementedException();
    }

    public override void Interact(TileScript Target)
    {
        throw new System.NotImplementedException();
    }
}