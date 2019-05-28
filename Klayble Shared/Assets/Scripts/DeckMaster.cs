using UnityEngine;

public class DeckMaster : MonoBehaviour, IBattlePiece
{
    [SerializeField] public int HP { get; private set; }
    [SerializeField] public int Atk { get; private set; }
    [SerializeField] public int Def { get; private set; }
    [SerializeField] public string Name { get; private set; }
    [SerializeField] public Player Player { get; set; }

    public void ApplyEffect(IBattlePiece Target)
    {
        throw new System.NotImplementedException();
    }

    public void Attack(IBattlePiece Target)
    {
        throw new System.NotImplementedException();
    }

    public void Move(IBattlePiece Target)
    {
        throw new System.NotImplementedException();
    }
}