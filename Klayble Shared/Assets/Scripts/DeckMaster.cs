using UnityEngine;

public class DeckMaster : BattlePiece
{
    
    [SerializeField] public Player Player { get; set; }

    public override void ApplyEffect(BattlePiece Target)
    {
        throw new System.NotImplementedException();
    }

    public override void Attack(BattlePiece Target)
    {
        throw new System.NotImplementedException();
    }

    public override void ChangeHP(float Change)
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

    public override void Move(TileScript Target)
    {
        throw new System.NotImplementedException();
    }
}