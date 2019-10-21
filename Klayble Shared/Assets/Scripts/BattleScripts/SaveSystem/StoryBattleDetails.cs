using BattleSystem;

namespace SaveSystem
{
    public class StoryBattleDetails : BattleDetails
    {
        public readonly int MissionNumber;

        /* TODO: ABSTRACT CONSTRUCTORS
         * I'm not sure if each derived class of BattleDetails gets its own BoardLayout of type Board.
         * I'm using an abstract constructor that takes in a Board boardLayout and initializes a protected
         * Board by assigning it to the argument boardLayout. I'm not sure if this ensures individual BoardLayouts
         * for each instance of a derived class of BattleDetails.
         *
         * TODO: I also need a List for the number of Players in a game, but this should be for later.
         * Also for BattlePieces (BattleCharacters & BattleStructures)!
         */

        public StoryBattleDetails(Board boardLayout, int missionNumber) : base(boardLayout)
        {
            MissionNumber = missionNumber;
        }
    }
}