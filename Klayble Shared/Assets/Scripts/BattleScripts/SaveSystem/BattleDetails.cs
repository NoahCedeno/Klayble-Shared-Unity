using System;

namespace SaveSystem
{
    public abstract class BattleDetails
    {
        protected Board BoardLayout; // Initializes Structures and things like that per map

        public BattleDetails(Board boardLayout)
        {
            BoardLayout = boardLayout; // TODO: Perhaps Deep Copy instead of reference? Idk if there's a need though.
        }
    }
}