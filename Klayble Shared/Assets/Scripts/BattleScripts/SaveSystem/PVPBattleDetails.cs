using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveSystem
{

    public class PVPBattleDetails : BattleDetails
    {
        readonly int EnemyPlayerID;

        public PVPBattleDetails(Board boardLayout, int enemyPlayerID) : base(boardLayout)
        {
            // Assuming just one opponent in a PVP Match,
            EnemyPlayerID = enemyPlayerID;
        }
    }
}
