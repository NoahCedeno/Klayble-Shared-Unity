using UnityEngine;

public class BattlePiece : MonoBehaviour
{
    [SerializeField] public int HP { get; protected set; }
    [SerializeField] public int Atk { get; protected set; }
    [SerializeField] public int Def { get; protected set; }
    [SerializeField] public string Name { get; protected set; }
    [SerializeField] public int Level { get; protected set; }

    [SerializeField] public readonly Vector3 Position;

    public enum Effects { Normal, Burning, Poison, Freezing, Sleeping, Paralyzed }

    [SerializeField] public Effects Effect { get; private set; }

    //public delegate void OnMoveHandler(BattlePiece User, BattlePiece Target);
    //public static event OnMoveHandler OnMove;

    // Constructors
    public BattlePiece()
    {
        this.Name = "MissingName";
        this.Level = 0;
        this.Atk = 0;
        this.Def = 0;
        this.HP = 1;
        this.Effect = Effects.Normal;
        this.Position = Vector3.zero;
    }

    public BattlePiece(string Name, int Level) : this()
    {
        this.Name = Name;
        this.Level = Level;
    }

    public BattlePiece(string Name, int Level, int HP, int Atk, int Def)
    {
        this.Name = Name;
        this.Level = Level;
        this.HP = HP;
        this.Atk = Atk;
        this.Def = Def;
        this.Position = Vector3.zero;
    }

    // Behaviors

    public void OnEnable()
    {
        // EventManager.OnMove += Move;
        // EventManager.OnAttack += Attack;
    }

    public void OnDisable()
    {
        // EventManager.OnMove -= Move;
        // EventManager.OnAttack -= Attack;
    }

    public override string ToString()
    {
        return this.Name;
    }

    protected int CalculateDamage(BattlePiece Target)
    {
        return ((this.Level) * (this.Atk / Target.Def));
    }

    public void ApplyEffect(Effects Effect)
    {
        this.Effect = Effect;
    }

    public void ChangeHP(int Change)
    {
        this.HP += Change;
    }
}