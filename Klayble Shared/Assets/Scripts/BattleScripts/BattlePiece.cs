using UnityEngine;

namespace BattleSystem
{
    public abstract class BattlePiece : MonoBehaviour
    {
        [SerializeField] public string Name { get; protected set; }
        [SerializeField] public int HP { get; protected set; }
        [SerializeField] public int Atk { get; protected set; }
        [SerializeField] public int Def { get; protected set; }

        [SerializeField] public readonly Vector2 BoardPosition;

        // TODO: Reference Model and other stuff!



        public override string ToString()
        {
            return this.Name;
        }

        protected abstract int CalculateDamage(BattlePiece Target);

        public void ChangeHP(int Change)
        {
            this.HP += Change;
        }
    }
}