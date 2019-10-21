using BattleSystem;

namespace SaveSystem
{
    public class PVPBattleDetails : BattleDetails
    {
        private readonly int EnemyPlayerID;

        public PVPBattleDetails(Board boardLayout, int enemyPlayerID) : base(boardLayout)
        {
            // Assuming just one opponent in a PVP Match,
            EnemyPlayerID = enemyPlayerID;
        }
    }
}