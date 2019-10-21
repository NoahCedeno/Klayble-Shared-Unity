using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleSystem
{
    public abstract class BattleCharacter : BattlePiece
    {
        [SerializeField] public int Level { get; protected set; }

        public enum Effects { Normal, Burning, Poison, Freezing, Sleeping, Paralyzed }
        [SerializeField] public Effects Effect { get; private set; }

        public void ApplyEffect(Effects Effect)
        {
            this.Effect = Effect;
        }

        //TODO: Derive Better Damage Formula!
        protected override int CalculateDamage(BattlePiece Target)
        {
            return ((this.Level) * (this.Atk / Target.Def));
        }

    }
}