using UnityEngine;

public abstract class BattlePiece : MonoBehaviour
{
    [SerializeField] public int HP { get; private set; }
    [SerializeField] public int Atk { get; private set; }
    [SerializeField] public int Def { get; private set; }
    [SerializeField] public string Name { get; private set; }
    

    public abstract void Move(TileScript Target);

    public void Attack(BattlePiece Target)
    {
        //TODO: Target.ChangeHP(CalculateDamage(Target);
    }

    /** TODO: Make Formula
    protected float CalculateDamage(BattlePiece Target)
        return ((this.Level) * (this.Atk / Target.Def));
    }
    */

    public abstract void ApplyEffect(BattlePiece Target);

    public void ChangeHP(int Change)
    {
        this.HP += Change;
    }

    public abstract void Interact(BattlePiece Target);

    public abstract void Interact(TileScript Target);

    
}

