using UnityEngine;

public abstract class BattlePiece : MonoBehaviour
{
    [SerializeField] public int HP { get; private set; }
    [SerializeField] public int Atk { get; private set; }
    [SerializeField] public int Def { get; private set; }
    [SerializeField] public string Name { get; private set; }
    

    public abstract void Move(TileScript Target);

    public abstract void Attack(BattlePiece Target);

    public abstract void ApplyEffect(BattlePiece Target);

    public abstract void ChangeHP(float Change);

    public abstract void Interact(BattlePiece Target);

    public abstract void Interact(TileScript Target);

    
}

